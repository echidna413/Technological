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
    public class RouteCardsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/RouteCards
        public IQueryable<RouteCard> Get()
        {
            return db.RouteCards;
        }

        // GET: api/RouteCards/5
        [ResponseType(typeof(RouteCard))]
        public IHttpActionResult Get(int id)
        {
            RouteCard routeCard = db.RouteCards.Find(id);
            if (routeCard == null)
            {
                return NotFound();
            }

            return Ok(routeCard);
        }

        // PUT: api/RouteCards/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, RouteCard routeCard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != routeCard.id_card)
            {
                return BadRequest();
            }

            db.Entry(routeCard).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteCardExists(id))
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

        // POST: api/RouteCards
        [ResponseType(typeof(RouteCard))]
        public IHttpActionResult Post(RouteCard routeCard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RouteCards.Add(routeCard);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = routeCard.id_card }, routeCard);
        }

        // DELETE: api/RouteCards/5
        [ResponseType(typeof(RouteCard))]
        public IHttpActionResult Delete(int id)
        {
            RouteCard routeCard = db.RouteCards.Find(id);
            if (routeCard == null)
            {
                return NotFound();
            }

            db.RouteCards.Remove(routeCard);
            db.SaveChanges();

            return Ok(routeCard);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RouteCardExists(int id)
        {
            return db.RouteCards.Count(e => e.id_card == id) > 0;
        }
    }
}