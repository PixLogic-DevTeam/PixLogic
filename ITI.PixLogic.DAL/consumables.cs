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
    
    public partial class consumables
    {
        public long id { get; set; }
        public string product_reference { get; set; }
        public string description { get; set; }
        public long brand { get; set; }
        public Nullable<long> reservation_cost { get; set; }
        public long sub_category { get; set; }
        public long invoice { get; set; }
        public long current_state { get; set; }
    
        public virtual brands brands { get; set; }
        public virtual states states { get; set; }
        public virtual consumables_sub_categories consumables_sub_categories { get; set; }
    }
}
