using ITI.PixLogic.DAL;
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
		ItemsEntity _itemsEntity;
		AccountingEntity _accountingEntity;

		public AddConsumableView()
		{
			InitializeComponent();
		}

		private void Add_consumable_button_Click(object sender, EventArgs e)
		{

			_itemsEntity = new ItemsEntity();
			_accountingEntity = new AccountingEntity();

			consumables objConsumable = new consumables();
			objConsumable.product_reference = Name_consumable_txt.Text;
			objConsumable.description = Description_consumable_txt.Text;

			long l;
			if (long.TryParse(textBox1.Text, out l))
			{
				objConsumable.reservation_cost = l;
			}

			int selectedIndex = subCategoryComboBox.SelectedIndex;
			Object selectedItem = subCategoryComboBox.SelectedItem;
			string test = subCategoryComboBox.Text;
		   /* MessageBox.Show("Selected Item Text: " + test + "\n" +
							 "Index: " + selectedIndex.ToString());*/


			states state = _itemsEntity.states.First();
			objConsumable.states = state;

			consumables_sub_categories sub = _itemsEntity.consumables_sub_categories.FirstOrDefault(o => o.name == subCategoryComboBox.Text);
			sub.name = subCategoryComboBox.Text;
			objConsumable.consumables_sub_categories = sub;

			consumables_main_categories main = _itemsEntity.consumables_main_categories.FirstOrDefault(o => o.name == mainCategoryComboBox.Text);
			main.name = mainCategoryComboBox.Text;
			objConsumable.consumables_sub_categories.consumables_main_categories = main;


			invoices invoice = _accountingEntity.invoices.First();
			objConsumable.invoice = invoice.id;

			_itemsEntity.consumables.Add(objConsumable);
			_itemsEntity.SaveChanges();
			_itemsEntity.consumables.Load();

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
			_itemsEntity.consumables_sub_categories.Load();

			subCategoryComboBox.DataSource = _itemsEntity.consumables_sub_categories.Local.ToBindingList();
			subCategoryComboBox.ValueMember = "id";
			subCategoryComboBox.DisplayMember = "name";
		}

		private void mainCategoryComboBox_Click(object sender, EventArgs e)
		{
			_itemsEntity = new ItemsEntity();
			_itemsEntity.consumables_main_categories.Load();

			mainCategoryComboBox.DataSource = _itemsEntity.consumables_main_categories.Local.ToBindingList();
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
