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
    public class ETransitionGeometryInputsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ETransitionGeometryInputs
        public IQueryable<ETransitionGeometryInput> Get()
        {
            return db.ETransitionGeometryInputs;
        }

        // GET: api/ETransitionGeometryInputs/5
        [ResponseType(typeof(ETransitionGeometryInput))]
        public IHttpActionResult Get(int id)
        {
            ETransitionGeometryInput eTransitionGeometryInput = db.ETransitionGeometryInputs.Find(id);
            if (eTransitionGeometryInput == null)
            {
                return NotFound();
            }

            return Ok(eTransitionGeometryInput);
        }

        // PUT: api/ETransitionGeometryInputs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ETransitionGeometryInput eTransitionGeometryInput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTransitionGeometryInput.transition_id)
            {
                return BadRequest();
            }

            db.Entry(eTransitionGeometryInput).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETransitionGeometryInputExists(id))
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

        // POST: api/ETransitionGeometryInputs
        [ResponseType(typeof(ETransitionGeometryInput))]
        public IHttpActionResult Post(ETransitionGeometryInput eTransitionGeometryInput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETransitionGeometryInputs.Add(eTransitionGeometryInput);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ETransitionGeometryInputExists(eTransitionGeometryInput.transition_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eTransitionGeometryInput.transition_id }, eTransitionGeometryInput);
        }

        // DELETE: api/ETransitionGeometryInputs/5
        [ResponseType(typeof(ETransitionGeometryInput))]
        public IHttpActionResult Delete(int id)
        {
            ETransitionGeometryInput eTransitionGeometryInput = db.ETransitionGeometryInputs.Find(id);
            if (eTransitionGeometryInput == null)
            {
                return NotFound();
            }

            db.ETransitionGeometryInputs.Remove(eTransitionGeometryInput);
            db.SaveChanges();

            return Ok(eTransitionGeometryInput);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETransitionGeometryInputExists(int id)
        {
            return db.ETransitionGeometryInputs.Count(e => e.transition_id == id) > 0;
        }
    }
}