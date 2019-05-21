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
    public class BSizeSurfacesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/BSizeSurfaces
        public IQueryable<BSizeSurface> Get()
        {
            return db.BSizesSurfaces;
        }

        // GET: api/BSizeSurfaces/5
        [ResponseType(typeof(BSizeSurface))]
        public IHttpActionResult Get(int id)
        {
            BSizeSurface bSizeSurface = db.BSizesSurfaces.Find(id);
            if (bSizeSurface == null)
            {
                return NotFound();
            }

            return Ok(bSizeSurface);
        }

        // PUT: api/BSizeSurfaces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, BSizeSurface bSizeSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bSizeSurface.size_id)
            {
                return BadRequest();
            }

            db.Entry(bSizeSurface).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BSizeSurfaceExists(id))
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

        // POST: api/BSizeSurfaces
        [ResponseType(typeof(BSizeSurface))]
        public IHttpActionResult Post(BSizeSurface bSizeSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BSizesSurfaces.Add(bSizeSurface);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bSizeSurface.size_id }, bSizeSurface);
        }

        // DELETE: api/BSizeSurfaces/5
        [ResponseType(typeof(BSizeSurface))]
        public IHttpActionResult Delete(int id)
        {
            BSizeSurface bSizeSurface = db.BSizesSurfaces.Find(id);
            if (bSizeSurface == null)
            {
                return NotFound();
            }

            db.BSizesSurfaces.Remove(bSizeSurface);
            db.SaveChanges();

            return Ok(bSizeSurface);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BSizeSurfaceExists(int id)
        {
            return db.BSizesSurfaces.Count(e => e.size_id == id) > 0;
        }
    }
}