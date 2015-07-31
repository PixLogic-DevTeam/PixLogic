using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using RibbonLib;
using RibbonLib.Controls;
using RibbonLib.Controls.Events;
using RibbonLib.Interop;

using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
	public partial class Home : Form
	{
		// Db contexts' declaration
		private readonly AccountsEntity _accountsEntity;
		private readonly EventsEntity _eventsEntity;
		private readonly InvoicesEntity _invoicesEntity;
		private readonly ItemsEntity _itemsEntity;
		private readonly PacksEntity _packsEntity;
		private readonly EmptyEntity _emptyEntity;

		public Home()
		{
			InitializeComponent();
			this.DoubleBuffered = true; // Prevent background flickering on form resize due to the linear gradient

			// Db contexts' initialization
			_accountsEntity = new AccountsEntity();
			_eventsEntity = new EventsEntity();
			_invoicesEntity = new InvoicesEntity();
			_itemsEntity = new ItemsEntity();
			_packsEntity = new PacksEntity();
			_emptyEntity = new EmptyEntity();

			// Ribbon's parts initialization
			RibbonApplicationMenuInitilization();
			RibbonAccountsTabInitialization();		
			RibbonInvoicesTabInitialization();
			RibbonItemsTabInitialization();
			RibbonPacksTabsInitialization();		
			RibbonReservationsTabInitialization();
			RibbonRestorationsTabInitialization();
			RibbonHelpButtonInitialization();
		}

		private void Home_OnPaint( object sender, PaintEventArgs e )
		{
			// Apply linear gradient
			using( LinearGradientBrush brush = new LinearGradientBrush( this.ClientRectangle, Color.FromArgb( 197, 207, 223 ), Color.FromArgb( 220, 229, 242 ), 0f ) )
			{
				e.Graphics.FillRectangle( brush, this.ClientRectangle );
			}	
		}

		private void Home_OnResize( object sender, EventArgs e )
		{
			// Reapply linear gradient to the updated surface
			this.Invalidate();
		}
	}
}
