using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Status
    {
        public Status()
        {
            this.Records = new HashSet<Record>();
        }

        [Key]
        public int id_status { get; set; }

        public string name { get; set; }

        public virtual ICollection<Record> Records { get; set; }

        public override bool Equals(object obj)
        {
            var status = obj as Status;
            return status != null &&
                   name == status.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
