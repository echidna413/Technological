using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Role
    {
        [Key]
        public int id_role { get; set; }
        public string name { get; set; }
        public bool canEnter { get; set; }
        public bool canGetData { get; set; }
        public bool canEdit { get; set; }
        public bool canEditCatalog { get; set; }
    }
}
