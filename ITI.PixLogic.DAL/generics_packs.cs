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
    
    public partial class generics_packs
    {
        public generics_packs()
        {
            this.capitalized_categories_in_packs = new HashSet<capitalized_categories_in_packs>();
            this.consumables_categories_in_packs = new HashSet<consumables_categories_in_packs>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<capitalized_categories_in_packs> capitalized_categories_in_packs { get; set; }
        public virtual ICollection<consumables_categories_in_packs> consumables_categories_in_packs { get; set; }
    }
}
