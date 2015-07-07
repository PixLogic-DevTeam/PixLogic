namespace ITI.PixLogic.WinApp
{
    partial class AddAccountView
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
			this.firstName = new System.Windows.Forms.Label();
			this.lastName = new System.Windows.Forms.Label();
			this.mail = new System.Windows.Forms.Label();
			this.state = new System.Windows.Forms.Label();
			this.wallet = new System.Windows.Forms.Label();
			this.subCategory = new System.Windows.Forms.Label();
			this.textBox_firstName = new System.Windows.Forms.TextBox();
			this.textBox_lastName = new System.Windows.Forms.TextBox();
			this.textBoxMail = new System.Windows.Forms.TextBox();
			this.textBoxWallet = new System.Windows.Forms.TextBox();
			this.button_confirm = new System.Windows.Forms.Button();
			this.comboBoxState = new System.Windows.Forms.ComboBox();
			this.UserCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.MainCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.buttonBack = new System.Windows.Forms.Button();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelAdress = new System.Windows.Forms.Label();
			this.richTextBoxAdress = new System.Windows.Forms.RichTextBox();
			this.richTextBoxHistoric = new System.Windows.Forms.RichTextBox();
			this.labelHistoric = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// firstName
			// 
			this.firstName.AutoSize = true;
			this.firstName.Location = new System.Drawing.Point(45, 41);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(49, 13);
			this.firstName.TabIndex = 0;
			this.firstName.Text = "Prénom :";
			this.firstName.Click += new System.EventHandler(this.label1_Click);
			// 
			// lastName
			// 
			this.lastName.AutoSize = true;
			this.lastName.Location = new System.Drawing.Point(45, 83);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(38, 13);
			this.lastName.TabIndex = 1;
			this.lastName.Text = "Nom : ";
			// 
			// mail
			// 
			this.mail.AutoSize = true;
			this.mail.Location = new System.Drawing.Point(48, 120);
			this.mail.Name = "mail";
			this.mail.Size = new System.Drawing.Size(38, 13);
			this.mail.TabIndex = 2;
			this.mail.Text = "Email :";
			// 
			// state
			// 
			this.state.AutoSize = true;
			this.state.Location = new System.Drawing.Point(45, 219);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(101, 13);
			this.state.TabIndex = 4;
			this.state.Text = "Etat de l\'utilisateur : ";
			// 
			// wallet
			// 
			this.wallet.AutoSize = true;
			this.wallet.Location = new System.Drawing.Point(45, 169);
			this.wallet.Name = "wallet";
			this.wallet.Size = new System.Drawing.Size(82, 13);
			this.wallet.TabIndex = 5;
			this.wallet.Text = "Porte-Monnaie :";
			// 
			// subCategory
			// 
			this.subCategory.AutoSize = true;
			this.subCategory.Location = new System.Drawing.Point(385, 252);
			this.subCategory.Name = "subCategory";
			this.subCategory.Size = new System.Drawing.Size(84, 13);
			this.subCategory.TabIndex = 7;
			this.subCategory.Text = "Sous-catégorie :";
			// 
			// textBox_firstName
			// 
			this.textBox_firstName.Location = new System.Drawing.Point(224, 33);
			this.textBox_firstName.Name = "textBox_firstName";
			this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
			this.textBox_firstName.TabIndex = 8;
			// 
			// textBox_lastName
			// 
			this.textBox_lastName.Location = new System.Drawing.Point(224, 75);
			this.textBox_lastName.Name = "textBox_lastName";
			this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
			this.textBox_lastName.TabIndex = 9;
			// 
			// textBoxMail
			// 
			this.textBoxMail.Location = new System.Drawing.Point(224, 120);
			this.textBoxMail.Name = "textBoxMail";
			this.textBoxMail.Size = new System.Drawing.Size(100, 20);
			this.textBoxMail.TabIndex = 10;
			// 
			// textBoxWallet
			// 
			this.textBoxWallet.Location = new System.Drawing.Point(224, 169);
			this.textBoxWallet.Name = "textBoxWallet";
			this.textBoxWallet.Size = new System.Drawing.Size(100, 20);
			this.textBoxWallet.TabIndex = 13;
			this.textBoxWallet.TextChanged += new System.EventHandler(this.textBoxWallet_TextChanged);
			// 
			// button_confirm
			// 
			this.button_confirm.Location = new System.Drawing.Point(749, 28);
			this.button_confirm.Name = "button_confirm";
			this.button_confirm.Size = new System.Drawing.Size(75, 23);
			this.button_confirm.TabIndex = 14;
			this.button_confirm.Text = "Valider";
			this.button_confirm.UseVisualStyleBackColor = true;
			this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
			// 
			// comboBoxState
			// 
			this.comboBoxState.FormattingEnabled = true;
			this.comboBoxState.Items.AddRange(new object[] {
            "Actif",
            "Inactif",
            "Banni"});
			this.comboBoxState.Location = new System.Drawing.Point(224, 219);
			this.comboBoxState.Name = "comboBoxState";
			this.comboBoxState.Size = new System.Drawing.Size(121, 21);
			this.comboBoxState.TabIndex = 15;
			// 
			// UserCategoryComboBox
			// 
			this.UserCategoryComboBox.FormattingEnabled = true;
			this.UserCategoryComboBox.Location = new System.Drawing.Point(481, 252);
			this.UserCategoryComboBox.Name = "UserCategoryComboBox";
			this.UserCategoryComboBox.Size = new System.Drawing.Size(121, 21);
			this.UserCategoryComboBox.TabIndex = 16;
			this.UserCategoryComboBox.Click += new System.EventHandler(this.UserCategoryComboBox_Click);
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(385, 291);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(58, 13);
			this.CategoryLabel.TabIndex = 17;
			this.CategoryLabel.Text = "Catégorie :";
			this.CategoryLabel.Click += new System.EventHandler(this.CategoryLabel_Click);
			// 
			// MainCategoryComboBox
			// 
			this.MainCategoryComboBox.FormattingEnabled = true;
			this.MainCategoryComboBox.Location = new System.Drawing.Point(481, 286);
			this.MainCategoryComboBox.Name = "MainCategoryComboBox";
			this.MainCategoryComboBox.Size = new System.Drawing.Size(121, 21);
			this.MainCategoryComboBox.TabIndex = 18;
			this.MainCategoryComboBox.Click += new System.EventHandler(this.MainCategoryComboBox_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(749, 72);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 19;
			this.buttonBack.Text = "Retour";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(48, 271);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(64, 13);
			this.labelPhone.TabIndex = 20;
			this.labelPhone.Text = "Téléphone :";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Location = new System.Drawing.Point(224, 271);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.textBoxPhone.TabIndex = 21;
			this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
			// 
			// labelAdress
			// 
			this.labelAdress.AutoSize = true;
			this.labelAdress.Location = new System.Drawing.Point(399, 33);
			this.labelAdress.Name = "labelAdress";
			this.labelAdress.Size = new System.Drawing.Size(51, 13);
			this.labelAdress.TabIndex = 22;
			this.labelAdress.Text = "Adresse :";
			// 
			// richTextBoxAdress
			// 
			this.richTextBoxAdress.Location = new System.Drawing.Point(481, 33);
			this.richTextBoxAdress.Name = "richTextBoxAdress";
			this.richTextBoxAdress.Size = new System.Drawing.Size(223, 71);
			this.richTextBoxAdress.TabIndex = 23;
			this.richTextBoxAdress.Text = "";
			// 
			// richTextBoxHistoric
			// 
			this.richTextBoxHistoric.Location = new System.Drawing.Point(481, 138);
			this.richTextBoxHistoric.Name = "richTextBoxHistoric";
			this.richTextBoxHistoric.Size = new System.Drawing.Size(223, 84);
			this.richTextBoxHistoric.TabIndex = 24;
			this.richTextBoxHistoric.Text = "";
			// 
			// labelHistoric
			// 
			this.labelHistoric.AutoSize = true;
			this.labelHistoric.Location = new System.Drawing.Point(399, 141);
			this.labelHistoric.Name = "labelHistoric";
			this.labelHistoric.Size = new System.Drawing.Size(60, 13);
			this.labelHistoric.TabIndex = 25;
			this.labelHistoric.Text = "Historique :";
			this.labelHistoric.Click += new System.EventHandler(this.labelHistoric_Click);
			// 
			// AddAccountView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 435);
			this.Controls.Add(this.labelHistoric);
			this.Controls.Add(this.richTextBoxHistoric);
			this.Controls.Add(this.richTextBoxAdress);
			this.Controls.Add(this.labelAdress);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.MainCategoryComboBox);
			this.Controls.Add(this.CategoryLabel);
			this.Controls.Add(this.UserCategoryComboBox);
			this.Controls.Add(this.comboBoxState);
			this.Controls.Add(this.button_confirm);
			this.Controls.Add(this.textBoxWallet);
			this.Controls.Add(this.textBoxMail);
			this.Controls.Add(this.textBox_lastName);
			this.Controls.Add(this.textBox_firstName);
			this.Controls.Add(this.subCategory);
			this.Controls.Add(this.wallet);
			this.Controls.Add(this.state);
			this.Controls.Add(this.mail);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.firstName);
			this.Name = "AddAccountView";
			this.Text = "PixLogic - Ajouter un compte d\'utilisateur";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
		private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label wallet;
        private System.Windows.Forms.Label subCategory;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
		private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox UserCategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox MainCategoryComboBox;
        private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelAdress;
		private System.Windows.Forms.RichTextBox richTextBoxAdress;
		private System.Windows.Forms.RichTextBox richTextBoxHistoric;
		private System.Windows.Forms.Label labelHistoric;
    }
}