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
	public partial class AddAccountView : Form
	{
		AccountsEntity _accountsEntity = new AccountsEntity();

		public AddAccountView()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button_confirm_Click(object sender, EventArgs e)
		{
			accounts objAccount = new accounts();
			objAccount.first_name = textBox_firstName.Text;
			objAccount.last_name = textBox_lastName.Text.ToUpper();
			objAccount.email = textBoxMail.Text;
			objAccount.password = textBoxPassword.Text;
			objAccount.wallet = Convert.ToInt32(textBoxWallet.Text);
			//objAccount.active = Convert.ToBoolean(comboBoxState);

			/*accounts_sub_categories sub = ple.accounts_sub_categories.FirstOrDefault(o => o.name == UserCategoryComboBox.Text);
			Debug.Assert(sub != null);
			sub.name = UserCategoryComboBox.Text;*/
			accounts_sub_categories sub = _accountsEntity.accounts_sub_categories.First();
			objAccount.accounts_sub_categories = sub;

			accounts_main_categories main = _accountsEntity.accounts_main_categories.First();
			objAccount.accounts_sub_categories.accounts_main_categories = main;

			_accountsEntity.accounts.Add(objAccount);
			_accountsEntity.SaveChanges();

			this.Close();
			new AccountsView().Show();
		}

		private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{
			//textBoxPassword.Text = "";
			Convert.ToChar(textBoxPassword.PasswordChar = '*');
		}

		private void textBoxWallet_TextChanged(object sender, EventArgs e)
		{
			int valeur;
			bool isInteger = int.TryParse(textBoxWallet.Text, out valeur);
			var result = isInteger.ToString();
			if (result == "False" && textBoxWallet.TextLength != 0)
			{
				MessageBox.Show("Tapez uniquement des chiffres.");
				textBoxWallet.Text = "";
			}

		}

		private void UserCategoryComboBox_Click(object sender, EventArgs e)
		{
			_accountsEntity.accounts_sub_categories.Load();
			UserCategoryComboBox.DataSource = _accountsEntity.accounts_sub_categories.Local.ToBindingList();
			UserCategoryComboBox.ValueMember = "id";
			UserCategoryComboBox.DisplayMember = "name";
		}

		private void CategoryLabel_Click(object sender, EventArgs e)
		{

		}

		private void MainCategoryComboBox_Click(object sender, EventArgs e)
		{
			_accountsEntity.accounts_main_categories.Load();
			MainCategoryComboBox.DataSource = _accountsEntity.accounts_main_categories.Local.ToBindingList();
			MainCategoryComboBox.ValueMember = "id";
			MainCategoryComboBox.DisplayMember = "name";
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			new AccountsView().Show();
			this.Close();
		}
	}
}
