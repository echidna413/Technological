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
    public class ESpeedsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ESpeeds
        public IQueryable<ESpeed> Get()
        {
            return db.ESpeeds;
        }

        // GET: api/ESpeeds/5
        [ResponseType(typeof(ESpeed))]
        public IHttpActionResult Get(int id)
        {
            ESpeed eSpeed = db.ESpeeds.Find(id);
            if (eSpeed == null)
            {
                return NotFound();
            }

            return Ok(eSpeed);
        }

        // PUT: api/ESpeeds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ESpeed eSpeed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eSpeed.speed_id)
            {
                return BadRequest();
            }

            db.Entry(eSpeed).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ESpeedExists(id))
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

        // POST: api/ESpeeds
        [ResponseType(typeof(ESpeed))]
        public IHttpActionResult Post(ESpeed eSpeed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ESpeeds.Add(eSpeed);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eSpeed.speed_id }, eSpeed);
        }

        // DELETE: api/ESpeeds/5
        [ResponseType(typeof(ESpeed))]
        public IHttpActionResult Delete(int id)
        {
            ESpeed eSpeed = db.ESpeeds.Find(id);
            if (eSpeed == null)
            {
                return NotFound();
            }

            db.ESpeeds.Remove(eSpeed);
            db.SaveChanges();

            return Ok(eSpeed);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ESpeedExists(int id)
        {
            return db.ESpeeds.Count(e => e.speed_id == id) > 0;
        }
    }
}