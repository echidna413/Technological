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
    public class CodeSurfaceSizesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/CodeSurfaceSizes
        public IQueryable<CodeSurfaceSize> Get()
        {
            return db.CodeSurfaceSizes;
        }

        // GET: api/CodeSurfaceSizes/5
        [ResponseType(typeof(CodeSurfaceSize))]
        public IHttpActionResult Get(int id)
        {
            CodeSurfaceSize codeSurfaceSize = db.CodeSurfaceSizes.Find(id);
            if (codeSurfaceSize == null)
            {
                return NotFound();
            }

            return Ok(codeSurfaceSize);
        }

        // PUT: api/CodeSurfaceSizes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, CodeSurfaceSize codeSurfaceSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != codeSurfaceSize.id)
            {
                return BadRequest();
            }

            db.Entry(codeSurfaceSize).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeSurfaceSizeExists(id))
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

        // POST: api/CodeSurfaceSizes
        [ResponseType(typeof(CodeSurfaceSize))]
        public IHttpActionResult Post(CodeSurfaceSize codeSurfaceSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CodeSurfaceSizes.Add(codeSurfaceSize);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = codeSurfaceSize.id }, codeSurfaceSize);
        }

        // DELETE: api/CodeSurfaceSizes/5
        [ResponseType(typeof(CodeSurfaceSize))]
        public IHttpActionResult Delete(int id)
        {
            CodeSurfaceSize codeSurfaceSize = db.CodeSurfaceSizes.Find(id);
            if (codeSurfaceSize == null)
            {
                return NotFound();
            }

            db.CodeSurfaceSizes.Remove(codeSurfaceSize);
            db.SaveChanges();

            return Ok(codeSurfaceSize);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CodeSurfaceSizeExists(int id)
        {
            return db.CodeSurfaceSizes.Count(e => e.id == id) > 0;
        }
    }
}