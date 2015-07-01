using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ITI.PixLogic.DAL.Contexts.Items;


namespace ITI.PixLogic.WinApp.Views
{
	public partial class AddReservationForm : Form
	{
		public AddReservationForm()
		{
			InitializeComponent();
		}

		private void comboBoxItem_SelectedIndexChanged( object sender, EventArgs e )
		{

		}

		private void AddReservationForm_Load( object sender, EventArgs e )
		{
			ItemsEntity _itemEntity = new ItemsEntity();
			_itemEntity.Items.Load();

			List<string> itemName = new List<string>();

			foreach(Item it in _itemEntity.Items.ToList())
			{
				itemName.Add( it.ItemSubCategory.Name );
			}
		}
	}
}
