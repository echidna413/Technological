using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestDataGridViewValidating
{
    public class ExcelHelper
    {
        private const int HEADER_HEIGHT = 11;
        private const string HEADER_PATH = "header.xlsx";

        private const string ERROR_MSG = "Ошибок в строке: {0}.";
        private const string MUST_NOT_EMPTY_MSG = "Это поле должно быть заполнено.";
        private const string MUST_EMPTY_MSG = "Это поле должно быть пустое.";
        private const string MUST_CONTAIN_CODE = "Такого кода поверхности не существует.";
        private const string MUST_NOT_SURFACE_3_WITHOUT_2_MSG = "Третья поверхность не может быть без второй.";
        private const string MUST_NUMBER_MSG = "Это поле должно быть числовым.";
        private const string MUST_INTEGER_MSG = "Это поле должно быть целым числом.";
        private const string MUST_BE_IN_RANGE_MSG = "Это поле должно быть в диапазоне с {0} по {1}.";
        private const string MUST_BE_IN_SEQUENCE_MSG = "Это поле должно быть в множестве значений.";
        private const string MUST_MIN_LESS_MAX_MSG = "Минимальное значение не должно превышать максимальное.";
        private const string MUST_MAX_MORE_MIN_MSG = "Максимальное значение не должно быть меньше минимального.";

        private static readonly Color COLOR_1 = Color.GreenYellow;
        private static readonly Color COLOR_2 = Color.MediumPurple;
        private static readonly Color COLOR_3 = Color.Cornsilk;
        private static readonly Color COLOR_4 = Color.SandyBrown;

        public DataGridView DataGridView { get; set; }

        public void LoadHeader()
        {
            LoadFromFile(Path.Combine(Environment.CurrentDirectory, HEADER_PATH), 0, 1, true);
        }
        public void LoadFromFile(string filename)
        {
            LoadFromFile(filename, HEADER_HEIGHT, 0, false);
        }
        public void LoadFromFile(string filename, int offsetExcel, int offsetDataGridView, bool readOnly)
        {
            var rowsColumns = GetArrayFromExcel(filename);

            var rowCount = rowsColumns.GetLength(0);
            var colCount = rowsColumns.GetLength(1);

            DataGridView.Invoke(new Action(() => {
                DataGridView.ColumnCount = colCount;
                DataGridView.RowCount = HEADER_HEIGHT + 1;
                DataGridView.RowCount = rowCount + offsetDataGridView + 1;
                
                for (var i = offsetExcel; i < rowCount + offsetDataGridView; i++)
                {
                    DataGridView.Rows[i].ReadOnly = readOnly;
                }
                foreach(DataGridViewColumn column in DataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }));

            var setGridCellValueFunc = new Action<DataGridViewCell, string>((cell, value) => {
                cell.Value = value;
            });


            for (var i = offsetExcel; i < rowCount; i++)
            {
                var emptyRow = true;
                var gridRow = DataGridView.Rows[i + offsetDataGridView];

                for (var j = 0; j < colCount; j++)
                {
                    var val = rowsColumns[i + 1, j + 1];

                    if (val != null)
                    {
                        DataGridView.Invoke(setGridCellValueFunc, gridRow.Cells[j], val.ToString());
                        emptyRow = false;
                    }
                    
                }
                
                if (emptyRow)
                {
                    DataGridView.Invoke(new Action(() => {
                        DataGridView.RowCount = i + 1;
                        DataGridView.Invalidate();
                    }));
                    break;
                }
            }
        }
        private object[,] GetArrayFromExcel(string filename)
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            var xlWorkbook = xlApp.Workbooks.Open(filename);
            var xlWorksheet = xlWorkbook.Sheets[1];
            var xlRange = xlWorksheet.UsedRange;

            var rowsColumns = xlRange.Value2;

            //закрываю открытые ресурсы
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("cleanup");

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            Console.WriteLine("release com objects to fully kill excel process from running in the background");

            xlWorkbook.Close(false);
            Marshal.ReleaseComObject(xlWorkbook);
            Console.WriteLine("close and release");

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            Console.WriteLine("quit and release");

            return rowsColumns;
        }
        public void Colorize()
        {
            var rowCount = ExcelToDataGridIndex(DataGridView.RowCount);

            if (rowCount < HEADER_HEIGHT) return;

            ForEachCellInRange(DataGridView.Rows[1], 4, 47, delegate (DataGridViewCell cell)
            {
                Repaint(cell, COLOR_1);
            });
            ForEachRowInRange(2, 6, delegate (DataGridViewRow row)
            {
                ForEachCellInRange(row, 5, 47, delegate (DataGridViewCell cell)
                {
                    Repaint(cell, COLOR_1);
                });
            });
            ForEachRowInRange(7, rowCount, delegate (DataGridViewRow row)
            {
                ForEachCellInRange(row, 6, 47, delegate (DataGridViewCell cell)
                {
                    Repaint(cell, COLOR_1);
                });
            });

            ForEachRowInRange(1, rowCount, delegate (DataGridViewRow row)
            {
                ForEachCellInRange(row, 48, 91, delegate (DataGridViewCell cell)
                {
                    Repaint(cell, COLOR_2);
                });
            });

            ForEachRowInRange(1, rowCount, delegate (DataGridViewRow row)
            {
                ForEachCellInRange(row, 92, 145, delegate (DataGridViewCell cell)
                {
                    Repaint(cell, COLOR_3);
                });
            });

            ForEachRowInRange(1, rowCount, delegate (DataGridViewRow row)
            {
                ForEachCellInRange(row, 146, 175, delegate (DataGridViewCell cell)
                {
                    Repaint(cell, COLOR_4);
                });
            });
        }
        private void Repaint(DataGridViewCell cell, Color color)
        {
            cell.Style.BackColor = color;
        }

        public int Validate()
        {
            // validate
            ForEachRow(ValidateRow);

            return ErrorCount();
        }
        public void ResetError()
        {
            ForEachRow(ResetRowError);
        }
        public int ErrorCount()
        {
            var errorCount = 0;

            ForEachCell(delegate (DataGridViewCell cell) {
                if (!string.IsNullOrWhiteSpace(cell.ErrorText))
                {
                    errorCount++;
                }
            });

            return errorCount;
        }

        public void ValidateRow(DataGridViewRow row)
        {
            if (row.Index < HEADER_HEIGHT || row.IsNewRow) return;

            //reset
            ResetRowError(row);

            //1.8.1
            ValidateRequiredAlways(row);
            //1.8.2
            ValidateSurface(row);
            //1.8.5
            ValidateSurfaceCount(row);
            //2.1
            ValidateNumbers(row);
            ValidateIntegers(row);
            //2.3
            ValidateRange(row);
            //2.4
            ValidateHitSequence(row);
            //2.5
            ValidateMinMax(row);

            //row indicator
            RowHighlighter(row);
        }

        public void ResetRowError(DataGridViewRow row)
        {
            row.ErrorText = string.Empty;
            ForEachCell(row, delegate (DataGridViewCell cell)
            {
                cell.ErrorText = string.Empty;
            });
        }
        public void RowHighlighter(DataGridViewRow row)
        {
            var errorCount = 0;

            ForEachCell(row, delegate (DataGridViewCell cell)
            {
                if (!string.IsNullOrWhiteSpace(cell.ErrorText))
                {
                    errorCount++;
                }
            });

            if (errorCount > 0)
            {
                row.ErrorText = string.Format(ERROR_MSG, errorCount);
            }
            else
            {
                row.ErrorText = string.Empty;
            }
        }

        private void ValidateRequiredAlways(DataGridViewRow row)
        {
            ForEachCellInIndexes(row, Rules.REQUIRED_ALWAYS_181, ValidateRequired);
        }
        private void ValidateSurface(DataGridViewRow row)
        {
            ForEachCellInIndexes(row, Rules.SURFACE_FIELDS_182, delegate (DataGridViewCell cell)
            {
                if (string.IsNullOrWhiteSpace(cell.ErrorText))
                {
                    var cellIndex = cell.ColumnIndex + 1;
                    var cellMaxIndex = cellIndex + Rules.SURFACE_FIELDS_TO_CHECK_COUNT_182;
                    var charIndex = 0;

                    if (int.TryParse(cell.Value as string, out int key))
                    {
                        for (; cellIndex < cellMaxIndex; cellIndex++, charIndex++)
                        {
                            var curCell = DataGridView.Rows[row.Index].Cells[cellIndex];

                            if (Rules.SURFACES_182.ContainsKey(key))
                            {
                                if (Rules.SURFACES_182[key][charIndex].Equals('1'))
                                {
                                    ValidateRequired(curCell);
                                }
                                else
                                {
                                    ValidateRequiredEmpty(curCell);
                                }
                            }
                            else
                            {
                                cell.ErrorText = MUST_CONTAIN_CODE;
                            }
                        }
                    }
                    else
                    {
                        ForEachCellInRange(row, cellIndex, cellMaxIndex - 1, ValidateRequiredEmpty);
                    }
                }
            });
        }
        private void ValidateSurfaceCount(DataGridViewRow row)
        {
            var surfaceIndex = 0;
            var surfaceExist = new bool[Rules.SURFACES.Length];

            ForEachCellInIndexes(row, Rules.SURFACES, delegate (DataGridViewCell cell)
            {
                surfaceExist[surfaceIndex++] = !string.IsNullOrWhiteSpace(cell.Value as string);
            });

            var surfaceCount = surfaceExist.Where(s => s).Count();

            if (!surfaceExist[1] && surfaceExist[2])
            {
                var cell = row.Cells[ExcelToDataGridIndex(Rules.SURFACES[2])];
                cell.ErrorText = MUST_NOT_SURFACE_3_WITHOUT_2_MSG;
            }
            else if (surfaceCount == 2)
            {
                var indexes = Rules.REQUIRED_2_SURFACES_1851;
                ForEachCellInIndexes(row, indexes, ValidateRequired);
            }
            else if (surfaceCount == 3)
            {
                var indexes = Rules.REQUIRED_2_SURFACES_1851.Concat(Rules.REQUIRED_3_SURFACES_1852);
                ForEachCellInIndexes(row, indexes, ValidateRequired);
            }
        }
        private void ValidateNumbers(DataGridViewRow row)
        {
            ForEachCell(row, ValidateNumber);
        }
        private void ValidateIntegers(DataGridViewRow row)
        {
            ForEachCellInIndexes(row, Rules.INTEGER_TYPE_21, ValidateInteger);
        }
        private void ValidateRange(DataGridViewRow row)
        {
            for (var ruleChunkIndex = 0; ruleChunkIndex < Rules.RANGE_23.Length; ruleChunkIndex++)
            {
                var ruleChank = Rules.RANGE_23[ruleChunkIndex];
                ForEachCellInRange(row, ruleChank[0], ruleChank[1], delegate (DataGridViewCell cell)
                {
                    ValidateRange(cell, ruleChank[2], ruleChank[3]);
                });
            }
        }
        private void ValidateHitSequence(DataGridViewRow row)
        {
            for (var cellIndexes = 0; cellIndexes < Rules.HIT_SEQ_INDEXES_24.Length; cellIndexes++)
            {
                ForEachCellInIndexes(row, Rules.HIT_SEQ_INDEXES_24[cellIndexes], delegate (DataGridViewCell cell)
                {
                    ValidateHitSequence(cell, Rules.HIT_SEQ_SEQUENCE_24[cellIndexes]);
                });
            }
        }
        private void ValidateMinMax(DataGridViewRow row)
        {
            ForEachCellInIndexes(row, Rules.MIN_INDEXES_25, delegate (DataGridViewCell cell)
            {
                var cellMin = cell;
                var cellMax = row.Cells[cell.ColumnIndex + 1];

                ValidateMinMax(cellMin, cellMax);
            });
        }

        private void ValidateRequired(DataGridViewCell cell)
        {
            var value = cell.Value as string;

            if (string.IsNullOrWhiteSpace(cell.ErrorText)
                && string.IsNullOrWhiteSpace(value))
            {
                cell.ErrorText = MUST_NOT_EMPTY_MSG;
            }
        }
        private void ValidateRequiredEmpty(DataGridViewCell cell)
        {
            var value = cell.Value as string;

            if (string.IsNullOrWhiteSpace(cell.ErrorText)
                && !string.IsNullOrWhiteSpace(value))
            {
                cell.ErrorText = MUST_EMPTY_MSG;
            }
        }


        private void ValidateNumber(DataGridViewCell cell)
        {
            var value = cell.Value as string;

            if (string.IsNullOrWhiteSpace(cell.ErrorText)
                && !string.IsNullOrWhiteSpace(value)
                && !double.TryParse(value, out double n))
            {
                cell.ErrorText = MUST_NUMBER_MSG;
            }
        }
        private void ValidateInteger(DataGridViewCell cell)
        {
            var value = cell.Value as string;

            if (string.IsNullOrWhiteSpace(cell.ErrorText)
                && !string.IsNullOrWhiteSpace(value)
                && !long.TryParse(value, out long n))
            {
                cell.ErrorText = MUST_INTEGER_MSG;
            }
        }
        private void ValidateHitSequence(DataGridViewCell cell, double[] sequence)
        {
            if (string.IsNullOrWhiteSpace(cell.ErrorText)
                && double.TryParse(cell.Value as string, out double value)
                && !sequence.Contains(value))
            {
                cell.ErrorText = MUST_BE_IN_SEQUENCE_MSG;
            }
        }
        private void ValidateMinMax(DataGridViewCell cellMin, DataGridViewCell cellMax)
        {
            if (double.TryParse(cellMin.Value as string, out double valueMin)
                && double.TryParse(cellMax.Value as string, out double valueMax)
                && valueMin > valueMax)
            {
                if (string.IsNullOrWhiteSpace(cellMin.ErrorText))
                {
                    cellMin.ErrorText = MUST_MIN_LESS_MAX_MSG;
                }
                if (string.IsNullOrWhiteSpace(cellMax.ErrorText))
                {
                    cellMax.ErrorText = MUST_MAX_MORE_MIN_MSG;
                }
            }
        }
        private void ValidateRange(DataGridViewCell cell, int min, int max)
        {
            if (string.IsNullOrWhiteSpace(cell.ErrorText)
                && double.TryParse(cell.Value as string, out double value)
                && (value < min || value >= max))
            {
                cell.ErrorText = string.Format(MUST_BE_IN_RANGE_MSG, min, max);
            }
        }

        private void ForEachCell(Action<DataGridViewCell> action)
        {
            ForEachRow(delegate(DataGridViewRow row) { ForEachCell(row, action); });
        }
        private void ForEachCell(DataGridViewRow row, Action<DataGridViewCell> action)
        {
            foreach (var j in Enumerable.Range(0, 175))
            {
                action.Invoke(row.Cells[j]);
            }
        }
        private void ForEachCellInIndexes(DataGridViewRow row, IEnumerable<int> cellExcelIndexes, Action<DataGridViewCell> action)
        {
            foreach (var j in cellExcelIndexes)
            {
                action.Invoke(row.Cells[ExcelToDataGridIndex(j)]);
            }
        }
        private void ForEachCellInRange(DataGridViewRow row, int startExcelIndex, int endExcelIndex, Action<DataGridViewCell> action)
        {
            var start = ExcelToDataGridIndex(startExcelIndex);
            var end = ExcelToDataGridIndex(endExcelIndex);

            for (var j = start; j <= end; j++)
            {
                action.Invoke(row.Cells[j]);
            }
        }
        private void ForEachRow(Action<DataGridViewRow> action)
        {
            for (var i = HEADER_HEIGHT; i < DataGridView.RowCount; i++)
            {
                action.Invoke(DataGridView.Rows[i]);
            }
        }
        private void ForEachRowInRange(int startExcelIndex, int endExcelIndex, Action<DataGridViewRow> action)
        {
            for (var i = startExcelIndex; i <= endExcelIndex; i++)
            {
                action.Invoke(DataGridView.Rows[i]);
            }
        }

        private int ExcelToDataGridIndex(int i)
        {
            return i - 1;
        }
    }
}
