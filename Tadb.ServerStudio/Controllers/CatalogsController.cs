using System.Collections.Generic;
using System.Web.Mvc;
using RestSharp;
using Tadb.ServerStudio.Models.CatalogModels;

namespace Tadb.ServerStudio.Controllers
{
    public class CatalogsController : Controller
    {
        public CatalogsController()
        {
            this.Client = new RestClient("http://localhost:64449");
        }

        public RestClient Client { get; set; }

        [HttpGet]
        public ActionResult SurfaceCatalogs()
        {
            var request = new RestRequest("api/SurfaceCatalogs");
            var data = Client.Get<List<SurfaceCatalogModel>>(request).Data;
            return View(data);
        }

        [HttpGet]
        public ActionResult FixtureCatalogs()
        {
            var request = new RestRequest("api/FixtureCatalogs");
            var data = Client.Get<List<FixtureCatalogModel>>(request).Data;
            return View(data);
        }


        [HttpGet]
        public ActionResult FixtureCatalog_Append()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FixtureCatalog_Append(FixtureCatalogModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(false);
            }

            var request = new RestRequest("api/FixtureCatalogs", Method.POST);
            request.AddJsonBody(model);

            var data = Client.Post(request);
            return RedirectToAction("FixtureCatalogs");
        }

        [HttpGet]
        public ActionResult ProcessCatalogs()
        {
            var request = new RestRequest("api/ProcessCatalogs");
            var data = Client.Get<List<ProcessCatalogModel>>(request).Data;
            return View(data);
        }

        [HttpGet]
        public ActionResult EquipmentCatalogs()
        {
            var request = new RestRequest("api/EquipmentCatalogs");
            var data = Client.Get<List<EquipmentCatalogModel>>(request).Data;
            return View(data);
        }
    }
}