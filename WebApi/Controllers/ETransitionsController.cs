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
    public class ETransitionsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ETransitions
        public IQueryable<ETransition> Get()
        {
            return db.ETransitions;
        }

        // GET: api/ETransitions/5
        [ResponseType(typeof(ETransition))]
        public IHttpActionResult Get(int id)
        {
            ETransition eTransition = db.ETransitions.Find(id);
            if (eTransition == null)
            {
                return NotFound();
            }

            return Ok(eTransition);
        }

        // PUT: api/ETransitions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ETransition eTransition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTransition.transition_id)
            {
                return BadRequest();
            }

            db.Entry(eTransition).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETransitionExists(id))
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

        // POST: api/ETransitions
        [ResponseType(typeof(ETransition))]
        public IHttpActionResult Post(ETransition eTransition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETransitions.Add(eTransition);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eTransition.transition_id }, eTransition);
        }

        // DELETE: api/ETransitions/5
        [ResponseType(typeof(ETransition))]
        public IHttpActionResult Delete(int id)
        {
            ETransition eTransition = db.ETransitions.Find(id);
            if (eTransition == null)
            {
                return NotFound();
            }

            db.ETransitions.Remove(eTransition);
            db.SaveChanges();

            return Ok(eTransition);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETransitionExists(int id)
        {
            return db.ETransitions.Count(e => e.transition_id == id) > 0;
        }
    }
}