﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.PixLogic.DAL.Contexts.Reservations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ReservationsEntity : DbContext
    {
        public ReservationsEntity()
            : base("name=ReservationsEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ReservationEvent> ReservationEvents { get; set; }
        public virtual DbSet<ReservationItem> ReservationItems { get; set; }
        public virtual DbSet<ReservationPlanning> ReservationPlannings { get; set; }
        public virtual DbSet<reservationexport> reservationexports { get; set; }
    }
}
