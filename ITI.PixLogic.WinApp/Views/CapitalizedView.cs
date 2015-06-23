using ITI.PixLogic.DAL;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Invoices;
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
		InvoicesEntity _invoicesEntity;
 
		public CapitalizedView()
		{
			InitializeComponent( );
			Consumables_Load();
		}

		private void Consumables_Load( )
		{    
			_itemsEntity = new ItemsEntity();
			_invoicesEntity = new InvoicesEntity();
			
			var query = from it in _itemsEntity.Items
						
						join sub in _itemsEntity.ItemSubCategories on it.SubCategory equals sub.Id
						join bra in _itemsEntity.ItemBrands on it.Brand equals bra.Id
						join sta in _itemsEntity.ItemStates on it.CurrentState equals sta.Id
						//join inv in _invoicesEntity.Invoices on c.RelatedInvoice equals inv.Id
						orderby it.Id
						select new CapitalizedItemModel { items = it, item_brands = bra, item_sub_categories = sub , item_state = sta, /*invoices = inv*/ };
			var cons = query.ToList();
			//_itemsEntity.Items.Load();
			CapitalizedDataListView.DataSource = cons;

                
            for(int i = CapitalizedDataListView.Columns.Count-1; i>11; i--){
                CapitalizedDataListView.Columns.RemoveAt( i );
            }
           
		}

		private void Suppr_Btn_Click( object sender, EventArgs e )
		{
			if ( CapitalizedDataListView.SelectedItems.Count == 0 )
			{
				MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
			}
			else
			{
                _itemsEntity = new ItemsEntity();
                _invoicesEntity = new InvoicesEntity();

                var query = from it in _itemsEntity.Items

                            join sub in _itemsEntity.ItemSubCategories on it.SubCategory equals sub.Id
                            join bra in _itemsEntity.ItemBrands on it.Brand equals bra.Id
                            join sta in _itemsEntity.ItemStates on it.CurrentState equals sta.Id
                            //join inv in _invoicesEntity.Invoices on c.RelatedInvoice equals inv.Id
                            orderby it.Id
                            select new CapitalizedItemModel { items = it, item_brands = bra, item_sub_categories = sub, item_state = sta, /*invoices = inv*/ };
                var cons = query.ToList();
				foreach(var item in CapitalizedDataListView.SelectedObjects)
				{
                    
                    cons.Remove( (CapitalizedItemModel) item );
					//_itemsEntity.Items.Remove( (Item)item );
				}
                CapitalizedDataListView.DataSource = cons;
                CapitalizedDataListView.Invalidate();
                
                //_itemsEntity.SaveChanges();
                //_itemsEntity.Items.Load();
                
                //CapitalizedDataListView.DataSource = _itemsEntity.Items.Local.ToBindingList( );
              
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
    public class CapitalizedItemModel
    {
        public Item items { get; set; }

        public ItemBrand item_brands { get; set; }

        public ItemSubCategory item_sub_categories { get; set; }

        public ItemState item_state { get; set; }
        //public ItemRestoration item_restoration { get; set; }

        //public ItemMainCategory item_main_catagories { get; set; }

        public Invoice invoices { get; set; }

        public Int64 Id
        {
            get { return items.Id; }
            set { items.Id = value; }
        }
        public Int64 EAN13
        {
            get { return (long)items.EAN13; }
            set { items.EAN13 = value; }
        }
        public string Reference
        {
            get { return items.Reference; }
            set { items.Reference = value; }
        }
        public Int64 ReservationCost
        {
            get { return items.ReservationCost; }
            set { items.ReservationCost = value; }
        }
        public bool Consumable
        {
            get { return items.Consumable; }
            set { items.Consumable = value; }
        }
        public bool Reservable
        {
            get { return items.Reservable; }
            set { items.Reservable = value; }
        }
        public string Description
        {
            get { return items.Description; }
            set { items.Description = value; }
        }
        public string PicturePath
        {
            get { return items.PicturePath; }
            set { items.PicturePath = value; }
        }
        public string Brand
        {
            get { return item_brands.Name; }
            set { item_brands.Name = value; }
        }
        public Int64 RelatedInvoice
        {
            get { return invoices.Id; }
            set { invoices.Id = value; }
        }
        public string SubCategory
        {
            get { return item_sub_categories.Name; }
            set { item_sub_categories.Name = value; }
        }
        public string CurrentState
        {
            get { return item_state.Name; }
            set { item_state.Name = value; }
        }
    }
}
