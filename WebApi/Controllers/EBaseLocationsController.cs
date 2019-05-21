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
    public class EBaseLocationsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EBaseLocations
        public IQueryable<EBaseLocation> Get()
        {
            return db.EBaseLocations;
        }

        // GET: api/EBaseLocations/5
        [ResponseType(typeof(EBaseLocation))]
        public IHttpActionResult Get(int id)
        {
            EBaseLocation eBaseLocation = db.EBaseLocations.Find(id);
            if (eBaseLocation == null)
            {
                return NotFound();
            }

            return Ok(eBaseLocation);
        }

        // PUT: api/EBaseLocations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EBaseLocation eBaseLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eBaseLocation.base_requirement_id)
            {
                return BadRequest();
            }

            db.Entry(eBaseLocation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EBaseLocationExists(id))
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

        // POST: api/EBaseLocations
        [ResponseType(typeof(EBaseLocation))]
        public IHttpActionResult Post(EBaseLocation eBaseLocation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EBaseLocations.Add(eBaseLocation);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EBaseLocationExists(eBaseLocation.base_requirement_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eBaseLocation.base_requirement_id }, eBaseLocation);
        }

        // DELETE: api/EBaseLocations/5
        [ResponseType(typeof(EBaseLocation))]
        public IHttpActionResult Delete(int id)
        {
            EBaseLocation eBaseLocation = db.EBaseLocations.Find(id);
            if (eBaseLocation == null)
            {
                return NotFound();
            }

            db.EBaseLocations.Remove(eBaseLocation);
            db.SaveChanges();

            return Ok(eBaseLocation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EBaseLocationExists(int id)
        {
            return db.EBaseLocations.Count(e => e.base_requirement_id == id) > 0;
        }
    }
}