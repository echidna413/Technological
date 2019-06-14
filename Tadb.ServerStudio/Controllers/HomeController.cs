using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Tadb.ServerStudio.Models;

namespace Tadb.ServerStudio.Controllers
{
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

        public ActionResult DetailReport()
        {
            var request = new RestRequest("api/DDescriptions");
            var details = Client.Get<List<DetailModel>>(request).Data;
            var required_data = details.ToList();
            return View();
        }

        public ActionResult TechBaseReport()
        {
            var request = new RestRequest("api/Records");
            var records = Client.Get<List<RecordModel>>(request).Data;
            var required_data = records.ToList();
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