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
    public class ETransitionSizesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ETransitionSizes
        public IQueryable<ETransitionSize> Get()
        {
            return db.ETransitionsSizes;
        }

        // GET: api/ETransitionSizes/5
        [ResponseType(typeof(ETransitionSize))]
        public IHttpActionResult Get(int id)
        {
            ETransitionSize eTransitionSize = db.ETransitionsSizes.Find(id);
            if (eTransitionSize == null)
            {
                return NotFound();
            }

            return Ok(eTransitionSize);
        }

        // PUT: api/ETransitionSizes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ETransitionSize eTransitionSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTransitionSize.transition_id)
            {
                return BadRequest();
            }

            db.Entry(eTransitionSize).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETransitionSizeExists(id))
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

        // POST: api/ETransitionSizes
        [ResponseType(typeof(ETransitionSize))]
        public IHttpActionResult Post(ETransitionSize eTransitionSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETransitionsSizes.Add(eTransitionSize);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ETransitionSizeExists(eTransitionSize.transition_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eTransitionSize.transition_id }, eTransitionSize);
        }

        // DELETE: api/ETransitionSizes/5
        [ResponseType(typeof(ETransitionSize))]
        public IHttpActionResult Delete(int id)
        {
            ETransitionSize eTransitionSize = db.ETransitionsSizes.Find(id);
            if (eTransitionSize == null)
            {
                return NotFound();
            }

            db.ETransitionsSizes.Remove(eTransitionSize);
            db.SaveChanges();

            return Ok(eTransitionSize);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETransitionSizeExists(int id)
        {
            return db.ETransitionsSizes.Count(e => e.transition_id == id) > 0;
        }
    }
}