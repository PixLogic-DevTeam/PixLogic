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

namespace ITI.PixLogic.WinApp
{
    public partial class Consumable_table : Form
    {

        pldb_entities ple;
        public Consumable_table()
        {
            InitializeComponent();
            Form1_Load();

        }

        private void Form1_Load()
        {

            ple = new pldb_entities();
            ple.consumables.Load();
            consumablesBindingSource.DataSource = ple.consumables.Local.ToBindingList();
        }

        private void Clear_datagridview_Click(object sender, EventArgs e)
        {

            if (consumablesdataGridView.SelectedRows.Count == 0 || consumablesdataGridView.SelectedRows.Contains(consumablesdataGridView.Rows[consumablesdataGridView.RowCount - 1]))
            {
                MessageBox.Show("Veuillez selectionner une ligne a supprimer");
            }

            else
            {
                var toBeDeleted = (long)consumablesdataGridView.SelectedRows[0].Cells[0].Value;
                var consumableData = ple.consumables.First(c => c.id == toBeDeleted);
                ple.consumables.Remove(consumableData);
                ple.SaveChanges();
                ple.consumables.Load();
                consumablesdataGridView.DataSource = ple.consumables.Local.ToBindingList();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddConsumableForm().Show();
            this.Close();

        }

        private void consumablesBindingSource_CurrentChanged( object sender, EventArgs e )
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Home().Show();
        }

    }
}
