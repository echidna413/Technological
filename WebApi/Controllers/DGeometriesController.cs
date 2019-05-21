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
    public class DGeometriesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/DGeometries
        public IQueryable<DGeometry> Get()
        {
            return db.DGeometries;
        }

        // GET: api/DGeometries/5
        [ResponseType(typeof(DGeometry))]
        public IHttpActionResult Get(int id)
        {
            DGeometry dGeometry = db.DGeometries.Find(id);
            if (dGeometry == null)
            {
                return NotFound();
            }

            return Ok(dGeometry);
        }

        // PUT: api/DGeometries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DGeometry dGeometry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dGeometry.deviation_id)
            {
                return BadRequest();
            }

            db.Entry(dGeometry).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DGeometryExists(id))
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

        // POST: api/DGeometries
        [ResponseType(typeof(DGeometry))]
        public IHttpActionResult Post(DGeometry dGeometry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DGeometries.Add(dGeometry);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dGeometry.deviation_id }, dGeometry);
        }

        // DELETE: api/DGeometries/5
        [ResponseType(typeof(DGeometry))]
        public IHttpActionResult Delete(int id)
        {
            DGeometry dGeometry = db.DGeometries.Find(id);
            if (dGeometry == null)
            {
                return NotFound();
            }

            db.DGeometries.Remove(dGeometry);
            db.SaveChanges();

            return Ok(dGeometry);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DGeometryExists(int id)
        {
            return db.DGeometries.Count(e => e.deviation_id == id) > 0;
        }
    }
}