using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.IO;

namespace Tadb.ServerStudio.Services
{
    public static class CreatePdfService
    {
        public static Stream CreatePdf(DataTable data)
        {
            using(Document document = new Document(PageSize.A4, 10, 10, 10, 10))
            {
                var output = new MemoryStream();

                PdfWriter writer = PdfWriter.GetInstance(document, output);
                writer.CloseStream = false;

                document.Open();
                
                BaseFont bf = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font f = new Font(bf, 12, Font.NORMAL, BaseColor.BLACK);

                PdfPTable table = new PdfPTable(data.Columns.Count);
                foreach (DataColumn col in data.Columns)
                {
                    table.AddCell(new Phrase(col.ColumnName, f));

                }
                foreach (DataRow row in data.Rows)
                {
                    foreach (DataColumn col in data.Columns)
                    {
                        table.AddCell(row[col].ToString());
                    }
                }
                
                document.Add(table);
                document.Close();

                output.Seek(0, SeekOrigin.Begin);

                return output;
            }
        }
    }
}