//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BomRnD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOM_Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOM_Unit()
        {
            this.BOM_BomBtp = new HashSet<BOM_BomBtp>();
            this.BOM_BomBtp1 = new HashSet<BOM_BomBtp>();
            this.BOM_BomNl = new HashSet<BOM_BomNl>();
            this.BOM_BomNl1 = new HashSet<BOM_BomNl>();
            this.BOM_BomTp = new HashSet<BOM_BomTp>();
            this.BOM_BomTp1 = new HashSet<BOM_BomTp>();
        }
    
        public string Unit { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomBtp> BOM_BomBtp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomBtp> BOM_BomBtp1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomNl> BOM_BomNl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomNl> BOM_BomNl1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomTp> BOM_BomTp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomTp> BOM_BomTp1 { get; set; }
    }
}
