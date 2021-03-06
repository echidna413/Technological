﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RestSharp;
using ServerStudio.Models;

namespace ServerStudio.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            this.Client = new RestClient("http://localhost:64449");
        }

        public RestClient Client { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DetailReport()
        {
            return View();
        }

        public ActionResult TechBaseReport()
        {
            return View();
        }

        public ActionResult ChooseCompany()
        {
            var request = new RestRequest("api/Companies");
            var companies = Client.Get<List<CompanyModel>>(request).Data;
            return PartialView(companies);
        }

        public ActionResult GetRecords(int id_company)
        {
            var request = new RestRequest("api/Records");
            var records = Client.Get<List<RecordModel>>(request).Data;
            var required_data = records.Where(r => r.id_company == id_company).ToList();
            return PartialView(required_data);
        }

        public ActionResult GetDetails(int id_company)
        {
            var request = new RestRequest("api/DDescriptions");
            var datails = Client.Get<List<DetailModel>>(request).Data;
            var required_data = datails.Where(r => r.id_company == id_company).ToList();

            // нужна вьюшка, принимающая в качестве модели данных List<DetailModel>
            return PartialView(required_data);
        }

        public ActionResult RecordData(RecordModel record)
        {
            return PartialView(record);
        }
    }
}