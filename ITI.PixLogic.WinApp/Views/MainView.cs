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
using ITI.PixLogic.DAL.Contexts.Accounts;

namespace ITI.PixLogic.WinApp.Views
{
	public partial class MainView : Form
	{
		public MainView()
		{
			InitializeComponent();
			DoubleBuffered = true;
		}

		private void MainFormView_Paint( object sender, PaintEventArgs e )
		{
			// Linear Gradient
			using( LinearGradientBrush brush = new LinearGradientBrush( this.ClientRectangle, Color.FromArgb( 197, 207, 223 ), Color.FromArgb( 220, 229, 242 ), 0f ) )
			{
				e.Graphics.FillRectangle( brush, this.ClientRectangle );
			}
			
		}

		private void MainFormView_Resize( object sender, EventArgs e )
		{
			this.Invalidate();
		}
	}
}
