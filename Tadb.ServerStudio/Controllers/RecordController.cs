using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Tadb.DAL;
using Tadb.ServerStudio.Models;
using System.Net;
using Tadb.ServerStudio.Services;
using System.Threading.Tasks;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("RecordController")]
    public class RecordController : ApiController
    {
        private static RecordService _recordService;

        public RecordController()
        {
            _recordService = new RecordService();
        }

        [HttpPost]
        [Route("Record")]
        public async Task<List<Record>> GetRecord(RecordFilter recordFilter)
        {
            var result = await _recordService.GetRecordsByFilter(recordFilter);
            return result;
        }

        [HttpGet]
        [Route("Record/Download")]
        public async Task<HttpResponseMessage> DownloadRecord(int? employeeId, int? statusId)
        {
            var records = await _recordService.GetRecordsByFilter(
                new RecordFilter { EmployeeId = employeeId, StatusId = statusId });

            var table = _recordService.RecordsToDataTable(records);

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
}
