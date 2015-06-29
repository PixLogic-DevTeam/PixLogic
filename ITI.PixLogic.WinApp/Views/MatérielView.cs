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
using ITI.PixLogic.DAL.Contexts.Items;

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
			ItemsEntity _itemsEntity = new ItemsEntity();
			_itemsEntity.ItemSubCategories.Load();

			List<string> _nameList = new List<string>();

			foreach( Item a in _itemsEntity.Items )
			{
				_nameList.Add( a.ItemSubCategory.Name);
			}

			comboBoxItem.DataSource = _nameList;
		}
	}
}
