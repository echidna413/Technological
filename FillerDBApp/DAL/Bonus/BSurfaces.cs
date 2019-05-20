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
    
    public partial class BSurfaces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSurfaces()
        {
            this.BGeometries = new HashSet<BGeometries>();
            this.BLocations = new HashSet<BLocations>();
            this.BRelationSizes = new HashSet<BRelationSizes>();
            this.BSizeSurfaces = new HashSet<BSizeSurfaces>();
        }
    
        public int surface_id { get; set; }
        public int billet_id { get; set; }
        public double number_surface { get; set; }
        public int code_surface_id { get; set; }
        public double zero_point_X { get; set; }
        public double zero_point_Y { get; set; }
        public double zero_point_Z { get; set; }
        public double ra { get; set; }
        public double rnax { get; set; }
        public double s { get; set; }
    
        public virtual BDescriptions BDescriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BGeometries> BGeometries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLocations> BLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRelationSizes> BRelationSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSizeSurfaces> BSizeSurfaces { get; set; }
    }
}
