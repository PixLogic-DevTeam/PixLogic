using System;
using System.Windows.Forms;

using RibbonLib;
using RibbonLib.Controls;
using RibbonLib.Controls.Events;
using RibbonLib.Interop;

namespace ITI.PixLogic.WinApp
{
	partial class Home
	{
		// Ribbon application menu parts' declaration
		private RibbonApplicationMenu _applicationMenu;
		private RibbonButton _commandDb;
		private RibbonButton _commandDbConnectionRefresh;
		private RibbonButton _commandDbBackupConfigure;
		private RibbonButton _commandDbBackupMakeNow;
		private RibbonButton _commandDbBackupApplyNow;
		private RibbonButton _commandExports;
		private RibbonButton _commandExportAccounts;
		private RibbonButton _commandExportInvoices;
		private RibbonButton _commandExportItems;
		private RibbonButton _commandExportPacks;
		private RibbonButton _commandExportReservations;
		private RibbonButton _commandContact;
		private RibbonButton _commandConfiguration;
		private RibbonButton _commandExit;

		private void RibbonApplicationMenuInitilization()
		{
			// Application menu initialization
			_applicationMenu = new RibbonApplicationMenu( _ribbon, (uint)RibbonMarkupCommands.ApplicationMenu );

			// Data management controls initialization
			_commandDb = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandDb );
			_commandDbConnectionRefresh = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandDbConnectionRefresh );
			_commandDbBackupConfigure = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandDbBackupConfigure );
			_commandDbBackupMakeNow = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandDbBackupMakeNow );
			_commandDbBackupApplyNow = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandDbBackupApplyNow );
			_commandExports = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExports );
			_commandExportAccounts = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportAccounts );
			_commandExportInvoices = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportInvoices );
			_commandExportItems = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportItems );
			_commandExportPacks = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportPacks );
			_commandExportReservations = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportReservations );

			// Application management controls initialization
			_commandContact = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandContact );
			_commandConfiguration = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandConfiguration );
			_commandExit = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExit );

			// if( _emptyEntity.Database.Connection != null ) { }	
			_commandExit.ExecuteEvent += new EventHandler<ExecuteEventArgs>( _buttonToExit_OnExecute );
		}

		private void _buttonToExit_OnExecute( object sender, EventArgs e )
		{
			// Close all application windows
			Application.Exit();
		}
	}
}
