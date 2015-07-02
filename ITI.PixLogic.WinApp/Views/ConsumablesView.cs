//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
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

namespace ITI.PixLogic.WinApp.Views
{
    public partial class ConsumablesView : Form
    {
        ItemsEntity _itemsEntity;

        public ConsumablesView()
        {
            InitializeComponent();
            test_Load();
        }
        private void test_Load()
        {
            
            _itemsEntity = new ItemsEntity();
            _itemsEntity.Items.Load();
            itemsBindingSource.DataSource= _itemsEntity.Items.Local.ToBindingList();
        }

        private void AddButton_Click( object sender, EventArgs e )
        {
            AddConsumableView ACV = new AddConsumableView();
            ACV.Show();
        }

       
    }
}
