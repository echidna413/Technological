using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tadb.ServerStudio.Models
{
    public class RecordDto
    {
        public string Employee { get; set; }

        public string Status { get; set; }

        public int equipment_code { get; set; }

        public int fixture_code { get; set; }

        public int process_code { get; set; }

        public int surface_code { get; set; }
    }
}