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
    public class BLocationsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/BLocations
        public IQueryable<BLocation> Get()
        {
            return db.BLocations;
        }

        // GET: api/BLocations/5
        [ResponseType(typeof(BLocation))]
        public IHttpActionResult Get(int id)
        {
            BLocation bLocation = db.BLocations.Find(id);
            if (bLocation == null)
            {
                return NotFound();
            }

            return Ok(bLocation);
        }

        // PUT: api/BLocations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, BLocation bLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bLocation.location_id)
            {
                return BadRequest();
            }

            db.Entry(bLocation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BLocationExists(id))
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

        // POST: api/BLocations
        [ResponseType(typeof(BLocation))]
        public IHttpActionResult Post(BLocation bLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BLocations.Add(bLocation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bLocation.location_id }, bLocation);
        }

        // DELETE: api/BLocations/5
        [ResponseType(typeof(BLocation))]
        public IHttpActionResult Delete(int id)
        {
            BLocation bLocation = db.BLocations.Find(id);
            if (bLocation == null)
            {
                return NotFound();
            }

            db.BLocations.Remove(bLocation);
            db.SaveChanges();

            return Ok(bLocation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BLocationExists(int id)
        {
            return db.BLocations.Count(e => e.location_id == id) > 0;
        }
    }
}