using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
	
	public partial class CapitalizedView : Form
	{
		ItemsEntity _itemsEntity = new ItemsEntity();
 
		public CapitalizedView()
		{
			InitializeComponent( );
			Consumables_Load();
		}

		private void Consumables_Load( )
		{ 
			var query =  _itemsEntity.view_items;
			var cons = query.ToList();
			CapitalizedDataListView.DataSource = cons;

			#region rezise the column of datalistview

			for( int j = 0; j < 7 - 1; j++ )
			{
				CapitalizedDataListView.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.ColumnContent );
				CapitalizedDataListView.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.HeaderSize );
			}

			for( int a = 7; a < 14 - 1; a++ )
			{
				CapitalizedDataListView.AutoResizeColumn( a, ColumnHeaderAutoResizeStyle.ColumnContent );
				CapitalizedDataListView.AutoResizeColumn( a, ColumnHeaderAutoResizeStyle.HeaderSize );
			}
			#endregion
		}

		private void Suppr_Btn_Click( object sender, EventArgs e )
		{
			if( CapitalizedDataListView.SelectedItems.Count == 0 )
			{
				MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
			}
			else
			{
				var toBeDeleted =(view_items)CapitalizedDataListView.SelectedObject;

				var capitalizedData =_itemsEntity.Items.First( c => c.Id == toBeDeleted.ItemId );
				_itemsEntity.Items.Remove( capitalizedData );
				try
				{
					_itemsEntity.SaveChanges();

				}
				catch( Exception expz )
				{
					MessageBox.Show( expz.InnerException.ToString() );
				}

				var query =  _itemsEntity.view_items;
				var cons = query.ToList();
				CapitalizedDataListView.DataSource = cons;

				for( int j = 0; j < 7 - 1; j++ )
				{
					CapitalizedDataListView.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.ColumnContent );
					CapitalizedDataListView.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.HeaderSize );
				}

				for( int a = 7; a < 14 - 1; a++ )
				{
					CapitalizedDataListView.AutoResizeColumn( a, ColumnHeaderAutoResizeStyle.ColumnContent );
					CapitalizedDataListView.AutoResizeColumn( a, ColumnHeaderAutoResizeStyle.HeaderSize );
				}
			}
		}

		private void Add_Btn_Click( object sender, EventArgs e )
		{
			new AddCapitalizedView(this ).Show( );
		}

		private void EditBtn_Click( object sender, EventArgs e )
		{
			using(AddCapitalizedView editForm = new AddCapitalizedView(this))
			{
				Item capToEdit = (Item)CapitalizedDataListView.SelectedObject;
			}
		}

		private void BackBtn_Click( object sender, EventArgs e )
		{
			this.Close( );
			new HomeView( ).Show( );
		}

		private void CapitalizedView_FormClosed( object sender, FormClosedEventArgs e )
		{
			//Application.Exit();
		}
	}
}
