using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LumenWorks.Framework.IO.Csv;
using ITI.PixLogic.DAL.Contexts.Accounts;
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
using ITI.PixLogic.DAL.Contexts.Reservations;
using System.Data.SqlClient;
using ITI.PixLogic.DAL.Contexts.Items;
using ITI.PixLogic.DAL.Contexts.Packs;
using ITI.PixLogic.DAL.Contexts.Invoices;


namespace ITI.PixLogic.WinApp
{
	public partial class HomeView : Form
	{
		AccountsEntity _accountsEntity = new AccountsEntity();
		ReservationsEntity _reservationsEntity = new ReservationsEntity();
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
								user.Password = csv[4];
								user.Salt = csv[5];
								user.Phone = csv[6];
								user.Adress = csv[7];
								user.Historic = csv[8];
								user.Wallet = Convert.ToInt32( csv[9] );
								//user.active = Convert.ToBoolean( csv[10] );
								//user.Banned = Convert.ToBoolean( csv[11] );
								user.PicturePath = csv[12];

								string subCategory = csv[13];
								AccountSubCategory asc = _accountsEntity.AccountSubCategories.FirstOrDefault( o => o.Name == subCategory );
								user.SubCategory = asc.Id;
								user.AccountSubCategory = asc;

								string mainCategory = csv[14];
								AccountMainCategory amc = _accountsEntity.AccountMainCategories.FirstOrDefault( o => o.Name == mainCategory );
								user.AccountSubCategory.AccountMainCategory = amc;

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
		#endregion

		#region Exports PDF
		private void réservationsToolStripMenuItem2_Click( object sender, EventArgs e )
		{
			Document doc = new Document( PageSize.A4, 2, 2, 2, 2 );
			Paragraph p = new Paragraph( "Export des réservations" );
			PdfPTable headers = new PdfPTable( 7 );
			PdfPTable infos = new PdfPTable( 7 );

			try
			{
				using( PdfWriter.GetInstance( doc, new FileStream( "toutes_les_réservations.pdf", FileMode.Create ) ) )
				{
					p.Alignment = Element.ALIGN_CENTER;

					headers.HorizontalAlignment = 1;
					headers.SpacingBefore = 40f;
					infos.HorizontalAlignment = 1;
					infos.SpacingAfter = 40f;

					headers.AddCell( "ID" );
					headers.AddCell( "Réservation" );
					headers.AddCell( "Plage horaire" );
					headers.AddCell( "Matériel réservé" );
					headers.AddCell( "Packs réservé" );
					headers.AddCell( "Etat initial" );
					headers.AddCell( "Etat rendu" );

					doc.Open();
					doc.AddAuthor( "PixLogic PDF Generator" );
					doc.Add( p );
					doc.Add( headers );

					foreach( var reservations in _reservationsEntity.ReservationItems )
					{
						infos.AddCell( reservations.Id.ToString() );
						infos.AddCell( reservations.Reservation.ToString() );
						infos.AddCell( reservations.RealPlanning.ToString() );
						infos.AddCell( reservations.ReservedItem.ToString() );
						infos.AddCell( reservations.ReservedPack.ToString() );
						infos.AddCell( reservations.InitialState.ToString() );
						infos.AddCell( reservations.ReturnState.ToString() );
					}

					doc.Add( infos );
					doc.Close();
				}
				MessageBox.Show( "Le fichier PDF a été créé !" );
			 }
			 catch( Exception ex )
			 {
				 MessageBox.Show( "Erreur : " + ex.Message );
			 }
			
		} 
		#endregion

		#region Exports CSV
		private void utilisateursToolStripMenuItem2_Click( object sender, EventArgs e )
		{

			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @"C:\Users\Loïc\Documents\PixLogic\ITI.PixLogic.WinApp\Csv\utilisateurs.csv" );

			try
			{
				foreach( var accounts in _accountsEntity.Accounts )
				{
					sb.Append( accounts.Id + delimiter );
					sb.Append( accounts.FirstName + delimiter );
					sb.Append( accounts.LastName + delimiter );
					sb.Append( accounts.Email + delimiter );
					sb.Append( accounts.Password + delimiter );
					sb.Append( accounts.Salt + delimiter );
					sb.Append( accounts.Phone + delimiter );
					sb.Append( accounts.Adress + delimiter );
					sb.Append( accounts.Historic + delimiter );
					sb.Append( accounts.Wallet + delimiter );
					sb.Append( accounts.Active + delimiter );
					sb.Append( accounts.Banned + delimiter );
					sb.Append( accounts.PicturePath + delimiter );
					sb.Append( accounts.SubCategory + delimiter );
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
			StreamWriter file = new StreamWriter( @"C:\Users\Loïc\Documents\PixLogic\ITI.PixLogic.WinApp\Csv\matériel.csv" );

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
					sb.Append( items.SubCategory + delimiter );
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
			StreamWriter file = new StreamWriter( @"C:\Users\Loïc\Documents\PixLogic\ITI.PixLogic.WinApp\Csv\packs.csv" );

			try
			{
				foreach( var packs in _packsEntity.Packs )
				{
					sb.Append( packs.Id + delimiter );
					sb.Append( packs.Name + delimiter );
					sb.Append( packs.Description + delimiter );
					sb.Append( packs.Reservable + delimiter );
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
			StreamWriter file = new StreamWriter( @"C:\Users\Loïc\Documents\PixLogic\ITI.PixLogic.WinApp\Csv\réservations.csv" );

			try
			{
				foreach( var reservations in _reservationsEntity.ReservationItems )
				{
					sb.Append( reservations.Id + delimiter );
					sb.Append( reservations.Reservation + delimiter );
					sb.Append( reservations.RealPlanning + delimiter );
					sb.Append( reservations.ReservedItem + delimiter );
					sb.Append( reservations.ReservedPack + delimiter );
					sb.Append( reservations.InitialState + delimiter );
					sb.Append( reservations.ReturnState + delimiter );
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

		private void facturesToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			StringBuilder sb = new StringBuilder();
			string delimiter = ";";
			StreamWriter file = new StreamWriter( @"C:\Users\Loïc\Documents\PixLogic\ITI.PixLogic.WinApp\Csv\factures.csv" );

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

		}

	}
}