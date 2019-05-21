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
    public class EGroupsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EGroups
        public IQueryable<EGroup> Get()
        {
            return db.EGroups;
        }

        // GET: api/EGroups/5
        [ResponseType(typeof(EGroup))]
        public IHttpActionResult Get(int id)
        {
            EGroup eGroup = db.EGroups.Find(id);
            if (eGroup == null)
            {
                return NotFound();
            }

            return Ok(eGroup);
        }

        // PUT: api/EGroups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EGroup eGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eGroup.group_id)
            {
                return BadRequest();
            }

            db.Entry(eGroup).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EGroupExists(id))
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

        // POST: api/EGroups
        [ResponseType(typeof(EGroup))]
        public IHttpActionResult Post(EGroup eGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EGroups.Add(eGroup);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eGroup.group_id }, eGroup);
        }

        // DELETE: api/EGroups/5
        [ResponseType(typeof(EGroup))]
        public IHttpActionResult Delete(int id)
        {
            EGroup eGroup = db.EGroups.Find(id);
            if (eGroup == null)
            {
                return NotFound();
            }

            db.EGroups.Remove(eGroup);
            db.SaveChanges();

            return Ok(eGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EGroupExists(int id)
        {
            return db.EGroups.Count(e => e.group_id == id) > 0;
        }
    }
}