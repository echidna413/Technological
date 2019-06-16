using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Tadb.DAL;
using Tadb.ServerStudio.Services;

namespace Tadb.ServerStudio.Controllers
{
    [RoutePrefix("EmployeeController")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        [HttpGet]
        [Route("Get")]
        public async Task<List<Employee>> GetEmployees()
        {
            var result = await _employeeService.GetEmployees();
            return result;
        }
    }
}
