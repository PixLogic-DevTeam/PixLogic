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
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
	public partial class ModifyAccountView : Form
	{
		AccountsEntity _accountsEntity = new AccountsEntity();
		Account _account;

		public ModifyAccountView()
		{
			InitializeComponent();
		}

		public ModifyAccountView(Account a)
		{
			_account = a;
			InitializeComponent();
		}

		private void textBox_firstName_TextChanged(object sender, EventArgs e)
		{
		}

		private void ModifyAccountView_Load( object sender, EventArgs e )
		{
			textBox_firstName.Text = _account.FirstName;
			textBox_lastName.Text = _account.LastName;
			textBoxMail.Text = _account.Email;
			textBoxWallet.Text = Convert.ToString(_account.Wallet);
			comboBoxState.SelectedText = _account.PermissionLevel;
			textBoxPhone.Text = _account.Phone;
			richTextBoxAdress.Text = _account.Adress;
			richTextBoxHistoric.Text = _account.Historic;
			UserCategoryComboBox.Text = _account.AccountDivision.Name;
			MainCategoryComboBox.Text = _account.AccountDivision.AccountCategory.Name;
		}

		private void buttonBack_Click( object sender, EventArgs e )
		{
			this.Close();
			new AccountsView().Show();
		}

		private void MainCategoryComboBox_Click( object sender, EventArgs e )
		{
			_accountsEntity.AccountCategories.Load();
			MainCategoryComboBox.DataSource = _accountsEntity.AccountCategories.Local.ToBindingList();
			MainCategoryComboBox.ValueMember = "id";
			MainCategoryComboBox.DisplayMember = "name";
		}

		private void UserCategoryComboBox_Click( object sender, EventArgs e )
		{
			_accountsEntity.AccountDivisions.Load();
			UserCategoryComboBox.DataSource = _accountsEntity.AccountDivisions.Local.ToBindingList();
			UserCategoryComboBox.ValueMember = "id";
			UserCategoryComboBox.DisplayMember = "name";
		}

		private void button_confirm_Click( object sender, EventArgs e )
		{
			Account a = _accountsEntity.Accounts.FirstOrDefault( o => o.FirstName.Equals(_account.FirstName) );
			a.FirstName = textBox_firstName.Text;
			a.LastName = textBox_lastName.Text;
			a.Email = textBoxMail.Text;
			a.Wallet = Convert.ToInt32(textBoxWallet.Text);
			a.PermissionLevel = comboBoxState.Text;
			a.Phone = textBoxPhone.Text;
			a.Adress = richTextBoxAdress.Text;
			a.Historic = richTextBoxHistoric.Text;
			a.AccountDivision.Name = UserCategoryComboBox.Text;
			a.AccountDivision.AccountCategory.Name = MainCategoryComboBox.Text;

			_accountsEntity.SaveChanges();
		}
	}
}
