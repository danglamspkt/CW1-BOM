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
    
    public partial class BOM_BomTH
    {
        public int Id { get; set; }
        public string MaTp { get; set; }
        public string MaBtp1 { get; set; }
        public string MaBtp2 { get; set; }
        public string MaBtp3 { get; set; }
        public string MaMuaHang { get; set; }
        public Nullable<double> TiLeNlBtp { get; set; }
        public Nullable<int> HeSo { get; set; }
        public string GhiChu { get; set; }
        public string ThiTruong { get; set; }
    
        public virtual BOM_BomBtp BOM_BomBtp { get; set; }
        public virtual BOM_BomBtp BOM_BomBtp1 { get; set; }
        public virtual BOM_BomBtp BOM_BomBtp2 { get; set; }
        public virtual BOM_BomTp BOM_BomTp { get; set; }
        public virtual BOM_BomNl BOM_BomNl { get; set; }
    }
}
