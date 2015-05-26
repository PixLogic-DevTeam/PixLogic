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

namespace ITI.PixLogic.WinApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void users_account_button_Click(object sender, System.EventArgs e)
        {
            new Accounts().Show();
            this.Hide();
        }

        private void consumable_button_Click(object sender, System.EventArgs e)
        {
            new Consumable_table().Show();
            this.Hide();
        }

        private void CapitalizedBtn_Click( object sender, EventArgs e )
        {
            new Capitalized( ).Show( );
            this.Hide( );
        }
    }
}
