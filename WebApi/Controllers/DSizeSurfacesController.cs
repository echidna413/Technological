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
    public class DSizeSurfacesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/DSizeSurfaces
        public IQueryable<DSizeSurface> Get()
        {
            return db.DSizesSurfaces;
        }

        // GET: api/DSizeSurfaces/5
        [ResponseType(typeof(DSizeSurface))]
        public IHttpActionResult Get(int id)
        {
            DSizeSurface dSizeSurface = db.DSizesSurfaces.Find(id);
            if (dSizeSurface == null)
            {
                return NotFound();
            }

            return Ok(dSizeSurface);
        }

        // PUT: api/DSizeSurfaces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DSizeSurface dSizeSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dSizeSurface.size_id)
            {
                return BadRequest();
            }

            db.Entry(dSizeSurface).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DSizeSurfaceExists(id))
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

        // POST: api/DSizeSurfaces
        [ResponseType(typeof(DSizeSurface))]
        public IHttpActionResult Post(DSizeSurface dSizeSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DSizesSurfaces.Add(dSizeSurface);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dSizeSurface.size_id }, dSizeSurface);
        }

        // DELETE: api/DSizeSurfaces/5
        [ResponseType(typeof(DSizeSurface))]
        public IHttpActionResult Delete(int id)
        {
            DSizeSurface dSizeSurface = db.DSizesSurfaces.Find(id);
            if (dSizeSurface == null)
            {
                return NotFound();
            }

            db.DSizesSurfaces.Remove(dSizeSurface);
            db.SaveChanges();

            return Ok(dSizeSurface);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DSizeSurfaceExists(int id)
        {
            return db.DSizesSurfaces.Count(e => e.size_id == id) > 0;
        }
    }
}