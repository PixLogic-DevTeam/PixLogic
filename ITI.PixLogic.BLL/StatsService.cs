﻿using System;
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

        public static int GetNumberOfReservableItems( )
        {
            var getReservableItems= from a in _itemEntity.Items
                                    where a.Reservable == true
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

        public static List<ReservationEvent> GetListOfReservationEvent()
        {
            return _resEntity.ReservationEvents.Local.ToList( );
        }

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
