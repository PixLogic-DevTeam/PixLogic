using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.PixLogic.DAL.Contexts.Accounts;
using System.Data.Entity;

namespace ITI.PixLogic.WinApp.Views
{
	public partial class MatérielView : Form
	{
		public MatérielView()
		{
			InitializeComponent();
		}

		private void comboBoxItem_SelectedIndexChanged( object sender, EventArgs e )
		{
		}

		private void MatérielView_Load( object sender, EventArgs e )
		{

			AccountsEntity _accoutsEntity = new AccountsEntity();
			_accoutsEntity.Accounts.Load();

			List<string> _nameList = new List<string>();

			foreach( Account a in _accoutsEntity.Accounts )
			{
				_nameList.Add( a.FirstName + a.LastName );
			}

			comboBoxItem.DataSource = _nameList;
		}
	}
}
