//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ReservationItem
    {
        public long Id { get; set; }
        public long Reservation { get; set; }
        public long RealPlanning { get; set; }
        public long ReservedItem { get; set; }
        public long ReservedPack { get; set; }
        public long InitialState { get; set; }
        public long ReturnState { get; set; }
    }
}
