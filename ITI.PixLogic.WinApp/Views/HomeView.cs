using ITI.PixLogic.DAL;
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
using ITI.PixLogic.BLL;
using ITI.PixLogic.DAL.Contexts.Items;
using System.Windows.Forms.DataVisualization.Charting;

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
            /*
             * Idée de statistique:
             * -Objet le plus utilisé
             * -Dernière réservations
             * -Réservation se terminant bientot
             */

            //Account Pie chart feeding
            DataPoint _activeAccountsDP = new DataPoint( );
            _activeAccountsDP.SetValueY( StatsService.GetNumberOfActiveAccount( ) );
            _activeAccountsDP.LegendText = "Comptes actifs";

            DataPoint _bannedAccountsDP = new DataPoint( );
            _bannedAccountsDP.SetValueY( StatsService.GetNumberOfBannedAccount( ) );
            _bannedAccountsDP.LegendText = "Comptes Suspendus";

            AccountCharts.Series[ 0 ].Points.Clear( );
            AccountCharts.Series[ 0 ].Points.Add( _activeAccountsDP );
            AccountCharts.Series[ 0 ].Points.Add( _bannedAccountsDP );

            //Item Pie chart feeding
            DataPoint _consummableDP = new DataPoint( );
            _consummableDP.SetValueY( StatsService.GetNumberOfConsummableItems() );
            _consummableDP.Color = Color.Red;
            _consummableDP.LegendText = "Consommable";

            DataPoint _reservableDP = new DataPoint( );
            _reservableDP.SetValueY( StatsService.GetNumberOfReservableItems( ) );
            _reservableDP.Color = Color.LightBlue;
            _reservableDP.LegendText = "Réservable";

            ItemsCharts.Series[ 0 ].Points.Clear( );
            ItemsCharts.Series[ 0 ].Points.Add( _consummableDP );
            ItemsCharts.Series[ 0 ].Points.Add( _reservableDP );

            //General stats feeding
            AmmountofItemsNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfItems( ) );
            ReservationAmmountNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfReservationEvent( ) );
            AmmountOfPackNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfPack( ) );
            AmmountOfInvoicesNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfInvoices( ) );

            //DataListView Feeding
            var query = 
		}

        private void ExitBtn_Click( object sender, EventArgs e )
        {
            Application.Exit( );
        }

        private void CapitalizedBtn_Click( object sender, EventArgs e )
        {
            new CapitalizedView( ).Show( );
            this.Hide( );
        }

        private void consumable_button_Click( object sender, EventArgs e )
        {
            new ConsumablesView( ).Show( );
            this.Hide( );
        }

        private void users_account_button_Click( object sender, EventArgs e )
        {
            new AccountsView( ).Show( );
            this.Hide( );
        }
	}
}
