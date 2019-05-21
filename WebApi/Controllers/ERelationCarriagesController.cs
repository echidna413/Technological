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
    public class ERelationCarriagesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ERelationCarriages
        public IQueryable<ERelationCarriage> Get()
        {
            return db.ERelationCarriages;
        }

        // GET: api/ERelationCarriages/5
        [ResponseType(typeof(ERelationCarriage))]
        public IHttpActionResult Get(int id)
        {
            ERelationCarriage eRelationCarriage = db.ERelationCarriages.Find(id);
            if (eRelationCarriage == null)
            {
                return NotFound();
            }

            return Ok(eRelationCarriage);
        }

        // PUT: api/ERelationCarriages/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ERelationCarriage eRelationCarriage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eRelationCarriage.relation_id)
            {
                return BadRequest();
            }

            db.Entry(eRelationCarriage).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ERelationCarriageExists(id))
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

        // POST: api/ERelationCarriages
        [ResponseType(typeof(ERelationCarriage))]
        public IHttpActionResult Post(ERelationCarriage eRelationCarriage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ERelationCarriages.Add(eRelationCarriage);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eRelationCarriage.relation_id }, eRelationCarriage);
        }

        // DELETE: api/ERelationCarriages/5
        [ResponseType(typeof(ERelationCarriage))]
        public IHttpActionResult Delete(int id)
        {
            ERelationCarriage eRelationCarriage = db.ERelationCarriages.Find(id);
            if (eRelationCarriage == null)
            {
                return NotFound();
            }

            db.ERelationCarriages.Remove(eRelationCarriage);
            db.SaveChanges();

            return Ok(eRelationCarriage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ERelationCarriageExists(int id)
        {
            return db.ERelationCarriages.Count(e => e.relation_id == id) > 0;
        }
    }
}