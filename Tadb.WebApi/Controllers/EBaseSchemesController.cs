using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
{
    public class EBaseSchemesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EBaseSchemes
        public IQueryable<EBaseScheme> Get()
        {
            return db.EBaseSchemes;
        }

        // GET: api/EBaseSchemes/5
        [ResponseType(typeof(EBaseScheme))]
        public IHttpActionResult Get(int id)
        {
            EBaseScheme eBaseScheme = db.EBaseSchemes.Find(id);
            if (eBaseScheme == null)
            {
                return NotFound();
            }

            return Ok(eBaseScheme);
        }

        // PUT: api/EBaseSchemes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EBaseScheme eBaseScheme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eBaseScheme.base_scheme_id)
            {
                return BadRequest();
            }

            db.Entry(eBaseScheme).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EBaseSchemeExists(id))
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

        // POST: api/EBaseSchemes
        [ResponseType(typeof(EBaseScheme))]
        public IHttpActionResult Post(EBaseScheme eBaseScheme)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EBaseSchemes.Add(eBaseScheme);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eBaseScheme.base_scheme_id }, eBaseScheme);
        }

        // DELETE: api/EBaseSchemes/5
        [ResponseType(typeof(EBaseScheme))]
        public IHttpActionResult Delete(int id)
        {
            EBaseScheme eBaseScheme = db.EBaseSchemes.Find(id);
            if (eBaseScheme == null)
            {
                return NotFound();
            }

            db.EBaseSchemes.Remove(eBaseScheme);
            db.SaveChanges();

            return Ok(eBaseScheme);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EBaseSchemeExists(int id)
        {
            return db.EBaseSchemes.Count(e => e.base_scheme_id == id) > 0;
        }
    }
}