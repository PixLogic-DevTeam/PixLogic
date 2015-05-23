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
    
    public partial class invoices
    {
        public invoices()
        {
            this.capitalized = new HashSet<capitalized>();
            this.consumables = new HashSet<consumables>();
        }
    
        public long id { get; set; }
        public System.DateTime purchase_date { get; set; }
        public decimal purchase_cost { get; set; }
        public int annual_depreciation_rate { get; set; }
        public long phase_number { get; set; }
        public string description { get; set; }
        public long company { get; set; }
    
        public virtual ICollection<capitalized> capitalized { get; set; }
        public virtual companies companies { get; set; }
        public virtual ICollection<consumables> consumables { get; set; }
    }
}
