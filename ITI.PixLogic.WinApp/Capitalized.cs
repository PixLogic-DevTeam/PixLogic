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
            if ( CapitalizedGridView.SelectedRows.Count == 0 || CapitalizedGridView.SelectedRows.Contains( CapitalizedGridView.Rows[ CapitalizedGridView.RowCount - 1 ] ) )
            {
                MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
            }

            else
            {
                var toBeDeleted = (long)CapitalizedGridView.SelectedRows[ 0 ].Cells[ 0 ].Value;
                var consumableData = ple.consumables.First( c => c.id == toBeDeleted );
                ple.consumables.Remove( consumableData );
                ple.SaveChanges( );
                ple.consumables.Load( );
                CapitalizedGridView.DataSource = ple.consumables.Local.ToBindingList( );
            }
        }

        private void Add_Btn_Click( object sender, EventArgs e )
        {
            new AddCapitalized( ).Show( );

            using( AddCapitalized addCapForm = new AddCapitalized() )
            {
                
            }
        }

        private void EditBtn_Click( object sender, EventArgs e )
        {
            new AddCapitalized( ).Show( );


            if ( CapitalizedGridView.SelectedRows.Count == 0 || CapitalizedGridView.SelectedRows.Contains( CapitalizedGridView.Rows[ CapitalizedGridView.RowCount - 1 ] ) )
            {
                MessageBox.Show( "Veuillez selectionner une ligne a supprimer" );
            }
            else 
            {
                capitalized SelectedCapitalized = CapitalizedGridView.SelectedRows[ 0 ].DataBoundItem as capitalized;

                using ( AddCapitalized EditCapForm = new AddCapitalized( ) )
                {
                    EditCapForm.NameTBox = SelectedCapitalized.name;
                    EditCapForm.DescriptionRTBox = SelectedCapitalized.description;
                    EditCapForm.EAN13 = Convert.ToInt64( SelectedCapitalized.ean13 );
                }
            }
            
        }
    }
}
