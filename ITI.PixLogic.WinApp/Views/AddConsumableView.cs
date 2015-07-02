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
using ITI.PixLogic.WinApp.Views;
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
	public partial class AddConsumableView : Form
	{
		ItemsEntity _itemsEntity = new ItemsEntity();
		InvoicesEntity _invoiceEntity = new InvoicesEntity();

		public AddConsumableView()
		{
			InitializeComponent();
		}

		private void Add_consumable_button_Click(object sender, EventArgs e)
		{

			Item objConsumable = new Item();
			objConsumable.Reference = Name_consumable_txt.Text;
			objConsumable.Description = Description_consumable_txt.Text;

			long l;
			if (long.TryParse(textBox1.Text, out l))
			{
				objConsumable.ReservationCost = l;
			}

			int selectedIndex = subCategoryComboBox.SelectedIndex;
			Object selectedItem = subCategoryComboBox.SelectedItem;
			string test = subCategoryComboBox.Text;
		   /* MessageBox.Show("Selected Item Text: " + test + "\n" +
							 "Index: " + selectedIndex.ToString());*/


			ItemState state = _itemsEntity.ItemStates.First();
			objConsumable.ItemState = state;

			ItemFunctionalCategory functionalCategory = _itemsEntity.ItemFunctionalCategories.FirstOrDefault( o => o.Name == subCategoryComboBox.Text );
			functionalCategory.Name = subCategoryComboBox.Text;
			objConsumable.ItemFunctionalCategory = functionalCategory;

			ItemCategory category = _itemsEntity.ItemCategories.FirstOrDefault(o => o.Name == mainCategoryComboBox.Text);
			category.Name = mainCategoryComboBox.Text;
			objConsumable.ItemFunctionalCategory.ItemCategory = category;


			Invoice invoice = _invoiceEntity.Invoices.First();
			objConsumable.RelatedInvoice = invoice.Id;

			_itemsEntity.Items.Add(objConsumable);
			_itemsEntity.SaveChanges();
			_itemsEntity.Items.Load();

			this.Close();
			new ConsumablesView().Show();

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void subCategoryComboBox_Click(object sender, EventArgs e)
		{
			_itemsEntity = new ItemsEntity();
			_itemsEntity.ItemFunctionalCategories.Load();

			subCategoryComboBox.DataSource = _itemsEntity.ItemFunctionalCategories.Local.ToBindingList();
			subCategoryComboBox.ValueMember = "id";
			subCategoryComboBox.DisplayMember = "name";
		}

		private void mainCategoryComboBox_Click(object sender, EventArgs e)
		{
			_itemsEntity = new ItemsEntity();
			_itemsEntity.ItemCategories.Load();

			mainCategoryComboBox.DataSource = _itemsEntity.ItemCategories.Local.ToBindingList();
			mainCategoryComboBox.ValueMember = "id";
			mainCategoryComboBox.DisplayMember = "name";
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
			new ConsumablesView().Show();
		}

		private void consumablessubcategoriesBindingSource_CurrentChanged( object sender, EventArgs e )
		{

		}

	}
}
