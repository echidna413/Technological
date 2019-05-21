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
using DAL;

namespace WebApi.Controllers
{
    public class ELathesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ELathes
        public IQueryable<ELathe> Get()
        {
            return db.ELathes;
        }

        // GET: api/ELathes/5
        [ResponseType(typeof(ELathe))]
        public IHttpActionResult Get(int id)
        {
            ELathe eLathe = db.ELathes.Find(id);
            if (eLathe == null)
            {
                return NotFound();
            }

            return Ok(eLathe);
        }

        // PUT: api/ELathes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ELathe eLathe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eLathe.lathe_id)
            {
                return BadRequest();
            }

            db.Entry(eLathe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ELatheExists(id))
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

        // POST: api/ELathes
        [ResponseType(typeof(ELathe))]
        public IHttpActionResult Post(ELathe eLathe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ELathes.Add(eLathe);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eLathe.lathe_id }, eLathe);
        }

        // DELETE: api/ELathes/5
        [ResponseType(typeof(ELathe))]
        public IHttpActionResult Delete(int id)
        {
            ELathe eLathe = db.ELathes.Find(id);
            if (eLathe == null)
            {
                return NotFound();
            }

            db.ELathes.Remove(eLathe);
            db.SaveChanges();

            return Ok(eLathe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ELatheExists(int id)
        {
            return db.ELathes.Count(e => e.lathe_id == id) > 0;
        }
    }
}