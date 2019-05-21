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
    public class CodeSurfacesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/CodeSurfaces
        public IQueryable<CodeSurface> Get()
        {
            return db.CodesSurfaces;
        }

        // GET: api/CodeSurfaces/5
        [ResponseType(typeof(CodeSurface))]
        public IHttpActionResult Get(int id)
        {
            CodeSurface codeSurface = db.CodesSurfaces.Find(id);
            if (codeSurface == null)
            {
                return NotFound();
            }

            return Ok(codeSurface);
        }

        // PUT: api/CodeSurfaces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, CodeSurface codeSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != codeSurface.code_surface_id)
            {
                return BadRequest();
            }

            db.Entry(codeSurface).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeSurfaceExists(id))
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

        // POST: api/CodeSurfaces
        [ResponseType(typeof(CodeSurface))]
        public IHttpActionResult Post(CodeSurface codeSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CodesSurfaces.Add(codeSurface);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = codeSurface.code_surface_id }, codeSurface);
        }

        // DELETE: api/CodeSurfaces/5
        [ResponseType(typeof(CodeSurface))]
        public IHttpActionResult Delete(int id)
        {
            CodeSurface codeSurface = db.CodesSurfaces.Find(id);
            if (codeSurface == null)
            {
                return NotFound();
            }

            db.CodesSurfaces.Remove(codeSurface);
            db.SaveChanges();

            return Ok(codeSurface);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CodeSurfaceExists(int id)
        {
            return db.CodesSurfaces.Count(e => e.code_surface_id == id) > 0;
        }
    }
}