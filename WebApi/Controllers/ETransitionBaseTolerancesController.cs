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
    public class ETransitionBaseTolerancesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ETransitionBaseTolerances
        public IQueryable<ETransitionBaseTolerance> Get()
        {
            return db.ETransitionsBasesTolerance;
        }

        // GET: api/ETransitionBaseTolerances/5
        [ResponseType(typeof(ETransitionBaseTolerance))]
        public IHttpActionResult Get(int id)
        {
            ETransitionBaseTolerance eTransitionBaseTolerance = db.ETransitionsBasesTolerance.Find(id);
            if (eTransitionBaseTolerance == null)
            {
                return NotFound();
            }

            return Ok(eTransitionBaseTolerance);
        }

        // PUT: api/ETransitionBaseTolerances/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ETransitionBaseTolerance eTransitionBaseTolerance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTransitionBaseTolerance.base_requirement_id)
            {
                return BadRequest();
            }

            db.Entry(eTransitionBaseTolerance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETransitionBaseToleranceExists(id))
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

        // POST: api/ETransitionBaseTolerances
        [ResponseType(typeof(ETransitionBaseTolerance))]
        public IHttpActionResult Post(ETransitionBaseTolerance eTransitionBaseTolerance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETransitionsBasesTolerance.Add(eTransitionBaseTolerance);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ETransitionBaseToleranceExists(eTransitionBaseTolerance.base_requirement_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eTransitionBaseTolerance.base_requirement_id }, eTransitionBaseTolerance);
        }

        // DELETE: api/ETransitionBaseTolerances/5
        [ResponseType(typeof(ETransitionBaseTolerance))]
        public IHttpActionResult Delete(int id)
        {
            ETransitionBaseTolerance eTransitionBaseTolerance = db.ETransitionsBasesTolerance.Find(id);
            if (eTransitionBaseTolerance == null)
            {
                return NotFound();
            }

            db.ETransitionsBasesTolerance.Remove(eTransitionBaseTolerance);
            db.SaveChanges();

            return Ok(eTransitionBaseTolerance);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETransitionBaseToleranceExists(int id)
        {
            return db.ETransitionsBasesTolerance.Count(e => e.base_requirement_id == id) > 0;
        }
    }
}