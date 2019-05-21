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
    public class ETransitionBasesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ETransitionBases
        public IQueryable<ETransitionBase> Get()
        {
            return db.ETransitionsBases;
        }

        // GET: api/ETransitionBases/5
        [ResponseType(typeof(ETransitionBase))]
        public IHttpActionResult Get(int id)
        {
            ETransitionBase eTransitionBase = db.ETransitionsBases.Find(id);
            if (eTransitionBase == null)
            {
                return NotFound();
            }

            return Ok(eTransitionBase);
        }

        // PUT: api/ETransitionBases/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ETransitionBase eTransitionBase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eTransitionBase.base_requirement_id)
            {
                return BadRequest();
            }

            db.Entry(eTransitionBase).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ETransitionBaseExists(id))
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

        // POST: api/ETransitionBases
        [ResponseType(typeof(ETransitionBase))]
        public IHttpActionResult Post(ETransitionBase eTransitionBase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ETransitionsBases.Add(eTransitionBase);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eTransitionBase.base_requirement_id }, eTransitionBase);
        }

        // DELETE: api/ETransitionBases/5
        [ResponseType(typeof(ETransitionBase))]
        public IHttpActionResult Delete(int id)
        {
            ETransitionBase eTransitionBase = db.ETransitionsBases.Find(id);
            if (eTransitionBase == null)
            {
                return NotFound();
            }

            db.ETransitionsBases.Remove(eTransitionBase);
            db.SaveChanges();

            return Ok(eTransitionBase);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ETransitionBaseExists(int id)
        {
            return db.ETransitionsBases.Count(e => e.base_requirement_id == id) > 0;
        }
    }
}