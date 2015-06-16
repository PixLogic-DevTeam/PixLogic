using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using ITI.PixLogic.DAL;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace ITI.PixLogic.WinApp
{
    public partial class HomeView : Form
    {
        AccountsEntity _accountsEntity = new AccountsEntity();
        public HomeView()
        {
            InitializeComponent();
        }

        private void users_account_button_Click(object sender, System.EventArgs e)
        {
            new AccountsView().Show();
            this.Hide();
        }

        private void consumable_button_Click(object sender, System.EventArgs e)
        {
            new ConsumablesView().Show();
            this.Hide();
        }

        private void CapitalizedBtn_Click(object sender, EventArgs e)
        {
            new CapitalizedView().Show();
            this.Hide();
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
                if ((myStream = openFileDialog.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        /// Clear table before add the data of csv
                        _accountsEntity.Database.ExecuteSqlCommand("DELETE FROM accounts");

                        // open the file openFileDialog.FileName which is a CSV file with headers
                        using (CsvReader csv =
                               new CsvReader(new StreamReader(openFileDialog.FileName), true))
                        {
                            int fieldCount = csv.FieldCount;

                            string[] headers = csv.GetFieldHeaders();
                            while (csv.ReadNextRecord())
                            {
                                for (int i = 0; i < fieldCount; i++) string.Format("{0} = {1};", headers[i], csv[i]);

                                accounts user = new accounts();
                                user.first_name = csv[1];
                                user.last_name = csv[2];
                                user.email = csv[3];
                                user.password = csv[4];
                                //user.active = Convert.ToBoolean(csv[5]);
                                user.wallet = Convert.ToInt32(csv[6]);
                                var test = csv[7];
                                accounts_sub_categories asc = _accountsEntity.accounts_sub_categories.FirstOrDefault(o => o.name == test);
                                asc.name = csv[7];
                                user.sub_category = asc.id;
                                user.accounts_sub_categories = asc;

                                var test2 = csv[8];
                                accounts_main_categories amc = _accountsEntity.accounts_main_categories.FirstOrDefault(o => o.name == test2);
                                amc.name = csv[8];
                                user.accounts_sub_categories.accounts_main_categories = amc;

                                _accountsEntity.accounts.Add(user);
                                _accountsEntity.SaveChanges();
                            }

                            MessageBox.Show("Import réussi");
                        }
                    }
                }
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
        }


        private void utilisateursformatPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Document doc = new Document(PageSize.A4, 2, 2, 2, 2);
            Paragraph p = new Paragraph("Export Database data to PDF file in c#");
            p.Alignment = Element.ALIGN_CENTER;

            try
            {
                PdfWriter.GetInstance(doc, new FileStream("réservations.pdf", FileMode.Create));

                PdfPTable pdftable = new PdfPTable(8);
                pdftable.HorizontalAlignment = 1;
                pdftable.SpacingBefore = 20f;
                pdftable.SpacingAfter = 20f;

                pdftable.AddCell("ID");
                pdftable.AddCell("Prénom");
                pdftable.AddCell("Nom");
                pdftable.AddCell("Email");
                pdftable.AddCell("Mot de passe");
                pdftable.AddCell("Etat");
                pdftable.AddCell("Porte-monnaie");
                pdftable.AddCell("Sous-catégorie");
                


                PdfPTable pdftable2 = new PdfPTable(8);
                pdftable2.HorizontalAlignment = 1;
                pdftable2.SpacingBefore = 20f;
                pdftable2.SpacingAfter = 20f;

                List<accounts> data = new List<accounts>();
                using (_accountsEntity)
                {
                    data = _accountsEntity.accounts.OrderBy(a => a.first_name).ThenBy(a => a.last_name).ThenBy(a => a.password).ToList();
                }

                foreach (var Account in data)
                {
                    pdftable2.AddCell(Account.id.ToString());
                    pdftable2.AddCell(Account.first_name);
                    pdftable2.AddCell(Account.last_name);
                    pdftable2.AddCell(Account.email);
                    pdftable2.AddCell(Account.password);
                    pdftable2.AddCell(Account.active.ToString());
                    pdftable2.AddCell(Account.wallet.ToString() + " points");
                    pdftable2.AddCell(Account.sub_category.ToString());

                    doc.Open();
                    doc.AddAuthor("Loïc DONNE");
                    doc.Add(p);
                    doc.Add(pdftable);
                    doc.Add(pdftable2);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            finally
            {
                doc.Close();
            }

            MessageBox.Show("PDF créer.");
        }
    }
}
