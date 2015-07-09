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
	public partial class AccountsView : Form
	{
		AccountsEntity _accountsEntity = new AccountsEntity();
		public AccountsView()
		{
			InitializeComponent();
			Accounts_Load();
		}

		private void Accounts_Load()
		{
			var query =  _accountsEntity.view_accounts;
			var cons = query.ToList();
			dataListView1.DataSource = cons;

			for( int k = 0; k < dataListView1.Columns.Count - 1; k++ )
			{
				dataListView1.AutoResizeColumn( k, ColumnHeaderAutoResizeStyle.ColumnContent );
				dataListView1.AutoResizeColumn( k, ColumnHeaderAutoResizeStyle.HeaderSize );
			}
		}

		private void button_back_Click( object sender, EventArgs e )
		{
			new HomeView().Show();
			this.Close();
		}

		private void button_add_Click( object sender, EventArgs e )
		{
			new AddAccountView().Show();
		}

		private void button_delete_Click( object sender, EventArgs e )
		{
			if( dataListView1.SelectedItems.Count == 0 )
			{
				MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
			}

			else
			{
				view_accounts toBeDeleted = (view_accounts)dataListView1.SelectedObject;
				Account UserData = _accountsEntity.Accounts.FirstOrDefault( c => c.Id == toBeDeleted.AccountId );

				_accountsEntity.Accounts.Remove( UserData );
				_accountsEntity.SaveChanges();

				var query =  _accountsEntity.view_accounts;
				var cons = query.ToList();
				dataListView1.DataSource = cons;
			}
		}

		private void button_modify_Click( object sender, EventArgs e)
		{
			view_accounts toBeModify = (view_accounts)dataListView1.SelectedObject;
			Account UserData = _accountsEntity.Accounts.FirstOrDefault( c => c.Id == toBeModify.AccountId );

			new ModifyAccountView(UserData).Show();
			this.Close();
		}
	}
}
