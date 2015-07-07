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
			this.dataListView1 = new BrightIdeasSoftware.DataListView();
			this.Resbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataListView1
			// 
			this.dataListView1.DataSource = null;
			this.dataListView1.Location = new System.Drawing.Point(208, 12);
			this.dataListView1.Name = "dataListView1";
			this.dataListView1.Size = new System.Drawing.Size(778, 401);
			this.dataListView1.TabIndex = 1;
			this.dataListView1.UseCompatibleStateImageBehavior = false;
			this.dataListView1.View = System.Windows.Forms.View.Details;
			// 
			// Resbutton
			// 
			this.Resbutton.Location = new System.Drawing.Point(27, 35);
			this.Resbutton.Name = "Resbutton";
			this.Resbutton.Size = new System.Drawing.Size(96, 48);
			this.Resbutton.TabIndex = 3;
			this.Resbutton.Text = "Faire une réservation";
			this.Resbutton.UseVisualStyleBackColor = true;
			this.Resbutton.Click += new System.EventHandler(this.Resbutton_Click);
			// 
			// MatérielView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 622);
			this.Controls.Add(this.Resbutton);
			this.Controls.Add(this.dataListView1);
			this.Name = "MatérielView";
			this.Text = "MatérielView";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MatérielView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.DataListView dataListView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationEventsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationItemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationPlanningsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationexportsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button Resbutton;
	}
}