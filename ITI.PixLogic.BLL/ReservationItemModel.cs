using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.PixLogic.DAL.Contexts.Reservations;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Packs;

namespace ITI.PixLogic.BLL
{
    class ReservationItemModel
    {
        public ReservationEvent res_Event { get; set; }

        public ReservationPlanning res_Planning { get; set; }

        public ReservationItem res_Item { get; set; }

        public ItemState item_State { get; set; }

        public Item item { get; set; }

        public Pack pack { get; set; }

       
        
        public Int64 Id 
        { 
            get{return res_Item.Id;}
            set { res_Item.Id = value; }
        }

        public Int64 Reservation
        {
            get { return res_Event.Id; }
            set { res_Event.Id = value; }
        }

        public Int64 RealPlanning
        {
            get { return res_Planning.Id; }
            set { res_Planning.Id = value; }
        }

        public string ReservedItem
        {
            get { return item.Reference; }
            set { item.Reference = value; }
        }

        public string ReservedPack
        {
            get { return pack.Name; }
            set { pack.Name = value; }
        }

        public string InitialState
        {
            get { return item_State.Name; }
            set { item_State.Name = value; }
        }

        public string ReturnState
        {
            get { return item_State.Name; }
            set { item_State.Name = value; }
        }
    }
}
