namespace ITI.PixLogic.WinApp.Views
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
            this.ConsumablesDataListView = new BrightIdeasSoftware.DataListView();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pixlogicdbDataSet1 = new ITI.PixLogic.WinApp.pixlogicdbDataSet1();
            this.itemSubCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new ITI.PixLogic.WinApp.pixlogicdbDataSet1TableAdapters.itemsTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumablesDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlogicdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSubCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsumablesDataListView
            // 
            this.ConsumablesDataListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsumablesDataListView.DataSource = this.itemsBindingSource;
            this.ConsumablesDataListView.Location = new System.Drawing.Point(12, 12);
            this.ConsumablesDataListView.Name = "ConsumablesDataListView";
            this.ConsumablesDataListView.Size = new System.Drawing.Size(554, 367);
            this.ConsumablesDataListView.TabIndex = 0;
            this.ConsumablesDataListView.UseCompatibleStateImageBehavior = false;
            this.ConsumablesDataListView.View = System.Windows.Forms.View.Details;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.pixlogicdbDataSet1;
            // 
            // pixlogicdbDataSet1
            // 
            this.pixlogicdbDataSet1.DataSetName = "pixlogicdbDataSet1";
            this.pixlogicdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemSubCategoryBindingSource
            // 
            this.itemSubCategoryBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Items.ItemSubCategory);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(596, 49);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ConsumablesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 391);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ConsumablesDataListView);
            this.Name = "ConsumablesView";
            this.Text = "ConsumablesView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ConsumablesDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlogicdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSubCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion

        private BrightIdeasSoftware.DataListView ConsumablesDataListView;
        private System.Windows.Forms.BindingSource itemSubCategoryBindingSource;
        private pixlogicdbDataSet1 pixlogicdbDataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private pixlogicdbDataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Button AddButton;
    }
}