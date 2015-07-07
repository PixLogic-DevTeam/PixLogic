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
            Account objAccount = new Account( );

			objAccount.FirstName = textBox_firstName.Text;
			objAccount.LastName = textBox_lastName.Text.ToUpper();
			objAccount.Email = textBoxMail.Text;
			objAccount.Phone = textBoxPhone.Text;
			objAccount.Adress = richTextBoxAdress.Text;
			objAccount.Historic = richTextBoxHistoric.Text;
			objAccount.Wallet = Convert.ToInt32(textBoxWallet.Text);
			objAccount.PermissionLevel = Convert.ToString(comboBoxState.SelectedText);
			objAccount.PortraitPath = null;
         
			AccountDivision div = _accountsEntity.AccountDivisions.FirstOrDefault(o => o.Name == UserCategoryComboBox.Text);
			objAccount.AccountDivision = div;

			AccountCategory cat = _accountsEntity.AccountCategories.FirstOrDefault(o => o.Name == MainCategoryComboBox.Text);
			objAccount.AccountDivision.AccountCategory = cat;

			_accountsEntity.Accounts.Add(objAccount);
			_accountsEntity.SaveChanges();

			this.Close();
			new AccountsView().Show();
		}

		private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
		{

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
			_accountsEntity.AccountDivisions.Load();
			UserCategoryComboBox.DataSource = _accountsEntity.AccountDivisions.Local.ToBindingList();
			UserCategoryComboBox.ValueMember = "id";
			UserCategoryComboBox.DisplayMember = "name";
		}

		private void CategoryLabel_Click(object sender, EventArgs e)
		{

		}

		private void MainCategoryComboBox_Click(object sender, EventArgs e)
		{
			_accountsEntity.AccountCategories.Load();
            MainCategoryComboBox.DataSource = _accountsEntity.AccountCategories.Local.ToBindingList( );
			MainCategoryComboBox.ValueMember = "id";
			MainCategoryComboBox.DisplayMember = "name";
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			new AccountsView().Show();
			this.Close();
		}

		private void labelHistoric_Click( object sender, EventArgs e )
		{

		}

		private void textBoxPhone_TextChanged( object sender, EventArgs e )
		{
			int valeur;
			bool isInteger = int.TryParse( textBoxWallet.Text, out valeur );
			var result = isInteger.ToString();
			if( result == "False" && textBoxWallet.TextLength != 0 )
			{
				MessageBox.Show( "Tapez uniquement des chiffres." );
				textBoxWallet.Text = "";
			}
		}
	}
}
