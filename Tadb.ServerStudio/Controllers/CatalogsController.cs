using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Tadb.ServerStudio.Models.CatalogModels;

namespace Tadb.ServerStudio.Controllers
{
    [Authorize]
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
        public ActionResult SurfaceCatalog_Append()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SurfaceCatalog_Append(SurfaceCatalogModel catalogItem)
        {
            if (!ModelState.IsValid)
            {
                return View(catalogItem);
            }

            var request = new RestRequest("api/SurfaceCatalogs", Method.POST);
            request.AddJsonBody(catalogItem);

            var data = Client.Post(request);
            if (data.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("SurfaceCatalogs");
            }
            ModelState.AddModelError("", "Запись с таким номером модели элементарной поверхности уже существует");
            return View(catalogItem);
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
        [ValidateAntiForgeryToken]
        public ActionResult FixtureCatalog_Append(FixtureCatalogModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var request = new RestRequest("api/FixtureCatalogs", Method.POST);
            request.AddJsonBody(model);

            var data = Client.Post(request);
            if (data.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("FixtureCatalogs");
            }
            ModelState.AddModelError("", "Запись с таким номером приспособления уже существует");
            return View(model);
        }

        [HttpGet]
        public ActionResult ProcessCatalogs()
        {
            var request = new RestRequest("api/ProcessCatalogs");
            var data = Client.Get<List<ProcessCatalogModel>>(request).Data;
            return View(data);
        }

        [HttpGet]
        public ActionResult ProcessCatalog_Append()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProcessCatalog_Append(ProcessCatalogModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var request = new RestRequest("api/ProcessCatalogs", Method.POST);
            request.AddJsonBody(model);

            var data = Client.Post(request);
            return RedirectToAction("ProcessCatalogs");
        }

        [HttpGet]
        public ActionResult EquipmentCatalogs()
        {
            var request = new RestRequest("api/EquipmentCatalogs");
            var data = Client.Get<List<EquipmentCatalogModel>>(request).Data;
            return View(data);
        }

        [HttpGet]
        public ActionResult EquipmentCatalog_Append()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EquipmentCatalog_Append(EquipmentCatalogModel catalogItem, string returnUrl)
        {
            if (!ModelState.IsValid)
            {

                return View(catalogItem);
            }

            var request = new RestRequest("api/EquipmentCatalogs", Method.POST);
            request.AddJsonBody(catalogItem);

            var data = Client.Post(request);

            if (data.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("EquipmentCatalogs");
            }
            ModelState.AddModelError("", "Запись с таким наименованием модели уже существует");
            return View(catalogItem);
        }

    }
}