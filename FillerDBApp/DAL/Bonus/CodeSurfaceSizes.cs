//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Bonus
{
    using System;
    using System.Collections.Generic;
    
    public partial class CodeSurfaceSizes
    {
        public int id { get; set; }
        public int code_surface_id { get; set; }
        public double size_number { get; set; }
        public double size_description_id { get; set; }
        public bool requremeint { get; set; }
    
        public virtual CodeSurfaces CodeSurfaces { get; set; }
    }
}
