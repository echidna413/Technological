using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tadb.DAL;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("EmployeeController")]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("Get")]
        public List<Employee> GetEmployees()
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
