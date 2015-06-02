using ITI.PixLogic.DAL;
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

namespace ITI.PixLogic.WinApp
{
	public partial class CapitalizedView : Form
	{
		ItemsEntity _itemsEntity;

		public CapitalizedView()
		{
			InitializeComponent( );
			Capitalized_Load( );
		}

		private void Capitalized_Load( )
		{
			_itemsEntity = new ItemsEntity();
			_itemsEntity.capitalized.Load( );
			capitalizedBindingSource.DataSource = _itemsEntity.capitalized.Local.ToBindingList( );
		}

		private void Suppr_Btn_Click( object sender, EventArgs e )
		{
			if ( CapitalizedGridView.SelectedRows.Count == 0 || CapitalizedGridView.SelectedRows.Contains( CapitalizedGridView.Rows[ CapitalizedGridView.RowCount - 1 ] ) )
			{
				MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
			}

			else
			{
				var toBeDeleted = (long)CapitalizedGridView.SelectedRows[ 0 ].Cells[ 0 ].Value;
				var consumableData = _itemsEntity.consumables.First( c => c.id == toBeDeleted );
				_itemsEntity.consumables.Remove( consumableData );
				_itemsEntity.SaveChanges( );
				_itemsEntity.consumables.Load( );
				CapitalizedGridView.DataSource = _itemsEntity.consumables.Local.ToBindingList( );
			}
		}

		private void Add_Btn_Click( object sender, EventArgs e )
		{
			new AddCapitalizedView( ).Show( );
		}
	}
}
