namespace ITI.PixLogic.WinApp.Views
{
	partial class MatérielView
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
			this.comboBoxItem = new System.Windows.Forms.ComboBox();
			this.dataListView1 = new BrightIdeasSoftware.DataListView();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxItem
			// 
			this.comboBoxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxItem.FormattingEnabled = true;
			this.comboBoxItem.Location = new System.Drawing.Point(52, 58);
			this.comboBoxItem.Name = "comboBoxItem";
			this.comboBoxItem.Size = new System.Drawing.Size(121, 21);
			this.comboBoxItem.TabIndex = 0;
			this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
			// 
			// dataListView1
			// 
			this.dataListView1.DataSource = null;
			this.dataListView1.Location = new System.Drawing.Point(208, 12);
			this.dataListView1.Name = "dataListView1";
			this.dataListView1.Size = new System.Drawing.Size(384, 257);
			this.dataListView1.TabIndex = 1;
			this.dataListView1.UseCompatibleStateImageBehavior = false;
			this.dataListView1.View = System.Windows.Forms.View.Details;
			// 
			// MatérielView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 312);
			this.Controls.Add(this.dataListView1);
			this.Controls.Add(this.comboBoxItem);
			this.Name = "MatérielView";
			this.Text = "MatérielView";
			this.Load += new System.EventHandler(this.MatérielView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxItem;
		private BrightIdeasSoftware.DataListView dataListView1;
	}
}