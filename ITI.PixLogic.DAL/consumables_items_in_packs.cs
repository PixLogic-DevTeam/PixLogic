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
    
    public partial class consumables_items_in_packs
    {
        public long id { get; set; }
        public long item { get; set; }
        public long pack { get; set; }
    
        public virtual packs packs { get; set; }
    }
}
