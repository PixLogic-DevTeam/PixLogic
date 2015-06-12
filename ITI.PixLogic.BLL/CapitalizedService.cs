using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Packs;
using ITI.PixLogic.DAL.Contexts.Reservations;

namespace ITI.PixLogic.BLL
{
    public static class CapitalizedService
    {

        public static void DeleteItem(Item itemToDelete)
        {
            PacksEntity _packEntity = new PacksEntity( );
            ItemsEntity _itemEntity = new ItemsEntity( );
            ReservationsEntity _resEntity= new ReservationsEntity();

            var getItemPackRequest = from c in _packEntity.PackagedItems
                                     where c.UsedItem == itemToDelete.Id
                                     select c;

            var getItemReservation = from d in _resEntity.ReservationItems
                                     where d.Id == itemToDelete.Id
                                     select d;

            foreach(PackagedItem pi in getItemPackRequest)
            {
                _packEntity.PackagedItems.Remove( pi );
            }

            foreach (ReservationItem ri in getItemReservation)
            {
                _resEntity.ReservationItems.Remove( ri );
            }

            _itemEntity.Items.Remove( itemToDelete );

            _packEntity.SaveChanges( );
            _resEntity.SaveChanges( );
            _itemEntity.SaveChanges( );
                                     
        }
    }
}
