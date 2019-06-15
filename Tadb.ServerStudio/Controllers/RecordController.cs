using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using Tadb.DAL;
using Tadb.ServerStudio.Models;
using System.Net;
using Tadb.ServerStudio.Services;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("RecordController")]
    public class RecordController : ApiController
    {
        [HttpPost]
        [Route("Record")]
        public List<Record> GetRecord(RecordFilter recordFilter)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                var records = context.Records;

                if (recordFilter == null)
                    return records.ToList();

                if (recordFilter.EmployeeId.HasValue)
                    records.Where(x => x.id_employee.Equals(recordFilter.EmployeeId));
                if (recordFilter.StatusId.HasValue)
                    records.Where(x => x.id_status.Equals(recordFilter.StatusId));

                return records.ToList();
            }
        }

        [HttpGet]
        [Route("Record/Download")]
        public HttpResponseMessage DownloadRecord(int? employeeId, int? statusId)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                var records = context.Records;

                if (employeeId.HasValue)
                    records.Where(x => x.id_employee.Equals(employeeId));
                if (statusId.HasValue)
                    records.Where(x => x.id_status.Equals(statusId));

                var table = ToDataTable(records.ToList());
                var stream = CreatePdfService.CreatePdf(table);

                return new HttpResponseMessage
                {
                    Content = new StreamContent(stream)
                    {
                        Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/pdf"),
                            ContentDisposition = new ContentDispositionHeaderValue("attachment")
                            {
                                FileName = "Отчет.pdf"
                            }
                        }
                    },
                    StatusCode = HttpStatusCode.OK
                };
            }
        }

        private static DataTable ToDataTable(List<Record> records)
        {
            //TODO добавить все нужные поля
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Сотрудник");
            dataTable.Columns.Add("Статус");

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Employee, record.Status);
            }

            return dataTable;
        }
    }
}
