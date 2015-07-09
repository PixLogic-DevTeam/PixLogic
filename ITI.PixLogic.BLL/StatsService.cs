﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.BLL
{
	public static class StatsService
	{
		static EventsEntity _resEntity = new EventsEntity();
		static ItemsEntity _itemEntity = new ItemsEntity();
		static PacksEntity _packEntity = new PacksEntity();
		static InvoicesEntity _invoiceEntity = new InvoicesEntity();
		static AccountsEntity _accountEntity = new AccountsEntity();



		public static int GetNumberOfReservationEvent()
		{
			_resEntity.RestorationEvents.Load();
			return _resEntity.ReservationEvents.Count();
		}

		public static int GetNumberOfPack()
		{
			_packEntity.Packs.Load();
			return _packEntity.Packs.Count();
		}

		public static int GetNumberOfItems()
		{
			_itemEntity.Items.Load();
			return _itemEntity.Items.Count();
		}

		public static int GetNumberOfConsummableItems()
		{
			var getConsummableItems = from a in _itemEntity.view_items
									  where a.ItemIsConsumable == true
									  select a;

			return getConsummableItems.Count();
		}

		public static int GetNumberOfReservableNonConsummableItems()
		{
			var getReservableItems= from a in _itemEntity.view_items
									where a.ItemIsReservable == true && a.ItemIsConsumable == false
									select a;

			return getReservableItems.Count();
		}

		public static int GetNumberOfInvoices()
		{
			_invoiceEntity.Invoices.Load();
			return _invoiceEntity.Invoices.Count();
		}

		public static int GetNumberOfActiveAccount()
		{
			var getActiveAccounts = from a in _accountEntity.view_accounts
									where a.AccountPermissionLevel == "Actived"
									select a;

			return getActiveAccounts.Count();
		}

		public static int GetNumberOfBannedAccount()
		{
			var getBannedAccounts = from a in _accountEntity.view_accounts
									where a.AccountPermissionLevel == "Banned"
									select a;

			return getBannedAccounts.Count();
		}

		public static string GetUserNameOnId( int id )
		{
			var getName = from account in _accountEntity.view_accounts
						  where account.AccountId == id
						  select account;

			return getName.FirstOrDefault().AccountFirstName + " " + getName.FirstOrDefault().AccountLastName
;
		}

		public static List<ReservationEvent> GetListOfReservationEvent()
		{
			return _resEntity.ReservationEvents.Local.ToList();
		}

		public static void DisposeAllEntities()
		{
			_resEntity.Dispose();
			_itemEntity.Dispose();
			_packEntity.Dispose();
			_invoiceEntity.Dispose();
			_accountEntity.Dispose();
		}
	}
}
