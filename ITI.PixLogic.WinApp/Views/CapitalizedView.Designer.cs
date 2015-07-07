namespace ITI.PixLogic.WinApp
{
    partial class CapitalizedView
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
			this.components = new System.ComponentModel.Container();
			this.Suppr_Btn = new System.Windows.Forms.Button();
			this.Add_Btn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.BackBtn = new System.Windows.Forms.Button();
			this.CapitalizedDataListView = new BrightIdeasSoftware.DataListView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.itemsEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.itemBrandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemFunctionalCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemStatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewitemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.CapitalizedDataListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsEntityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Suppr_Btn
			// 
			this.Suppr_Btn.Location = new System.Drawing.Point(301, 176);
			this.Suppr_Btn.Name = "Suppr_Btn";
			this.Suppr_Btn.Size = new System.Drawing.Size(91, 52);
			this.Suppr_Btn.TabIndex = 1;
			this.Suppr_Btn.Text = "Supprimer";
			this.Suppr_Btn.UseVisualStyleBackColor = true;
			this.Suppr_Btn.Click += new System.EventHandler(this.Suppr_Btn_Click);
			// 
			// Add_Btn
			// 
			this.Add_Btn.Location = new System.Drawing.Point(301, 25);
			this.Add_Btn.Name = "Add_Btn";
			this.Add_Btn.Size = new System.Drawing.Size(91, 52);
			this.Add_Btn.TabIndex = 2;
			this.Add_Btn.Text = "Ajouter";
			this.Add_Btn.UseVisualStyleBackColor = true;
			this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Location = new System.Drawing.Point(301, 100);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(91, 52);
			this.EditBtn.TabIndex = 3;
			this.EditBtn.Text = "Modifier";
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// BackBtn
			// 
			this.BackBtn.Location = new System.Drawing.Point(1, 90);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(66, 53);
			this.BackBtn.TabIndex = 4;
			this.BackBtn.Text = "Retour";
			this.BackBtn.UseVisualStyleBackColor = true;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			// 
			// CapitalizedDataListView
			// 
			this.CapitalizedDataListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CapitalizedDataListView.AutoArrange = false;
			this.CapitalizedDataListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
			this.CapitalizedDataListView.DataSource = this.itemsEntityBindingSource;
			this.CapitalizedDataListView.Location = new System.Drawing.Point(134, 11);
			this.CapitalizedDataListView.Name = "CapitalizedDataListView";
			this.CapitalizedDataListView.Size = new System.Drawing.Size(1027, 387);
			this.CapitalizedDataListView.TabIndex = 1;
			this.CapitalizedDataListView.UseCompatibleStateImageBehavior = false;
			this.CapitalizedDataListView.View = System.Windows.Forms.View.Details;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemBrandsDataGridViewTextBoxColumn,
            this.itemCategoriesDataGridViewTextBoxColumn,
            this.itemFunctionalCategoriesDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.itemStatesDataGridViewTextBoxColumn,
            this.viewitemsDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.itemsEntityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(1, 306);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(101, 68);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.Visible = false;
			// 
			// itemsEntityBindingSource
			// 
			this.itemsEntityBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.ItemsEntity);
			// 
			// itemBrandsDataGridViewTextBoxColumn
			// 
			this.itemBrandsDataGridViewTextBoxColumn.DataPropertyName = "ItemBrands";
			this.itemBrandsDataGridViewTextBoxColumn.HeaderText = "ItemBrands";
			this.itemBrandsDataGridViewTextBoxColumn.Name = "itemBrandsDataGridViewTextBoxColumn";
			// 
			// itemCategoriesDataGridViewTextBoxColumn
			// 
			this.itemCategoriesDataGridViewTextBoxColumn.DataPropertyName = "ItemCategories";
			this.itemCategoriesDataGridViewTextBoxColumn.HeaderText = "ItemCategories";
			this.itemCategoriesDataGridViewTextBoxColumn.Name = "itemCategoriesDataGridViewTextBoxColumn";
			// 
			// itemFunctionalCategoriesDataGridViewTextBoxColumn
			// 
			this.itemFunctionalCategoriesDataGridViewTextBoxColumn.DataPropertyName = "ItemFunctionalCategories";
			this.itemFunctionalCategoriesDataGridViewTextBoxColumn.HeaderText = "ItemFunctionalCategories";
			this.itemFunctionalCategoriesDataGridViewTextBoxColumn.Name = "itemFunctionalCategoriesDataGridViewTextBoxColumn";
			// 
			// itemsDataGridViewTextBoxColumn
			// 
			this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
			this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
			this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
			// 
			// itemStatesDataGridViewTextBoxColumn
			// 
			this.itemStatesDataGridViewTextBoxColumn.DataPropertyName = "ItemStates";
			this.itemStatesDataGridViewTextBoxColumn.HeaderText = "ItemStates";
			this.itemStatesDataGridViewTextBoxColumn.Name = "itemStatesDataGridViewTextBoxColumn";
			// 
			// viewitemsDataGridViewTextBoxColumn
			// 
			this.viewitemsDataGridViewTextBoxColumn.DataPropertyName = "view_items";
			this.viewitemsDataGridViewTextBoxColumn.HeaderText = "view_items";
			this.viewitemsDataGridViewTextBoxColumn.Name = "viewitemsDataGridViewTextBoxColumn";
			// 
			// databaseDataGridViewTextBoxColumn
			// 
			this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
			this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
			this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
			this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// changeTrackerDataGridViewTextBoxColumn
			// 
			this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
			this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
			this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
			this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// configurationDataGridViewTextBoxColumn
			// 
			this.configurationDataGridViewTextBoxColumn.DataPropertyName = "Configuration";
			this.configurationDataGridViewTextBoxColumn.HeaderText = "Configuration";
			this.configurationDataGridViewTextBoxColumn.Name = "configurationDataGridViewTextBoxColumn";
			this.configurationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// CapitalizedView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1109, 499);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.CapitalizedDataListView);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.Add_Btn);
			this.Controls.Add(this.Suppr_Btn);
			this.Name = "CapitalizedView";
			this.Text = "PixLogic - Objets immobilisables";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CapitalizedView_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.CapitalizedDataListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemsEntityBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Suppr_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BackBtn;
		public BrightIdeasSoftware.DataListView CapitalizedDataListView;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemBrandsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoriesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemFunctionalCategoriesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemStatesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn viewitemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource itemsEntityBindingSource;
    }
}