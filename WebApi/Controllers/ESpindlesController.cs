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
    public class ESpindlesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ESpindles
        public IQueryable<ESpindle> Get()
        {
            return db.ESpindles;
        }

        // GET: api/ESpindles/5
        [ResponseType(typeof(ESpindle))]
        public IHttpActionResult Get(int id)
        {
            ESpindle eSpindle = db.ESpindles.Find(id);
            if (eSpindle == null)
            {
                return NotFound();
            }

            return Ok(eSpindle);
        }

        // PUT: api/ESpindles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ESpindle eSpindle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eSpindle.spindle_id)
            {
                return BadRequest();
            }

            db.Entry(eSpindle).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ESpindleExists(id))
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

        // POST: api/ESpindles
        [ResponseType(typeof(ESpindle))]
        public IHttpActionResult Post(ESpindle eSpindle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ESpindles.Add(eSpindle);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eSpindle.spindle_id }, eSpindle);
        }

        // DELETE: api/ESpindles/5
        [ResponseType(typeof(ESpindle))]
        public IHttpActionResult Delete(int id)
        {
            ESpindle eSpindle = db.ESpindles.Find(id);
            if (eSpindle == null)
            {
                return NotFound();
            }

            db.ESpindles.Remove(eSpindle);
            db.SaveChanges();

            return Ok(eSpindle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ESpindleExists(int id)
        {
            return db.ESpindles.Count(e => e.spindle_id == id) > 0;
        }
    }
}