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
    
    public partial class capitalized_main_categories
    {
        public capitalized_main_categories()
        {
            this.capitalized_sub_categories = new HashSet<capitalized_sub_categories>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<capitalized_sub_categories> capitalized_sub_categories { get; set; }
    }
}
