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
    
    public partial class CodeSurfaces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeSurfaces()
        {
            this.CodeSurfaceSizes = new HashSet<CodeSurfaceSizes>();
        }
    
        public int code_surface_id { get; set; }
        public string code_surface { get; set; }
        public string description { get; set; }
        public string view_2d { get; set; }
        public string view_3d_small { get; set; }
        public string view_3d_big { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodeSurfaceSizes> CodeSurfaceSizes { get; set; }
    }
}
