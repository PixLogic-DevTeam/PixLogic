﻿using ITI.PixLogic.DAL;
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
        public AddCapitalized()
        {
            InitializeComponent( );
        }

        private void SubCatComboBox_Click( object sender, EventArgs e )
        {
            ple.capitalized_sub_categories.Load( );
            SubCatComboBox.DataSource = ple.capitalized_sub_categories.Local.ToBindingList( );
            SubCatComboBox.ValueMember = "id";
            SubCatComboBox.DisplayMember = "name";
        }

        private void InvoiceComboBox_Click( object sender, EventArgs e )
        {
            //ple.invoices.Load( );
            //InvoiceComboBox.DataSource = ple.invoices.Local.ToBindingList( );
            //InvoiceComboBox.ValueMember = "id";
            //InvoiceComboBox.DisplayMember = "description";
        }

        private void CurrentStateComboBox_Click( object sender, EventArgs e )
        {
            ple.capitalized_states.Load( );
            CurrentStateComboBox.DataSource = ple.capitalized_states.Local.ToBindingList( );
            CurrentStateComboBox.ValueMember = "id";
            CurrentStateComboBox.DisplayMember = "name";
        }

        private void BackBtn_Click( object sender, EventArgs e )
        {
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

            capitalized_states state = ple.capitalized_states.FirstOrDefault( o => o.name == CurrentStateComboBox.Text );
            Debug.Assert( state != null );
            state.name = CurrentStateComboBox.Text;
            objCapitalized.capitalized_states = state;

            ple.capitalized.Add( objCapitalized );
            ple.SaveChanges();

            

            this.Close( );
        }
    }
}
