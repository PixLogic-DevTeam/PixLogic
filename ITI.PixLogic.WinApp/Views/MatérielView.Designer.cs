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
			this.Resbutton = new System.Windows.Forms.Button();
			this.eventsEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservedItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.restorationEventsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.restoredItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewreservationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewrestorationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsEntityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataListView1
			// 
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
            this.dataGridViewTextBoxColumn1,
            this.reservedItemsDataGridViewTextBoxColumn,
            this.restorationEventsDataGridViewTextBoxColumn,
            this.restoredItemsDataGridViewTextBoxColumn,
            this.viewreservationsDataGridViewTextBoxColumn,
            this.viewrestorationsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dataGridView1.DataSource = this.eventsEntityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(27, 201);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(72, 68);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.Visible = false;
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
			// eventsEntityBindingSource
			// 
			this.eventsEntityBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.EventsEntity);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ReservationEvents";
			this.dataGridViewTextBoxColumn1.HeaderText = "ReservationEvents";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// reservedItemsDataGridViewTextBoxColumn
			// 
			this.reservedItemsDataGridViewTextBoxColumn.DataPropertyName = "ReservedItems";
			this.reservedItemsDataGridViewTextBoxColumn.HeaderText = "ReservedItems";
			this.reservedItemsDataGridViewTextBoxColumn.Name = "reservedItemsDataGridViewTextBoxColumn";
			// 
			// restorationEventsDataGridViewTextBoxColumn
			// 
			this.restorationEventsDataGridViewTextBoxColumn.DataPropertyName = "RestorationEvents";
			this.restorationEventsDataGridViewTextBoxColumn.HeaderText = "RestorationEvents";
			this.restorationEventsDataGridViewTextBoxColumn.Name = "restorationEventsDataGridViewTextBoxColumn";
			// 
			// restoredItemsDataGridViewTextBoxColumn
			// 
			this.restoredItemsDataGridViewTextBoxColumn.DataPropertyName = "RestoredItems";
			this.restoredItemsDataGridViewTextBoxColumn.HeaderText = "RestoredItems";
			this.restoredItemsDataGridViewTextBoxColumn.Name = "restoredItemsDataGridViewTextBoxColumn";
			// 
			// viewreservationsDataGridViewTextBoxColumn
			// 
			this.viewreservationsDataGridViewTextBoxColumn.DataPropertyName = "view_reservations";
			this.viewreservationsDataGridViewTextBoxColumn.HeaderText = "view_reservations";
			this.viewreservationsDataGridViewTextBoxColumn.Name = "viewreservationsDataGridViewTextBoxColumn";
			// 
			// viewrestorationsDataGridViewTextBoxColumn
			// 
			this.viewrestorationsDataGridViewTextBoxColumn.DataPropertyName = "view_restorations";
			this.viewrestorationsDataGridViewTextBoxColumn.HeaderText = "view_restorations";
			this.viewrestorationsDataGridViewTextBoxColumn.Name = "viewrestorationsDataGridViewTextBoxColumn";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Database";
			this.dataGridViewTextBoxColumn2.HeaderText = "Database";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ChangeTracker";
			this.dataGridViewTextBoxColumn3.HeaderText = "ChangeTracker";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Configuration";
			this.dataGridViewTextBoxColumn4.HeaderText = "Configuration";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
			((System.ComponentModel.ISupportInitialize)(this.eventsEntityBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.DataListView dataListView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationEventsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationItemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationPlanningsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationexportsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button Resbutton;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservedItemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn restorationEventsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn restoredItemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn viewreservationsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn viewrestorationsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.BindingSource eventsEntityBindingSource;
	}
}