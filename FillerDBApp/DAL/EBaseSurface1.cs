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

    public class EBaseSurface1
    {
        [Key]
        public int id { get; set; }
        public double number_equipment { get; set; }
        public double number_base_surface { get; set; }
        public double code_surface { get; set; }
        public string com_1_tol { get; set; }
        public string com_2_tol { get; set; }
        public string com_3_tol { get; set; }
        public string com_4_tol { get; set; }
        public string com_5_tol { get; set; }
        public string com_6_tol { get; set; }
        public string com_7_tol { get; set; }
        public string com_8_tol { get; set; }

        public override bool Equals(object obj)
        {
            var surface = obj as EBaseSurface1;
            return surface != null &&
                   number_equipment == surface.number_equipment &&
                   number_base_surface == surface.number_base_surface &&
                   code_surface == surface.code_surface &&
                   com_1_tol == surface.com_1_tol &&
                   com_2_tol == surface.com_2_tol &&
                   com_3_tol == surface.com_3_tol &&
                   com_4_tol == surface.com_4_tol &&
                   com_5_tol == surface.com_5_tol &&
                   com_6_tol == surface.com_6_tol &&
                   com_7_tol == surface.com_7_tol &&
                   com_8_tol == surface.com_8_tol;
        }

        public override int GetHashCode()
        {
            var hashCode = 1077662215;
            hashCode = hashCode * -1521134295 + number_equipment.GetHashCode();
            hashCode = hashCode * -1521134295 + number_base_surface.GetHashCode();
            hashCode = hashCode * -1521134295 + code_surface.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_1_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_2_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_3_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_4_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_5_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_6_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_7_tol);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(com_8_tol);
            return hashCode;
        }
    }
}