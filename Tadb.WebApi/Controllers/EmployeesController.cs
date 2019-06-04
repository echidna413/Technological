using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.BL;
using Tadb.DAL;
using Tadb.WebApi.Models;

namespace Tadb.WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private AutorizationService service = new AutorizationService();
        private MachineDbContext db = new MachineDbContext();

        // GET: api/Employees
        public IQueryable<Employee> Get()
        {
            return db.Employees;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult Get(int id_employee)
        {
            Employee employee = db.Employees.Find(id_employee);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.id_employee)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [HttpPost]
        [AllowAnonymous]
        [ResponseType(typeof(Employee))]
        public IHttpActionResult Post(EmployeeModel employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            service.CreateNewUser(employee.Role,
                                  employee.Company,
                                  employee.first_name,
                                  employee.second_name,
                                  employee.patronymic,
                                  employee.login,
                                  employee.password);
            //db.Employees.Add(employee);
            //db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.id_employee }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.id_employee == id) > 0;
        }
    }
}