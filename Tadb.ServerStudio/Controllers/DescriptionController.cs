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
    [RoutePrefix("DescriptionController")]
    public class DescriptionController : ApiController
    {
        private static DescriptionService _descriptionService;

        public DescriptionController()
        {
            _descriptionService = new DescriptionService();
        }

        [HttpPost]
        [Route("Description")]
        public async Task<List<DescriptionDto>> GetDescription(DetailFilter detailFilter)
        {
            var result = await _descriptionService.GetDescriprionsByFilter(detailFilter);
            return result;
        }

        [HttpGet]
        [Route("Description/Material")]
        public async Task<List<string>> GetMaterials()
        {
            var result = await _descriptionService.GetMaterials();
            return result;
        }

        [HttpGet]
        [Route("Description/Download")]
        public async Task<HttpResponseMessage> DownloadDescription(int? employeeId, string material)
        {
            var descriptions = await _descriptionService.GetDescriprionsByFilter(
                new DetailFilter { EmployeeId = employeeId, Material = material });

            var table = _descriptionService.DescriptionsToDataTable(descriptions);

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
