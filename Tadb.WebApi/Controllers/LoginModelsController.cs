using System;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using Tadb.BL;
using Tadb.DAL;
using Tadb.WebApi.Models;

namespace WebApi.Controllers
{
    public class LoginModelsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();
        private AutorizationService service = new AutorizationService();

        // GET: api/LoginModels/5
        [HttpPost]
        [AllowAnonymous]
        [ResponseType(typeof(LoginModel))]
        public IHttpActionResult Post([FromBody] UserModel user)
        {
            Employee employee;

            try
            {
                employee = service.GetEmployeeByLoginPassword(user.username, user.password);
                var loginModel = Mapper.Map<Employee, LoginModel>(employee);
                return Ok(loginModel);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}