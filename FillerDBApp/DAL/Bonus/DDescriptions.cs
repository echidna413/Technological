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
    
    public partial class DDescriptions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DDescriptions()
        {
            this.DSurfaces = new HashSet<DSurfaces>();
        }
    
        public int detail_id { get; set; }
        public string code_detail { get; set; }
        public string name_detail { get; set; }
        public string mark_material { get; set; }
        public double size_production { get; set; }
        public double size_transmission { get; set; }
        public double mass_detail { get; set; }
        public double length { get; set; }
        public bool central_hole { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSurfaces> DSurfaces { get; set; }
    }
}
