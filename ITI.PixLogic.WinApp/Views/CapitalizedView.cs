using ITI.PixLogic.DAL;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.BLL;
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
			_itemsEntity.Items.Load( );
            capitalizedBindingSource.DataSource = _itemsEntity.Items.Local.ToBindingList( );
		}

		private void Suppr_Btn_Click( object sender, EventArgs e )
		{
            if ( CapitalizedDataListView.SelectedItems.Count == 0 )
			{
				MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
			}

			else
			{
                CapitalizedService.DeleteItem( (Item) CapitalizedDataListView.SelectedObject );
                CapitalizedDataListView.DataSource = _itemsEntity.Items.Local.ToBindingList( );
			}
		}

		private void Add_Btn_Click( object sender, EventArgs e )
		{
			new AddCapitalizedView( ).Show( );
		}

        private void EditBtn_Click( object sender, EventArgs e )
        {
            using(AddCapitalizedView editForm = new AddCapitalizedView())
            {
                Item capToEdit = (Item)CapitalizedDataListView.SelectedObject;

                
            }
        }

        private void BackBtn_Click( object sender, EventArgs e )
        {
            this.Close( );
            new HomeView( ).Show( );
        }
	}
}
