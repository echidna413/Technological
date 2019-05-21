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
    public class EDevicesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EDevices
        public IQueryable<EDevice> Get()
        {
            return db.EDevices;
        }

        // GET: api/EDevices/5
        [ResponseType(typeof(EDevice))]
        public IHttpActionResult Get(int id)
        {
            EDevice eDevice = db.EDevices.Find(id);
            if (eDevice == null)
            {
                return NotFound();
            }

            return Ok(eDevice);
        }

        // PUT: api/EDevices/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EDevice eDevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eDevice.device_id)
            {
                return BadRequest();
            }

            db.Entry(eDevice).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EDeviceExists(id))
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

        // POST: api/EDevices
        [ResponseType(typeof(EDevice))]
        public IHttpActionResult Post(EDevice eDevice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EDevices.Add(eDevice);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eDevice.device_id }, eDevice);
        }

        // DELETE: api/EDevices/5
        [ResponseType(typeof(EDevice))]
        public IHttpActionResult Delete(int id)
        {
            EDevice eDevice = db.EDevices.Find(id);
            if (eDevice == null)
            {
                return NotFound();
            }

            db.EDevices.Remove(eDevice);
            db.SaveChanges();

            return Ok(eDevice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EDeviceExists(int id)
        {
            return db.EDevices.Count(e => e.device_id == id) > 0;
        }
    }
}