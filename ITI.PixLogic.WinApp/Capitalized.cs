using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITI.PixLogic.DAL;
using System.Data.Entity;

namespace ITI.PixLogic.WinApp
{
    public partial class Capitalized : Form
    {
        pldb_entities ple;

        public Capitalized()
        {
            InitializeComponent( );
            Capitalized_Load( );
        }

        private void Capitalized_Load( )
        {
            ple = new pldb_entities( );
            ple.capitalized.Load( );
            capitalizedBindingSource.DataSource = ple.capitalized.Local.ToBindingList( );
        }

        private void Suppr_Btn_Click( object sender, EventArgs e )
        {

        }
    }
}
