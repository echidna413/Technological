using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
{
    public class SurfaceCatalogsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/SurfaceCatalogs
        public IQueryable<SurfaceCatalog> Get()
        {
            return db.CodesSurfaces;
        }

        // GET: api/SurfaceCatalogs/5
        [ResponseType(typeof(SurfaceCatalog))]
        public IHttpActionResult Get(int id)
        {
            SurfaceCatalog surfaceCatalog = db.CodesSurfaces.Find(id);
            if (surfaceCatalog == null)
            {
                return NotFound();
            }

            return Ok(surfaceCatalog);
        }

        // POST: api/SurfaceCatalogs
        [ResponseType(typeof(SurfaceCatalog))]
        public IHttpActionResult Post(SurfaceCatalog surfaceCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CodesSurfaces.Add(surfaceCatalog);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SurfaceCatalogExists(surfaceCatalog.surface_code))
                {
                    return Conflict();
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = surfaceCatalog.surface_code }, surfaceCatalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SurfaceCatalogExists(int id)
        {
            return db.CodesSurfaces.Count(e => e.surface_code == id) > 0;
        }
    }
}