using ITI.PixLogic.DAL;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Invoices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.PixLogic.WinApp
{
	public partial class AddCapitalizedView : Form
	{
		ItemsEntity _itemsEntity = new ItemsEntity();
		InvoicesEntity _invoiceEntity = new InvoicesEntity();

        public string CapitalizedName { get; set; }

        public string Description {get; set;}

        public string Reference { get; set; }

        public Nullable<long> EAN13 { get; set; }

        public Nullable<long> ReservationCost { get; set; }

        public long SubCategory { get; set; }

        public long Invoice { get; set; }

        public long Current_State { get; set; }


		public AddCapitalizedView()
		{
			InitializeComponent( );
		}

		private void SubCatComboBox_Click( object sender, EventArgs e )
		{
            _itemsEntity.ItemSubCategories.Load( );
            SubCatComboBox.DataSource = _itemsEntity.ItemSubCategories.Local.ToBindingList( );
			SubCatComboBox.ValueMember = "id";
			SubCatComboBox.DisplayMember = "name";
		}

		private void InvoiceComboBox_Click( object sender, EventArgs e )
		{
            _invoiceEntity.Invoices.Load( );
			InvoiceComboBox.DataSource = _invoiceEntity.Invoices.Local.ToBindingList();
			InvoiceComboBox.ValueMember = "id";
			InvoiceComboBox.DisplayMember = "description";
		}

		private void CurrentStateComboBox_Click( object sender, EventArgs e )
		{
            _itemsEntity.ItemStates.Load( );
            CurrentStateComboBox.DataSource = _itemsEntity.ItemStates.Local.ToBindingList( );
			CurrentStateComboBox.ValueMember = "id";
			CurrentStateComboBox.DisplayMember = "name";
		}

		private void BackBtn_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void AddBtn_Click( object sender, EventArgs e )
		{
            Item objItem = new Item( );
			objItem.Reference = NameTextBox.Text;
			objItem.Description = DescriptionRichTextBox.Text;
			objItem.EAN13 = Convert.ToInt64( EANTextBox.Text );
			objItem.ReservationCost = Convert.ToInt64( ResCostTextBox.Text );

            ItemSubCategory subcat = _itemsEntity.ItemSubCategories.FirstOrDefault( o => o.Name == SubCatComboBox.Text );
			Debug.Assert( subcat != null );
			subcat.Name = SubCatComboBox.Text;
            objItem.ItemSubCategory = subcat;

			Invoice invo = _invoiceEntity.Invoices.FirstOrDefault( o => o.ScanPath == InvoiceComboBox.Text );
			Debug.Assert( invo != null );
			objItem.RelatedInvoice = invo.Id;

			ItemState state = _itemsEntity.ItemStates.FirstOrDefault( o => o.Name == CurrentStateComboBox.Text );
			Debug.Assert( state != null );
			state.Name = CurrentStateComboBox.Text;
			objItem.ItemState = state;

			_itemsEntity.Items.Add( objItem );
			_itemsEntity.SaveChanges();

			this.Close( );
		}

        private void checkBox2_CheckedChanged( object sender, EventArgs e )
        {

        }
	}
}
