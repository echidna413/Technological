using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tadb.DAL;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("StatusController")]
    public class StatusController : ApiController
    {
        [HttpGet]
        [Route("Get")]
        public List<Status> GetStatuses()
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Statuses.ToList();
            }
        }
    }
}
