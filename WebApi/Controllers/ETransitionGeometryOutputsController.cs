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
    public class ETransitionGeometryOutputsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ETransitionGeometryOutputs
        public IQueryable<ETransitionGeometryOutput> Get()
        {
            return db.ETransitionsGeometryOutputs;
        }

        // GET: api/ETransitionGeometryOutputs/5
        [ResponseType(typeof(ETransitionGeometryOutput))]
        public IHttpActionResult Get(int id)
        {
            ETransitionGeometryOutput eTransitionGeometryOutput = db.ETransitionsGeometryOutputs.Find(id);
            if (eTransitionGeometryOutput == null)
            {
                return NotFound();
            }

            return Ok(eTransitionGeometryOutput);
        }

        // PUT: api/ETransitionGeometryOutputs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ETransitionGeometryOutput eTransitionGeometryOutput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTransitionGeometryOutput.transition_id)
            {
                return BadRequest();
            }

            db.Entry(eTransitionGeometryOutput).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETransitionGeometryOutputExists(id))
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

        // POST: api/ETransitionGeometryOutputs
        [ResponseType(typeof(ETransitionGeometryOutput))]
        public IHttpActionResult Post(ETransitionGeometryOutput eTransitionGeometryOutput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETransitionsGeometryOutputs.Add(eTransitionGeometryOutput);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ETransitionGeometryOutputExists(eTransitionGeometryOutput.transition_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eTransitionGeometryOutput.transition_id }, eTransitionGeometryOutput);
        }

        // DELETE: api/ETransitionGeometryOutputs/5
        [ResponseType(typeof(ETransitionGeometryOutput))]
        public IHttpActionResult Delete(int id)
        {
            ETransitionGeometryOutput eTransitionGeometryOutput = db.ETransitionsGeometryOutputs.Find(id);
            if (eTransitionGeometryOutput == null)
            {
                return NotFound();
            }

            db.ETransitionsGeometryOutputs.Remove(eTransitionGeometryOutput);
            db.SaveChanges();

            return Ok(eTransitionGeometryOutput);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETransitionGeometryOutputExists(int id)
        {
            return db.ETransitionsGeometryOutputs.Count(e => e.transition_id == id) > 0;
        }
    }
}