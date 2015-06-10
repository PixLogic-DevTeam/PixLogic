﻿using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.PixLogic.WinApp
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void users_account_button_Click(object sender, System.EventArgs e)
        {
            new AccountsView().Show();
            this.Hide();
        }

        private void consumable_button_Click(object sender, System.EventArgs e)
        {
            new ConsumablesView().Show();
            this.Hide();
        }

        private void CapitalizedBtn_Click(object sender, EventArgs e)
        {
            new CapitalizedView().Show();
            this.Hide();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
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
                            // open the file openFileDialog.FileName which is a CSV file with headers
                            using (CsvReader csv =
                                   new CsvReader(new StreamReader(openFileDialog.FileName), true))
                            {
                                int fieldCount = csv.FieldCount;

                                string[] headers = csv.GetFieldHeaders();
                                while (csv.ReadNextRecord())
                                {
                                    for (int i = 0; i < fieldCount; i++) MessageBox.Show(string.Format("{0} = {1};", headers[i], csv[i]));                                                    
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: could not read file from disk (" + ex.Message + ")");
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

    }
}