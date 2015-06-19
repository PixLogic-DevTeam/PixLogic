using ITI.PixLogic.DAL.Contexts.Accounts;
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
	public partial class ModifyAccountView : Form
	{
		AccountsEntity _invoiceEntity = new AccountsEntity();

		public ModifyAccountView()
		{
			InitializeComponent();
		}

		private void textBox_firstName_TextChanged(object sender, EventArgs e)
		{
			Account objAccount = new Account();
			textBox_firstName.Text = objAccount.FirstName;
		}

		private void ModifyAccountView_Load( object sender, EventArgs e )
		{

		}
	}
}
