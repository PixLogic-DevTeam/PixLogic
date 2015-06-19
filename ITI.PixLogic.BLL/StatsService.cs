using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ITI.PixLogic.DAL.Contexts.Reservations;
using ITI.PixLogic.DAL.Contexts.Items;

namespace ITI.PixLogic.BLL
{
    public static class StatsService
    {
        static ReservationsEntity _resEntity = new ReservationsEntity();
        static ItemsEntity _itemEntity = new ItemsEntity( );

        public static  int GetNumberOfItems()
        {
            _itemEntity.Items.Load( );
            return _itemEntity.Items.Count( );
        }

        public static int GetNumberOfReservationEvent()
        {
            _resEntity.ReservationEvents.Load( );
            return _resEntity.ReservationEvents.Count( );
        }

        public static void GetNumberofItemBySubCategory()
        {

        }
    }
}
