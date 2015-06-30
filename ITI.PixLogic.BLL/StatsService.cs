using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ITI.PixLogic.DAL.Contexts.Reservations;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Packs;
using ITI.PixLogic.DAL.Contexts.Invoices;
using ITI.PixLogic.DAL.Contexts.Accounts;

namespace ITI.PixLogic.BLL
{
    public static class StatsService
    {
        static ReservationsEntity _resEntity = new ReservationsEntity( );
        static ItemsEntity _itemEntity = new ItemsEntity( );
        static PacksEntity _packEntity = new PacksEntity( );
        static InvoicesEntity _invoiceEntity = new InvoicesEntity( );
        static AccountsEntity _accountEntity = new AccountsEntity( );

       

        public static int GetNumberOfReservationEvent( )
        {
            _resEntity.ReservationEvents.Load( );
            return _resEntity.ReservationEvents.Count( );
        }

        public static int GetNumberOfPack( )
        {
            _packEntity.Packs.Load( );
            return _packEntity.Packs.Count( );
        }

        public static  int GetNumberOfItems( )
        {
            _itemEntity.Items.Load( );
            return _itemEntity.Items.Count( );
        }

        public static int GetNumberOfConsummableItems( )
        {
            var getConsummableItems = from a in _itemEntity.Items
                                      where a.Consumable == true
                                      select a;

            return getConsummableItems.Count( );
        }

        public static int GetNumberOfReservableNonConsummableItems( )
        {
            var getReservableItems= from a in _itemEntity.Items
                                    where a.Reservable == true && a.Consumable == false
                                    select a;

            return getReservableItems.Count( );
        }

        public static int GetNumberOfInvoices()
        {
            _invoiceEntity.Invoices.Load( );
            return _invoiceEntity.Invoices.Count( );
        }

        public static int GetNumberOfActiveAccount( )
        {
            var getActiveAccounts = from a in _accountEntity.Accounts
                                    where a.Active == true
                                    select a;

            return getActiveAccounts.Count( );
        }

        public static int GetNumberOfBannedAccount()
        {
            var getBannedAccounts = from a in _accountEntity.Accounts
                                    where a.Banned == true
                                    select a;

            return getBannedAccounts.Count( );
        }

        public static string GetUserNameOnId(int id)
        {
            var getName = from account in _accountEntity.Accounts
                          where account.Id == id
                          select account;

            return getName.FirstOrDefault( ).FirstName + " " + getName.FirstOrDefault( ).LastName;
        }

        public static List<ReservationEvent> GetListOfReservationEvent()
        {
            return _resEntity.ReservationEvents.Local.ToList( );
        }

        //public static List<ReservationItemModel> GetAllReservationItemModel()
        //{
        //    var itemQuery = (from a in _itemEntity.Items
        //                    join state in _itemEntity.ItemStates on a.CurrentState equals state.Id
        //                    select a).ToArray();

        //    var packQuery = (from b in _packEntity.Packs
        //                    select b).ToArray();

        //    var resQuery = from res in _resEntity.ReservationItems
        //                join reservation in _resEntity.ReservationEvents on res.Reservation equals reservation.Id
        //                join planning in _resEntity.ReservationPlannings on res.RealPlanning equals planning.Id
        //                join it in itemQuery on res.ReservedItem equals it.Id
        //                join pa in packQuery on res.ReservedPack equals pa.Id
        //                //join resitem in _itemEntity.Items on res.ReservedItem equals resitem.Id
        //                //join respack in _packEntity.Packs on res.ReservedPack equals respack.Id
        //                //join initialsta in _itemEntity.ItemStates on res.InitialState equals initialsta.Id
        //                //join returnsta in _itemEntity.ItemStates on res.ReturnState equals returnsta.Id

        //                select new ReservationItemModel { res_Event = reservation, res_Planning = planning, res_Item = res, item_State = it.ItemState, item = it, pack = pa};

        //    return resQuery.ToList( );
        //}

        public static void DisposeAllEntities( )
        {
            _resEntity.Dispose( );
            _itemEntity.Dispose( );
            _packEntity.Dispose( );
            _invoiceEntity.Dispose( );
            _accountEntity.Dispose( );
        }
    }
}
