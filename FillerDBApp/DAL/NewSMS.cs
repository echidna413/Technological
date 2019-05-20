//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class NewSMS
    {
        [Key]
        public int id { get; set; }
        public int detail_id { get; set; }
        public int surface_id { get; set; }
        public double number_variant { get; set; }
        public double number_step { get; set; }
        public string code_surface { get; set; }
        public string finish { get; set; }
        public double tolerance { get; set; }
        public bool symmetry { get; set; }
        public double zero_point_x { get; set; }
        public double zero_point_y { get; set; }
        public double zero_point_z { get; set; }
        public double surface_size_1 { get; set; }
        public double surface_size_2 { get; set; }
        public double surface_size_3 { get; set; }
        public double surface_size_4 { get; set; }
        public double surface_size_5 { get; set; }
        public double surface_size_6 { get; set; }
        public double surface_size_7 { get; set; }
        public double surface_size_8 { get; set; }
        public double ra { get; set; }
        public double rmax { get; set; }
        public double s { get; set; }
        public double tp { get; set; }
        public double hrc { get; set; }
        public double depth { get; set; }
        public double base_code { get; set; }
        public double orientation { get; set; }
        public int device_id { get; set; }
        public double number_machining_step { get; set; }
        public bool not_base { get; set; }
        public double number_surface { get; set; }

        public override bool Equals(object obj)
        {
            var sMS = obj as NewSMS;
            return sMS != null &&
                   detail_id == sMS.detail_id &&
                   surface_id == sMS.surface_id &&
                   number_variant == sMS.number_variant &&
                   number_step == sMS.number_step &&
                   code_surface == sMS.code_surface &&
                   finish == sMS.finish &&
                   tolerance == sMS.tolerance &&
                   symmetry == sMS.symmetry &&
                   zero_point_x == sMS.zero_point_x &&
                   zero_point_y == sMS.zero_point_y &&
                   zero_point_z == sMS.zero_point_z &&
                   surface_size_1 == sMS.surface_size_1 &&
                   surface_size_2 == sMS.surface_size_2 &&
                   surface_size_3 == sMS.surface_size_3 &&
                   surface_size_4 == sMS.surface_size_4 &&
                   surface_size_5 == sMS.surface_size_5 &&
                   surface_size_6 == sMS.surface_size_6 &&
                   surface_size_7 == sMS.surface_size_7 &&
                   surface_size_8 == sMS.surface_size_8 &&
                   ra == sMS.ra &&
                   rmax == sMS.rmax &&
                   s == sMS.s &&
                   tp == sMS.tp &&
                   hrc == sMS.hrc &&
                   depth == sMS.depth &&
                   base_code == sMS.base_code &&
                   orientation == sMS.orientation &&
                   device_id == sMS.device_id &&
                   number_machining_step == sMS.number_machining_step &&
                   not_base == sMS.not_base &&
                   number_surface == sMS.number_surface;
        }

        public override int GetHashCode()
        {
            var hashCode = -529367970;
            hashCode = hashCode * -1521134295 + detail_id.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_id.GetHashCode();
            hashCode = hashCode * -1521134295 + number_variant.GetHashCode();
            hashCode = hashCode * -1521134295 + number_step.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(code_surface);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(finish);
            hashCode = hashCode * -1521134295 + tolerance.GetHashCode();
            hashCode = hashCode * -1521134295 + symmetry.GetHashCode();
            hashCode = hashCode * -1521134295 + zero_point_x.GetHashCode();
            hashCode = hashCode * -1521134295 + zero_point_y.GetHashCode();
            hashCode = hashCode * -1521134295 + zero_point_z.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_1.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_2.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_3.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_4.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_5.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_6.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_7.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_size_8.GetHashCode();
            hashCode = hashCode * -1521134295 + ra.GetHashCode();
            hashCode = hashCode * -1521134295 + rmax.GetHashCode();
            hashCode = hashCode * -1521134295 + s.GetHashCode();
            hashCode = hashCode * -1521134295 + tp.GetHashCode();
            hashCode = hashCode * -1521134295 + hrc.GetHashCode();
            hashCode = hashCode * -1521134295 + depth.GetHashCode();
            hashCode = hashCode * -1521134295 + base_code.GetHashCode();
            hashCode = hashCode * -1521134295 + orientation.GetHashCode();
            hashCode = hashCode * -1521134295 + device_id.GetHashCode();
            hashCode = hashCode * -1521134295 + number_machining_step.GetHashCode();
            hashCode = hashCode * -1521134295 + not_base.GetHashCode();
            hashCode = hashCode * -1521134295 + number_surface.GetHashCode();
            return hashCode;
        }
    }
}
