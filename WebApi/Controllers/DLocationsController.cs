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
    public class DLocationsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/DLocations
        public IQueryable<DLocation> Get()
        {
            return db.DLocations;
        }

        // GET: api/DLocations/5
        [ResponseType(typeof(DLocation))]
        public IHttpActionResult Get(int id)
        {
            DLocation dLocation = db.DLocations.Find(id);
            if (dLocation == null)
            {
                return NotFound();
            }

            return Ok(dLocation);
        }

        // PUT: api/DLocations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DLocation dLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dLocation.location_id)
            {
                return BadRequest();
            }

            db.Entry(dLocation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DLocationExists(id))
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

        // POST: api/DLocations
        [ResponseType(typeof(DLocation))]
        public IHttpActionResult Post(DLocation dLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DLocations.Add(dLocation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dLocation.location_id }, dLocation);
        }

        // DELETE: api/DLocations/5
        [ResponseType(typeof(DLocation))]
        public IHttpActionResult Delete(int id)
        {
            DLocation dLocation = db.DLocations.Find(id);
            if (dLocation == null)
            {
                return NotFound();
            }

            db.DLocations.Remove(dLocation);
            db.SaveChanges();

            return Ok(dLocation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DLocationExists(int id)
        {
            return db.DLocations.Count(e => e.location_id == id) > 0;
        }
    }
}