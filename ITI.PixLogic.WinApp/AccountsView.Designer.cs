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
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.walletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			nameLabel = new System.Windows.Forms.Label();
			nameLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_sub_categoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_main_categoriesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(940, 87);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(71, 13);
			nameLabel.TabIndex = 6;
			nameLabel.Text = "Sub Category";
			// 
			// nameLabel1
			// 
			nameLabel1.AutoSize = true;
			nameLabel1.Location = new System.Drawing.Point(936, 21);
			nameLabel1.Name = "nameLabel1";
			nameLabel1.Size = new System.Drawing.Size(75, 13);
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
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.walletDataGridViewTextBoxColumn,
            this.subcategoryDataGridViewTextBoxColumn});
			this.dataGridViewUsers.DataSource = this.accountBindingSource;
			this.dataGridViewUsers.Location = new System.Drawing.Point(2, 2);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.Size = new System.Drawing.Size(844, 494);
			this.dataGridViewUsers.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstnameDataGridViewTextBoxColumn
			// 
			this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
			this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
			this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
			this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastnameDataGridViewTextBoxColumn
			// 
			this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
			this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
			this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
			this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// activeDataGridViewTextBoxColumn
			// 
			this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
			this.activeDataGridViewTextBoxColumn.HeaderText = "active";
			this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
			this.activeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// walletDataGridViewTextBoxColumn
			// 
			this.walletDataGridViewTextBoxColumn.DataPropertyName = "wallet";
			this.walletDataGridViewTextBoxColumn.HeaderText = "wallet";
			this.walletDataGridViewTextBoxColumn.Name = "walletDataGridViewTextBoxColumn";
			this.walletDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// subcategoryDataGridViewTextBoxColumn
			// 
			this.subcategoryDataGridViewTextBoxColumn.DataPropertyName = "sub_category";
			this.subcategoryDataGridViewTextBoxColumn.HeaderText = "sub_category";
			this.subcategoryDataGridViewTextBoxColumn.Name = "subcategoryDataGridViewTextBoxColumn";
			this.subcategoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// accountBindingSource
			// 
			this.accountBindingSource.DataSource = typeof(ITI.PixLogic.DAL.accounts);
			// 
			// save_button
			// 
			this.save_button.Location = new System.Drawing.Point(40, 368);
			this.save_button.Name = "save_button";
			this.save_button.Size = new System.Drawing.Size(75, 23);
			this.save_button.TabIndex = 1;
			this.save_button.Text = "Sauvegarder";
			this.save_button.UseVisualStyleBackColor = true;
			this.save_button.Click += new System.EventHandler(this.save_button_Click);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(218, 368);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(75, 23);
			this.button_back.TabIndex = 2;
			this.button_back.Text = "Retour";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(402, 368);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(75, 23);
			this.button_add.TabIndex = 3;
			this.button_add.Text = "Ajouter";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(570, 367);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(75, 23);
			this.button_delete.TabIndex = 4;
			this.button_delete.Text = "Supprimer";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_modify
			// 
			this.button_modify.Location = new System.Drawing.Point(736, 367);
			this.button_modify.Name = "button_modify";
			this.button_modify.Size = new System.Drawing.Size(75, 23);
			this.button_modify.TabIndex = 5;
			this.button_modify.Text = "Modifier";
			this.button_modify.UseVisualStyleBackColor = true;
			this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
			// 
			// accounts_sub_categoriesBindingSource
			// 
			this.accounts_sub_categoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.accounts_sub_categories);
			// 
			// nameSubCategory
			// 
			this.nameSubCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accounts_sub_categoriesBindingSource, "name", true));
			this.nameSubCategory.Location = new System.Drawing.Point(928, 117);
			this.nameSubCategory.Name = "nameSubCategory";
			this.nameSubCategory.Size = new System.Drawing.Size(100, 20);
			this.nameSubCategory.TabIndex = 8;
			// 
			// accounts_main_categoriesBindingSource
			// 
			this.accounts_main_categoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.accounts_main_categories);
			// 
			// nameMainCategory
			// 
			this.nameMainCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accounts_main_categoriesBindingSource, "name", true));
			this.nameMainCategory.Location = new System.Drawing.Point(928, 51);
			this.nameMainCategory.Name = "nameMainCategory";
			this.nameMainCategory.Size = new System.Drawing.Size(100, 20);
			this.nameMainCategory.TabIndex = 9;
			// 
			// Accounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1094, 549);
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
			this.Name = "Accounts";
			this.Text = "PixLogic - Comptes d\'utilisateurs";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_sub_categoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accounts_main_categoriesBindingSource)).EndInit();
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
    }
}