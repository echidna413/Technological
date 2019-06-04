using System.Collections.Generic;
using System.Web.Mvc;
using RestSharp;
using Tadb.ServerStudio.Models.CatalogModels;

namespace Tadb.ServerStudio.Controllers
{
    public class CatalogController : Controller
    {
        public CatalogController()
        {
            this.Client = new RestClient("http://localhost:64449");
        }

        public RestClient Client { get; set; }

        public ActionResult SurfaceCatalogs()
        {
            var request = new RestRequest("api/SurfaceCatalogs");
            var data = Client.Get<List<SurfaceCatalogModel>>(request).Data;
            return View(data);
        }

        public ActionResult FixtureCatalogs()
        {
            var request = new RestRequest("api/FixtureCatalogs");
            var data = Client.Get<List<FixtureCatalogModel>>(request).Data;
            return View(data);
        }

        public ActionResult ProcessCatalogs()
        {
            var request = new RestRequest("api/ProcessCatalogs");
            var data = Client.Get<List<ProcessCatalogModel>>(request).Data;
            return View(data);
        }

        public ActionResult EquipmentCatalogs()
        {
            var request = new RestRequest("api/EquipmentCatalogs");
            var data = Client.Get<List<EquipmentCatalogModel>>(request).Data;
            return View(data);
        }
    }
}