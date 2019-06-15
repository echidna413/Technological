using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tadb.DAL;
using Tadb.ServerStudio.Models;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("RecordController")]
    public class RecordController : ApiController
    {
        [HttpGet]
        [Route("Record")]
        public List<Record> GetAllRecord()
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Records.ToList();
            }
        }

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
    }
}
