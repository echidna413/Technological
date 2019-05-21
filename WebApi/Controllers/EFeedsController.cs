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
    public class EFeedsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EFeeds
        public IQueryable<EFeed> Get()
        {
            return db.EFeeds;
        }

        // GET: api/EFeeds/5
        [ResponseType(typeof(EFeed))]
        public IHttpActionResult Get(int id)
        {
            EFeed eFeed = db.EFeeds.Find(id);
            if (eFeed == null)
            {
                return NotFound();
            }

            return Ok(eFeed);
        }

        // PUT: api/EFeeds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EFeed eFeed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eFeed.feed_id)
            {
                return BadRequest();
            }

            db.Entry(eFeed).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EFeedExists(id))
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

        // POST: api/EFeeds
        [ResponseType(typeof(EFeed))]
        public IHttpActionResult Post(EFeed eFeed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EFeeds.Add(eFeed);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eFeed.feed_id }, eFeed);
        }

        // DELETE: api/EFeeds/5
        [ResponseType(typeof(EFeed))]
        public IHttpActionResult Delete(int id)
        {
            EFeed eFeed = db.EFeeds.Find(id);
            if (eFeed == null)
            {
                return NotFound();
            }

            db.EFeeds.Remove(eFeed);
            db.SaveChanges();

            return Ok(eFeed);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EFeedExists(int id)
        {
            return db.EFeeds.Count(e => e.feed_id == id) > 0;
        }
    }
}