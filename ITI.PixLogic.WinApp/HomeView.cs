﻿using ITI.PixLogic.DAL;
using LumenWorks.Framework.IO.Csv;
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
        AccountsEntity _accountsEntity = new AccountsEntity();
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
                //try
                //{
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

                                accounts user = new accounts();
                                user.first_name = csv[1];
                                user.last_name = csv[2];
                                user.email = csv[3];
                                user.password = csv[4];
                                //user.active = Convert.ToBoolean(csv[5]);
                                user.wallet = Convert.ToInt32(csv[6]);
                                var test = csv[7];
                                accounts_sub_categories asc = _accountsEntity.accounts_sub_categories.FirstOrDefault(o => o.name == test);
                                asc.name = csv[7];
                                user.sub_category = asc.id;
                                user.accounts_sub_categories = asc;

                                var test2 = csv[8];
                                accounts_main_categories amc = _accountsEntity.accounts_main_categories.FirstOrDefault(o => o.name == test2);
                                amc.name = csv[8];

                                user.accounts_sub_categories.accounts_main_categories = amc;

                                _accountsEntity.accounts.Add(user);
                                _accountsEntity.SaveChanges();
                            }
                        }
                    }
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: could not read file from disk (" + ex.Message + ")");
            //}
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

    }
}