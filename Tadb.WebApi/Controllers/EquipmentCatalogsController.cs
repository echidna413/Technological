using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
{
    public class EquipmentCatalogsController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/EquipmentCatalogs
        public IQueryable<EquipmentCatalog> Get()
        {
            return db.EquipmentCatalogs;
        }

        // GET: api/EquipmentCatalogs/5
        [ResponseType(typeof(EquipmentCatalog))]
        public IHttpActionResult Get(int id)
        {
            EquipmentCatalog equipmentCatalog = db.EquipmentCatalogs.Find(id);
            if (equipmentCatalog == null)
            {
                return NotFound();
            }

            return Ok(equipmentCatalog);
        }

        // POST: api/EquipmentCatalogs
        [ResponseType(typeof(EquipmentCatalog))]
        public IHttpActionResult Post(EquipmentCatalog equipmentCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EquipmentCatalogs.Add(equipmentCatalog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = equipmentCatalog.equipment_code }, equipmentCatalog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EquipmentCatalogExists(int id)
        {
            return db.EquipmentCatalogs.Count(e => e.equipment_code == id) > 0;
        }
    }
}