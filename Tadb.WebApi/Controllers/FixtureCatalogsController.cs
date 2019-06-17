using System.Data.Entity.Infrastructure;
using System.Linq;
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
                    return BadRequest(ModelState);
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fixtureCatalog.fixture_code }, fixtureCatalog);
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