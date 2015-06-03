using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;
using System.Data.SqlClient;
using ITI.PixLogic.DAL;

namespace ITI.PixLogic.WinApp
{
    public partial class Home : Form
    {
        pldb_entities ple = new pldb_entities();
        public Home()
        {
            InitializeComponent();
        }


        private void users_account_button_Click(object sender, System.EventArgs e)
        {
            new Accounts().Show();
            this.Hide();
        }

        private void consumable_button_Click(object sender, System.EventArgs e)
        {
            new Consumable_table().Show();
            this.Hide();
        }

        private void CapitalizedBtn_Click(object sender, EventArgs e)
        {
            new Capitalized().Show();
            this.Hide();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "CSV files (*.csv) | *.csv | All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            
                            var reader = new StreamReader(File.OpenRead(openFileDialog.FileName));
                            List<string> listA = new List<string>();

                            reader.ReadLine();
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(',');

                                listA.Add(values[0]);
                                listA.Add(values[1]);
                            }
                            foreach (string val in listA)
                            {
                                MessageBox.Show(val);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
