using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Tadb.ServerStudio.Models;

namespace Tadb.ServerStudio.Controllers
{
    internal enum Statuses : int
    {
        ReadyForCheck = 1,
        Accepted = 2,
        Declined = 3,
        Outdated = 4,
    }

    [Authorize]
    public class HomeController : Controller
    {
        public HomeController()
        {
            this.Client = new RestClient("http://localhost:64449");
        }

        public RestClient Client { get; set; }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExpertChecking()
        {
            var request = new RestRequest("api/Records");
            var data = Client.Get<List<ExpertModel>>(request).Data;
            var required_data = data.Where(x => x.id_status == (int)Statuses.ReadyForCheck).ToList();
            return View(required_data);
        }

        public ActionResult ApproveRecord(int id)
        {
            var fetchRequest = new RestRequest($"api/Records/{id}");
            var recordData = Client.Get<ExpertModel>(fetchRequest).Data;
            recordData.id_status = (int)Statuses.Accepted;

            var updateRequest = new RestRequest($"api/Records/{id}", Method.PUT);
            updateRequest.AddJsonBody(recordData);

            var data = Client.Put(updateRequest);
            //if (data.StatusCode == HttpStatusCode.OK)
            //{
            //    return Json(true);
            //}

            return RedirectToAction("ExpertChecking");
        }

        public ActionResult DeclineRecord(int id)
        {
            var fetchRequest = new RestRequest($"api/Records/{id}");
            var recordData = Client.Get<ExpertModel>(fetchRequest).Data;
            recordData.id_status = (int)Statuses.Declined;

            var updateRequest = new RestRequest($"api/Records/{id}", Method.PUT);
            updateRequest.AddJsonBody(recordData);

            var data = Client.Put(updateRequest);
            return RedirectToAction("ExpertChecking");
        }

        public ActionResult DetailReport()
        {
            //var request = new RestRequest("api/DDescriptions");
            //var details = Client.Get<List<DetailModel>>(request).Data;
            //var required_data = details.ToList();
            return View();
        }

        public ActionResult TechBaseReport()
        {
            //var request = new RestRequest("api/Records");
            //var records = Client.Get<List<RecordModel>>(request).Data;
            //var required_data = records.ToList();
            return View();
        }

        //public ActionResult ChooseCompany()
        //{
        //    var request = new RestRequest("api/Companies");
        //    var companies = Client.Get<List<CompanyModel>>(request).Data;
        //    return PartialView("_ChooseCompany", companies);
        //}

        //public ActionResult GetRecords(int id_company)
        //{
        //    var request = new RestRequest("api/Records");
        //    var records = Client.Get<List<RecordModel>>(request).Data;
        //    //var required_data = records.Where(r => r.id_company == id_company).ToList();
        //    return PartialView("_GetRecords");
        //}

        //public ActionResult GetDetails(int id_company)
        //{
        //    var request = new RestRequest("api/DDescriptions");
        //    var details = Client.Get<List<DetailModel>>(request).Data;
        //    //var required_data = details.Where(r => r.id_company == id_company).ToList();
        //    return PartialView("_GetDetails", required_data);
        //}

        public ActionResult RecordData(RecordModel record)
        {
            return PartialView("_RecordData", record);
        }

        public ActionResult DetailData(DetailModel detail)
        {
            return PartialView("_DetailData", detail);
        }
    }
}