//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.PixLogic.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation
    {
        public reservation()
        {
            this.capitalized_reserved = new HashSet<capitalized_reserved>();
            this.consumables_reserved = new HashSet<consumables_reserved>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> estimated_return_date { get; set; }
        public Nullable<bool> confirmation { get; set; }
        public Nullable<bool> taken_out { get; set; }
        public Nullable<int> account { get; set; }
    
        public virtual account account1 { get; set; }
        public virtual ICollection<capitalized_reserved> capitalized_reserved { get; set; }
        public virtual ICollection<consumables_reserved> consumables_reserved { get; set; }
    }
}
