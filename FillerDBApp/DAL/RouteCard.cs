using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RouteCard
    {

        [ForeignKey("id_company")]
        public Company Company { get; set; }

        [ForeignKey("id_employee")]
        public Employee Employee { get; set; }

        [Key]
        public int? id_card { get; set; }
        public int? id_company { get; set; }
        public int? id_employee { get; set; }
    }
}
