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

			ItemSubCategory sub = _itemsEntity.ItemSubCategories.FirstOrDefault(o => o.Name == subCategoryComboBox.Text);
			sub.Name = subCategoryComboBox.Text;
			objConsumable.ItemSubCategory = sub;

			ItemMainCategory main = _itemsEntity.ItemMainCategories.FirstOrDefault(o => o.Name == mainCategoryComboBox.Text);
			main.Name = mainCategoryComboBox.Text;
			objConsumable.ItemSubCategory.ItemMainCategory = main;


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
			_itemsEntity.ItemSubCategories.Load();

			subCategoryComboBox.DataSource = _itemsEntity.ItemSubCategories.Local.ToBindingList();
			subCategoryComboBox.ValueMember = "id";
			subCategoryComboBox.DisplayMember = "name";
		}

		private void mainCategoryComboBox_Click(object sender, EventArgs e)
		{
			_itemsEntity = new ItemsEntity();
			_itemsEntity.ItemMainCategories.Load();

			mainCategoryComboBox.DataSource = _itemsEntity.ItemMainCategories.Local.ToBindingList();
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
