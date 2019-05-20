using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class FixtureCatalog
    {
        [Key]
        public int fixture_code { get; set; }
        public string fixture_value { get; set; }
        public string description { get; set; }

        public override bool Equals(object obj)
        {
            var catalog = obj as FixtureCatalog;
            return catalog != null &&
                   fixture_value == catalog.fixture_value &&
                   description == catalog.description;
        }

        public override int GetHashCode()
        {
            var hashCode = -1045668907;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fixture_value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            return hashCode;
        }
    }
}
