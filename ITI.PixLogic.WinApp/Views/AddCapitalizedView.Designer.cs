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
			this.ReferenceTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Reservable_comboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BrandComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// DescriptionRichTextBox
			// 
			this.DescriptionRichTextBox.Location = new System.Drawing.Point(126, 64);
			this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
			this.DescriptionRichTextBox.Size = new System.Drawing.Size(207, 36);
			this.DescriptionRichTextBox.TabIndex = 2;
			this.DescriptionRichTextBox.Text = "";
			// 
			// DescriptionLbl
			// 
			this.DescriptionLbl.AutoSize = true;
			this.DescriptionLbl.Location = new System.Drawing.Point(51, 67);
			this.DescriptionLbl.Name = "DescriptionLbl";
			this.DescriptionLbl.Size = new System.Drawing.Size(69, 13);
			this.DescriptionLbl.TabIndex = 3;
			this.DescriptionLbl.Text = "Description : ";
			// 
			// EANLbl
			// 
			this.EANLbl.AutoSize = true;
			this.EANLbl.Location = new System.Drawing.Point(70, 187);
			this.EANLbl.Name = "EANLbl";
			this.EANLbl.Size = new System.Drawing.Size(50, 13);
			this.EANLbl.TabIndex = 4;
			this.EANLbl.Text = "EAN13 : ";
			// 
			// EANTextBox
			// 
			this.EANTextBox.Location = new System.Drawing.Point(126, 180);
			this.EANTextBox.Name = "EANTextBox";
			this.EANTextBox.Size = new System.Drawing.Size(103, 20);
			this.EANTextBox.TabIndex = 5;
			this.EANTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EANTextBox_KeyPress);
			// 
			// ResCostTextBox
			// 
			this.ResCostTextBox.Location = new System.Drawing.Point(126, 206);
			this.ResCostTextBox.Name = "ResCostTextBox";
			this.ResCostTextBox.Size = new System.Drawing.Size(103, 20);
			this.ResCostTextBox.TabIndex = 6;
			// 
			// ResCostLbl
			// 
			this.ResCostLbl.AutoSize = true;
			this.ResCostLbl.Location = new System.Drawing.Point(12, 209);
			this.ResCostLbl.Name = "ResCostLbl";
			this.ResCostLbl.Size = new System.Drawing.Size(108, 13);
			this.ResCostLbl.TabIndex = 7;
			this.ResCostLbl.Text = "Coût de réservation : ";
			// 
			// SubCatLbl
			// 
			this.SubCatLbl.AutoSize = true;
			this.SubCatLbl.Location = new System.Drawing.Point(33, 238);
			this.SubCatLbl.Name = "SubCatLbl";
			this.SubCatLbl.Size = new System.Drawing.Size(87, 13);
			this.SubCatLbl.TabIndex = 8;
			this.SubCatLbl.Text = "Sous-catégorie : ";
			// 
			// SubCatComboBox
			// 
			this.SubCatComboBox.FormattingEnabled = true;
			this.SubCatComboBox.Location = new System.Drawing.Point(126, 235);
			this.SubCatComboBox.Name = "SubCatComboBox";
			this.SubCatComboBox.Size = new System.Drawing.Size(134, 21);
			this.SubCatComboBox.TabIndex = 9;
			this.SubCatComboBox.Click += new System.EventHandler(this.SubCatComboBox_Click);
			// 
			// InvoiceComboBox
			// 
			this.InvoiceComboBox.FormattingEnabled = true;
			this.InvoiceComboBox.Location = new System.Drawing.Point(126, 262);
			this.InvoiceComboBox.Name = "InvoiceComboBox";
			this.InvoiceComboBox.Size = new System.Drawing.Size(134, 21);
			this.InvoiceComboBox.TabIndex = 10;
			this.InvoiceComboBox.Click += new System.EventHandler(this.InvoiceComboBox_Click);
			// 
			// InvoiceLbl
			// 
			this.InvoiceLbl.AutoSize = true;
			this.InvoiceLbl.Location = new System.Drawing.Point(68, 265);
			this.InvoiceLbl.Name = "InvoiceLbl";
			this.InvoiceLbl.Size = new System.Drawing.Size(52, 13);
			this.InvoiceLbl.TabIndex = 11;
			this.InvoiceLbl.Text = "Facture : ";
			// 
			// CurrentStateLbl
			// 
			this.CurrentStateLbl.AutoSize = true;
			this.CurrentStateLbl.Location = new System.Drawing.Point(53, 294);
			this.CurrentStateLbl.Name = "CurrentStateLbl";
			this.CurrentStateLbl.Size = new System.Drawing.Size(67, 13);
			this.CurrentStateLbl.TabIndex = 12;
			this.CurrentStateLbl.Text = "Etat actuel : ";
			// 
			// CurrentStateComboBox
			// 
			this.CurrentStateComboBox.FormattingEnabled = true;
			this.CurrentStateComboBox.Location = new System.Drawing.Point(126, 291);
			this.CurrentStateComboBox.Name = "CurrentStateComboBox";
			this.CurrentStateComboBox.Size = new System.Drawing.Size(134, 21);
			this.CurrentStateComboBox.TabIndex = 13;
			this.CurrentStateComboBox.Click += new System.EventHandler(this.CurrentStateComboBox_Click);
			// 
			// BackBtn
			// 
			this.BackBtn.Location = new System.Drawing.Point(15, 325);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(75, 23);
			this.BackBtn.TabIndex = 14;
			this.BackBtn.Text = "Annuler";
			this.BackBtn.UseVisualStyleBackColor = true;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(257, 325);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 15;
			this.AddBtn.Text = "Ajouter";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// ReferenceTextBox
			// 
			this.ReferenceTextBox.Location = new System.Drawing.Point(126, 38);
			this.ReferenceTextBox.Name = "ReferenceTextBox";
			this.ReferenceTextBox.Size = new System.Drawing.Size(100, 20);
			this.ReferenceTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Référence : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 155);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Reservable";
			// 
			// Reservable_comboBox
			// 
			this.Reservable_comboBox.FormattingEnabled = true;
			this.Reservable_comboBox.Items.AddRange(new object[] {
            "0",
            "1"});
			this.Reservable_comboBox.Location = new System.Drawing.Point(126, 155);
			this.Reservable_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Reservable_comboBox.Name = "Reservable_comboBox";
			this.Reservable_comboBox.Size = new System.Drawing.Size(92, 21);
			this.Reservable_comboBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 123);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "Marque";
			// 
			// BrandComboBox
			// 
			this.BrandComboBox.FormattingEnabled = true;
			this.BrandComboBox.Location = new System.Drawing.Point(126, 123);
			this.BrandComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BrandComboBox.Name = "BrandComboBox";
			this.BrandComboBox.Size = new System.Drawing.Size(92, 21);
			this.BrandComboBox.TabIndex = 3;
			this.BrandComboBox.Click += new System.EventHandler(this.BrandComboBox_Click);
			// 
			// AddCapitalizedView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 360);
			this.Controls.Add(this.BrandComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Reservable_comboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ReferenceTextBox);
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
			this.Name = "AddCapitalizedView";
			this.Text = "PixLogic - Ajouter un objet immobilisable";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox ReferenceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Reservable_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BrandComboBox;
    }
}