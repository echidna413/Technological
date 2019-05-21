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
    public class EBaseSizesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EBaseSizes
        public IQueryable<EBaseSize> Get()
        {
            return db.EBaseSizes;
        }

        // GET: api/EBaseSizes/5
        [ResponseType(typeof(EBaseSize))]
        public IHttpActionResult Get(int id)
        {
            EBaseSize eBaseSize = db.EBaseSizes.Find(id);
            if (eBaseSize == null)
            {
                return NotFound();
            }

            return Ok(eBaseSize);
        }

        // PUT: api/EBaseSizes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EBaseSize eBaseSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eBaseSize.base_requirement_id)
            {
                return BadRequest();
            }

            db.Entry(eBaseSize).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EBaseSizeExists(id))
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

        // POST: api/EBaseSizes
        [ResponseType(typeof(EBaseSize))]
        public IHttpActionResult Post(EBaseSize eBaseSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EBaseSizes.Add(eBaseSize);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EBaseSizeExists(eBaseSize.base_requirement_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eBaseSize.base_requirement_id }, eBaseSize);
        }

        // DELETE: api/EBaseSizes/5
        [ResponseType(typeof(EBaseSize))]
        public IHttpActionResult Delete(int id)
        {
            EBaseSize eBaseSize = db.EBaseSizes.Find(id);
            if (eBaseSize == null)
            {
                return NotFound();
            }

            db.EBaseSizes.Remove(eBaseSize);
            db.SaveChanges();

            return Ok(eBaseSize);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EBaseSizeExists(int id)
        {
            return db.EBaseSizes.Count(e => e.base_requirement_id == id) > 0;
        }
    }
}