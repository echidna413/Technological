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
    public class BDescriptionsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/BDescriptions
        public IQueryable<BDescription> Get()
        {
            return db.BDescriptions;
        }

        // GET: api/BDescriptions/5
        [ResponseType(typeof(BDescription))]
        public IHttpActionResult Get(int id)
        {
            BDescription bDescription = db.BDescriptions.Find(id);
            if (bDescription == null)
            {
                return NotFound();
            }

            return Ok(bDescription);
        }

        // PUT: api/BDescriptions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, BDescription bDescription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bDescription.billet_id)
            {
                return BadRequest();
            }

            db.Entry(bDescription).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BDescriptionExists(id))
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

        // POST: api/BDescriptions
        [ResponseType(typeof(BDescription))]
        public IHttpActionResult Post(BDescription bDescription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BDescriptions.Add(bDescription);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bDescription.billet_id }, bDescription);
        }

        // DELETE: api/BDescriptions/5
        [ResponseType(typeof(BDescription))]
        public IHttpActionResult Delete(int id)
        {
            BDescription bDescription = db.BDescriptions.Find(id);
            if (bDescription == null)
            {
                return NotFound();
            }

            db.BDescriptions.Remove(bDescription);
            db.SaveChanges();

            return Ok(bDescription);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BDescriptionExists(int id)
        {
            return db.BDescriptions.Count(e => e.billet_id == id) > 0;
        }
    }
}