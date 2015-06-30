using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.PixLogic.DAL.Contexts.Accounts;
using System.Data.Entity;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Reservations;

namespace ITI.PixLogic.WinApp.Views
{
	public partial class MatérielView : Form
	{
		ReservationsEntity _reservationsEntity = new ReservationsEntity();

		public MatérielView()
		{
			InitializeComponent();
		}

		private void comboBoxItem_SelectedIndexChanged( object sender, EventArgs e )
		{
		}

		private void MatérielView_Load( object sender, EventArgs e )
		{
			var query =  _reservationsEntity.reservationexports;
			var cons = query.ToList();
			dataListView1.DataSource = cons;
			dataListView1.Columns.RemoveAt( 0 );
			for( int i = 0; i < 9 ; i++ )
			{
				dataListView1.Columns.RemoveAt( i );
			}

			for( int j=0; j < dataListView1.Columns.Count -1; j++ )
			{
				dataListView1.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.ColumnContent );
				dataListView1.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.HeaderSize );
			}
		}

		private void Resbutton_Click( object sender, EventArgs e )
		{
			new AddReservationForm().Show();
			this.Hide();
		}
	}
}
