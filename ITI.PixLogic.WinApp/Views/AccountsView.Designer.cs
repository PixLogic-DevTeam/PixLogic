namespace ITI.PixLogic.WinApp
{
    partial class AccountsView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save_button = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.accounts_sub_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameSubCategory = new System.Windows.Forms.TextBox();
            this.accounts_main_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameMainCategory = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bannedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.picturePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountSubCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDataListView = new BrightIdeasSoftware.DataListView();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_sub_categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_main_categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(1253, 107);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(94, 17);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Sub Category";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(1248, 26);
            nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(99, 17);
            nameLabel1.TabIndex = 8;
            nameLabel1.Text = "Main Category";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.saltDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.historicDataGridViewTextBoxColumn,
            this.walletDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.bannedDataGridViewCheckBoxColumn,
            this.picturePathDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn,
            this.accountSubCategoryDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.accountBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(386, 319);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(88, 71);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.Visible = false;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Accounts.Account);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(53, 453);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 28);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Sauvegarder";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(291, 453);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(100, 28);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Retour";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(536, 453);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 28);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(760, 452);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 28);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Supprimer";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(981, 452);
            this.button_modify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(100, 28);
            this.button_modify.TabIndex = 5;
            this.button_modify.Text = "Modifier";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // accounts_sub_categoriesBindingSource
            // 
            this.accounts_sub_categoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Accounts.AccountSubCategory);
            // 
            // nameSubCategory
            // 
            this.nameSubCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accounts_sub_categoriesBindingSource, "name", true));
            this.nameSubCategory.Location = new System.Drawing.Point(1237, 144);
            this.nameSubCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameSubCategory.Name = "nameSubCategory";
            this.nameSubCategory.Size = new System.Drawing.Size(132, 22);
            this.nameSubCategory.TabIndex = 8;
            // 
            // accounts_main_categoriesBindingSource
            // 
            this.accounts_main_categoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Accounts.AccountMainCategory);
            // 
            // nameMainCategory
            // 
            this.nameMainCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accounts_main_categoriesBindingSource, "name", true));
            this.nameMainCategory.Location = new System.Drawing.Point(1237, 63);
            this.nameMainCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameMainCategory.Name = "nameMainCategory";
            this.nameMainCategory.Size = new System.Drawing.Size(132, 22);
            this.nameMainCategory.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saltDataGridViewTextBoxColumn
            // 
            this.saltDataGridViewTextBoxColumn.DataPropertyName = "Salt";
            this.saltDataGridViewTextBoxColumn.HeaderText = "Salt";
            this.saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            this.saltDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicDataGridViewTextBoxColumn
            // 
            this.historicDataGridViewTextBoxColumn.DataPropertyName = "Historic";
            this.historicDataGridViewTextBoxColumn.HeaderText = "Historic";
            this.historicDataGridViewTextBoxColumn.Name = "historicDataGridViewTextBoxColumn";
            this.historicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // walletDataGridViewTextBoxColumn
            // 
            this.walletDataGridViewTextBoxColumn.DataPropertyName = "Wallet";
            this.walletDataGridViewTextBoxColumn.HeaderText = "Wallet";
            this.walletDataGridViewTextBoxColumn.Name = "walletDataGridViewTextBoxColumn";
            this.walletDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bannedDataGridViewCheckBoxColumn
            // 
            this.bannedDataGridViewCheckBoxColumn.DataPropertyName = "Banned";
            this.bannedDataGridViewCheckBoxColumn.HeaderText = "Banned";
            this.bannedDataGridViewCheckBoxColumn.Name = "bannedDataGridViewCheckBoxColumn";
            this.bannedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // picturePathDataGridViewTextBoxColumn
            // 
            this.picturePathDataGridViewTextBoxColumn.DataPropertyName = "PicturePath";
            this.picturePathDataGridViewTextBoxColumn.HeaderText = "PicturePath";
            this.picturePathDataGridViewTextBoxColumn.Name = "picturePathDataGridViewTextBoxColumn";
            this.picturePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            this.subCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.HeaderText = "SubCategory";
            this.subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            this.subCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountSubCategoryDataGridViewTextBoxColumn
            // 
            this.accountSubCategoryDataGridViewTextBoxColumn.DataPropertyName = "AccountSubCategory";
            this.accountSubCategoryDataGridViewTextBoxColumn.HeaderText = "AccountSubCategory";
            this.accountSubCategoryDataGridViewTextBoxColumn.Name = "accountSubCategoryDataGridViewTextBoxColumn";
            this.accountSubCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccountDataListView
            // 
            this.AccountDataListView.DataSource = this.accountBindingSource;
            this.AccountDataListView.Location = new System.Drawing.Point(12, 12);
            this.AccountDataListView.Name = "AccountDataListView";
            this.AccountDataListView.Size = new System.Drawing.Size(1435, 421);
            this.AccountDataListView.TabIndex = 10;
            this.AccountDataListView.UseCompatibleStateImageBehavior = false;
            this.AccountDataListView.View = System.Windows.Forms.View.Details;
            // 
            // AccountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 676);
            this.Controls.Add(this.AccountDataListView);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameMainCategory);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameSubCategory);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dataGridViewUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountsView";
            this.Text = "PixLogic - Comptes d\'utilisateurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_sub_categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_main_categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn walletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.BindingSource accounts_sub_categoriesBindingSource;
        private System.Windows.Forms.TextBox nameSubCategory;
        private System.Windows.Forms.BindingSource accounts_main_categoriesBindingSource;
        private System.Windows.Forms.TextBox nameMainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bannedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSubCategoryDataGridViewTextBoxColumn;
        private BrightIdeasSoftware.DataListView AccountDataListView;
    }
}