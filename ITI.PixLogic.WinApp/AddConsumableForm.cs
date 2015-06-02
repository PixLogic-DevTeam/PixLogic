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
            if (Name_consumable_txt.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner un nom de consommable");
            }
            else
            {
                objConsumable.name = Name_consumable_txt.Text;
            }
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



            consumables_states state = ple.consumables_states.FirstOrDefault(o => o.name == stateComboBox.Text);
            
            if (stateComboBox.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner l'état du consommable à ajouter");
            }
            else
            {
                state.name = stateComboBox.Text;
                objConsumable.consumables_states = state;
            }

            consumables_sub_categories sub = ple.consumables_sub_categories.FirstOrDefault(o => o.name == subCategoryComboBox.Text);
         
            if (subCategoryComboBox.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner une sous-catégorie à votre consommable");
            }
            else
            {
                sub.name = subCategoryComboBox.Text;
                objConsumable.consumables_sub_categories = sub;
            }
            
            consumables_main_categories main = ple.consumables_main_categories.FirstOrDefault(o => o.name == mainCategoryComboBox.Text);
           
            if (mainCategoryComboBox.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner un catégorie principale à votre consommable");
            }
            else
            {
                main.name = mainCategoryComboBox.Text;
                objConsumable.consumables_sub_categories.consumables_main_categories = main;
            }

            invoices invoice = ple.invoices.First();
            objConsumable.invoices = invoice;
            
                ple.consumables.Add(objConsumable);
                ple.SaveChanges();
                ple.consumables.Load();
           
            this.Close();
            
            
            
            

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

        private void stateComboBox_Click(object sender, EventArgs e)
        {
            ple = new pldb_entities();
            ple.consumables_states.Load();

            stateComboBox.DataSource = ple.consumables_states.Local.ToBindingList();
            stateComboBox.ValueMember = "id";
            stateComboBox.DisplayMember = "name";
        }

       


    }
}
