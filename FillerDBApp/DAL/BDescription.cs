using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class BDescription
    {
        [ForeignKey("id_employee")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("id_company")]
        public virtual Company Company { get; set; }

        [Key]
        public int billet_id { get; set; }

        public int id_employee { get; set; }

        public int id_company { get; set; }

        public int detail_id { get; set; }

        public int code_type_billet_id { get; set; }

        public double mass_billet { get; set; }

        public string description { get; set; }
    }
}