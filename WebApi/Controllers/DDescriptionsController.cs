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
    public class DDescriptionsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/DDescriptions
        public IQueryable<DDescription> Get()
        {
            return db.DDescriptions;
        }

        // GET: api/DDescriptions/5
        [ResponseType(typeof(DDescription))]
        public IHttpActionResult Get(int id)
        {
            DDescription dDescription = db.DDescriptions.Find(id);
            if (dDescription == null)
            {
                return NotFound();
            }

            return Ok(dDescription);
        }

        // PUT: api/DDescriptions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DDescription dDescription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dDescription.detail_id)
            {
                return BadRequest();
            }

            db.Entry(dDescription).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DDescriptionExists(id))
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

        // POST: api/DDescriptions
        [ResponseType(typeof(DDescription))]
        public IHttpActionResult Post(DDescription dDescription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DDescriptions.Add(dDescription);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dDescription.detail_id }, dDescription);
        }

        // DELETE: api/DDescriptions/5
        [ResponseType(typeof(DDescription))]
        public IHttpActionResult Delete(int id)
        {
            DDescription dDescription = db.DDescriptions.Find(id);
            if (dDescription == null)
            {
                return NotFound();
            }

            db.DDescriptions.Remove(dDescription);
            db.SaveChanges();

            return Ok(dDescription);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DDescriptionExists(int id)
        {
            return db.DDescriptions.Count(e => e.detail_id == id) > 0;
        }
    }
}