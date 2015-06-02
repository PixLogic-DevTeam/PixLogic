using ITI.PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;

namespace ITI.PixLogic.WinApp
{
	public partial class AddCapitalizedView : Form
	{
		ItemsEntity _itemsEntity = new ItemsEntity();
		AccountingEntity _accountingEntity = new AccountingEntity();

		public AddCapitalizedView()
		{
			InitializeComponent( );
		}

		private void SubCatComboBox_Click( object sender, EventArgs e )
		{
			_itemsEntity.capitalized_sub_categories.Load( );
			SubCatComboBox.DataSource = _itemsEntity.capitalized_sub_categories.Local.ToBindingList( );
			SubCatComboBox.ValueMember = "id";
			SubCatComboBox.DisplayMember = "name";
		}

		private void InvoiceComboBox_Click( object sender, EventArgs e )
		{
			_accountingEntity.invoices.Load();
			InvoiceComboBox.DataSource = _accountingEntity.invoices.Local.ToBindingList();
			InvoiceComboBox.ValueMember = "id";
			InvoiceComboBox.DisplayMember = "description";
		}

		private void CurrentStateComboBox_Click( object sender, EventArgs e )
		{
			_itemsEntity.states.Load( );
			CurrentStateComboBox.DataSource = _itemsEntity.states.Local.ToBindingList( );
			CurrentStateComboBox.ValueMember = "id";
			CurrentStateComboBox.DisplayMember = "name";
		}

		private void BackBtn_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void AddBtn_Click( object sender, EventArgs e )
		{
			capitalized objCapitalized = new capitalized( );
			objCapitalized.product_reference = NameTextBox.Text;
			objCapitalized.description = DescriptionRichTextBox.Text;
			objCapitalized.ean13 = Convert.ToInt64( EANTextBox.Text );
			objCapitalized.reservation_cost = Convert.ToInt64( ResCostTextBox.Text );

			capitalized_sub_categories subcat = _itemsEntity.capitalized_sub_categories.FirstOrDefault( o => o.name == SubCatComboBox.Text );
			Debug.Assert( subcat != null );
			subcat.name = SubCatComboBox.Text;
			objCapitalized.capitalized_sub_categories = subcat;

			invoices invo = _accountingEntity.invoices.FirstOrDefault( o => o.description == InvoiceComboBox.Text );
			Debug.Assert( invo != null );
			objCapitalized.invoice = invo.id;

			states state = _itemsEntity.states.FirstOrDefault( o => o.name == CurrentStateComboBox.Text );
			Debug.Assert( state != null );
			state.name = CurrentStateComboBox.Text;
			objCapitalized.states = state;

			_itemsEntity.capitalized.Add( objCapitalized );
			_itemsEntity.SaveChanges();

			this.Close( );
		}
	}
}
