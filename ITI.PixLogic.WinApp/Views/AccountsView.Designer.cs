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
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.button_back = new System.Windows.Forms.Button();
			this.button_add = new System.Windows.Forms.Button();
			this.button_delete = new System.Windows.Forms.Button();
			this.button_modify = new System.Windows.Forms.Button();
			this.dataListView1 = new BrightIdeasSoftware.DataListView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.AllowUserToAddRows = false;
			this.dataGridViewUsers.AllowUserToOrderColumns = true;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Location = new System.Drawing.Point(928, 273);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.Size = new System.Drawing.Size(66, 58);
			this.dataGridViewUsers.TabIndex = 0;
			this.dataGridViewUsers.Visible = false;
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(191, 437);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(86, 33);
			this.button_back.TabIndex = 2;
			this.button_back.Text = "Retour";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(319, 437);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(83, 33);
			this.button_add.TabIndex = 3;
			this.button_add.Text = "Ajouter";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(441, 437);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(84, 33);
			this.button_delete.TabIndex = 4;
			this.button_delete.Text = "Supprimer";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// button_modify
			// 
			this.button_modify.Location = new System.Drawing.Point(555, 437);
			this.button_modify.Name = "button_modify";
			this.button_modify.Size = new System.Drawing.Size(81, 33);
			this.button_modify.TabIndex = 5;
			this.button_modify.Text = "Modifier";
			this.button_modify.UseVisualStyleBackColor = true;
			this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
			// 
			// dataListView1
			// 
			this.dataListView1.DataSource = null;
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
			this.ClientSize = new System.Drawing.Size(1028, 544);
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
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button_back;
		private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_delete;
		private System.Windows.Forms.Button button_modify;
		private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bannedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountSubCategoryDataGridViewTextBoxColumn;
		private BrightIdeasSoftware.DataListView dataListView1;
    }
}