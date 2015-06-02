namespace ITI.PixLogic.WinApp
{
    partial class AddCapitalizedView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.NameLbl = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
			this.DescriptionLbl = new System.Windows.Forms.Label();
			this.EANLbl = new System.Windows.Forms.Label();
			this.EANTextBox = new System.Windows.Forms.TextBox();
			this.ResCostTextBox = new System.Windows.Forms.TextBox();
			this.ResCostLbl = new System.Windows.Forms.Label();
			this.SubCatLbl = new System.Windows.Forms.Label();
			this.SubCatComboBox = new System.Windows.Forms.ComboBox();
			this.InvoiceComboBox = new System.Windows.Forms.ComboBox();
			this.InvoiceLbl = new System.Windows.Forms.Label();
			this.CurrentStateLbl = new System.Windows.Forms.Label();
			this.CurrentStateComboBox = new System.Windows.Forms.ComboBox();
			this.BackBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NameLbl
			// 
			this.NameLbl.AutoSize = true;
			this.NameLbl.Location = new System.Drawing.Point(82, 25);
			this.NameLbl.Name = "NameLbl";
			this.NameLbl.Size = new System.Drawing.Size(38, 13);
			this.NameLbl.TabIndex = 0;
			this.NameLbl.Text = "Nom : ";
			// 
			// NameTextBox
			// 
			this.NameTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.NameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
			this.NameTextBox.Location = new System.Drawing.Point(126, 25);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(94, 20);
			this.NameTextBox.TabIndex = 1;
			// 
			// DescriptionRichTextBox
			// 
			this.DescriptionRichTextBox.Location = new System.Drawing.Point(126, 51);
			this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
			this.DescriptionRichTextBox.Size = new System.Drawing.Size(207, 110);
			this.DescriptionRichTextBox.TabIndex = 2;
			this.DescriptionRichTextBox.Text = "";
			// 
			// DescriptionLbl
			// 
			this.DescriptionLbl.AutoSize = true;
			this.DescriptionLbl.Location = new System.Drawing.Point(51, 54);
			this.DescriptionLbl.Name = "DescriptionLbl";
			this.DescriptionLbl.Size = new System.Drawing.Size(69, 13);
			this.DescriptionLbl.TabIndex = 3;
			this.DescriptionLbl.Text = "Description : ";
			// 
			// EANLbl
			// 
			this.EANLbl.AutoSize = true;
			this.EANLbl.Location = new System.Drawing.Point(70, 174);
			this.EANLbl.Name = "EANLbl";
			this.EANLbl.Size = new System.Drawing.Size(50, 13);
			this.EANLbl.TabIndex = 4;
			this.EANLbl.Text = "EAN13 : ";
			// 
			// EANTextBox
			// 
			this.EANTextBox.Location = new System.Drawing.Point(126, 167);
			this.EANTextBox.Name = "EANTextBox";
			this.EANTextBox.Size = new System.Drawing.Size(103, 20);
			this.EANTextBox.TabIndex = 5;
			// 
			// ResCostTextBox
			// 
			this.ResCostTextBox.Location = new System.Drawing.Point(126, 193);
			this.ResCostTextBox.Name = "ResCostTextBox";
			this.ResCostTextBox.Size = new System.Drawing.Size(103, 20);
			this.ResCostTextBox.TabIndex = 6;
			// 
			// ResCostLbl
			// 
			this.ResCostLbl.AutoSize = true;
			this.ResCostLbl.Location = new System.Drawing.Point(12, 196);
			this.ResCostLbl.Name = "ResCostLbl";
			this.ResCostLbl.Size = new System.Drawing.Size(108, 13);
			this.ResCostLbl.TabIndex = 7;
			this.ResCostLbl.Text = "Coût de réservation : ";
			// 
			// SubCatLbl
			// 
			this.SubCatLbl.AutoSize = true;
			this.SubCatLbl.Location = new System.Drawing.Point(33, 225);
			this.SubCatLbl.Name = "SubCatLbl";
			this.SubCatLbl.Size = new System.Drawing.Size(87, 13);
			this.SubCatLbl.TabIndex = 8;
			this.SubCatLbl.Text = "Sous-catégorie : ";
			// 
			// SubCatComboBox
			// 
			this.SubCatComboBox.FormattingEnabled = true;
			this.SubCatComboBox.Location = new System.Drawing.Point(126, 222);
			this.SubCatComboBox.Name = "SubCatComboBox";
			this.SubCatComboBox.Size = new System.Drawing.Size(134, 21);
			this.SubCatComboBox.TabIndex = 9;
			this.SubCatComboBox.Click += new System.EventHandler(this.SubCatComboBox_Click);
			// 
			// InvoiceComboBox
			// 
			this.InvoiceComboBox.FormattingEnabled = true;
			this.InvoiceComboBox.Location = new System.Drawing.Point(126, 249);
			this.InvoiceComboBox.Name = "InvoiceComboBox";
			this.InvoiceComboBox.Size = new System.Drawing.Size(134, 21);
			this.InvoiceComboBox.TabIndex = 10;
			this.InvoiceComboBox.Click += new System.EventHandler(this.InvoiceComboBox_Click);
			// 
			// InvoiceLbl
			// 
			this.InvoiceLbl.AutoSize = true;
			this.InvoiceLbl.Location = new System.Drawing.Point(68, 252);
			this.InvoiceLbl.Name = "InvoiceLbl";
			this.InvoiceLbl.Size = new System.Drawing.Size(52, 13);
			this.InvoiceLbl.TabIndex = 11;
			this.InvoiceLbl.Text = "Facture : ";
			// 
			// CurrentStateLbl
			// 
			this.CurrentStateLbl.AutoSize = true;
			this.CurrentStateLbl.Location = new System.Drawing.Point(53, 281);
			this.CurrentStateLbl.Name = "CurrentStateLbl";
			this.CurrentStateLbl.Size = new System.Drawing.Size(67, 13);
			this.CurrentStateLbl.TabIndex = 12;
			this.CurrentStateLbl.Text = "Etat actuel : ";
			// 
			// CurrentStateComboBox
			// 
			this.CurrentStateComboBox.FormattingEnabled = true;
			this.CurrentStateComboBox.Location = new System.Drawing.Point(126, 278);
			this.CurrentStateComboBox.Name = "CurrentStateComboBox";
			this.CurrentStateComboBox.Size = new System.Drawing.Size(134, 21);
			this.CurrentStateComboBox.TabIndex = 13;
			this.CurrentStateComboBox.Click += new System.EventHandler(this.CurrentStateComboBox_Click);
			// 
			// BackBtn
			// 
			this.BackBtn.Location = new System.Drawing.Point(258, 309);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(75, 23);
			this.BackBtn.TabIndex = 14;
			this.BackBtn.Text = "Annuler";
			this.BackBtn.UseVisualStyleBackColor = true;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(12, 309);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 15;
			this.AddBtn.Text = "Ajouter";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// AddCapitalized
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 344);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.CurrentStateComboBox);
			this.Controls.Add(this.CurrentStateLbl);
			this.Controls.Add(this.InvoiceLbl);
			this.Controls.Add(this.InvoiceComboBox);
			this.Controls.Add(this.SubCatComboBox);
			this.Controls.Add(this.SubCatLbl);
			this.Controls.Add(this.ResCostLbl);
			this.Controls.Add(this.ResCostTextBox);
			this.Controls.Add(this.EANTextBox);
			this.Controls.Add(this.EANLbl);
			this.Controls.Add(this.DescriptionLbl);
			this.Controls.Add(this.DescriptionRichTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLbl);
			this.Name = "AddCapitalized";
			this.Text = "PixLogic - Ajouter un objet immobilisable";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label EANLbl;
        private System.Windows.Forms.TextBox EANTextBox;
        private System.Windows.Forms.TextBox ResCostTextBox;
        private System.Windows.Forms.Label ResCostLbl;
        private System.Windows.Forms.Label SubCatLbl;
        private System.Windows.Forms.ComboBox SubCatComboBox;
        private System.Windows.Forms.ComboBox InvoiceComboBox;
        private System.Windows.Forms.Label InvoiceLbl;
        private System.Windows.Forms.Label CurrentStateLbl;
        private System.Windows.Forms.ComboBox CurrentStateComboBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}