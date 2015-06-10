﻿using ITI.PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.PixLogic.WinApp
{
	public partial class HomeView : Form
	{
		public HomeView()
		{
			InitializeComponent();
		}
		
		private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Filter = "CSV files (*.csv) | *.csv | All files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog.OpenFile()) != null)
					{
						using (myStream)
						{
							
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: could not read file from disk (" + ex.Message  + ")");
				}
			}
		}

		private void Home_Load( object sender, EventArgs e )
		{
		}

        private void ExitBtn_Click( object sender, EventArgs e )
        {
            Application.Exit( );
        }
	}
}
