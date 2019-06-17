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
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
{
    public class OperationsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/Operations
        public IQueryable<Operation> Get()
        {
            return db.Operations;
        }

        // GET: api/Operations/5
        [ResponseType(typeof(Operation))]
        public IHttpActionResult Get(int id)
        {
            Operation operation = db.Operations.Find(id);
            if (operation == null)
            {
                return NotFound();
            }

            return Ok(operation);
        }

        // PUT: api/Operations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Operation operation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != operation.id)
            {
                return BadRequest();
            }

            db.Entry(operation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperationExists(id))
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

        // POST: api/Operations
        [ResponseType(typeof(Operation))]
        public IHttpActionResult Post(Operation operation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Operations.Add(operation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = operation.id }, operation);
        }

        // DELETE: api/Operations/5
        [ResponseType(typeof(Operation))]
        public IHttpActionResult Delete(int id)
        {
            Operation operation = db.Operations.Find(id);
            if (operation == null)
            {
                return NotFound();
            }

            db.Operations.Remove(operation);
            db.SaveChanges();

            return Ok(operation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OperationExists(int id)
        {
            return db.Operations.Count(e => e.id == id) > 0;
        }
    }
}