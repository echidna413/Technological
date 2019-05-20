using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SurfaceCatalog
    {
        [Key]
        public int surface_code { get; set; }
        public string description { get; set; }

        public override bool Equals(object obj)
        {
            var catalog = obj as SurfaceCatalog;
            return catalog != null &&
                   description == catalog.description;
        }

        public override int GetHashCode()
        {
            return -1150852911 + EqualityComparer<string>.Default.GetHashCode(description);
        }
    }
}
