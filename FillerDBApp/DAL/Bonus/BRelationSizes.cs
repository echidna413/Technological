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
    
    public partial class BRelationSizes
    {
        public int relation_id { get; set; }
        public int surface_id { get; set; }
        public int relation_surface_id { get; set; }
        public double size { get; set; }
        public string tolerance { get; set; }
        public double max_deviation { get; set; }
        public double min_deviation { get; set; }
    
        public virtual BSurfaces BSurfaces { get; set; }
    }
}
