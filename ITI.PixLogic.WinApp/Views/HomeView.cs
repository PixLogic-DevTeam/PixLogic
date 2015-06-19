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


namespace ITI.PixLogic.WinApp
{
    public partial class HomeView : Form
    {
        AccountsEntity _accountsEntity = new AccountsEntity();
        ReservationsEntity _resEntity = new ReservationsEntity();

        public HomeView()
        {
            InitializeComponent();
        }

        #region Imports
        private void MainMenuStrip_Imports_Users_Click( object sender, EventArgs e )
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            //openFileDialog.Filter = "CSV files (*.csv) | *.csv | All files (*.*)|*.*"; /* Error with CSV Files */
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                if( (myStream = openFileDialog.OpenFile()) != null )
                {
                    using( myStream )
                    {
                        // open the file openFileDialog.FileName which is a CSV file with headers
                        using( CsvReader csv =
							   new CsvReader( new StreamReader( openFileDialog.FileName ), true ) )
                        {
                            
                            int fieldCount = csv.FieldCount;

                            string[] headers = csv.GetFieldHeaders();
                            while( csv.ReadNextRecord() )
                            {
                                for( int i = 0; i < fieldCount; i++ ) string.Format( "{0} = {1};", headers[i], csv[i] );

                                Account user = new Account();
                                user.FirstName = csv[1];
                                user.LastName = csv[2];
                                user.Email = csv[3];
                                user.Password = csv[4];
                                user.Salt = csv[5];
                                user.Phone = csv[6];
                                user.Adress = csv[7];
                                user.Historic = csv[8];
                                user.Wallet = Convert.ToInt32( csv[9] );
                                //user.active = Convert.ToBoolean(csv[10]);
                                //user.Banned = Convert.ToBoolean( csv[11] );
                                user.PicturePath = csv[12];
                                var test = csv[13];
                                AccountSubCategory asc = _accountsEntity.AccountSubCategories.FirstOrDefault( o => o.Name == test );
                                asc.Name = csv[13];
                                user.SubCategory = asc.Id;
                                user.AccountSubCategory = asc;

                                var test2 = csv[14];
                                AccountMainCategory amc = _accountsEntity.AccountMainCategories.FirstOrDefault( o => o.Name == test2 );
                                amc.Name = csv[14];
                                user.AccountSubCategory.AccountMainCategory = amc;

                                _accountsEntity.Accounts.Add( user );
                                _accountsEntity.SaveChanges();
                            }

                            MessageBox.Show( "L'import de donnée a réussi." );
                        }
                    }
                }
            }

        }
        #endregion

        #region Exports
        private void MainMenuStrip_Exports_Users_Click( object sender, EventArgs e )
        {
            Document doc = new Document( PageSize.A4, 2, 2, 2, 2 );
            Paragraph p = new Paragraph( "Export de la base de donnée en PDF." );
            p.Alignment = Element.ALIGN_CENTER;

            try
            {
                using( PdfWriter.GetInstance( doc, new FileStream("toutes_les_réservations.pdf", FileMode.Create ) ) )
                {
                    List<ReservationItem> _resItem = new List<ReservationItem>();
                    /*_resItem = _resEntity.ReservationItems.ToList();
                    _resItem.Join()*/

                    PdfPTable headers = new PdfPTable( 8 );
                    PdfPTable infos = new PdfPTable( 8 );
                    List<Account> data = new List<Account>();

                    headers.HorizontalAlignment = 1;
                    headers.SpacingBefore = 20f;
                    headers.SpacingAfter = 20f;
                    infos.HorizontalAlignment = 1;
                    infos.SpacingBefore = 20f;
                    infos.SpacingAfter = 20f;

                    headers.AddCell( "ID" );
                    headers.AddCell( "Prénom" );
                    headers.AddCell( "Nom" );
                    headers.AddCell( "Email" );
                    headers.AddCell( "Mot de passe" );
                    headers.AddCell( "Etat" );
                    headers.AddCell( "Porte-monnaie" );
                    headers.AddCell( "Sous-catégorie" );

                    data = _accountsEntity.Accounts.OrderBy( a => a.FirstName ).ThenBy( a => a.LastName ).ThenBy( a => a.Password ).ToList();

                    foreach( var Account in data )
                    {
                        infos.AddCell( Account.Id.ToString() );
                        infos.AddCell( Account.FirstName );
                        infos.AddCell( Account.LastName );
                        infos.AddCell( Account.Email );
                        infos.AddCell( Account.Password );
                        infos.AddCell( Account.Active.ToString() );
                        infos.AddCell( Account.Wallet.ToString() + " points" );
                        infos.AddCell( Account.SubCategory.ToString() );
                        doc.Open();
                        doc.AddAuthor( "PixLogic PDF Generator" );
                        doc.Add( p );
                        doc.Add( headers );
                        doc.Add( infos );
                        
                    }
                }
                MessageBox.Show( "Le fichier PDF a été créé !" );
            }
            catch( Exception ex )
            {
                MessageBox.Show( "Une erreur s'est produite (plus d'informations : " + ex.Message + ")." );
            }
            finally
            {
                doc.Close();
            }
        }
        #endregion
    }
}
