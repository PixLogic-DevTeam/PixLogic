﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.PixLogic.DAL.Contexts.Packs
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PacksEntity : DbContext
    {
        public PacksEntity()
            : base("name=PacksEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PackagedItemCategory> PackagedItemCategories { get; set; }
        public virtual DbSet<PackagedItem> PackagedItems { get; set; }
        public virtual DbSet<Pack> Packs { get; set; }
    }
}
