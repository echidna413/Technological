using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
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

        // PUT: api/EquipmentCatalogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EquipmentCatalog equipmentCatalog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != equipmentCatalog.equipment_code)
            {
                return BadRequest();
            }

            db.Entry(equipmentCatalog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipmentCatalogExists(id))
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

        // DELETE: api/EquipmentCatalogs/5
        [ResponseType(typeof(EquipmentCatalog))]
        public IHttpActionResult Delete(int id)
        {
            EquipmentCatalog equipmentCatalog = db.EquipmentCatalogs.Find(id);
            if (equipmentCatalog == null)
            {
                return NotFound();
            }

            db.EquipmentCatalogs.Remove(equipmentCatalog);
            db.SaveChanges();

            return Ok(equipmentCatalog);
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