namespace ITI.PixLogic.WinApp
{
    partial class ModifyAccountView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.MainCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.UserCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.comboBoxState = new System.Windows.Forms.ComboBox();
			this.textBoxWallet = new System.Windows.Forms.TextBox();
			this.textBoxMail = new System.Windows.Forms.TextBox();
			this.textBox_lastName = new System.Windows.Forms.TextBox();
			this.textBox_firstName = new System.Windows.Forms.TextBox();
			this.subCategory = new System.Windows.Forms.Label();
			this.wallet = new System.Windows.Forms.Label();
			this.mail = new System.Windows.Forms.Label();
			this.lastName = new System.Windows.Forms.Label();
			this.firstName = new System.Windows.Forms.Label();
			this.buttonBack = new System.Windows.Forms.Button();
			this.button_confirm = new System.Windows.Forms.Button();
			this.richTextBoxAdress = new System.Windows.Forms.RichTextBox();
			this.richTextBoxHistoric = new System.Windows.Forms.RichTextBox();
			this.labelAdress = new System.Windows.Forms.Label();
			this.labelHistoric = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MainCategoryComboBox
			// 
			this.MainCategoryComboBox.FormattingEnabled = true;
			this.MainCategoryComboBox.Location = new System.Drawing.Point(561, 201);
			this.MainCategoryComboBox.Name = "MainCategoryComboBox";
			this.MainCategoryComboBox.Size = new System.Drawing.Size(121, 21);
			this.MainCategoryComboBox.TabIndex = 34;
			this.MainCategoryComboBox.Click += new System.EventHandler(this.MainCategoryComboBox_Click);
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(406, 204);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(58, 13);
			this.CategoryLabel.TabIndex = 33;
			this.CategoryLabel.Text = "Catégorie :";
			// 
			// UserCategoryComboBox
			// 
			this.UserCategoryComboBox.FormattingEnabled = true;
			this.UserCategoryComboBox.Location = new System.Drawing.Point(561, 250);
			this.UserCategoryComboBox.Name = "UserCategoryComboBox";
			this.UserCategoryComboBox.Size = new System.Drawing.Size(121, 21);
			this.UserCategoryComboBox.TabIndex = 32;
			this.UserCategoryComboBox.Click += new System.EventHandler(this.UserCategoryComboBox_Click);
			// 
			// comboBoxState
			// 
			this.comboBoxState.FormattingEnabled = true;
			this.comboBoxState.Items.AddRange(new object[] {
            "Actif",
            "Inactif"});
			this.comboBoxState.Location = new System.Drawing.Point(190, 198);
			this.comboBoxState.Name = "comboBoxState";
			this.comboBoxState.Size = new System.Drawing.Size(121, 21);
			this.comboBoxState.TabIndex = 31;
			// 
			// textBoxWallet
			// 
			this.textBoxWallet.Location = new System.Drawing.Point(190, 161);
			this.textBoxWallet.Name = "textBoxWallet";
			this.textBoxWallet.Size = new System.Drawing.Size(100, 20);
			this.textBoxWallet.TabIndex = 30;
			// 
			// textBoxMail
			// 
			this.textBoxMail.Location = new System.Drawing.Point(190, 113);
			this.textBoxMail.Name = "textBoxMail";
			this.textBoxMail.Size = new System.Drawing.Size(100, 20);
			this.textBoxMail.TabIndex = 28;
			// 
			// textBox_lastName
			// 
			this.textBox_lastName.Location = new System.Drawing.Point(190, 71);
			this.textBox_lastName.Name = "textBox_lastName";
			this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
			this.textBox_lastName.TabIndex = 27;
			// 
			// textBox_firstName
			// 
			this.textBox_firstName.Location = new System.Drawing.Point(190, 32);
			this.textBox_firstName.Name = "textBox_firstName";
			this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
			this.textBox_firstName.TabIndex = 26;
			this.textBox_firstName.TextChanged += new System.EventHandler(this.textBox_firstName_TextChanged);
			this.textBox_firstName.MouseHover += new System.EventHandler(this.textBox_firstName_TextChanged);
			// 
			// subCategory
			// 
			this.subCategory.AutoSize = true;
			this.subCategory.Location = new System.Drawing.Point(406, 250);
			this.subCategory.Name = "subCategory";
			this.subCategory.Size = new System.Drawing.Size(84, 13);
			this.subCategory.TabIndex = 25;
			this.subCategory.Text = "Sous-catégorie :";
			// 
			// wallet
			// 
			this.wallet.AutoSize = true;
			this.wallet.Location = new System.Drawing.Point(35, 161);
			this.wallet.Name = "wallet";
			this.wallet.Size = new System.Drawing.Size(82, 13);
			this.wallet.TabIndex = 24;
			this.wallet.Text = "Porte-Monnaie :";
			// 
			// mail
			// 
			this.mail.AutoSize = true;
			this.mail.Location = new System.Drawing.Point(35, 116);
			this.mail.Name = "mail";
			this.mail.Size = new System.Drawing.Size(38, 13);
			this.mail.TabIndex = 21;
			this.mail.Text = "Email :";
			// 
			// lastName
			// 
			this.lastName.AutoSize = true;
			this.lastName.Location = new System.Drawing.Point(35, 78);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(38, 13);
			this.lastName.TabIndex = 20;
			this.lastName.Text = "Nom : ";
			// 
			// firstName
			// 
			this.firstName.AutoSize = true;
			this.firstName.Location = new System.Drawing.Point(35, 32);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(49, 13);
			this.firstName.TabIndex = 19;
			this.firstName.Text = "Prénom :";
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(561, 335);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 36;
			this.buttonBack.Text = "Retour";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// button_confirm
			// 
			this.button_confirm.Location = new System.Drawing.Point(304, 335);
			this.button_confirm.Name = "button_confirm";
			this.button_confirm.Size = new System.Drawing.Size(75, 23);
			this.button_confirm.TabIndex = 35;
			this.button_confirm.Text = "Valider";
			this.button_confirm.UseVisualStyleBackColor = true;
			this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
			// 
			// richTextBoxAdress
			// 
			this.richTextBoxAdress.Location = new System.Drawing.Point(561, 20);
			this.richTextBoxAdress.Name = "richTextBoxAdress";
			this.richTextBoxAdress.Size = new System.Drawing.Size(223, 71);
			this.richTextBoxAdress.TabIndex = 37;
			this.richTextBoxAdress.Text = "";
			// 
			// richTextBoxHistoric
			// 
			this.richTextBoxHistoric.Location = new System.Drawing.Point(561, 106);
			this.richTextBoxHistoric.Name = "richTextBoxHistoric";
			this.richTextBoxHistoric.Size = new System.Drawing.Size(223, 84);
			this.richTextBoxHistoric.TabIndex = 38;
			this.richTextBoxHistoric.Text = "";
			// 
			// labelAdress
			// 
			this.labelAdress.AutoSize = true;
			this.labelAdress.Location = new System.Drawing.Point(404, 39);
			this.labelAdress.Name = "labelAdress";
			this.labelAdress.Size = new System.Drawing.Size(51, 13);
			this.labelAdress.TabIndex = 39;
			this.labelAdress.Text = "Adresse :";
			// 
			// labelHistoric
			// 
			this.labelHistoric.AutoSize = true;
			this.labelHistoric.Location = new System.Drawing.Point(404, 106);
			this.labelHistoric.Name = "labelHistoric";
			this.labelHistoric.Size = new System.Drawing.Size(60, 13);
			this.labelHistoric.TabIndex = 40;
			this.labelHistoric.Text = "Historique :";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(190, 247);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.textBoxPhone.TabIndex = 41;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(35, 247);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(64, 13);
			this.labelPhone.TabIndex = 42;
			this.labelPhone.Text = "Téléphone :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 43;
			this.label1.Text = "Etat de l\'utilisateur : ";
			// 
			// ModifyAccountView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 354);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelHistoric);
			this.Controls.Add(this.labelAdress);
			this.Controls.Add(this.richTextBoxHistoric);
			this.Controls.Add(this.richTextBoxAdress);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.button_confirm);
			this.Controls.Add(this.MainCategoryComboBox);
			this.Controls.Add(this.CategoryLabel);
			this.Controls.Add(this.UserCategoryComboBox);
			this.Controls.Add(this.comboBoxState);
			this.Controls.Add(this.textBoxWallet);
			this.Controls.Add(this.textBoxMail);
			this.Controls.Add(this.textBox_lastName);
			this.Controls.Add(this.textBox_firstName);
			this.Controls.Add(this.subCategory);
			this.Controls.Add(this.wallet);
			this.Controls.Add(this.mail);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.firstName);
			this.Name = "ModifyAccountView";
			this.Text = "PixLogic - Modifier un compte d\'utilisateur";
			this.Load += new System.EventHandler(this.ModifyAccountView_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MainCategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox UserCategoryComboBox;
        private System.Windows.Forms.ComboBox comboBoxState;
		private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label subCategory;
		private System.Windows.Forms.Label wallet;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button_confirm;
		private System.Windows.Forms.RichTextBox richTextBoxAdress;
		private System.Windows.Forms.RichTextBox richTextBoxHistoric;
		private System.Windows.Forms.Label labelAdress;
		private System.Windows.Forms.Label labelHistoric;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label label1;
    }
}