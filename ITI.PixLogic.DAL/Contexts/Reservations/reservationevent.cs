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
    
    public partial class ReservationEvent
    {
        public long Id { get; set; }
        public bool Confirmed { get; set; }
        public long InitialPlanning { get; set; }
        public long Reserver { get; set; }
    }
}
