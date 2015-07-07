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
			if ( CapitalizedDataListView.SelectedItems.Count == 0 )
			{
				MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
			}
			else
			{
                var toBeDeleted =(CapitalizedItemModel)CapitalizedDataListView.SelectedObject;
                   
                var capitalizedData =_itemsEntity.Items.First( c => c.Id == toBeDeleted.Id );
                _itemsEntity.Items.Remove( capitalizedData );
                try
                {
                    _itemsEntity.SaveChanges();

                }
                catch( Exception expz )
                {
                    MessageBox.Show( expz.InnerException.ToString() );
                }
                _itemsEntity = new ItemsEntity();

                var query = from item3 in _itemsEntity.Items

							join funcCat3 in _itemsEntity.ItemFunctionalCategories on item3.FunctionalCategory equals funcCat3.Id
                            join brand3 in _itemsEntity.ItemBrands on item3.Brand equals brand3.Id
                            join state3 in _itemsEntity.ItemStates on item3.CurrentState equals state3.Id
                            //join inv in _invoicesEntity.Invoices on c.RelatedInvoice equals inv.Id
                            orderby item3.Id
                            select new CapitalizedItemModel { item = item3, item_brand = brand3, item_func_category = funcCat3, item_state = state3, /*invoices = inv*/ };
                var cons = query.ToList();
                CapitalizedDataListView.DataSource = cons;
                for( int i = CapitalizedDataListView.Columns.Count - 1; i > 11; i-- )
                {
                    CapitalizedDataListView.Columns.RemoveAt( i );
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
    public class CapitalizedItemModel
    {
        public Item item { get; set; }

        public ItemBrand item_brand { get; set; }

        public ItemFunctionalCategory item_func_category { get; set; }

        public ItemState item_state { get; set; }

        //public ItemCategory item_catagories { get; set; }

        public Invoice invoice { get; set; }

        public Int64 Id
        {
            get { return item.Id; }
            set { item.Id = value; }
        }
        public Int64 EAN13
        {
            get { return (long)item.EAN13; }
            set { item.EAN13 = value; }
        }
        public string Reference
        {
            get { return item.Reference; }
            set { item.Reference = value; }
        }
        public Int64 ReservationCost
        {
            get { return item.ReservationCost; }
            set { item.ReservationCost = value; }
        }
        public bool Consumable
        {
            get { return item.Consumable; }
            set { item.Consumable = value; }
        }
        public bool Reservable
        {
            get { return item.Reservable; }
            set { item.Reservable = value; }
        }
        public string Description
        {
            get { return item.Description; }
            set { item.Description = value; }
        }
        public string PicturePath
        {
            get { return item.PicturePath; }
            set { item.PicturePath = value; }
        }
        public string Brand
        {
            get { return item_brand.Name; }
            set { item_brand.Name = value; }
        }
        public Int64 RelatedInvoice
        {
            get { return invoice.Id; }
            set { invoice.Id = value; }
        }
        public string SubCategory
        {
            get { return item_func_category.Name; }
            set { item_func_category.Name = value; }
        }
        public string CurrentState
        {
            get { return item_state.Name; }
            set { item_state.Name = value; }
        }
    }
}
