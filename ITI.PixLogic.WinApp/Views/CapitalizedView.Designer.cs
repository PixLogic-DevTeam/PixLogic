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
			this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eAN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.consumableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.reservableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.picturePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.relatedInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.functionalCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.currentStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemFunctionalCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.CapitalizedDataListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
			this.BackBtn.Location = new System.Drawing.Point(12, 460);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(67, 27);
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
			this.CapitalizedDataListView.Location = new System.Drawing.Point(153, 11);
			this.CapitalizedDataListView.Name = "CapitalizedDataListView";
			this.CapitalizedDataListView.Size = new System.Drawing.Size(927, 387);
			this.CapitalizedDataListView.TabIndex = 5;
			this.CapitalizedDataListView.UseCompatibleStateImageBehavior = false;
			this.CapitalizedDataListView.View = System.Windows.Forms.View.Details;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eAN13DataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.reservationCostDataGridViewTextBoxColumn,
            this.consumableDataGridViewCheckBoxColumn,
            this.reservableDataGridViewCheckBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.picturePathDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.relatedInvoiceDataGridViewTextBoxColumn,
            this.functionalCategoryDataGridViewTextBoxColumn,
            this.currentStateDataGridViewTextBoxColumn,
            this.itemBrandDataGridViewTextBoxColumn,
            this.itemFunctionalCategoryDataGridViewTextBoxColumn,
            this.itemStateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.itemBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(81, 391);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 6;
			// 
			// itemBindingSource
			// 
			this.itemBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Item);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// eAN13DataGridViewTextBoxColumn
			// 
			this.eAN13DataGridViewTextBoxColumn.DataPropertyName = "EAN13";
			this.eAN13DataGridViewTextBoxColumn.HeaderText = "EAN13";
			this.eAN13DataGridViewTextBoxColumn.Name = "eAN13DataGridViewTextBoxColumn";
			// 
			// referenceDataGridViewTextBoxColumn
			// 
			this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
			this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
			this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
			// 
			// reservationCostDataGridViewTextBoxColumn
			// 
			this.reservationCostDataGridViewTextBoxColumn.DataPropertyName = "ReservationCost";
			this.reservationCostDataGridViewTextBoxColumn.HeaderText = "ReservationCost";
			this.reservationCostDataGridViewTextBoxColumn.Name = "reservationCostDataGridViewTextBoxColumn";
			// 
			// consumableDataGridViewCheckBoxColumn
			// 
			this.consumableDataGridViewCheckBoxColumn.DataPropertyName = "Consumable";
			this.consumableDataGridViewCheckBoxColumn.HeaderText = "Consumable";
			this.consumableDataGridViewCheckBoxColumn.Name = "consumableDataGridViewCheckBoxColumn";
			// 
			// reservableDataGridViewCheckBoxColumn
			// 
			this.reservableDataGridViewCheckBoxColumn.DataPropertyName = "Reservable";
			this.reservableDataGridViewCheckBoxColumn.HeaderText = "Reservable";
			this.reservableDataGridViewCheckBoxColumn.Name = "reservableDataGridViewCheckBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// picturePathDataGridViewTextBoxColumn
			// 
			this.picturePathDataGridViewTextBoxColumn.DataPropertyName = "PicturePath";
			this.picturePathDataGridViewTextBoxColumn.HeaderText = "PicturePath";
			this.picturePathDataGridViewTextBoxColumn.Name = "picturePathDataGridViewTextBoxColumn";
			// 
			// brandDataGridViewTextBoxColumn
			// 
			this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
			this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
			this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
			// 
			// relatedInvoiceDataGridViewTextBoxColumn
			// 
			this.relatedInvoiceDataGridViewTextBoxColumn.DataPropertyName = "RelatedInvoice";
			this.relatedInvoiceDataGridViewTextBoxColumn.HeaderText = "RelatedInvoice";
			this.relatedInvoiceDataGridViewTextBoxColumn.Name = "relatedInvoiceDataGridViewTextBoxColumn";
			// 
			// functionalCategoryDataGridViewTextBoxColumn
			// 
			this.functionalCategoryDataGridViewTextBoxColumn.DataPropertyName = "FunctionalCategory";
			this.functionalCategoryDataGridViewTextBoxColumn.HeaderText = "FunctionalCategory";
			this.functionalCategoryDataGridViewTextBoxColumn.Name = "functionalCategoryDataGridViewTextBoxColumn";
			// 
			// currentStateDataGridViewTextBoxColumn
			// 
			this.currentStateDataGridViewTextBoxColumn.DataPropertyName = "CurrentState";
			this.currentStateDataGridViewTextBoxColumn.HeaderText = "CurrentState";
			this.currentStateDataGridViewTextBoxColumn.Name = "currentStateDataGridViewTextBoxColumn";
			// 
			// itemBrandDataGridViewTextBoxColumn
			// 
			this.itemBrandDataGridViewTextBoxColumn.DataPropertyName = "ItemBrand";
			this.itemBrandDataGridViewTextBoxColumn.HeaderText = "ItemBrand";
			this.itemBrandDataGridViewTextBoxColumn.Name = "itemBrandDataGridViewTextBoxColumn";
			// 
			// itemFunctionalCategoryDataGridViewTextBoxColumn
			// 
			this.itemFunctionalCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemFunctionalCategory";
			this.itemFunctionalCategoryDataGridViewTextBoxColumn.HeaderText = "ItemFunctionalCategory";
			this.itemFunctionalCategoryDataGridViewTextBoxColumn.Name = "itemFunctionalCategoryDataGridViewTextBoxColumn";
			// 
			// itemStateDataGridViewTextBoxColumn
			// 
			this.itemStateDataGridViewTextBoxColumn.DataPropertyName = "ItemState";
			this.itemStateDataGridViewTextBoxColumn.HeaderText = "ItemState";
			this.itemStateDataGridViewTextBoxColumn.Name = "itemStateDataGridViewTextBoxColumn";
			// 
			// CapitalizedView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1028, 499);
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
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eAN13DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn consumableDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn reservableDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn picturePathDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn relatedInvoiceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn functionalCategoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn currentStateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemBrandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemFunctionalCategoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemStateDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource itemBindingSource;
    }
}