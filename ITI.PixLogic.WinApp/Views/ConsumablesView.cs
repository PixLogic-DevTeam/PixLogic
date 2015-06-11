using ITI.PixLogic.DAL;
using ITI.PixLogic.DAL.Contexts.Items;
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
	public partial class ConsumablesView : Form
	{

		ItemsEntity _itemsEntity;

		public ConsumablesView()
		{
			InitializeComponent();
			Form1_Load();

		}

		private void Form1_Load()
		{

			_itemsEntity = new ItemsEntity();
			_itemsEntity.Items.Load();
			consumablesBindingSource.DataSource = _itemsEntity.Items.Local.ToBindingList();
		}

		private void Clear_datagridview_Click(object sender, EventArgs e)
		{

			if (consumablesdataGridView.SelectedRows.Count == 0 || consumablesdataGridView.SelectedRows.Contains(consumablesdataGridView.Rows[consumablesdataGridView.RowCount - 1]))
			{
				MessageBox.Show("Veuillez selectionner une ligne a supprimer");
			}

			else
			{
				var toBeDeleted = (long)consumablesdataGridView.SelectedRows[0].Cells[0].Value;
				var consumableData = _itemsEntity.Items.First(c => c.Id == toBeDeleted);
				_itemsEntity.Items.Remove(consumableData);
				_itemsEntity.SaveChanges();
				_itemsEntity.Items.Load();
				consumablesdataGridView.DataSource = _itemsEntity.Items.Local.ToBindingList();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			new AddConsumableView().Show();
			this.Close();

		}

		private void consumablesBindingSource_CurrentChanged( object sender, EventArgs e )
		{

		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
			new HomeView().Show();
		}

		private void nameLabel_Click( object sender, EventArgs e )
		{

		}

	}
}
