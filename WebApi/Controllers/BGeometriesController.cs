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
    public class BGeometriesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/BGeometries
        public IQueryable<BGeometry> Get()
        {
            return db.BGeometries;
        }

        // GET: api/BGeometries/5
        [ResponseType(typeof(BGeometry))]
        public IHttpActionResult Get(int id)
        {
            BGeometry bGeometry = db.BGeometries.Find(id);
            if (bGeometry == null)
            {
                return NotFound();
            }

            return Ok(bGeometry);
        }

        // PUT: api/BGeometries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, BGeometry bGeometry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bGeometry.deviation_id)
            {
                return BadRequest();
            }

            db.Entry(bGeometry).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BGeometryExists(id))
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

        // POST: api/BGeometries
        [ResponseType(typeof(BGeometry))]
        public IHttpActionResult Post(BGeometry bGeometry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BGeometries.Add(bGeometry);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bGeometry.deviation_id }, bGeometry);
        }

        // DELETE: api/BGeometries/5
        [ResponseType(typeof(BGeometry))]
        public IHttpActionResult Delete(int id)
        {
            BGeometry bGeometry = db.BGeometries.Find(id);
            if (bGeometry == null)
            {
                return NotFound();
            }

            db.BGeometries.Remove(bGeometry);
            db.SaveChanges();

            return Ok(bGeometry);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BGeometryExists(int id)
        {
            return db.BGeometries.Count(e => e.deviation_id == id) > 0;
        }
    }
}