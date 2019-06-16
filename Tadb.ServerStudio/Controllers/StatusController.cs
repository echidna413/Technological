using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Tadb.DAL;
using Tadb.ServerStudio.Services;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("StatusController")]
    public class StatusController : ApiController
    {
        private readonly StatusService _statusService;

        public StatusController()
        {
            _statusService = new StatusService();
        }

        [HttpGet]
        [Route("Get")]
        public async Task<List<Status>> GetStatuses()
        {
            var result = await _statusService.GetStatuses();
            return result;
        }
    }
}
