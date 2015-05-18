namespace ITI.PixLogic.WinApp
{
	partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumablesstatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumablesitemsinpacksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumablesreservedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumablessubcategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.reservationcostDataGridViewTextBoxColumn,
            this.subcategoryDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.currentstateDataGridViewTextBoxColumn,
            this.consumablesstatesDataGridViewTextBoxColumn,
            this.invoice1DataGridViewTextBoxColumn,
            this.consumablesitemsinpacksDataGridViewTextBoxColumn,
            this.consumablesreservedDataGridViewTextBoxColumn,
            this.consumablessubcategoriesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consumableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // reservationcostDataGridViewTextBoxColumn
            // 
            this.reservationcostDataGridViewTextBoxColumn.DataPropertyName = "reservation_cost";
            this.reservationcostDataGridViewTextBoxColumn.HeaderText = "reservation_cost";
            this.reservationcostDataGridViewTextBoxColumn.Name = "reservationcostDataGridViewTextBoxColumn";
            // 
            // subcategoryDataGridViewTextBoxColumn
            // 
            this.subcategoryDataGridViewTextBoxColumn.DataPropertyName = "sub_category";
            this.subcategoryDataGridViewTextBoxColumn.HeaderText = "sub_category";
            this.subcategoryDataGridViewTextBoxColumn.Name = "subcategoryDataGridViewTextBoxColumn";
            // 
            // invoiceDataGridViewTextBoxColumn
            // 
            this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "invoice";
            this.invoiceDataGridViewTextBoxColumn.HeaderText = "invoice";
            this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
            // 
            // currentstateDataGridViewTextBoxColumn
            // 
            this.currentstateDataGridViewTextBoxColumn.DataPropertyName = "current_state";
            this.currentstateDataGridViewTextBoxColumn.HeaderText = "current_state";
            this.currentstateDataGridViewTextBoxColumn.Name = "currentstateDataGridViewTextBoxColumn";
            // 
            // consumablesstatesDataGridViewTextBoxColumn
            // 
            this.consumablesstatesDataGridViewTextBoxColumn.DataPropertyName = "consumables_states";
            this.consumablesstatesDataGridViewTextBoxColumn.HeaderText = "consumables_states";
            this.consumablesstatesDataGridViewTextBoxColumn.Name = "consumablesstatesDataGridViewTextBoxColumn";
            // 
            // invoice1DataGridViewTextBoxColumn
            // 
            this.invoice1DataGridViewTextBoxColumn.DataPropertyName = "invoice1";
            this.invoice1DataGridViewTextBoxColumn.HeaderText = "invoice1";
            this.invoice1DataGridViewTextBoxColumn.Name = "invoice1DataGridViewTextBoxColumn";
            // 
            // consumablesitemsinpacksDataGridViewTextBoxColumn
            // 
            this.consumablesitemsinpacksDataGridViewTextBoxColumn.DataPropertyName = "consumables_items_in_packs";
            this.consumablesitemsinpacksDataGridViewTextBoxColumn.HeaderText = "consumables_items_in_packs";
            this.consumablesitemsinpacksDataGridViewTextBoxColumn.Name = "consumablesitemsinpacksDataGridViewTextBoxColumn";
            // 
            // consumablesreservedDataGridViewTextBoxColumn
            // 
            this.consumablesreservedDataGridViewTextBoxColumn.DataPropertyName = "consumables_reserved";
            this.consumablesreservedDataGridViewTextBoxColumn.HeaderText = "consumables_reserved";
            this.consumablesreservedDataGridViewTextBoxColumn.Name = "consumablesreservedDataGridViewTextBoxColumn";
            // 
            // consumablessubcategoriesDataGridViewTextBoxColumn
            // 
            this.consumablessubcategoriesDataGridViewTextBoxColumn.DataPropertyName = "consumables_sub_categories";
            this.consumablessubcategoriesDataGridViewTextBoxColumn.HeaderText = "consumables_sub_categories";
            this.consumablessubcategoriesDataGridViewTextBoxColumn.Name = "consumablessubcategoriesDataGridViewTextBoxColumn";
            // 
            // consumableBindingSource
            // 
            this.consumableBindingSource.DataSource = typeof(ITI.PixLogic.DAL.consumable);
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumableBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumablesstatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumablesitemsinpacksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumablesreservedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumablessubcategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consumableBindingSource;
        private System.Windows.Forms.Button button1;
	}
}

