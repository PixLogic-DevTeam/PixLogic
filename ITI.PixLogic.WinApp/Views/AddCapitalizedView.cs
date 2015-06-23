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
        public int Reservable { get; set; }

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
        private void BrandComboBox_Click( object sender, EventArgs e )
        {
            _itemsEntity.ItemBrands.Load();
            BrandComboBox.DataSource = _itemsEntity.ItemBrands.Local.ToBindingList();
            BrandComboBox.ValueMember = "id";
            BrandComboBox.DisplayMember = "name";
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
            Item item = new Item( );
			item.Reference = NameTextBox.Text;
			item.Description = DescriptionRichTextBox.Text;
			item.EAN13 = Convert.ToInt64( EANTextBox.Text );
			item.ReservationCost = Convert.ToInt64( ResCostTextBox.Text );
            item.Reservable = Convert.ToBoolean( Convert.ToInt32( Reservable_comboBox.Text)) ;

            ItemBrand brand = _itemsEntity.ItemBrands.FirstOrDefault( o => o.Name == BrandComboBox.Text );
            brand.Name = BrandComboBox.Text;
            item.ItemBrand = brand;

            ItemSubCategory subCategory = _itemsEntity.ItemSubCategories.FirstOrDefault( o => o.Name == SubCatComboBox.Text );
			//Debug.Assert( subCategory != null );
			subCategory.Name = SubCatComboBox.Text;
            item.ItemSubCategory = subCategory;

			Invoice invoice = _invoiceEntity.Invoices.FirstOrDefault( o => o.Id == InvoiceComboBox.SelectedIndex+1);
			//Debug.Assert( invoce != null );
			item.RelatedInvoice = invoice.Id;

			ItemState state = _itemsEntity.ItemStates.FirstOrDefault( o => o.Name == CurrentStateComboBox.Text );
			//Debug.Assert( state != null );
			state.Name = CurrentStateComboBox.Text;
			item.ItemState = state;
            
			_itemsEntity.Items.Add( item );
			_itemsEntity.SaveChanges();
            _itemsEntity.Items.Load();

			this.Close( );
		}

       

     
        
	}
}
