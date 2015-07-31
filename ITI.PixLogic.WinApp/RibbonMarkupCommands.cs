using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PixLogic.WinApp
{
	public enum RibbonMarkupCommands : uint
	{
		// Ribbon application menu's commands' id list
		// Ids' range: 1000/1999
		ApplicationMenu = 1000,
		DataManagementGroup = 1100,
		CommandDb = 1110,
		CommandDbConnectionRefresh = 1111,
		CommandDbBackupConfigure = 1112,
		CommandDbBackupMakeNow = 1113,
		CommandDbBackupApplyNow = 1114,
		CommandExports = 1120,
		CommandExportAccounts = 1121,
		CommandExportInvoices = 1122,
		CommandExportItems = 1123,
		CommandExportPacks = 1124,
		CommandExportReservations = 1125,
		ApplicationManagementCategory = 1200,
		CommandContact = 1210,
		CommandConfiguration = 1220,
		CommandExit = 1230,

		// Ribbon accounts' tab commands' id list
		// Ids' range: 2000/2999
		AccountsTab = 2000,

		// Ribbon invoices' tab commands' id list
		// Ids' range: 3000/3999
		InvoicesTab = 3000,

		// Ribbon items' tab commands' id list
		// Ids' range: 4000/4999
		ItemsTab = 4000,

		// Ribbon packs' tab commands' id list
		// Ids' range: 5000/5999
		PacksTab = 5000,

		// Ribbon reservations' tab commands' id list
		// Ids' range: 6000/6999
		ReservationsTab = 6000,

		// Ribbon restorations' tab commands' id list
		// Ids' range: 7000/7999
		RestorationsTab = 7000,

		// Ribbon help's button command's id
		CommandHelp = 9999,
	}
}
