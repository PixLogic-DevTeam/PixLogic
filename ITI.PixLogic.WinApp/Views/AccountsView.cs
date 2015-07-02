﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
    public partial class AccountsView : Form
    {
		AccountsEntity _accountsEntity = new AccountsEntity();
        public AccountsView()
        {
            InitializeComponent();
            Accounts_Load();
        }

        private void Accounts_Load()
        {
            _accountsEntity.Accounts.Load();
			dataListView1.DataSource = _accountsEntity.Accounts.Local.ToBindingList();
			for( int j=0; j < 6; j++ )
			{
				dataListView1.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.ColumnContent );
				dataListView1.AutoResizeColumn( j, ColumnHeaderAutoResizeStyle.HeaderSize );
			}
			for( int k =8; k < dataListView1.Columns.Count - 1; k++ )
			{
				dataListView1.AutoResizeColumn( k, ColumnHeaderAutoResizeStyle.ColumnContent );
				dataListView1.AutoResizeColumn( k, ColumnHeaderAutoResizeStyle.HeaderSize );
			}
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            this.Validate();

            // Save the changes to the database. 
            this._accountsEntity.SaveChanges();

            // Refresh the controls to show the values          
            // that were generated by the database. 
            this.dataGridViewUsers.Refresh();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            new HomeView().Show();
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            new AddAccountView().Show();
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0 || dataGridViewUsers.SelectedRows.Contains(dataGridViewUsers.Rows[dataGridViewUsers.RowCount - 1]))
            //if (consumablesdataGridView.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Veuillez selectionner une ligne a supprimer");
            }

            else
            {
                var toBeDeleted = (long)dataGridViewUsers.SelectedRows[0].Cells[0].Value;
                var UserData = _accountsEntity.Accounts.First(c => c.Id == toBeDeleted);
                _accountsEntity.Accounts.Remove(UserData);
                _accountsEntity.SaveChanges();
                _accountsEntity.Accounts.Load();
                dataGridViewUsers.DataSource = _accountsEntity.Accounts.Local.ToBindingList();
                
            }          
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            /*var toBeModify = (long)dataGridViewUsers.SelectedRows[0].Cells[0].Value;
            var UserData = ple.accounts.First(c => c.id == toBeModify);*/
            new ModifyAccountView().Show();
            this.Close();
        }
    }
}
