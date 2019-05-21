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
    public class EBaseSurfacesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EBaseSurfaces
        public IQueryable<EBaseSurface> Get()
        {
            return db.EBaseSurfaces;
        }

        // GET: api/EBaseSurfaces/5
        [ResponseType(typeof(EBaseSurface))]
        public IHttpActionResult Get(int id)
        {
            EBaseSurface eBaseSurface = db.EBaseSurfaces.Find(id);
            if (eBaseSurface == null)
            {
                return NotFound();
            }

            return Ok(eBaseSurface);
        }

        // PUT: api/EBaseSurfaces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EBaseSurface eBaseSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eBaseSurface.base_requirement_id)
            {
                return BadRequest();
            }

            db.Entry(eBaseSurface).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EBaseSurfaceExists(id))
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

        // POST: api/EBaseSurfaces
        [ResponseType(typeof(EBaseSurface))]
        public IHttpActionResult Post(EBaseSurface eBaseSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EBaseSurfaces.Add(eBaseSurface);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eBaseSurface.base_requirement_id }, eBaseSurface);
        }

        // DELETE: api/EBaseSurfaces/5
        [ResponseType(typeof(EBaseSurface))]
        public IHttpActionResult Delete(int id)
        {
            EBaseSurface eBaseSurface = db.EBaseSurfaces.Find(id);
            if (eBaseSurface == null)
            {
                return NotFound();
            }

            db.EBaseSurfaces.Remove(eBaseSurface);
            db.SaveChanges();

            return Ok(eBaseSurface);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EBaseSurfaceExists(int id)
        {
            return db.EBaseSurfaces.Count(e => e.base_requirement_id == id) > 0;
        }
    }
}