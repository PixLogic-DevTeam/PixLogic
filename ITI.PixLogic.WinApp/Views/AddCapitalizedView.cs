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
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
	public partial class AddCapitalizedView : Form
	{
        CapitalizedView _capitalizedViewMain;
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

		public AddCapitalizedView(CapitalizedView CV)
		{
			InitializeComponent( );
            _capitalizedViewMain = CV;
		}

		private void SubCatComboBox_Click( object sender, EventArgs e )
		{
            _itemsEntity.ItemFunctionalCategories.Load( );
			SubCatComboBox.DataSource = _itemsEntity.ItemFunctionalCategories.Local.ToBindingList();
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
			item.Reference = ReferenceTextBox.Text;
			item.Description = DescriptionRichTextBox.Text;
			item.EAN13 = Convert.ToInt64( EANTextBox.Text );
			item.ReservationCost = Convert.ToInt64( ResCostTextBox.Text );
            item.Reservable = Convert.ToBoolean( Convert.ToInt32( Reservable_comboBox.Text)) ;

            ItemBrand brand = _itemsEntity.ItemBrands.FirstOrDefault( o => o.Name == BrandComboBox.Text );
            brand.Name = BrandComboBox.Text;
            item.ItemBrand = brand;

			ItemFunctionalCategory funcCat = _itemsEntity.ItemFunctionalCategories.FirstOrDefault( o => o.Name == SubCatComboBox.Text );
			//Debug.Assert( subCategory != null );
			funcCat.Name = SubCatComboBox.Text;
			item.ItemFunctionalCategory = funcCat;

			Invoice invoice = _invoiceEntity.Invoices.FirstOrDefault( o => o.Id == InvoiceComboBox.SelectedIndex+1);
			//Debug.Assert( invoce != null );
			item.RelatedInvoice = invoice.Id;

			ItemState state = _itemsEntity.ItemStates.FirstOrDefault( o => o.Name == CurrentStateComboBox.Text );
			//Debug.Assert( state != null );
			state.Name = CurrentStateComboBox.Text;
			item.ItemState = state;
            
			_itemsEntity.Items.Add( item );
			_itemsEntity.SaveChanges();
            //_itemsEntity.Items.Load();


            _itemsEntity = new ItemsEntity();

            var query = from item2 in _itemsEntity.Items

                        join funcCat2 in _itemsEntity.ItemFunctionalCategories on item2.FunctionalCategory equals funcCat2.Id
                        join brand2 in _itemsEntity.ItemBrands on item2.Brand equals brand2.Id
                        join state2 in _itemsEntity.ItemStates on item2.CurrentState equals state2.Id
                        //join inv in _invoicesEntity.Invoices on c.RelatedInvoice equals inv.Id
                        orderby item2.Id
                        select new CapitalizedItemModel { item = item2, item_brand = brand2, item_func_category = funcCat2, item_state = state, /*invoices = inv*/ };
            var cons = query.ToList();
            _capitalizedViewMain.CapitalizedDataListView.DataSource = cons;
            
            for( int i =_capitalizedViewMain.CapitalizedDataListView.Columns.Count - 1; i > 11; i-- )
            {
               _capitalizedViewMain.CapitalizedDataListView.Columns.RemoveAt( i );
            }
			this.Close( );
		}

		private void EANTextBox_KeyPress( object sender, KeyPressEventArgs e )
		{
			if( !char.IsControl( e.KeyChar )
		&& !char.IsDigit( e.KeyChar )
		&& e.KeyChar != '.' )
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if( e.KeyChar == '.'
				&& (sender as TextBox).Text.IndexOf( '.' ) > -1 )
			{
				e.Handled = true;
			}
		}

       

     
        
	}
}
