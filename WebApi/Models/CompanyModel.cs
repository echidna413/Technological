using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class CompanyModel
    {
        public int id_company { get; set; }

        public int responsible_employee { get; set; }

        public int numberof_branch { get; set; }

        public string name { get; set; }

        public string address { get; set; }
    }
}