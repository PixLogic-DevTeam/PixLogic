namespace ITI.PixLogic.WinApp.Views
{
	partial class MainView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this._printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this._ribbon = new RibbonLib.Ribbon();
			this._panel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _printPreviewDialog
			// 
			this._printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this._printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this._printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
			this._printPreviewDialog.Enabled = true;
			this._printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("_printPreviewDialog.Icon")));
			this._printPreviewDialog.Name = "printPreviewDialog1";
			this._printPreviewDialog.Visible = false;
			// 
			// _ribbon
			// 
			this._ribbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._ribbon.BackColor = System.Drawing.Color.White;
			this._ribbon.Dock = System.Windows.Forms.DockStyle.None;
			this._ribbon.Location = new System.Drawing.Point(0, 0);
			this._ribbon.Margin = new System.Windows.Forms.Padding(0);
			this._ribbon.Minimized = false;
			this._ribbon.Name = "_ribbon";
			this._ribbon.ResourceName = "ITI.PixLogic.WinApp.RibbonMarkup.ribbon";
			this._ribbon.ShortcutTableResourceName = null;
			this._ribbon.Size = new System.Drawing.Size(784, 144);
			this._ribbon.TabIndex = 4;
			// 
			// _panel
			// 
			this._panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._panel.BackColor = System.Drawing.Color.White;
			this._panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._panel.Location = new System.Drawing.Point(5, 149);
			this._panel.Name = "_panel";
			this._panel.Size = new System.Drawing.Size(774, 408);
			this._panel.TabIndex = 5;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this._ribbon);
			this.Controls.Add(this._panel);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainView";
			this.Text = "PixLogic";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_OnPaint);
			this.Resize += new System.EventHandler(this.MainForm_OnResize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PrintPreviewDialog _printPreviewDialog;
		private RibbonLib.Ribbon _ribbon;
		private System.Windows.Forms.Panel _panel;
	}
}