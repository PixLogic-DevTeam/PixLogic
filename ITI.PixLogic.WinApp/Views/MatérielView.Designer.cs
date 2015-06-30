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
			this.components = new System.ComponentModel.Container();
			this.dataListView1 = new BrightIdeasSoftware.DataListView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reservationsEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.reservationEventsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationPlanningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationexportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Resbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationsEntityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataListView1
			// 
			this.dataListView1.DataSource = this.reservationsEntityBindingSource;
			this.dataListView1.Location = new System.Drawing.Point(208, 12);
			this.dataListView1.Name = "dataListView1";
			this.dataListView1.Size = new System.Drawing.Size(778, 401);
			this.dataListView1.TabIndex = 1;
			this.dataListView1.UseCompatibleStateImageBehavior = false;
			this.dataListView1.View = System.Windows.Forms.View.Details;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationEventsDataGridViewTextBoxColumn,
            this.reservationItemsDataGridViewTextBoxColumn,
            this.reservationPlanningsDataGridViewTextBoxColumn,
            this.reservationexportsDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.reservationsEntityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(27, 201);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(72, 68);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.Visible = false;
			// 
			// reservationsEntityBindingSource
			// 
			this.reservationsEntityBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Reservations.ReservationsEntity);
			// 
			// reservationEventsDataGridViewTextBoxColumn
			// 
			this.reservationEventsDataGridViewTextBoxColumn.DataPropertyName = "ReservationEvents";
			this.reservationEventsDataGridViewTextBoxColumn.HeaderText = "ReservationEvents";
			this.reservationEventsDataGridViewTextBoxColumn.Name = "reservationEventsDataGridViewTextBoxColumn";
			// 
			// reservationItemsDataGridViewTextBoxColumn
			// 
			this.reservationItemsDataGridViewTextBoxColumn.DataPropertyName = "ReservationItems";
			this.reservationItemsDataGridViewTextBoxColumn.HeaderText = "ReservationItems";
			this.reservationItemsDataGridViewTextBoxColumn.Name = "reservationItemsDataGridViewTextBoxColumn";
			// 
			// reservationPlanningsDataGridViewTextBoxColumn
			// 
			this.reservationPlanningsDataGridViewTextBoxColumn.DataPropertyName = "ReservationPlannings";
			this.reservationPlanningsDataGridViewTextBoxColumn.HeaderText = "ReservationPlannings";
			this.reservationPlanningsDataGridViewTextBoxColumn.Name = "reservationPlanningsDataGridViewTextBoxColumn";
			// 
			// reservationexportsDataGridViewTextBoxColumn
			// 
			this.reservationexportsDataGridViewTextBoxColumn.DataPropertyName = "reservationexports";
			this.reservationexportsDataGridViewTextBoxColumn.HeaderText = "reservationexports";
			this.reservationexportsDataGridViewTextBoxColumn.Name = "reservationexportsDataGridViewTextBoxColumn";
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
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataListView1);
			this.Name = "MatérielView";
			this.Text = "MatérielView";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MatérielView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationsEntityBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.DataListView dataListView1;
		private System.Windows.Forms.BindingSource reservationsEntityBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
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