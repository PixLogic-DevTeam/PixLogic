namespace ITI.PixLogic.WinApp
{
    partial class Capitalized
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
            this.CapitalizedGridView = new System.Windows.Forms.DataGridView();
            this.Suppr_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ean13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalizedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.CapitalizedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalizedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CapitalizedGridView
            // 
            this.CapitalizedGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CapitalizedGridView.AutoGenerateColumns = false;
            this.CapitalizedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CapitalizedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ean13DataGridViewTextBoxColumn,
            this.reservationcostDataGridViewTextBoxColumn,
            this.subcategoryDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.currentstateDataGridViewTextBoxColumn});
            this.CapitalizedGridView.DataSource = this.capitalizedBindingSource;
            this.CapitalizedGridView.Location = new System.Drawing.Point(244, 12);
            this.CapitalizedGridView.Name = "CapitalizedGridView";
            this.CapitalizedGridView.Size = new System.Drawing.Size(843, 475);
            this.CapitalizedGridView.TabIndex = 0;
            // 
            // Suppr_Btn
            // 
            this.Suppr_Btn.Location = new System.Drawing.Point(83, 12);
            this.Suppr_Btn.Name = "Suppr_Btn";
            this.Suppr_Btn.Size = new System.Drawing.Size(67, 27);
            this.Suppr_Btn.TabIndex = 1;
            this.Suppr_Btn.Text = "Supprimer";
            this.Suppr_Btn.UseVisualStyleBackColor = true;
            this.Suppr_Btn.Click += new System.EventHandler(this.Suppr_Btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(83, 45);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(66, 27);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "Ajouter";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(83, 78);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(66, 27);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            // ean13DataGridViewTextBoxColumn
            // 
            this.ean13DataGridViewTextBoxColumn.DataPropertyName = "ean13";
            this.ean13DataGridViewTextBoxColumn.HeaderText = "ean13";
            this.ean13DataGridViewTextBoxColumn.Name = "ean13DataGridViewTextBoxColumn";
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
            // capitalizedBindingSource
            // 
            this.capitalizedBindingSource.DataSource = typeof(ITI.PixLogic.DAL.capitalized);
            // 
            // Capitalized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 499);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Suppr_Btn);
            this.Controls.Add(this.CapitalizedGridView);
            this.Name = "Capitalized";
            this.Text = "Capitalized";
            ((System.ComponentModel.ISupportInitialize)(this.CapitalizedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalizedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource capitalizedBindingSource;
        private System.Windows.Forms.DataGridView CapitalizedGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ean13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Suppr_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button EditBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}