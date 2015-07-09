using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LumenWorks.Framework.IO.Csv;
using ITI.PixLogic.WinApp.Views;
using ITI.PixLogic.BLL;
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.WinApp
{
	public partial class HomeView : Form
	{
		AccountsEntity _accountsEntity = new AccountsEntity();
		EventsEntity _reservationsEntity = new EventsEntity();
		ItemsEntity _itemsEntity = new ItemsEntity();
		PacksEntity _packsEntity = new PacksEntity();
		InvoicesEntity _invoicesEntity = new InvoicesEntity();

		public HomeView()
		{
			InitializeComponent();
		}

		#region Imports CSV
		private void utilisateursToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			int fieldCount = 0, rowCount = 0, importCount = 0;

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.RestoreDirectory = true;

			if( openFileDialog.ShowDialog() == DialogResult.OK )
			{
				if( (myStream = openFileDialog.OpenFile()) != null )
				{
					using( myStream )
					{
						// open the file openFileDialog.FileName which is a CSV file with headers
						using( CsvReader csv = new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
						{
							fieldCount = csv.FieldCount;

							string[] headers = csv.GetFieldHeaders();
							while( csv.ReadNextRecord() )
							{
								Account user = new Account();

								for( int i = 0; i < fieldCount; i++ )
									string.Format( "{0} = {1};", headers[i], csv[i] );

								user.FirstName = csv[1];
								user.LastName = csv[2];
								user.Email = csv[3];
								user.Phone = csv[4];
								user.Adress = csv[5];
								user.Historic = csv[6];
								user.Wallet = Convert.ToInt32( csv[7] );
								user.PermissionLevel = csv[8];
								user.PortraitPath = csv[9];

								string strDiv = csv[10];
								AccountDivision div = _accountsEntity.AccountDivisions.FirstOrDefault( o => o.Name == strDiv );
								user.Division = div.Id;
								user.AccountDivision = div;

								string strCat = csv[11];
								AccountCategory cat = _accountsEntity.AccountCategories.FirstOrDefault( o => o.Name == strCat );
								user.AccountDivision.AccountCategory = cat;

								if( _accountsEntity.Accounts.FirstOrDefault<Account>( u => u.Email == user.Email ) != null )
									MessageBox.Show( "Erreur : l'entrée n°" + user.Id + " n'as pas pu être inséré car l'email \"" + user.Email + "\" est déjà utilisé." );
								else
								{
									_accountsEntity.Accounts.Add( user );
									_accountsEntity.SaveChanges();
									importCount++;
								}
								rowCount++;
							}
							MessageBox.Show( importCount + " comptes sur " + rowCount + " ont été importé dans la base de données." );
						}
					}
				}
			}
		}

		private void packsToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			int fieldCount = 0, rowCount = 0, importCount = 0;

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.RestoreDirectory = true;

			if( openFileDialog.ShowDialog() == DialogResult.OK )
			{
				if( (myStream = openFileDialog.OpenFile()) != null )
				{
					using( myStream )
					{
						// open the file openFileDialog.FileName which is a CSV file with headers
						using( CsvReader csv = new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
						{
							fieldCount = csv.FieldCount;

							string[] headers = csv.GetFieldHeaders();
							while( csv.ReadNextRecord() )
							{
								Pack pack = new Pack();

								for( int i = 0; i < fieldCount; i++ )
									string.Format( "{0} = {1};", headers[i], csv[i] );

								pack.Name = csv[1];
								pack.Description = csv[2];

								if( _packsEntity.Packs.FirstOrDefault<Pack>( u => u.Name == pack.Name ) != null )
									MessageBox.Show( "Erreur : l'entrée n°" + pack.Id + " n'as pas pu être inséré car ce pack du nom \"" + pack.Name + "\" existe déjà." );
								else
								{
									_packsEntity.Packs.Add( pack );
									_packsEntity.SaveChanges();
									importCount++;
								}
								rowCount++;
							}
							MessageBox.Show( importCount + " packs sur " + rowCount + " ont été importé dans la base de données." );
						}
					}
				}
			}
		}

		private void facturesToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			int fieldCount = 0, rowCount = 0, importCount = 0;

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.RestoreDirectory = true;

			if( openFileDialog.ShowDialog() == DialogResult.OK )
			{
				if( (myStream = openFileDialog.OpenFile()) != null )
				{
					using( myStream )
					{
						// open the file openFileDialog.FileName which is a CSV file with headers
						using( CsvReader csv = new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
						{
							fieldCount = csv.FieldCount;

							string[] headers = csv.GetFieldHeaders();
							while( csv.ReadNextRecord() )
							{
								Invoice invoices = new Invoice();

								for( int i = 0; i < fieldCount; i++ )
									string.Format( "{0} = {1};", headers[i], csv[i] );

								invoices.PhaseNumber = Convert.ToInt32( csv[1] );
								invoices.PurchaseDate = Convert.ToDateTime( csv[2] );
								invoices.PurchaseCost = Convert.ToInt32( csv[3] );
								invoices.Depreciation = Convert.ToInt32( csv[4] );
								invoices.Indication = csv[5];
								invoices.ScanPath = csv[6];

								string strDiv = csv[7];
								Company div = _invoicesEntity.Companies.FirstOrDefault( o => o.Name == strDiv );
								invoices.Provider = div.Id;

								if( _invoicesEntity.Invoices.FirstOrDefault<Invoice>( u => u.PhaseNumber == invoices.PhaseNumber ) != null )
									MessageBox.Show( "Erreur : l'entrée n°" + invoices.Id + " n'as pas pu être inséré car le numéro \"" + invoices.PhaseNumber + "\" est déjà utilisé." );
								else
								{
									_invoicesEntity.Invoices.Add( invoices );
									_invoicesEntity.SaveChanges();
									importCount++;
								}
								rowCount++;
							}
							MessageBox.Show( importCount + " factures sur " + rowCount + " ont été importé dans la base de données." );
						}
					}
				}
			}
		}

		private void objetsToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			int fieldCount = 0, rowCount = 0, importCount = 0;

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.RestoreDirectory = true;

			if( openFileDialog.ShowDialog() == DialogResult.OK )
			{
				if( (myStream = openFileDialog.OpenFile()) != null )
				{
					using( myStream )
					{
						// open the file openFileDialog.FileName which is a CSV file with headers
						using( CsvReader csv = new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
						{
							fieldCount = csv.FieldCount;

							string[] headers = csv.GetFieldHeaders();
							while( csv.ReadNextRecord() )
							{
								Item item = new Item();

								for( int i = 0; i < fieldCount; i++ )
									string.Format( "{0} = {1};", headers[i], csv[i] );

								item.EAN13 = Convert.ToInt32(csv[1]);
								item.Reference = csv[2];
								item.ReservationCost = Convert.ToInt32(csv[3]);
								item.Consumable =Convert.ToBoolean(csv[4]);
								item.Reservable =Convert.ToBoolean(csv[5]);
								item.Description = csv[6];
								item.PicturePath = csv[7];

								string strDiv = csv[8];
								ItemBrand div = _itemsEntity.ItemBrands.FirstOrDefault( o => o.Name == strDiv );
								item.Brand = div.Id;

								int intPhaseNb = Convert.ToInt32(csv[9]);
								Invoice search = _invoicesEntity.Invoices.FirstOrDefault( o => o.PhaseNumber == intPhaseNb );
								item.RelatedInvoice = search.Id;

								string strFunc = csv[10];
								ItemFunctionalCategory search2 = _itemsEntity.ItemFunctionalCategories.FirstOrDefault( o => o.Name == strFunc );
								item.FunctionalCategory = search2.Id;

								string strState = csv[11];
								ItemState search3 = _itemsEntity.ItemStates.FirstOrDefault( o => o.Name == strState );
								item.CurrentState = search3.Id;

								if( _itemsEntity.Items.FirstOrDefault<Item>( u => u.EAN13 == item.EAN13 ) != null )
									MessageBox.Show( "Erreur : l'entrée n°" + item.Id + " n'as pas pu être inséré car l'EAN13 \"" + item.EAN13 + "\" est déjà utilisé." );
								else
								{
									_itemsEntity.Items.Add( item );
									_itemsEntity.SaveChanges();
									importCount++;
								}
								rowCount++;
							}
							MessageBox.Show( importCount + " Matériels sur " + rowCount + " ont été importé dans la base de données." );
						}
					}
				}
			}
		}

		private void entreprisesToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			int fieldCount = 0, rowCount = 0, importCount = 0;

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.RestoreDirectory = true;

			if( openFileDialog.ShowDialog() == DialogResult.OK )
			{
				if( (myStream = openFileDialog.OpenFile()) != null )
				{
					using( myStream )
					{
						// open the file openFileDialog.FileName which is a CSV file with headers
						using( CsvReader csv = new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
						{
							fieldCount = csv.FieldCount;

							string[] headers = csv.GetFieldHeaders();
							while( csv.ReadNextRecord() )
							{
								Company company = new Company();

								for( int i = 0; i < fieldCount; i++ )
									string.Format( "{0} = {1};", headers[i], csv[i] );

								company.Name = csv[1] ;
								company.Phone = csv[2];
								company.Email = csv[3];
								company.Fax = csv[4];
								company.Website = csv[5];
								company.Adress = csv[6];
								company.Historic = csv[7];
								company.LogoPath = csv[8];

								if( _invoicesEntity.Companies.FirstOrDefault<Company>( u => u.Name == company.Name ) != null )
									MessageBox.Show( "Erreur : l'entrée n°" + company.Id + " n'as pas pu être inséré car le nom de cette entreprise \"" + company.Name + "\" existe déjà." );
								else
								{
									_invoicesEntity.Companies.Add( company );
									_invoicesEntity.SaveChanges();
									importCount++;
								}
								rowCount++;
							}
							MessageBox.Show( importCount + " Entreprises sur " + rowCount + " ont été importé dans la base de données." );
						}
					}
				}
			}
		}

		private void contactsToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			int fieldCount = 0, rowCount = 0, importCount = 0;

			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.RestoreDirectory = true;

			if( openFileDialog.ShowDialog() == DialogResult.OK )
			{
				if( (myStream = openFileDialog.OpenFile()) != null )
				{
					using( myStream )
					{
						// open the file openFileDialog.FileName which is a CSV file with headers
						using( CsvReader csv = new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
						{
							fieldCount = csv.FieldCount;

							string[] headers = csv.GetFieldHeaders();
							while( csv.ReadNextRecord() )
							{
								Contact contact = new Contact();

								for( int i = 0; i < fieldCount; i++ )
									string.Format( "{0} = {1};", headers[i], csv[i] );

								contact.FirstName = csv[1];
								contact.LastName = csv[2];
								contact.Email = csv[3];
								contact.Phone = csv[4];
								contact.Fax = csv[5];
								contact.Historic = csv[6];
								contact.PortraitPath = csv[7];

								string companyName = csv[8];
								Company search = _invoicesEntity.Companies.FirstOrDefault( o => o.Name == companyName );
								contact.Employer = search.Id;

								if( _invoicesEntity.Companies.FirstOrDefault<Company>( u => u.Email == contact.Email ) != null )
									MessageBox.Show( "Erreur : l'entrée n°" + contact.Id + " n'as pas pu être inséré car l'email \"" + contact.Email + "\" existe déjà." );
								else
								{
									_invoicesEntity.Contacts.Add( contact );
									_invoicesEntity.SaveChanges();
									importCount++;
								}
								rowCount++;
							}
							MessageBox.Show( importCount + " Contacts sur " + rowCount + " ont été importé dans la base de données." );
						}
					}
				}
			}
		}

		#endregion

		#region Exports PDF
		private void réservationsToolStripMenuItem2_Click( object sender, EventArgs e )
		{
			Document doc = new Document( PageSize.A4, 2, 2, 2, 2 );
			Paragraph p = new Paragraph( "Export des réservations" );
			PdfPTable headers = new PdfPTable( 21 );
			PdfPTable infos = new PdfPTable( 21 );
			PdfPCell cellule = new PdfPCell( new Paragraph( "izi" ) );

			using( PdfWriter.GetInstance( doc, new FileStream( @".\..\..\..\ITI.PixLogic.WinApp\PDF\toutes_les_réservations.pdf", FileMode.Create ) ) )
			{
				p.Alignment = Element.ALIGN_CENTER;

				headers.HorizontalAlignment = 1;
				headers.SpacingBefore = 40f;
				infos.HorizontalAlignment = 1;
				infos.SpacingAfter = 40f;

				headers.AddCell( "ID" );
				headers.AddCell( "Etat de la réservation" );
				headers.AddCell( "Indicatif" );
				headers.AddCell( "Email du réserveur" );
				headers.AddCell( "Porte monnaie du réserveur" );
				headers.AddCell( "Historique du réserveur" );
				headers.AddCell( "Date prévu de la réservation" );
				headers.AddCell( "Date réel de la réservation" );
				headers.AddCell( "Matériel utilisable" );
				headers.AddCell( "Date prévu du rendu " );
				headers.AddCell( "Data réel du rendu" );
				headers.AddCell( "Pack utilisé" );
				headers.AddCell( "EAN13" );
				headers.AddCell( "Marque" );
				headers.AddCell( "Nom" );
				headers.AddCell( "Description" );
				headers.AddCell( "Prix" );
				headers.AddCell( "Etat avant réservation" );
				headers.AddCell( "Etat après réservation" );
				headers.AddCell( "Etat actuel" );
				headers.AddCell( "Matériel utilisable" );
				headers.AddCell( " Matériel Consommable" );

				doc.Open();
				doc.AddAuthor( "PixLogic PDF Generator" );
				doc.Add( p );
				doc.Add( headers );

				foreach( var reservations in _reservationsEntity.view_reservations )
				{
					infos.AddCell( reservations.ReservationId.ToString() );
					infos.AddCell( reservations.ReservationEventState.ToString() );
					infos.AddCell( reservations.ReservationIndication );
					infos.AddCell( reservations.ReserverEmail.ToString() );
					infos.AddCell( reservations.ReserverWallet.ToString() );
					infos.AddCell( reservations.ReserverHistoric );
					infos.AddCell( reservations.PlannedStartDate.ToString() );
					infos.AddCell( reservations.RealStartDate.ToString() );
					infos.AddCell( reservations.PlannedEndDate.ToString() );
					infos.AddCell( reservations.RealEndDate.ToString() );
					infos.AddCell( reservations.UsedPack.ToString() );
					infos.AddCell( reservations.ItemEAN13.ToString() );
					infos.AddCell( reservations.ItemBrand.ToString() );
					infos.AddCell( reservations.ItemReference.ToString() );
					infos.AddCell( reservations.ItemDescription.ToString() );
					infos.AddCell( reservations.ItemCost.ToString() );
					infos.AddCell( reservations.ItemStateBefore.ToString() );
					infos.AddCell( reservations.ItemStateAfter.ToString() );
					infos.AddCell( reservations.ItemStateNow.ToString() );
					infos.AddCell( reservations.ItemIsUsable.ToString() );
					infos.AddCell( reservations.ItemIsConsumable.ToString() );
				}

				doc.Add( infos );
				doc.Close();
			}
			MessageBox.Show( "Le fichier PDF a été créé !" );
		}
		#endregion

		#region Exports CSV
		private void utilisateursToolStripMenuItem2_Click( object sender, EventArgs e )
		{

			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @".\..\..\..\ITI.PixLogic.WinApp\Csv\utilisateurs.csv" );

			try
			{
				foreach( var accounts in _accountsEntity.Accounts )
				{
					sb.Append( accounts.Id + delimiter );
					sb.Append( accounts.FirstName + delimiter );
					sb.Append( accounts.LastName + delimiter );
					sb.Append( accounts.Email + delimiter );
					sb.Append( accounts.Phone + delimiter );
					sb.Append( accounts.Adress + delimiter );
					sb.Append( accounts.Historic + delimiter );
					sb.Append( accounts.Wallet + delimiter );
					sb.Append( accounts.PortraitPath + delimiter );
					sb.Append( accounts.Division + delimiter );
					sb.Append( "\r\n" );
				}

				file.WriteLine( sb.ToString() );
				MessageBox.Show( "Le fichier csv est créer." );
			}
			catch( Exception a )
			{
				MessageBox.Show( " Une erreur est survenue : " + a.Message );
			}

			finally
			{
				file.Close();
			}

		}

		private void objetsToolStripMenuItem_Click( object sender, EventArgs e )
		{
			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @".\..\..\..\ITI.PixLogic.WinApp\Csv\matériel.csv" );

			try
			{
				foreach( var items in _itemsEntity.Items )
				{
					sb.Append( items.Id + delimiter );
					sb.Append( items.EAN13 + delimiter );
					sb.Append( items.Reference + delimiter );
					sb.Append( items.ReservationCost + delimiter );
					sb.Append( items.Consumable + delimiter );
					sb.Append( items.Reservable + delimiter );
					sb.Append( items.Description + delimiter );
					sb.Append( items.PicturePath + delimiter );
					sb.Append( items.Brand + delimiter );
					sb.Append( items.RelatedInvoice + delimiter );
					sb.Append( items.FunctionalCategory + delimiter );
					sb.Append( items.CurrentState + delimiter );
					sb.Append( "\r\n" );
				}

				file.WriteLine( sb.ToString() );
				MessageBox.Show( "Le fichier csv est créer." );
			}
			catch( Exception a )
			{
				MessageBox.Show( " Une erreur est survenue : " + a.Message );
			}

			finally
			{
				file.Close();
			}
		}

		private void packsToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @".\..\..\..\ITI.PixLogic.WinApp\Csv\packs.csv" );

			try
			{
				foreach( var packs in _packsEntity.Packs )
				{
					sb.Append( packs.Id + delimiter );
					sb.Append( packs.Name + delimiter );
					sb.Append( packs.Description + delimiter );
					sb.Append( "\r\n" );
				}

				file.WriteLine( sb.ToString() );
				MessageBox.Show( "Le fichier csv est créer." );
			}
			catch( Exception a )
			{
				MessageBox.Show( " Une erreur est survenue : " + a.Message );
			}

			finally
			{
				file.Close();
			}
		}

		private void réservationsToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @".\..\..\..\ITI.PixLogic.WinApp\Csv\réservations.csv" );

			try
			{
				foreach( var reservations in _reservationsEntity.view_reservations )
				{
					sb.Append( reservations.ReservationId.ToString() + delimiter );
					sb.Append( reservations.ReservationEventState + delimiter );
					sb.Append( reservations.ReservationIndication + delimiter );
					sb.Append( reservations.ReserverEmail + delimiter );
					sb.Append( reservations.ReserverWallet + delimiter );
					sb.Append( reservations.ReserverHistoric + delimiter );
					sb.Append( reservations.PlannedStartDate + delimiter );
					sb.Append( reservations.RealStartDate + delimiter );
					sb.Append( reservations.PlannedEndDate + delimiter );
					sb.Append( reservations.RealEndDate + delimiter );
					sb.Append( reservations.UsedPack + delimiter );
					sb.Append( reservations.ItemEAN13 + delimiter );
					sb.Append( reservations.ItemBrand + delimiter );
					sb.Append( reservations.ItemReference + delimiter );
					sb.Append( reservations.ItemDescription + delimiter );
					sb.Append( reservations.ItemCost + delimiter );
					sb.Append( reservations.ItemStateBefore + delimiter );
					sb.Append( reservations.ItemStateAfter + delimiter );
					sb.Append( reservations.ItemStateNow + delimiter );
					sb.Append( reservations.ItemIsUsable + delimiter );
					sb.Append( reservations.ItemIsConsumable + delimiter );
					sb.Append( "\r\n" );
				}

				file.WriteLine( sb.ToString() );
				file.Close();
				MessageBox.Show( "Le fichier csv est créer." );
			}
			catch( Exception a )
			{
				MessageBox.Show( " Une erreur est survenue : " + a.Message );
			}

			finally
			{

			}
		}

		private void facturesToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @".\..\..\..\ITI.PixLogic.WinApp\Csv\factures.csv" );

			try
			{
				foreach( var factures in _invoicesEntity.Invoices )
				{
					sb.Append( factures.Id + delimiter );
					sb.Append( factures.PhaseNumber + delimiter );
					sb.Append( factures.PurchaseDate + delimiter );
					sb.Append( factures.PurchaseCost + delimiter );
					sb.Append( factures.Depreciation + delimiter );
					sb.Append( factures.ScanPath + delimiter );
					sb.Append( factures.Provider + delimiter );
					sb.Append( "\r\n" );
				}

				file.WriteLine( sb.ToString() );
				MessageBox.Show( "Le fichier csv est créer." );
			}
			catch( Exception a )
			{
				MessageBox.Show( " Une erreur est survenue : " + a.Message );
			}

			finally
			{
				file.Close();
			}
		}
		#endregion

		private void bookEquipmentToolStripMenuItem_Click( object sender, EventArgs e )
		{
			new MatérielView().Show();
		}

		private void HomeView_Load( object sender, EventArgs e )
		{
			/*
			* Idée de statistique:
			* -Objet le plus utilisé
			* -Dernière réservations
			* -Réservation se terminant bientot
			*/

			//Account Pie chart feeding
			DataPoint _activeAccountsDP = new DataPoint();
			_activeAccountsDP.SetValueY( StatsService.GetNumberOfActiveAccount() );
			_activeAccountsDP.LegendText = "Comptes actifs";
			ActiveAccNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfActiveAccount() );

			DataPoint _bannedAccountsDP = new DataPoint();
			_bannedAccountsDP.SetValueY( StatsService.GetNumberOfBannedAccount() );
			_bannedAccountsDP.LegendText = "Comptes Suspendus";
			BannedAccNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfBannedAccount() );

			AccountCharts.Series[0].Points.Clear();
			AccountCharts.Series[0].Points.Add( _activeAccountsDP );
			AccountCharts.Series[0].Points.Add( _bannedAccountsDP );

			//Item Pie chart feeding
			DataPoint _consummableDP = new DataPoint();
			_consummableDP.SetValueY( StatsService.GetNumberOfConsummableItems() );
			_consummableDP.Color = Color.Red;
			_consummableDP.LegendText = "Consommable";
			ConsummableItemNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfConsummableItems() );

			DataPoint _reservableDP = new DataPoint();
			_reservableDP.SetValueY( StatsService.GetNumberOfReservableNonConsummableItems() );
			_reservableDP.Color = Color.LightBlue;
			_reservableDP.LegendText = "Réservable";
			ReservableItemNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfReservableNonConsummableItems() );

			ItemsCharts.Series[0].Points.Clear();
			ItemsCharts.Series[0].Points.Add( _consummableDP );
			ItemsCharts.Series[0].Points.Add( _reservableDP );

			//General stats feeding
			AmmountofItemsNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfItems() );
			ReservationAmmountNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfReservationEvent() );
			AmmountOfPackNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfPack() );
			AmmountOfInvoicesNbrLbl.Text = Convert.ToString( StatsService.GetNumberOfInvoices() );
		}

		private void ExitBtn_Click( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void CapitalizedBtn_Click( object sender, EventArgs e )
		{
			new CapitalizedView().Show();
			this.Hide();
		}

		private void consumable_button_Click( object sender, EventArgs e )
		{
			new ConsumablesView().Show();
			this.Hide();
		}

		private void users_account_button_Click( object sender, EventArgs e )
		{
			new AccountsView().Show();
			this.Hide();
		}

		private void ReservationBtn_Click( object sender, EventArgs e )
		{

		}

		private void cSVToolStripMenuItem_Click( object sender, EventArgs e )
		{

		}

		private void contactsToolStripMenuItem_Click( object sender, EventArgs e )
		{
			ContactView contact = new ContactView();
			contact.Show();
		}
	}
}