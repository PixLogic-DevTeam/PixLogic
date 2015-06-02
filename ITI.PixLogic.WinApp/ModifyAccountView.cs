using ITI.PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.PixLogic.WinApp
{
	public partial class ModifyAccountView : Form
	{
		AccountsEntity _accountsEntity = new AccountsEntity();

		public ModifyAccountView()
		{
			InitializeComponent();
		}

		private void textBox_firstName_TextChanged(object sender, EventArgs e)
		{
			accounts objAccount = new accounts();
			textBox_firstName.Text = objAccount.first_name;
		}

		private void ModifyAccountView_Load( object sender, EventArgs e )
		{

		}
	}
}
