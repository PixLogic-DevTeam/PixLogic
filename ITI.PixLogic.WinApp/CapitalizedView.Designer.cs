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
            this.capitalizedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CapitalizedDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalizedBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.Add_Btn.Size = new System.Drawing.Size(67, 27);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "Ajouter";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(83, 78);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(67, 27);
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
            this.CapitalizedDataListView.AutoArrange = false;
            this.CapitalizedDataListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.CapitalizedDataListView.DataSource = this.capitalizedBindingSource;
            this.CapitalizedDataListView.Location = new System.Drawing.Point(195, 12);
            this.CapitalizedDataListView.Name = "CapitalizedDataListView";
            this.CapitalizedDataListView.Size = new System.Drawing.Size(892, 475);
            this.CapitalizedDataListView.TabIndex = 5;
            this.CapitalizedDataListView.UseCompatibleStateImageBehavior = false;
            this.CapitalizedDataListView.View = System.Windows.Forms.View.Details;
            // 
            // capitalizedBindingSource
            // 
            this.capitalizedBindingSource.DataSource = typeof(ITI.PixLogic.DAL.capitalized);
            // 
            // CapitalizedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 499);
            this.Controls.Add(this.CapitalizedDataListView);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Suppr_Btn);
            this.Name = "CapitalizedView";
            this.Text = "PixLogic - Objets immobilisables";
            ((System.ComponentModel.ISupportInitialize)(this.CapitalizedDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalizedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource capitalizedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Suppr_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BackBtn;
        private BrightIdeasSoftware.DataListView CapitalizedDataListView;
    }
}