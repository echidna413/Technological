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
    public class BRelationSizesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/BRelationSizes
        public IQueryable<BRelationSize> Get()
        {
            return db.BRelationSizes;
        }

        // GET: api/BRelationSizes/5
        [ResponseType(typeof(BRelationSize))]
        public IHttpActionResult Get(int id)
        {
            BRelationSize bRelationSize = db.BRelationSizes.Find(id);
            if (bRelationSize == null)
            {
                return NotFound();
            }

            return Ok(bRelationSize);
        }

        // PUT: api/BRelationSizes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, BRelationSize bRelationSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bRelationSize.relation_id)
            {
                return BadRequest();
            }

            db.Entry(bRelationSize).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BRelationSizeExists(id))
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

        // POST: api/BRelationSizes
        [ResponseType(typeof(BRelationSize))]
        public IHttpActionResult Post(BRelationSize bRelationSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BRelationSizes.Add(bRelationSize);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bRelationSize.relation_id }, bRelationSize);
        }

        // DELETE: api/BRelationSizes/5
        [ResponseType(typeof(BRelationSize))]
        public IHttpActionResult Delete(int id)
        {
            BRelationSize bRelationSize = db.BRelationSizes.Find(id);
            if (bRelationSize == null)
            {
                return NotFound();
            }

            db.BRelationSizes.Remove(bRelationSize);
            db.SaveChanges();

            return Ok(bRelationSize);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BRelationSizeExists(int id)
        {
            return db.BRelationSizes.Count(e => e.relation_id == id) > 0;
        }
    }
}