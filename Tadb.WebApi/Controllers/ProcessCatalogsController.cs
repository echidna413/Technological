using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
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