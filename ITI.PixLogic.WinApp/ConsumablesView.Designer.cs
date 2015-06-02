namespace ITI.PixLogic.WinApp
{
	partial class ConsumablesView
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
			if( disposing && (components != null) )
			{
				components.Dispose();
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label nameLabel1;
			this.consumablesdataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.currentstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.consumablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.Clear_datagridview = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.nameSubCategory = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.button_back = new System.Windows.Forms.Button();
			this.button_modify = new System.Windows.Forms.Button();
			nameLabel = new System.Windows.Forms.Label();
			nameLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.consumablesdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.consumablesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(1, 242);
			nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(78, 13);
			nameLabel.TabIndex = 4;
			nameLabel.Text = "Sous-catégorie";
			nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
			// 
			// nameLabel1
			// 
			nameLabel1.AutoSize = true;
			nameLabel1.Location = new System.Drawing.Point(1, 205);
			nameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			nameLabel1.Name = "nameLabel1";
			nameLabel1.Size = new System.Drawing.Size(52, 13);
			nameLabel1.TabIndex = 6;
			nameLabel1.Text = "Catégorie";
			// 
			// consumablesdataGridView
			// 
			this.consumablesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consumablesdataGridView.AutoGenerateColumns = false;
			this.consumablesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.consumablesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.consumablesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.consumablesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.reservationcostDataGridViewTextBoxColumn,
            this.subcategoryDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.currentstateDataGridViewTextBoxColumn});
			this.consumablesdataGridView.DataSource = this.consumablesBindingSource;
			this.consumablesdataGridView.Location = new System.Drawing.Point(137, 10);
			this.consumablesdataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.consumablesdataGridView.Name = "consumablesdataGridView";
			this.consumablesdataGridView.ReadOnly = true;
			this.consumablesdataGridView.RowTemplate.Height = 24;
			this.consumablesdataGridView.Size = new System.Drawing.Size(721, 494);
			this.consumablesdataGridView.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// reservationcostDataGridViewTextBoxColumn
			// 
			this.reservationcostDataGridViewTextBoxColumn.DataPropertyName = "reservation_cost";
			this.reservationcostDataGridViewTextBoxColumn.HeaderText = "reservation_cost";
			this.reservationcostDataGridViewTextBoxColumn.Name = "reservationcostDataGridViewTextBoxColumn";
			this.reservationcostDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// subcategoryDataGridViewTextBoxColumn
			// 
			this.subcategoryDataGridViewTextBoxColumn.DataPropertyName = "sub_category";
			this.subcategoryDataGridViewTextBoxColumn.HeaderText = "sub_category";
			this.subcategoryDataGridViewTextBoxColumn.Name = "subcategoryDataGridViewTextBoxColumn";
			this.subcategoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// invoiceDataGridViewTextBoxColumn
			// 
			this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "invoice";
			this.invoiceDataGridViewTextBoxColumn.HeaderText = "invoice";
			this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
			this.invoiceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// currentstateDataGridViewTextBoxColumn
			// 
			this.currentstateDataGridViewTextBoxColumn.DataPropertyName = "current_state";
			this.currentstateDataGridViewTextBoxColumn.HeaderText = "current_state";
			this.currentstateDataGridViewTextBoxColumn.Name = "currentstateDataGridViewTextBoxColumn";
			this.currentstateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// consumablesBindingSource
			// 
			this.consumablesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.consumables);
			this.consumablesBindingSource.CurrentChanged += new System.EventHandler(this.consumablesBindingSource_CurrentChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 11);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 19);
			this.button1.TabIndex = 0;
			// 
			// Clear_datagridview
			// 
			this.Clear_datagridview.Location = new System.Drawing.Point(23, 38);
			this.Clear_datagridview.Margin = new System.Windows.Forms.Padding(2);
			this.Clear_datagridview.Name = "Clear_datagridview";
			this.Clear_datagridview.Size = new System.Drawing.Size(75, 23);
			this.Clear_datagridview.TabIndex = 1;
			this.Clear_datagridview.Text = "Supprimer";
			this.Clear_datagridview.UseVisualStyleBackColor = true;
			this.Clear_datagridview.Click += new System.EventHandler(this.Clear_datagridview_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(23, 11);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Ajouter";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// nameSubCategory
			// 
			this.nameSubCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumablesBindingSource, "consumables_sub_categories.name", true));
			this.nameSubCategory.Location = new System.Drawing.Point(4, 257);
			this.nameSubCategory.Margin = new System.Windows.Forms.Padding(2);
			this.nameSubCategory.Name = "nameSubCategory";
			this.nameSubCategory.Size = new System.Drawing.Size(129, 20);
			this.nameSubCategory.TabIndex = 5;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumablesBindingSource, "consumables_sub_categories.consumables_main_categories.name", true));
			this.nameTextBox.Location = new System.Drawing.Point(4, 220);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(129, 20);
			this.nameTextBox.TabIndex = 7;
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(23, 95);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(75, 23);
			this.button_back.TabIndex = 8;
			this.button_back.Text = "Retour";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// button_modify
			// 
			this.button_modify.Location = new System.Drawing.Point(23, 66);
			this.button_modify.Name = "button_modify";
			this.button_modify.Size = new System.Drawing.Size(75, 23);
			this.button_modify.TabIndex = 9;
			this.button_modify.Text = "Modifier";
			this.button_modify.UseVisualStyleBackColor = true;
			// 
			// ConsumablesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 549);
			this.Controls.Add(this.button_modify);
			this.Controls.Add(this.button_back);
			this.Controls.Add(nameLabel1);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameSubCategory);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Clear_datagridview);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.consumablesdataGridView);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ConsumablesView";
			this.Text = "PixLogic - Objets consommables";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.consumablesdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.consumablesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridView consumablesdataGridView;
        private System.Windows.Forms.BindingSource consumablesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear_datagridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameSubCategory;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_modify;
	}
}

