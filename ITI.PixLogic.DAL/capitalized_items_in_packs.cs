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
    
    public partial class capitalized_items_in_packs
    {
        public int id { get; set; }
        public Nullable<int> item { get; set; }
        public Nullable<int> pack { get; set; }
    
        public virtual capitalized capitalized { get; set; }
        public virtual specifics_packs specifics_packs { get; set; }
    }
}
