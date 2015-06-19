namespace ITI.PixLogic.WinApp
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 9D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 6D);
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.users_account_button = new System.Windows.Forms.Button();
            this.consumable_button = new System.Windows.Forms.Button();
            this.CapitalizedBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatisticsTabControl = new System.Windows.Forms.TabControl();
            this.GeneralInfoTab = new System.Windows.Forms.TabPage();
            this.PlaceHolderNameTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.AmmountofItemsLbl = new System.Windows.Forms.Label();
            this.ReservationAmmountLbl = new System.Windows.Forms.Label();
            this.ReservationAmmountNbrLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.StatisticsTabControl.SuspendLayout();
            this.GeneralInfoTab.SuspendLayout();
            this.PlaceHolderNameTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // users_account_button
            // 
            this.users_account_button.Location = new System.Drawing.Point(693, 27);
            this.users_account_button.Name = "users_account_button";
            this.users_account_button.Size = new System.Drawing.Size(131, 41);
            this.users_account_button.TabIndex = 0;
            this.users_account_button.Text = "Comptes utilisateurs";
            this.users_account_button.UseVisualStyleBackColor = true;
            this.users_account_button.Click += new System.EventHandler(this.users_account_button_Click);
            // 
            // consumable_button
            // 
            this.consumable_button.Location = new System.Drawing.Point(693, 122);
            this.consumable_button.Name = "consumable_button";
            this.consumable_button.Size = new System.Drawing.Size(131, 41);
            this.consumable_button.TabIndex = 1;
            this.consumable_button.Text = "Consommables";
            this.consumable_button.UseVisualStyleBackColor = true;
            this.consumable_button.Click += new System.EventHandler(this.consumable_button_Click);
            // 
            // CapitalizedBtn
            // 
            this.CapitalizedBtn.Location = new System.Drawing.Point(693, 74);
            this.CapitalizedBtn.Name = "CapitalizedBtn";
            this.CapitalizedBtn.Size = new System.Drawing.Size(131, 42);
            this.CapitalizedBtn.TabIndex = 2;
            this.CapitalizedBtn.Text = "Immobilisables";
            this.CapitalizedBtn.UseVisualStyleBackColor = true;
            this.CapitalizedBtn.Click += new System.EventHandler(this.CapitalizedBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDeDonnéeToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportDeDonnéeToolStripMenuItem
            // 
            this.exportDeDonnéeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem});
            this.exportDeDonnéeToolStripMenuItem.Name = "exportDeDonnéeToolStripMenuItem";
            this.exportDeDonnéeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.exportDeDonnéeToolStripMenuItem.Text = "Importations";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cSVToolStripMenuItem.Text = "Utilisateurs (format CSV)";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aideToolStripMenuItem.Text = "À propos";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.contactToolStripMenuItem.Text = "Contacts";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(693, 169);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(131, 41);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Quitter";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // chart1
            // 
            lineAnnotation4.AnchorDataPointName = "Series1\\r0";
            lineAnnotation4.AnchorOffsetY = -2.5D;
            lineAnnotation4.Height = -5D;
            lineAnnotation4.Name = "LineAnnotation1";
            lineAnnotation4.SmartLabelStyle.IsOverlappedHidden = false;
            lineAnnotation4.Width = 0D;
            this.chart1.Annotations.Add(lineAnnotation4);
            chartArea7.Area3DStyle.Enable3D = true;
            chartArea7.Area3DStyle.WallWidth = 0;
            chartArea7.Name = "ChartArea1";
            chartArea8.Area3DStyle.Enable3D = true;
            chartArea8.Area3DStyle.WallWidth = 0;
            chartArea8.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.ChartAreas.Add(chartArea8);
            legend7.DockedToChartArea = "ChartArea1";
            legend7.IsDockedInsideChartArea = false;
            legend7.Name = "Legend1";
            legend8.DockedToChartArea = "ChartArea2";
            legend8.Name = "Legend2";
            this.chart1.Legends.Add(legend7);
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend2";
            series7.Name = "Series1";
            series7.Points.Add(dataPoint34);
            series7.Points.Add(dataPoint35);
            series7.Points.Add(dataPoint36);
            series7.Points.Add(dataPoint37);
            series7.Points.Add(dataPoint38);
            series7.Points.Add(dataPoint39);
            series8.ChartArea = "ChartArea2";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series8.CustomProperties = "DrawingStyle=Cylinder";
            series8.Legend = "Legend1";
            series8.Name = "BarChart";
            series8.Points.Add(dataPoint40);
            series8.Points.Add(dataPoint41);
            series8.Points.Add(dataPoint42);
            series8.Points.Add(dataPoint43);
            series8.Points.Add(dataPoint44);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(655, 358);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Some Title here";
            this.chart1.Titles.Add(title4);
            // 
            // StatisticsTabControl
            // 
            this.StatisticsTabControl.Controls.Add(this.GeneralInfoTab);
            this.StatisticsTabControl.Controls.Add(this.PlaceHolderNameTab);
            this.StatisticsTabControl.Location = new System.Drawing.Point(12, 27);
            this.StatisticsTabControl.Name = "StatisticsTabControl";
            this.StatisticsTabControl.SelectedIndex = 0;
            this.StatisticsTabControl.Size = new System.Drawing.Size(675, 396);
            this.StatisticsTabControl.TabIndex = 6;
            // 
            // GeneralInfoTab
            // 
            this.GeneralInfoTab.Controls.Add(this.ReservationAmmountNbrLbl);
            this.GeneralInfoTab.Controls.Add(this.ReservationAmmountLbl);
            this.GeneralInfoTab.Controls.Add(this.AmmountofItemsLbl);
            this.GeneralInfoTab.Controls.Add(this.label1);
            this.GeneralInfoTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralInfoTab.Name = "GeneralInfoTab";
            this.GeneralInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralInfoTab.Size = new System.Drawing.Size(667, 370);
            this.GeneralInfoTab.TabIndex = 0;
            this.GeneralInfoTab.Text = "Général";
            this.GeneralInfoTab.UseVisualStyleBackColor = true;
            // 
            // PlaceHolderNameTab
            // 
            this.PlaceHolderNameTab.Controls.Add(this.chart1);
            this.PlaceHolderNameTab.Location = new System.Drawing.Point(4, 22);
            this.PlaceHolderNameTab.Name = "PlaceHolderNameTab";
            this.PlaceHolderNameTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlaceHolderNameTab.Size = new System.Drawing.Size(667, 370);
            this.PlaceHolderNameTab.TabIndex = 1;
            this.PlaceHolderNameTab.Text = "Plein de trucs";
            this.PlaceHolderNameTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres d\'objets total : ";
            // 
            // AmmountofItemsLbl
            // 
            this.AmmountofItemsLbl.AutoSize = true;
            this.AmmountofItemsLbl.Location = new System.Drawing.Point(177, 6);
            this.AmmountofItemsLbl.Name = "AmmountofItemsLbl";
            this.AmmountofItemsLbl.Size = new System.Drawing.Size(0, 13);
            this.AmmountofItemsLbl.TabIndex = 1;
            // 
            // ReservationAmmountLbl
            // 
            this.ReservationAmmountLbl.AutoSize = true;
            this.ReservationAmmountLbl.Location = new System.Drawing.Point(9, 25);
            this.ReservationAmmountLbl.Name = "ReservationAmmountLbl";
            this.ReservationAmmountLbl.Size = new System.Drawing.Size(128, 13);
            this.ReservationAmmountLbl.TabIndex = 2;
            this.ReservationAmmountLbl.Text = "Nombre de réservations : ";
            // 
            // ReservationAmmountNbrLbl
            // 
            this.ReservationAmmountNbrLbl.AutoSize = true;
            this.ReservationAmmountNbrLbl.Location = new System.Drawing.Point(177, 25);
            this.ReservationAmmountNbrLbl.Name = "ReservationAmmountNbrLbl";
            this.ReservationAmmountNbrLbl.Size = new System.Drawing.Size(40, 13);
            this.ReservationAmmountNbrLbl.TabIndex = 3;
            this.ReservationAmmountNbrLbl.Text = "<error>";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(836, 435);
            this.Controls.Add(this.StatisticsTabControl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CapitalizedBtn);
            this.Controls.Add(this.consumable_button);
            this.Controls.Add(this.users_account_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeView";
            this.Text = "PixLogic - Accueil";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.StatisticsTabControl.ResumeLayout(false);
            this.GeneralInfoTab.ResumeLayout(false);
            this.GeneralInfoTab.PerformLayout();
            this.PlaceHolderNameTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button users_account_button;
        private System.Windows.Forms.Button consumable_button;
        private System.Windows.Forms.Button CapitalizedBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exportDeDonnéeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl StatisticsTabControl;
        private System.Windows.Forms.TabPage GeneralInfoTab;
        private System.Windows.Forms.Label ReservationAmmountNbrLbl;
        private System.Windows.Forms.Label ReservationAmmountLbl;
        private System.Windows.Forms.Label AmmountofItemsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage PlaceHolderNameTab;
    }
}