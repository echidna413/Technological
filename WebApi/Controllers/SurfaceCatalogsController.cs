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
    public class SurfaceCatalogsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/SurfaceCatalogs
        public IQueryable<SurfaceCatalog> Get()
        {
            return db.CodesSurfaces;
        }

        // GET: api/SurfaceCatalogs/5
        [ResponseType(typeof(SurfaceCatalog))]
        public IHttpActionResult Get(int id)
        {
            SurfaceCatalog surfaceCatalog = db.CodesSurfaces.Find(id);
            if (surfaceCatalog == null)
            {
                return NotFound();
            }

            return Ok(surfaceCatalog);
        }

        // PUT: api/SurfaceCatalogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, SurfaceCatalog surfaceCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != surfaceCatalog.surface_code)
            {
                return BadRequest();
            }

            db.Entry(surfaceCatalog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurfaceCatalogExists(id))
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

        // POST: api/SurfaceCatalogs
        [ResponseType(typeof(SurfaceCatalog))]
        public IHttpActionResult Post(SurfaceCatalog surfaceCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CodesSurfaces.Add(surfaceCatalog);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SurfaceCatalogExists(surfaceCatalog.surface_code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = surfaceCatalog.surface_code }, surfaceCatalog);
        }

        // DELETE: api/SurfaceCatalogs/5
        [ResponseType(typeof(SurfaceCatalog))]
        public IHttpActionResult Delete(int id)
        {
            SurfaceCatalog surfaceCatalog = db.CodesSurfaces.Find(id);
            if (surfaceCatalog == null)
            {
                return NotFound();
            }

            db.CodesSurfaces.Remove(surfaceCatalog);
            db.SaveChanges();

            return Ok(surfaceCatalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SurfaceCatalogExists(int id)
        {
            return db.CodesSurfaces.Count(e => e.surface_code == id) > 0;
        }
    }
}