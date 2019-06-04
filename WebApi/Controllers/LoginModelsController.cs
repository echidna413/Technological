using AutoMapper;
using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

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

        // PUT: api/LoginModels/5
        [ResponseType(typeof(void))]
        //public IHttpActionResult Put(int id, LoginModel loginModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != loginModel.id_employee)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(loginModel).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LoginModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/LoginModels
        //[ResponseType(typeof(LoginModel))]
        //public IHttpActionResult Post(LoginModel loginModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.LoginModels.Add(loginModel);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = loginModel.id_employee }, loginModel);
        //}

        //// DELETE: api/LoginModels/5
        //[ResponseType(typeof(LoginModel))]
        //public IHttpActionResult Delete(int id)
        //{
        //    LoginModel loginModel = db.LoginModels.Find(id);
        //    if (loginModel == null)
        //    {
        //        return NotFound();
        //    }

        //    db.LoginModels.Remove(loginModel);
        //    db.SaveChanges();

        //    return Ok(loginModel);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool LoginModelExists(int id)
        //{
        //    return db.LoginModels.Count(e => e.id_employee == id) > 0;
        //}
    }
}