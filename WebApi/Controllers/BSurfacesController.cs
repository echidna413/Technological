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
    public class BSurfacesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/BSurfaces
        public IQueryable<BSurface> Get()
        {
            return db.BSurfaces;
        }

        // GET: api/BSurfaces/5
        [ResponseType(typeof(BSurface))]
        public IHttpActionResult Get(int id)
        {
            BSurface bSurface = db.BSurfaces.Find(id);
            if (bSurface == null)
            {
                return NotFound();
            }

            return Ok(bSurface);
        }

        // PUT: api/BSurfaces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, BSurface bSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bSurface.surface_id)
            {
                return BadRequest();
            }

            db.Entry(bSurface).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BSurfaceExists(id))
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

        // POST: api/BSurfaces
        [ResponseType(typeof(BSurface))]
        public IHttpActionResult Post(BSurface bSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BSurfaces.Add(bSurface);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bSurface.surface_id }, bSurface);
        }

        // DELETE: api/BSurfaces/5
        [ResponseType(typeof(BSurface))]
        public IHttpActionResult Delete(int id)
        {
            BSurface bSurface = db.BSurfaces.Find(id);
            if (bSurface == null)
            {
                return NotFound();
            }

            db.BSurfaces.Remove(bSurface);
            db.SaveChanges();

            return Ok(bSurface);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BSurfaceExists(int id)
        {
            return db.BSurfaces.Count(e => e.surface_id == id) > 0;
        }
    }
}