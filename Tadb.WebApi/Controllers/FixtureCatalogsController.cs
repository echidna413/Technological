using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
{
    public class FixtureCatalogsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        public IQueryable<FixtureCatalog> Get()
        {
            return db.FixtureCatalogs;
        }

        [ResponseType(typeof(FixtureCatalog))]
        public IHttpActionResult Get(int id)
        {
            FixtureCatalog fixtureCatalog = db.FixtureCatalogs.Find(id);
            if (fixtureCatalog == null)
            {
                return NotFound();
            }

            return Ok(fixtureCatalog);
        }

        // PUT: api/SurfaceCatalogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, FixtureCatalog fixtureCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fixtureCatalog.fixture_code)
            {
                return BadRequest();
            }

            db.Entry(fixtureCatalog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FixtureCatalogExists(id))
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

        // POST: api/SurfaceCatalogs
        [ResponseType(typeof(FixtureCatalog))]
        public IHttpActionResult Post(FixtureCatalog fixtureCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FixtureCatalogs.Add(fixtureCatalog);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (FixtureCatalogExists(fixtureCatalog.fixture_code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fixtureCatalog.fixture_code }, fixtureCatalog);
        }

        // DELETE: api/SurfaceCatalogs/5
        [ResponseType(typeof(FixtureCatalog))]
        public IHttpActionResult Delete(int id)
        {
            FixtureCatalog fixtureCatalog = db.FixtureCatalogs.Find(id);
            if (fixtureCatalog == null)
            {
                return NotFound();
            }

            db.FixtureCatalogs.Remove(fixtureCatalog);
            db.SaveChanges();

            return Ok(fixtureCatalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FixtureCatalogExists(int id)
        {
            return db.FixtureCatalogs.Count(e => e.fixture_code == id) > 0;
        }
    }
}