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
    
    public partial class BOM_BomNl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOM_BomNl()
        {
            this.BOM_BomTH = new HashSet<BOM_BomTH>();
        }
    
        public string MaHang { get; set; }
        public string DisplayName { get; set; }
        public string TenTiengTrung { get; set; }
        public string ChatLieu { get; set; }
        public string QuyCach { get; set; }
        public Nullable<int> Version { get; set; }
        public string UnitERP { get; set; }
        public string UnitSx { get; set; }
        public Nullable<double> TyLeChuyenDoi { get; set; }
        public Nullable<int> MaKeToanERP { get; set; }
        public Nullable<int> MaPLLonERP { get; set; }
        public Nullable<int> MaPLNhoERP { get; set; }
        public Nullable<int> MaPL4ERP { get; set; }
        public string MaPLLonSx { get; set; }
        public string MaPLNhoSx { get; set; }
        public string IDImg { get; set; }
        public string LinkImg { get; set; }
        public string UserName { get; set; }
    
        public virtual BOM_Unit BOM_Unit { get; set; }
        public virtual BOM_Unit BOM_Unit1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM_BomTH> BOM_BomTH { get; set; }
    }
}
