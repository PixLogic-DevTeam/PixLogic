namespace ITI.PixLogic.WinApp
{
	partial class Consumable_table
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
            this.consumablesdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Clear_datagridview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.consumablesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pixlogic_dbDataSet = new ITI.PixLogic.WinApp.pixlogic_dbDataSet();
            this.pixlogicdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumablesTableAdapter = new ITI.PixLogic.WinApp.pixlogic_dbDataSetTableAdapters.consumablesTableAdapter();
            this.tableAdapterManager = new ITI.PixLogic.WinApp.pixlogic_dbDataSetTableAdapters.TableAdapterManager();
            this.consumables_sub_categoriesTableAdapter = new ITI.PixLogic.WinApp.pixlogic_dbDataSetTableAdapters.consumables_sub_categoriesTableAdapter();
            this.consumables_sub_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumables_main_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumables_main_categoriesTableAdapter = new ITI.PixLogic.WinApp.pixlogic_dbDataSetTableAdapters.consumables_main_categoriesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationcostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentstateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationCostCheckBox = new System.Windows.Forms.CheckBox();
            this.consumableNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SortConsumablesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consumablesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumablesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlogic_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlogicdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumables_sub_categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumables_main_categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.reservationcostDataGridViewTextBoxColumn,
            this.subcategoryDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.currentstateDataGridViewTextBoxColumn});
            this.consumablesdataGridView.DataSource = this.consumablesBindingSource;
            this.consumablesdataGridView.Location = new System.Drawing.Point(1112, 511);
            this.consumablesdataGridView.Name = "consumablesdataGridView";
            this.consumablesdataGridView.ReadOnly = true;
            this.consumablesdataGridView.RowTemplate.Height = 24;
            this.consumablesdataGridView.Size = new System.Drawing.Size(102, 96);
            this.consumablesdataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // Clear_datagridview
            // 
            this.Clear_datagridview.Location = new System.Drawing.Point(1382, 246);
            this.Clear_datagridview.Name = "Clear_datagridview";
            this.Clear_datagridview.Size = new System.Drawing.Size(254, 117);
            this.Clear_datagridview.TabIndex = 1;
            this.Clear_datagridview.Text = "Clear";
            this.Clear_datagridview.UseVisualStyleBackColor = true;
            this.Clear_datagridview.Click += new System.EventHandler(this.Clear_datagridview_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1382, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 121);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add consumable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // consumablesBindingSource1
            // 
            this.consumablesBindingSource1.DataMember = "consumables";
            this.consumablesBindingSource1.DataSource = this.pixlogic_dbDataSet;
            // 
            // pixlogic_dbDataSet
            // 
            this.pixlogic_dbDataSet.DataSetName = "pixlogic_dbDataSet";
            this.pixlogic_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pixlogicdbDataSetBindingSource
            // 
            this.pixlogicdbDataSetBindingSource.DataSource = this.pixlogic_dbDataSet;
            this.pixlogicdbDataSetBindingSource.Position = 0;
            // 
            // consumablesTableAdapter
            // 
            this.consumablesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consumables_main_categoriesTableAdapter = null;
            this.tableAdapterManager.consumables_sub_categoriesTableAdapter = this.consumables_sub_categoriesTableAdapter;
            this.tableAdapterManager.consumablesTableAdapter = this.consumablesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITI.PixLogic.WinApp.pixlogic_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consumables_sub_categoriesTableAdapter
            // 
            this.consumables_sub_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // consumables_sub_categoriesBindingSource
            // 
            this.consumables_sub_categoriesBindingSource.DataMember = "consumables_sub_categories";
            this.consumables_sub_categoriesBindingSource.DataSource = this.pixlogic_dbDataSet;
            // 
            // consumables_main_categoriesBindingSource
            // 
            this.consumables_main_categoriesBindingSource.DataMember = "consumables_main_categories";
            this.consumables_main_categoriesBindingSource.DataSource = this.pixlogic_dbDataSet;
            // 
            // consumables_main_categoriesTableAdapter
            // 
            this.consumables_main_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.reservationcostDataGridViewTextBoxColumn1,
            this.subcategoryDataGridViewTextBoxColumn1,
            this.invoiceDataGridViewTextBoxColumn1,
            this.currentstateDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.consumablesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 649);
            this.dataGridView1.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // reservationcostDataGridViewTextBoxColumn1
            // 
            this.reservationcostDataGridViewTextBoxColumn1.DataPropertyName = "reservation_cost";
            this.reservationcostDataGridViewTextBoxColumn1.HeaderText = "reservation_cost";
            this.reservationcostDataGridViewTextBoxColumn1.Name = "reservationcostDataGridViewTextBoxColumn1";
            // 
            // subcategoryDataGridViewTextBoxColumn1
            // 
            this.subcategoryDataGridViewTextBoxColumn1.DataPropertyName = "sub_category";
            this.subcategoryDataGridViewTextBoxColumn1.HeaderText = "Sous Catégorie";
            this.subcategoryDataGridViewTextBoxColumn1.Name = "subcategoryDataGridViewTextBoxColumn1";
            // 
            // invoiceDataGridViewTextBoxColumn1
            // 
            this.invoiceDataGridViewTextBoxColumn1.DataPropertyName = "invoice";
            this.invoiceDataGridViewTextBoxColumn1.HeaderText = "invoice";
            this.invoiceDataGridViewTextBoxColumn1.Name = "invoiceDataGridViewTextBoxColumn1";
            // 
            // currentstateDataGridViewTextBoxColumn1
            // 
            this.currentstateDataGridViewTextBoxColumn1.DataPropertyName = "current_state";
            this.currentstateDataGridViewTextBoxColumn1.HeaderText = "current_state";
            this.currentstateDataGridViewTextBoxColumn1.Name = "currentstateDataGridViewTextBoxColumn1";
            // 
            // reservationCostCheckBox
            // 
            this.reservationCostCheckBox.AutoSize = true;
            this.reservationCostCheckBox.Location = new System.Drawing.Point(1078, 189);
            this.reservationCostCheckBox.Name = "reservationCostCheckBox";
            this.reservationCostCheckBox.Size = new System.Drawing.Size(154, 21);
            this.reservationCostCheckBox.TabIndex = 9;
            this.reservationCostCheckBox.Text = "Coût de réservation";
            this.reservationCostCheckBox.UseVisualStyleBackColor = true;
           // this.reservationCostCheckBox.CheckedChanged += new System.EventHandler(this.reservationCostCheckBox_CheckedChanged);
            // 
            // consumableNameCheckBox
            // 
            this.consumableNameCheckBox.AutoSize = true;
            this.consumableNameCheckBox.Location = new System.Drawing.Point(1078, 216);
            this.consumableNameCheckBox.Name = "consumableNameCheckBox";
            this.consumableNameCheckBox.Size = new System.Drawing.Size(59, 21);
            this.consumableNameCheckBox.TabIndex = 10;
            this.consumableNameCheckBox.Text = "Nom";
            this.consumableNameCheckBox.UseVisualStyleBackColor = true;
           // this.consumableNameCheckBox.CheckedChanged += new System.EventHandler(this.consumableNameCheckBox_CheckedChanged);
            // 
            // SortConsumablesButton
            // 
            this.SortConsumablesButton.Location = new System.Drawing.Point(1091, 280);
            this.SortConsumablesButton.Name = "SortConsumablesButton";
            this.SortConsumablesButton.Size = new System.Drawing.Size(75, 23);
            this.SortConsumablesButton.TabIndex = 11;
            this.SortConsumablesButton.Text = "Trier";
            this.SortConsumablesButton.UseVisualStyleBackColor = true;
            this.SortConsumablesButton.Click += new System.EventHandler(this.SortConsumablesButton_Click);
            // 
            // Consumable_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 676);
            this.Controls.Add(this.SortConsumablesButton);
            this.Controls.Add(this.consumableNameCheckBox);
            this.Controls.Add(this.reservationCostCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Clear_datagridview);
            this.Controls.Add(this.consumablesdataGridView);
            this.Name = "Consumable_table";
            this.Text = "Consumables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consumable_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consumablesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumablesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlogic_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlogicdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumables_sub_categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumables_main_categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridView consumablesdataGridView;
        private System.Windows.Forms.BindingSource consumablesBindingSource;
        private System.Windows.Forms.Button Clear_datagridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pixlogicdbDataSetBindingSource;
        private pixlogic_dbDataSet pixlogic_dbDataSet;
        private System.Windows.Forms.BindingSource consumablesBindingSource1;
        private pixlogic_dbDataSetTableAdapters.consumablesTableAdapter consumablesTableAdapter;
        private pixlogic_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pixlogic_dbDataSetTableAdapters.consumables_sub_categoriesTableAdapter consumables_sub_categoriesTableAdapter;
        private System.Windows.Forms.BindingSource consumables_sub_categoriesBindingSource;
        private System.Windows.Forms.BindingSource consumables_main_categoriesBindingSource;
        private pixlogic_dbDataSetTableAdapters.consumables_main_categoriesTableAdapter consumables_main_categoriesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentstateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.CheckBox reservationCostCheckBox;
        private System.Windows.Forms.CheckBox consumableNameCheckBox;
        private System.Windows.Forms.Button SortConsumablesButton;
	}
}

