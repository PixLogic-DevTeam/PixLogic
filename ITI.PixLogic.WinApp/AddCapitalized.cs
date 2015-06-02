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
using System.Data.Entity;
using System.Diagnostics;

namespace ITI.PixLogic.WinApp
{
    public partial class AddCapitalized : Form
    {
        pldb_entities ple = new pldb_entities( );

        public string NameTBox { get; set; }

        public string DescriptionRTBox { get; set; }

        public Nullable<long> EAN13
        {
            get 
            {
                Nullable<long> Value = new Nullable<long>( );
                string sEAN = EANTextBox.Text;

                try
                {
                    if ( !string.IsNullOrEmpty( sEAN ) && sEAN.Trim( ).Length > 0 )
                    {
                        TypeConverter conv = TypeDescriptor.GetConverter( typeof( long ) );
                        Value = (long)conv.ConvertFrom( sEAN );
                    }
                }
                catch { }
                return Value;
            }

            set{ EAN13 = value; }

        }

        public capitalized_sub_categories SubCatCBox
        {
            get 
            {
                capitalized_sub_categories subcat = ple.capitalized_sub_categories.FirstOrDefault( o => o.name == SubCatComboBox.Text );
                Debug.Assert( subcat != null );
                subcat.name = SubCatComboBox.Text;
                return subcat;
            }
            set { SubCatCBox = value; }
        }
        
        public AddCapitalized()
        {
            InitializeComponent( );
        }

        private void SubCatComboBox_Click( object sender, EventArgs e )
        {
            
        }

        private void InvoiceComboBox_Click( object sender, EventArgs e )
        {
           
        }

        private void CurrentStateComboBox_Click( object sender, EventArgs e )
        {
            
        }

        private void BackBtn_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            this.Close( );
        }

        private void AddBtn_Click( object sender, EventArgs e )
        {
            capitalized objCapitalized = new capitalized( );
            objCapitalized.name = NameTextBox.Text;
            objCapitalized.description = DescriptionRichTextBox.Text;
            objCapitalized.ean13 = Convert.ToInt64( EANTextBox.Text );
            objCapitalized.reservation_cost = Convert.ToInt64( ResCostTextBox.Text );

            capitalized_sub_categories subcat = ple.capitalized_sub_categories.FirstOrDefault( o => o.name == SubCatComboBox.Text );
            Debug.Assert( subcat != null );
            subcat.name = SubCatComboBox.Text;
            objCapitalized.capitalized_sub_categories = subcat;

            invoices invo = ple.invoices.FirstOrDefault( o => o.description == InvoiceComboBox.Text );
            Debug.Assert( invo != null );
            objCapitalized.invoice = invo.id;

            capitalized_states state = ple.capitalized_states.FirstOrDefault( o => o.name == CurrentStateComboBox.Text );
            Debug.Assert( state != null );
            state.name = CurrentStateComboBox.Text;
            objCapitalized.capitalized_states = state;

            ple.capitalized.Add( objCapitalized );
            ple.SaveChanges();
            DialogResult = DialogResult.OK;
            

            this.Close( );
        }

        private void AddCapitalized_Load( object sender, EventArgs e )
        {
            ple.capitalized_sub_categories.Load( );
            SubCatComboBox.DataSource = ple.capitalized_sub_categories.Local.ToBindingList( );
            SubCatComboBox.ValueMember = "id";
            SubCatComboBox.DisplayMember = "name";
            

            ple.invoices.Load( );
            InvoiceComboBox.DataSource = ple.invoices.Local.ToBindingList( );
            InvoiceComboBox.ValueMember = "id";
            InvoiceComboBox.DisplayMember = "description";

            ple.capitalized_states.Load( );
            CurrentStateComboBox.DataSource = ple.capitalized_states.Local.ToBindingList( );
            CurrentStateComboBox.ValueMember = "id";
            CurrentStateComboBox.DisplayMember = "name";
        }
    }
}
