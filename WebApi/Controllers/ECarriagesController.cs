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
    public class ECarriagesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ECarriages
        public IQueryable<ECarriage> Get()
        {
            return db.ECarriages;
        }

        // GET: api/ECarriages/5
        [ResponseType(typeof(ECarriage))]
        public IHttpActionResult Get(int id)
        {
            ECarriage eCarriage = db.ECarriages.Find(id);
            if (eCarriage == null)
            {
                return NotFound();
            }

            return Ok(eCarriage);
        }

        // PUT: api/ECarriages/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ECarriage eCarriage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eCarriage.carriage_id)
            {
                return BadRequest();
            }

            db.Entry(eCarriage).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ECarriageExists(id))
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

        // POST: api/ECarriages
        [ResponseType(typeof(ECarriage))]
        public IHttpActionResult Post(ECarriage eCarriage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ECarriages.Add(eCarriage);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eCarriage.carriage_id }, eCarriage);
        }

        // DELETE: api/ECarriages/5
        [ResponseType(typeof(ECarriage))]
        public IHttpActionResult Delete(int id)
        {
            ECarriage eCarriage = db.ECarriages.Find(id);
            if (eCarriage == null)
            {
                return NotFound();
            }

            db.ECarriages.Remove(eCarriage);
            db.SaveChanges();

            return Ok(eCarriage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ECarriageExists(int id)
        {
            return db.ECarriages.Count(e => e.carriage_id == id) > 0;
        }
    }
}