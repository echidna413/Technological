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
    public class DRelationSizesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/DRelationSizes
        public IQueryable<DRelationSize> Get()
        {
            return db.DRelationSizes;
        }

        // GET: api/DRelationSizes/5
        [ResponseType(typeof(DRelationSize))]
        public IHttpActionResult Get(int id)
        {
            DRelationSize dRelationSize = db.DRelationSizes.Find(id);
            if (dRelationSize == null)
            {
                return NotFound();
            }

            return Ok(dRelationSize);
        }

        // PUT: api/DRelationSizes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DRelationSize dRelationSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dRelationSize.relation_id)
            {
                return BadRequest();
            }

            db.Entry(dRelationSize).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DRelationSizeExists(id))
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

        // POST: api/DRelationSizes
        [ResponseType(typeof(DRelationSize))]
        public IHttpActionResult Post(DRelationSize dRelationSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DRelationSizes.Add(dRelationSize);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dRelationSize.relation_id }, dRelationSize);
        }

        // DELETE: api/DRelationSizes/5
        [ResponseType(typeof(DRelationSize))]
        public IHttpActionResult Delete(int id)
        {
            DRelationSize dRelationSize = db.DRelationSizes.Find(id);
            if (dRelationSize == null)
            {
                return NotFound();
            }

            db.DRelationSizes.Remove(dRelationSize);
            db.SaveChanges();

            return Ok(dRelationSize);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DRelationSizeExists(int id)
        {
            return db.DRelationSizes.Count(e => e.relation_id == id) > 0;
        }
    }
}