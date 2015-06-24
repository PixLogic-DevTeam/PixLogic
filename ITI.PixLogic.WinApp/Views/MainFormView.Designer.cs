namespace ITI.PixLogic.WinApp.Views
{
	partial class MainFormView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormView));
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.PixLogicMainPanel = new System.Windows.Forms.Panel();
			this.PixLogicRibbon = new RibbonLib.Ribbon();
			this.SuspendLayout();
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// PixLogicMainPanel
			// 
			this.PixLogicMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PixLogicMainPanel.BackColor = System.Drawing.Color.White;
			this.PixLogicMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PixLogicMainPanel.Location = new System.Drawing.Point(5, 149);
			this.PixLogicMainPanel.Name = "PixLogicMainPanel";
			this.PixLogicMainPanel.Size = new System.Drawing.Size(774, 408);
			this.PixLogicMainPanel.TabIndex = 1;
			// 
			// PixLogicRibbon
			// 
			this.PixLogicRibbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PixLogicRibbon.Dock = System.Windows.Forms.DockStyle.None;
			this.PixLogicRibbon.Location = new System.Drawing.Point(0, 0);
			this.PixLogicRibbon.Minimized = false;
			this.PixLogicRibbon.Name = "PixLogicRibbon";
			this.PixLogicRibbon.ResourceName = "ITI.PixLogic.WinApp.RibbonMarkup.ribbon";
			this.PixLogicRibbon.ShortcutTableResourceName = null;
			this.PixLogicRibbon.Size = new System.Drawing.Size(784, 144);
			this.PixLogicRibbon.TabIndex = 0;
			// 
			// MainFormView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.PixLogicMainPanel);
			this.Controls.Add(this.PixLogicRibbon);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainFormView";
			this.Text = "PixLogic";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormView_Paint);
			this.Resize += new System.EventHandler(this.MainFormView_Resize);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Panel PixLogicMainPanel;
		private RibbonLib.Ribbon PixLogicRibbon;
	}
}