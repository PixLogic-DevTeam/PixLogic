namespace ITI.PixLogic.WinApp.Views
{
	partial class AddReservationForm
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.comboBoxItem = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(18, 173);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			// 
			// comboBoxItem
			// 
			this.comboBoxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxItem.FormattingEnabled = true;
			this.comboBoxItem.Location = new System.Drawing.Point(31, 38);
			this.comboBoxItem.Name = "comboBoxItem";
			this.comboBoxItem.Size = new System.Drawing.Size(121, 21);
			this.comboBoxItem.TabIndex = 1;
			this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
			// 
			// AddReservationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 353);
			this.Controls.Add(this.comboBoxItem);
			this.Controls.Add(this.monthCalendar1);
			this.Name = "AddReservationForm";
			this.Text = "AddReservationForm";
			this.Load += new System.EventHandler(this.AddReservationForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.ComboBox comboBoxItem;
	}
}