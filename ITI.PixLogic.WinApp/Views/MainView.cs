using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using ITI.PixLogic.BLL;
using ITI.PixLogic.DAL.Contexts;

using RibbonLib;
using RibbonLib.Controls;
using RibbonLib.Controls.Events;
using RibbonLib.Interop;

namespace ITI.PixLogic.WinApp.Views
{
	// Helper enumaration
	public enum RibbonMarkupCommands : uint
	{
		ApplicationMenu = 1000,

		CommandDb = 1200,
		CommandDbConnectionRefresh = 1210,
		CommandDBBackupConfigure = 1220,
		CommandDbBackupMakeNow = 1230,
		CommandDbBackupApplyNow = 1240,

		CommandExports = 1400,
		CommandExportAccounts = 1410,
		CommandExportInvoices = 1420,
		CommandExportItems = 1430,
		CommandExportPacks = 1440,
		CommandExportReservations = 1450,

		CommandContact = 1600,
		CommandConfiguration = 1700,
		CommandExit = 1800,
	}

	public partial class MainView : Form
	{
		// Models declaration
		private readonly AccountsEntity _accountsEntity;
		private readonly EventsEntity _eventsEntity;
		private readonly InvoicesEntity _invoicesEntity;
		private readonly ItemsEntity _itemsEntity;
		private readonly PacksEntity _packsEntity;
		private readonly EmptyEntity _emptyEntity;

		// Ribbon parts declaration
		private RibbonApplicationMenu _applicationMenu;

		private RibbonButton _commandDb;
		private RibbonButton _commandDbConnectionRefresh;
		private RibbonButton _commandDbBackupMakeNow;
		private RibbonButton _commandDbBackupConfigure;
		private RibbonButton _commandDbBackupApply;

		private RibbonButton _commandExports;
		private RibbonButton _commandExportAccounts;
		private RibbonButton _commandExportInvoices;
		private RibbonButton _commandExportItems;
		private RibbonButton _commandExportPacks;
		private RibbonButton _commandExportReservations;

		private RibbonButton _commandContact;
		private RibbonButton _commandConfiguration;
		private RibbonButton _commandExit;
		
		public MainView()
		{
			InitializeComponent();
			this.DoubleBuffered = true; // Prevent background flickering on form resize due to the linear gradient

			// Models initialization
			_accountsEntity = new AccountsEntity();
			_eventsEntity = new EventsEntity();
			_invoicesEntity = new InvoicesEntity();
			_itemsEntity = new ItemsEntity();
			_packsEntity = new PacksEntity();
			_emptyEntity = new EmptyEntity();

			// Ribbon parts initialization
			_applicationMenu = new RibbonApplicationMenu( _ribbon, (uint)RibbonMarkupCommands.ApplicationMenu );
			_commandExports = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExports );
			_commandExportAccounts = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportAccounts );
			_commandExportInvoices = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportInvoices );
			_commandExportItems = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportItems );
			_commandExportPacks = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportPacks );
			_commandExportReservations = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExportReservations );
			_commandContact = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandContact);
			_commandConfiguration = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandConfiguration );
			_commandExit = new RibbonButton( _ribbon, (uint)RibbonMarkupCommands.CommandExit );

			_commandExit.ExecuteEvent += new EventHandler<ExecuteEventArgs>( _buttonToExit_OnExecute );


			// if( _emptyEntity.Database.Connection != null ) { }
		}

		private void MainForm_OnPaint( object sender, PaintEventArgs e )
		{
			// Apply linear gradient
			using( LinearGradientBrush brush = new LinearGradientBrush( this.ClientRectangle, Color.FromArgb( 197, 207, 223 ), Color.FromArgb( 220, 229, 242 ), 0f ) )
			{
				e.Graphics.FillRectangle( brush, this.ClientRectangle );
			}	
		}

		private void MainForm_OnResize( object sender, EventArgs e )
		{
			// Reapply linear gradient to the updated surface
			this.Invalidate();
		}

		private void _buttonToExit_OnExecute( object sender, EventArgs e )
		{
			// Close all application windows
			Application.Exit();
		}
	}
}
