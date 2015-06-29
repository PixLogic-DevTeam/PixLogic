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
            this.Suppr_Btn.Location = new System.Drawing.Point(401, 217);
            this.Suppr_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Suppr_Btn.Name = "Suppr_Btn";
            this.Suppr_Btn.Size = new System.Drawing.Size(121, 64);
            this.Suppr_Btn.TabIndex = 1;
            this.Suppr_Btn.Text = "Supprimer";
            this.Suppr_Btn.UseVisualStyleBackColor = true;
            this.Suppr_Btn.Click += new System.EventHandler(this.Suppr_Btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(401, 31);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(121, 64);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "Ajouter";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(401, 123);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(121, 64);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Modifier";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(16, 566);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(89, 33);
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
            this.CapitalizedDataListView.DataSource = this.capitalizedBindingSource;
            this.CapitalizedDataListView.Location = new System.Drawing.Point(204, 13);
            this.CapitalizedDataListView.Margin = new System.Windows.Forms.Padding(4);
            this.CapitalizedDataListView.Name = "CapitalizedDataListView";
            this.CapitalizedDataListView.Size = new System.Drawing.Size(1235, 475);
            this.CapitalizedDataListView.TabIndex = 5;
            this.CapitalizedDataListView.UseCompatibleStateImageBehavior = false;
            this.CapitalizedDataListView.View = System.Windows.Forms.View.Details;
            // 
            // capitalizedBindingSource
            // 
            this.capitalizedBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Items.Item);
            // 
            // CapitalizedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1465, 614);
            this.Controls.Add(this.CapitalizedDataListView);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Suppr_Btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CapitalizedView";
            this.Text = "PixLogic - Objets immobilisables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        public BrightIdeasSoftware.DataListView CapitalizedDataListView;
    }
}