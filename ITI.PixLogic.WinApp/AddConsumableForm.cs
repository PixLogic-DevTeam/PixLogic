using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.PixLogic.DAL;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ITI.PixLogic.WinApp
{
    public partial class AddConsumableForm : Form
    {
        pldb_entities ple;

        public AddConsumableForm()
        {
            InitializeComponent();

        }

        private void Add_consumable_button_Click(object sender, EventArgs e)
        {

            ple = new pldb_entities();

            consumables objConsumable = new consumables();
            objConsumable.name = Name_consumable_txt.Text;
            objConsumable.description = Description_consumable_txt.Text;

            long l;
            if (long.TryParse(textBox1.Text, out l))
            {
                objConsumable.reservation_cost = l;
            }
            else
            {

            }

            int selectedIndex = subCategoryComboBox.SelectedIndex;
            Object selectedItem = subCategoryComboBox.SelectedItem;
            string test = subCategoryComboBox.Text;
            MessageBox.Show("Selected Item Text: " + test + "\n" +
                             "Index: " + selectedIndex.ToString());



            consumables_states state = ple.consumables_states.First();
            objConsumable.consumables_states = state;

            consumables_sub_categories sub = ple.consumables_sub_categories.FirstOrDefault(o => o.name == subCategoryComboBox.Text);
            Debug.Assert(sub != null);
            sub.name = subCategoryComboBox.Text;
            objConsumable.consumables_sub_categories = sub;

            consumables_main_categories main = ple.consumables_main_categories.FirstOrDefault(o => o.name == mainCategoryComboBox.Text);
            main.name = mainCategoryComboBox.Text;
            objConsumable.consumables_sub_categories.consumables_main_categories = main;


            invoices invoice = ple.invoices.First();
            objConsumable.invoices = invoice;

            ple.consumables.Add(objConsumable);
            ple.SaveChanges();
            ple.consumables.Load();
            this.Close();
            new Consumable_table().Show();

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
            ple = new pldb_entities();
            ple.consumables_sub_categories.Load();

            subCategoryComboBox.DataSource = ple.consumables_sub_categories.Local.ToBindingList();
            subCategoryComboBox.ValueMember = "id";
            subCategoryComboBox.DisplayMember = "name";
        }

        private void mainCategoryComboBox_Click(object sender, EventArgs e)
        {
            ple = new pldb_entities();
            ple.consumables_main_categories.Load();

            mainCategoryComboBox.DataSource = ple.consumables_main_categories.Local.ToBindingList();
            mainCategoryComboBox.ValueMember = "id";
            mainCategoryComboBox.DisplayMember = "name";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Consumable_table().Show();
        }

    }
}
