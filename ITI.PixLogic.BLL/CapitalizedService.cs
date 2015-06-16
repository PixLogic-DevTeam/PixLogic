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
        static ItemsEntity _itemEntity = new ItemsEntity( );
        static PacksEntity _packEntity = new PacksEntity( );
        static ReservationsEntity _resEntity = new ReservationsEntity( );

        /// <summary>
        /// Delete the given item in the database by removing all binded packs and reservations first
        /// </summary>
        /// <param name="itemToDelete"></param>
        public static void DeleteItem(Item itemToDelete)
        {


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

            _packEntity.Dispose( );
            _resEntity.Dispose( );
                                     
        }

        public static void AddItem(Item itemToAdd)
        {
            _itemEntity.Items.Add( itemToAdd );
        }

        /// <summary>
        /// Get all items in the database
        /// </summary>
        /// <returns>a list of item</returns>
        public static List<Item> GetAllItems()
        {
            using(_itemEntity)
            {
                //var nonConsumableReservableItems = _itemEntity.Items.Where() 
            }
            
            List < Item > listOfItem = _itemEntity.Items.Local.ToList( );          

            return listOfItem;
        }

        /// <summary>
        /// Just a helper to dispose the ItemsEntity
        /// </summary>
        public static void DisposeItemEntity()
        {
            _itemEntity.Dispose( );
        }
    }
}
