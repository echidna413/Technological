using System;
using System.Windows.Forms;

namespace TestDataGridViewValidating
{
    public partial class Form1 : Form
    {
        public ExcelHelper ExcelHelper { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelHelper = new ExcelHelper() {
                DataGridView = dataGridView1
            };

            ExcelHelper.LoadHeader();
        }
        private void open_toolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            loadFile_backgroundWorker.RunWorkerAsync();
        }
        private void validate_toolStripLabel_Click(object sender, EventArgs e)
        {
            ValidateData();
        }
        private void reset_toolStripLabel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ResetError();
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ExcelHelper.ValidateRow(dataGridView1.Rows[e.RowIndex]);
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ExcelHelper.Colorize();
        }

        private void loadFile_backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DisableControl();
            ExcelHelper.LoadFromFile(openFileDialog1.FileName);
        }
        private void loadFile_backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ValidateData();
            EnableControl();
        }
        private void loadHeader_backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DisableControl();
            ExcelHelper.LoadHeader();
        }
        private void loadHeader_backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableControl();
        }

        private void ValidateData()
        {
            int errorCount = ExcelHelper.Validate();
            if (errorCount > 0)
            {
                MessageBox.Show(
                    string.Format("Error count: {0}", errorCount),
                    "There are some errors!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Everything is fine!",
                    "There are no errors!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void DisableControl()
        {
            toolStrip1.Invoke(new Action(() =>
            {
                Cursor = Cursors.WaitCursor;
                open_toolStripLabel.Enabled = false;
                validate_toolStripLabel.Enabled = false;
                reset_toolStripLabel.Enabled = false;
            }));
        }
        private void EnableControl()
        {
            toolStrip1.Invoke(new Action(() =>
            {
                reset_toolStripLabel.Enabled = true;
                validate_toolStripLabel.Enabled = true;
                open_toolStripLabel.Enabled = true;
                Cursor = Cursors.Default;
            }));
        }
    }
}
