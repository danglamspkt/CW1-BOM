﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gla43158_QLSXCW1Entities : DbContext
    {
        public gla43158_QLSXCW1Entities()
            : base("name=gla43158_QLSXCW1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOM_MaPL4ERP> BOM_MaPL4ERP { get; set; }
        public virtual DbSet<BOM_MaPLLonERP> BOM_MaPLLonERP { get; set; }
        public virtual DbSet<BOM_MaPLNhoERP> BOM_MaPLNhoERP { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<BOM_Image> BOM_Image { get; set; }
        public virtual DbSet<BOM_MaPLLonSx> BOM_MaPLLonSx { get; set; }
        public virtual DbSet<BOM_MaPLNhoSx> BOM_MaPLNhoSx { get; set; }
        public virtual DbSet<Dev_Lang> Dev_Lang { get; set; }
        public virtual DbSet<BOM_BomBtp> BOM_BomBtp { get; set; }
        public virtual DbSet<BOM_BomTp> BOM_BomTp { get; set; }
        public virtual DbSet<BOM_BomTH> BOM_BomTH { get; set; }
        public virtual DbSet<BOM_Unit> BOM_Unit { get; set; }
        public virtual DbSet<BOM_BomNl> BOM_BomNl { get; set; }
        public virtual DbSet<BOM_MaKeToanERP> BOM_MaKeToanERP { get; set; }
    }
}
