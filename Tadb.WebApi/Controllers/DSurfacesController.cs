using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Tadb.DAL;

namespace Tadb.WebApi.Controllers
{
    public class DSurfacesController : ApiController
    {
        private MachineDbContext db = new MachineDbContext();

        // GET: api/DSurfaces
        public IQueryable<DSurface> Get()
        {
            return db.DSurfaces;
        }

        // GET: api/DSurfaces/5
        [ResponseType(typeof(DSurface))]
        public IHttpActionResult Get(int id)
        {
            DSurface dSurface = db.DSurfaces.Find(id);
            if (dSurface == null)
            {
                return NotFound();
            }

            return Ok(dSurface);
        }

        // PUT: api/DSurfaces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, DSurface dSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dSurface.surface_id)
            {
                return BadRequest();
            }

            db.Entry(dSurface).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DSurfaceExists(id))
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

        // POST: api/DSurfaces
        [ResponseType(typeof(DSurface))]
        public IHttpActionResult Post(DSurface dSurface)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DSurfaces.Add(dSurface);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dSurface.surface_id }, dSurface);
        }

        // DELETE: api/DSurfaces/5
        [ResponseType(typeof(DSurface))]
        public IHttpActionResult Delete(int id)
        {
            DSurface dSurface = db.DSurfaces.Find(id);
            if (dSurface == null)
            {
                return NotFound();
            }

            db.DSurfaces.Remove(dSurface);
            db.SaveChanges();

            return Ok(dSurface);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DSurfaceExists(int id)
        {
            return db.DSurfaces.Count(e => e.surface_id == id) > 0;
        }
    }
}