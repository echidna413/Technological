﻿using System;
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
    public class ProcessCatalogsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/ProcessCatalogs
        public IQueryable<ProcessCatalog> Get()
        {
            return db.ProcessCatalogs;
        }

        // GET: api/ProcessCatalogs/5
        [ResponseType(typeof(ProcessCatalog))]
        public IHttpActionResult Get(int id)
        {
            ProcessCatalog processCatalog = db.ProcessCatalogs.Find(id);
            if (processCatalog == null)
            {
                return NotFound();
            }

            return Ok(processCatalog);
        }

        // PUT: api/ProcessCatalogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, ProcessCatalog processCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != processCatalog.process_code)
            {
                return BadRequest();
            }

            db.Entry(processCatalog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessCatalogExists(id))
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

        // POST: api/ProcessCatalogs
        [ResponseType(typeof(ProcessCatalog))]
        public IHttpActionResult Post(ProcessCatalog processCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProcessCatalogs.Add(processCatalog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = processCatalog.process_code }, processCatalog);
        }

        // DELETE: api/ProcessCatalogs/5
        [ResponseType(typeof(ProcessCatalog))]
        public IHttpActionResult Delete(int id)
        {
            ProcessCatalog processCatalog = db.ProcessCatalogs.Find(id);
            if (processCatalog == null)
            {
                return NotFound();
            }

            db.ProcessCatalogs.Remove(processCatalog);
            db.SaveChanges();

            return Ok(processCatalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProcessCatalogExists(int id)
        {
            return db.ProcessCatalogs.Count(e => e.process_code == id) > 0;
        }
    }
}