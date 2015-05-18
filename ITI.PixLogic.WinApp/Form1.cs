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
	public partial class Form1 : Form
	{
        pldb_entities ple;
		public Form1()
		{
			InitializeComponent();
            Form1_Load();
            
		}
        private void Form1_Load()
        {
            ple = new pldb_entities();
            ple.consumables.Load();
            consumableBindingSource.DataSource = ple.consumables.Local.ToBindingList();
        }
       
	}
}
