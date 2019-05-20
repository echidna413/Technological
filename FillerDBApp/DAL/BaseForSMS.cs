namespace DAL
{
    using System.ComponentModel.DataAnnotations;

    public class BaseForSMS
    {
        [Key]
        public int id { get; set; }
        public int process_surface_id { get; set; }
        public double number_base_schema { get; set; }
        public int base_id { get; set; }
        public double number_base { get; set; }
        public int base_surface_id { get; set; }
        public double number_variant { get; set; }
        public double number_step { get; set; }
        public bool reverse { get; set; }
        public double number_base_surface { get; set; }

        public override bool Equals(object obj)
        {
            var sMS = obj as BaseForSMS;
            return sMS != null &&
                   process_surface_id == sMS.process_surface_id &&
                   number_base_schema == sMS.number_base_schema &&
                   base_id == sMS.base_id &&
                   number_base == sMS.number_base &&
                   base_surface_id == sMS.base_surface_id &&
                   number_variant == sMS.number_variant &&
                   number_step == sMS.number_step &&
                   reverse == sMS.reverse &&
                   number_base_surface == sMS.number_base_surface;
        }

        public override int GetHashCode()
        {
            var hashCode = -233511918;
            hashCode = hashCode * -1521134295 + process_surface_id.GetHashCode();
            hashCode = hashCode * -1521134295 + number_base_schema.GetHashCode();
            hashCode = hashCode * -1521134295 + base_id.GetHashCode();
            hashCode = hashCode * -1521134295 + number_base.GetHashCode();
            hashCode = hashCode * -1521134295 + base_surface_id.GetHashCode();
            hashCode = hashCode * -1521134295 + number_variant.GetHashCode();
            hashCode = hashCode * -1521134295 + number_step.GetHashCode();
            hashCode = hashCode * -1521134295 + reverse.GetHashCode();
            hashCode = hashCode * -1521134295 + number_base_surface.GetHashCode();
            return hashCode;
        }
    }
}
