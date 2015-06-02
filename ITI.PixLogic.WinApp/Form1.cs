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

        public void Form1_Load()
        {

            ple = new pldb_entities();

            var query = from c in ple.consumables
                        join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
                        join s in ple.consumables_states on c.current_state equals s.id
                        orderby c.id
                        select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

            var cons = query.ToList();
            dataGridView1.DataSource = cons;
            consumablesdataGridView.Visible = false;

        }

        public void Clear_datagridview_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez selectionner une ligne a supprimer");
            }


            else
            {
                var toBeDeleted = (long)dataGridView1.SelectedRows[0].Cells[0].Value;
                var consumableData = ple.consumables.First(c => c.id == toBeDeleted);
                ple.consumables.Remove(consumableData);
                ple.SaveChanges();
                ple = new pldb_entities();

                var query = from c in ple.consumables
                            join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
                            join s in ple.consumables_states on c.current_state equals s.id
                            orderby c.id
                            select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

                var cons = query.ToList();
                dataGridView1.DataSource = cons;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddConsumableForm ACF = new AddConsumableForm();
            ACF.Show();

        }

        private void Consumable_table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pixlogic_dbDataSet.consumables_main_categories' table. You can move, or remove it, as needed.
            this.consumables_main_categoriesTableAdapter.Fill(this.pixlogic_dbDataSet.consumables_main_categories);
            // TODO: This line of code loads data into the 'pixlogic_dbDataSet.consumables_sub_categories' table. You can move, or remove it, as needed.
            this.consumables_sub_categoriesTableAdapter.Fill(this.pixlogic_dbDataSet.consumables_sub_categories);
            // TODO: This line of code loads data into the 'pixlogic_dbDataSet.consumables' table. You can move, or remove it, as needed.
            this.consumablesTableAdapter.Fill(this.pixlogic_dbDataSet.consumables);

        }

        //private void reservationCostCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (reservationCostCheckBox.Checked == true)
        //    {
        //        if (consumableNameCheckBox.Checked == true)
        //        {
        //            ple = new pldb_entities();

        //            var query = from c in ple.consumables
        //                        join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
        //                        join s in ple.consumables_states on c.current_state equals s.id
        //                        orderby c.sub_category, c.reservation_cost

        //                        select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

        //            var cons = query.ToList();
        //            dataGridView1.DataSource = cons;
        //        }
        //        else
        //        {
        //            ple = new pldb_entities();
        //            var query = from c in ple.consumables
        //                        join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
        //                        join s in ple.consumables_states on c.current_state equals s.id
        //                        orderby c.reservation_cost
        //                        select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };
        //            var cons = query.ToList();
        //            dataGridView1.DataSource = cons;
        //        }

        //    }

        //    else
        //    {
        //        ple = new pldb_entities();

        //        var query = from c in ple.consumables
        //                    join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
        //                    join s in ple.consumables_states on c.current_state equals s.id
        //                    orderby c.id
        //                    select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

        //        var cons = query.ToList();
        //        dataGridView1.DataSource = cons;
        //    }

        //}

        //private void consumableNameCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (consumableNameCheckBox.Checked == true)
        //    {
        //        ple = new pldb_entities();
        //        var query = from c in ple.consumables
        //                    join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
        //                    join s in ple.consumables_states on c.current_state equals s.id
        //                    orderby c.name
        //                    select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };
        //        var cons = query.ToList();
        //        dataGridView1.DataSource = cons;
        //    }

        //    else if (consumableNameCheckBox.Checked == true && reservationCostCheckBox.Checked == true)
        //    {
        //        ple = new pldb_entities();

        //        var query = from c in ple.consumables
        //                    join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
        //                    join s in ple.consumables_states on c.current_state equals s.id
        //                    orderby c.name , c.reservation_cost

        //                    select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

        //        var cons = query.ToList();
        //        dataGridView1.DataSource = cons;
        //    }


        //    else
        //    {
        //        ple = new pldb_entities();

        //        var query = from c in ple.consumables
        //                    join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
        //                    join s in ple.consumables_states on c.current_state equals s.id
        //                    orderby c.id
        //                    select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

        //        var cons = query.ToList();
        //        dataGridView1.DataSource = cons;
        //    }
        //}

        private void SortConsumablesButton_Click(object sender, EventArgs e)
        {
            if (reservationCostCheckBox.Checked == true)
            {
                if (consumableNameCheckBox.Checked == true)
                {
                    ple = new pldb_entities();

                    var query = from c in ple.consumables
                                join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
                                join s in ple.consumables_states on c.current_state equals s.id
                                orderby c.sub_category, c.reservation_cost

                                select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

                    var cons = query.ToList();
                    dataGridView1.DataSource = cons;
                }
            }
            else
            {
                ple = new pldb_entities();

                var query = from c in ple.consumables
                            join sub in ple.consumables_sub_categories on c.sub_category equals sub.id
                            join s in ple.consumables_states on c.current_state equals s.id
                            orderby c.id

                            select new ConsumAndSubcategoriesAndMaincategories { consumables = c, sub_categories = sub, state = s };

                var cons = query.ToList();
                dataGridView1.DataSource = cons;
            }

        }
    }
}
