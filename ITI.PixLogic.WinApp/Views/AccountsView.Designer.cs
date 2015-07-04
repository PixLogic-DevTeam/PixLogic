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
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.historicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.walletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button_back = new System.Windows.Forms.Button();
			this.button_add = new System.Windows.Forms.Button();
			this.button_delete = new System.Windows.Forms.Button();
			this.button_modify = new System.Windows.Forms.Button();
			this.accounts_sub_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.accounts_main_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataListView1 = new BrightIdeasSoftware.DataListView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_sub_categoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_main_categoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			this.SuspendLayout();
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
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.historicDataGridViewTextBoxColumn,
            this.walletDataGridViewTextBoxColumn});
			this.dataGridViewUsers.DataSource = this.accountBindingSource;
			this.dataGridViewUsers.Location = new System.Drawing.Point(928, 273);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.Size = new System.Drawing.Size(66, 58);
			this.dataGridViewUsers.TabIndex = 0;
			this.dataGridViewUsers.Visible = false;
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
			// accountBindingSource
			// 
			this.accountBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Account);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(191, 437);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(75, 23);
			this.button_back.TabIndex = 2;
			this.button_back.Text = "Retour";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(350, 437);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(75, 23);
			this.button_add.TabIndex = 3;
			this.button_add.Text = "Ajouter";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(500, 437);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(75, 23);
			this.button_delete.TabIndex = 4;
			this.button_delete.Text = "Supprimer";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_modify
			// 
			this.button_modify.Location = new System.Drawing.Point(653, 437);
			this.button_modify.Name = "button_modify";
			this.button_modify.Size = new System.Drawing.Size(75, 23);
			this.button_modify.TabIndex = 5;
			this.button_modify.Text = "Modifier";
			this.button_modify.UseVisualStyleBackColor = true;
			this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
			// 
			// accounts_sub_categoriesBindingSource
			// 
			this.accounts_sub_categoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.AccountDivision);
			// 
			// accounts_main_categoriesBindingSource
			// 
			this.accounts_main_categoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.AccountCategory);
			// 
			// dataListView1
			// 
			this.dataListView1.DataSource = this.accountBindingSource;
			this.dataListView1.Location = new System.Drawing.Point(62, 32);
			this.dataListView1.Name = "dataListView1";
			this.dataListView1.Size = new System.Drawing.Size(932, 356);
			this.dataListView1.TabIndex = 10;
			this.dataListView1.UseCompatibleStateImageBehavior = false;
			this.dataListView1.View = System.Windows.Forms.View.Details;
			// 
			// AccountsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 549);
			this.Controls.Add(this.dataListView1);
			this.Controls.Add(this.button_modify);
			this.Controls.Add(this.button_delete);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.dataGridViewUsers);
			this.Name = "AccountsView";
			this.Text = "PixLogic - Comptes d\'utilisateurs";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_sub_categoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_main_categoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource accountBindingSource;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
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
		private System.Windows.Forms.BindingSource accounts_main_categoriesBindingSource;
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
		private BrightIdeasSoftware.DataListView dataListView1;
    }
}