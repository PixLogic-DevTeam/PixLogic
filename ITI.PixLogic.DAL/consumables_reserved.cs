//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI.PixLogic.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class consumables_reserved
    {
        public long id { get; set; }
        public Nullable<System.DateTime> real_return_date { get; set; }
        public long reservation { get; set; }
        public long item { get; set; }
        public long initial_state { get; set; }
        public Nullable<long> return_state { get; set; }
    
        public virtual consumable consumable { get; set; }
        public virtual consumables_states consumables_states { get; set; }
        public virtual reservation reservation1 { get; set; }
        public virtual consumables_states consumables_states1 { get; set; }
    }
}
