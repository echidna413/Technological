using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DDescription
    {
        [ForeignKey("id_employee")]
        public Employee Employee { get; set; }

        [ForeignKey("id_company")]
        public Company Company { get; set; }

        [Key]
        public int detail_id { get; set; }
        public int id_employee { get; set; }
        public int id_company { get; set; }
        public string code_detail { get; set; }
        public string name_detail { get; set; }
        public string mark_material { get; set; }
        public double size_production { get; set; }
        public double size_transmission { get; set; }
        public double mass_detail { get; set; }
        public double length { get; set; }
        public bool central_hole { get; set; }
        public string description { get; set; }
    }
}
