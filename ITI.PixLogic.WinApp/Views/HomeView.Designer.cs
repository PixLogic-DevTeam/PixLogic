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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 18D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.users_account_button = new System.Windows.Forms.Button();
            this.consumable_button = new System.Windows.Forms.Button();
            this.CapitalizedBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ItemsCharts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatisticsTabControl = new System.Windows.Forms.TabControl();
            this.GeneralInfoTab = new System.Windows.Forms.TabPage();
            this.AmmountOfInvoicesNbrLbl = new System.Windows.Forms.Label();
            this.AmmountOfInvoicesLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NearExpiredReservationdataListView = new BrightIdeasSoftware.DataListView();
            this.RecentReservationdataListView = new BrightIdeasSoftware.DataListView();
            this.AmmountOfPackNbrLbl = new System.Windows.Forms.Label();
            this.AmmountOfPacksLbl = new System.Windows.Forms.Label();
            this.ReservationAmmountNbrLbl = new System.Windows.Forms.Label();
            this.ReservationAmmountLbl = new System.Windows.Forms.Label();
            this.AmmountofItemsNbrLbl = new System.Windows.Forms.Label();
            this.AmmountOfItemsLbl = new System.Windows.Forms.Label();
            this.ItemTab = new System.Windows.Forms.TabPage();
            this.AccountTab = new System.Windows.Forms.TabPage();
            this.AccountCharts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCharts)).BeginInit();
            this.StatisticsTabControl.SuspendLayout();
            this.GeneralInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearExpiredReservationdataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentReservationdataListView)).BeginInit();
            this.ItemTab.SuspendLayout();
            this.AccountTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountCharts)).BeginInit();
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
            // ItemsCharts
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 60;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.Name = "PieChartArea";
            this.ItemsCharts.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "PieChartArea";
            legend1.Name = "Legend1";
            this.ItemsCharts.Legends.Add(legend1);
            this.ItemsCharts.Location = new System.Drawing.Point(6, 6);
            this.ItemsCharts.Name = "ItemsCharts";
            series1.ChartArea = "PieChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "DrawingStyle=Cylinder";
            series1.Legend = "Legend1";
            series1.Name = "PieChartSerie";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.ItemsCharts.Series.Add(series1);
            this.ItemsCharts.Size = new System.Drawing.Size(655, 358);
            this.ItemsCharts.TabIndex = 5;
            this.ItemsCharts.Text = "chart1";
            title1.Name = "PieChartTitle";
            title1.Text = "Proportion de matériel";
            this.ItemsCharts.Titles.Add(title1);
            // 
            // StatisticsTabControl
            // 
            this.StatisticsTabControl.Controls.Add(this.GeneralInfoTab);
            this.StatisticsTabControl.Controls.Add(this.ItemTab);
            this.StatisticsTabControl.Controls.Add(this.AccountTab);
            this.StatisticsTabControl.Location = new System.Drawing.Point(12, 27);
            this.StatisticsTabControl.Name = "StatisticsTabControl";
            this.StatisticsTabControl.SelectedIndex = 0;
            this.StatisticsTabControl.Size = new System.Drawing.Size(675, 396);
            this.StatisticsTabControl.TabIndex = 6;
            // 
            // GeneralInfoTab
            // 
            this.GeneralInfoTab.Controls.Add(this.AmmountOfInvoicesNbrLbl);
            this.GeneralInfoTab.Controls.Add(this.AmmountOfInvoicesLbl);
            this.GeneralInfoTab.Controls.Add(this.label2);
            this.GeneralInfoTab.Controls.Add(this.label1);
            this.GeneralInfoTab.Controls.Add(this.NearExpiredReservationdataListView);
            this.GeneralInfoTab.Controls.Add(this.RecentReservationdataListView);
            this.GeneralInfoTab.Controls.Add(this.AmmountOfPackNbrLbl);
            this.GeneralInfoTab.Controls.Add(this.AmmountOfPacksLbl);
            this.GeneralInfoTab.Controls.Add(this.ReservationAmmountNbrLbl);
            this.GeneralInfoTab.Controls.Add(this.ReservationAmmountLbl);
            this.GeneralInfoTab.Controls.Add(this.AmmountofItemsNbrLbl);
            this.GeneralInfoTab.Controls.Add(this.AmmountOfItemsLbl);
            this.GeneralInfoTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralInfoTab.Name = "GeneralInfoTab";
            this.GeneralInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralInfoTab.Size = new System.Drawing.Size(667, 370);
            this.GeneralInfoTab.TabIndex = 0;
            this.GeneralInfoTab.Text = "Général";
            this.GeneralInfoTab.UseVisualStyleBackColor = true;
            // 
            // AmmountOfInvoicesNbrLbl
            // 
            this.AmmountOfInvoicesNbrLbl.AutoSize = true;
            this.AmmountOfInvoicesNbrLbl.Location = new System.Drawing.Point(177, 62);
            this.AmmountOfInvoicesNbrLbl.Name = "AmmountOfInvoicesNbrLbl";
            this.AmmountOfInvoicesNbrLbl.Size = new System.Drawing.Size(40, 13);
            this.AmmountOfInvoicesNbrLbl.TabIndex = 11;
            this.AmmountOfInvoicesNbrLbl.Text = "<error>";
            // 
            // AmmountOfInvoicesLbl
            // 
            this.AmmountOfInvoicesLbl.AutoSize = true;
            this.AmmountOfInvoicesLbl.Location = new System.Drawing.Point(33, 62);
            this.AmmountOfInvoicesLbl.Name = "AmmountOfInvoicesLbl";
            this.AmmountOfInvoicesLbl.Size = new System.Drawing.Size(104, 13);
            this.AmmountOfInvoicesLbl.TabIndex = 10;
            this.AmmountOfInvoicesLbl.Text = "Nombre de facture : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Réservations arrivant à expiration : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Réservations récentes : ";
            // 
            // NearExpiredReservationdataListView
            // 
            this.NearExpiredReservationdataListView.DataSource = null;
            this.NearExpiredReservationdataListView.Location = new System.Drawing.Point(406, 103);
            this.NearExpiredReservationdataListView.Name = "NearExpiredReservationdataListView";
            this.NearExpiredReservationdataListView.Size = new System.Drawing.Size(154, 219);
            this.NearExpiredReservationdataListView.TabIndex = 7;
            this.NearExpiredReservationdataListView.UseCompatibleStateImageBehavior = false;
            this.NearExpiredReservationdataListView.View = System.Windows.Forms.View.Details;
            // 
            // RecentReservationdataListView
            // 
            this.RecentReservationdataListView.DataSource = null;
            this.RecentReservationdataListView.Location = new System.Drawing.Point(12, 103);
            this.RecentReservationdataListView.Name = "RecentReservationdataListView";
            this.RecentReservationdataListView.Size = new System.Drawing.Size(352, 219);
            this.RecentReservationdataListView.TabIndex = 6;
            this.RecentReservationdataListView.UseCompatibleStateImageBehavior = false;
            this.RecentReservationdataListView.View = System.Windows.Forms.View.Details;
            // 
            // AmmountOfPackNbrLbl
            // 
            this.AmmountOfPackNbrLbl.AutoSize = true;
            this.AmmountOfPackNbrLbl.Location = new System.Drawing.Point(177, 44);
            this.AmmountOfPackNbrLbl.Name = "AmmountOfPackNbrLbl";
            this.AmmountOfPackNbrLbl.Size = new System.Drawing.Size(40, 13);
            this.AmmountOfPackNbrLbl.TabIndex = 5;
            this.AmmountOfPackNbrLbl.Text = "<error>";
            // 
            // AmmountOfPacksLbl
            // 
            this.AmmountOfPacksLbl.AutoSize = true;
            this.AmmountOfPacksLbl.Location = new System.Drawing.Point(42, 44);
            this.AmmountOfPacksLbl.Name = "AmmountOfPacksLbl";
            this.AmmountOfPacksLbl.Size = new System.Drawing.Size(95, 13);
            this.AmmountOfPacksLbl.TabIndex = 4;
            this.AmmountOfPacksLbl.Text = "Nombre de pack : ";
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
            // ReservationAmmountLbl
            // 
            this.ReservationAmmountLbl.AutoSize = true;
            this.ReservationAmmountLbl.Location = new System.Drawing.Point(9, 25);
            this.ReservationAmmountLbl.Name = "ReservationAmmountLbl";
            this.ReservationAmmountLbl.Size = new System.Drawing.Size(128, 13);
            this.ReservationAmmountLbl.TabIndex = 2;
            this.ReservationAmmountLbl.Text = "Nombre de réservations : ";
            // 
            // AmmountofItemsNbrLbl
            // 
            this.AmmountofItemsNbrLbl.AutoSize = true;
            this.AmmountofItemsNbrLbl.Location = new System.Drawing.Point(177, 6);
            this.AmmountofItemsNbrLbl.Name = "AmmountofItemsNbrLbl";
            this.AmmountofItemsNbrLbl.Size = new System.Drawing.Size(40, 13);
            this.AmmountofItemsNbrLbl.TabIndex = 1;
            this.AmmountofItemsNbrLbl.Text = "<error>";
            // 
            // AmmountOfItemsLbl
            // 
            this.AmmountOfItemsLbl.AutoSize = true;
            this.AmmountOfItemsLbl.Location = new System.Drawing.Point(17, 6);
            this.AmmountOfItemsLbl.Name = "AmmountOfItemsLbl";
            this.AmmountOfItemsLbl.Size = new System.Drawing.Size(120, 13);
            this.AmmountOfItemsLbl.TabIndex = 0;
            this.AmmountOfItemsLbl.Text = "Nombres d\'objets total : ";
            // 
            // ItemTab
            // 
            this.ItemTab.Controls.Add(this.ItemsCharts);
            this.ItemTab.Location = new System.Drawing.Point(4, 22);
            this.ItemTab.Name = "ItemTab";
            this.ItemTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTab.Size = new System.Drawing.Size(667, 370);
            this.ItemTab.TabIndex = 1;
            this.ItemTab.Text = "Objets";
            this.ItemTab.UseVisualStyleBackColor = true;
            // 
            // AccountTab
            // 
            this.AccountTab.Controls.Add(this.AccountCharts);
            this.AccountTab.Location = new System.Drawing.Point(4, 22);
            this.AccountTab.Name = "AccountTab";
            this.AccountTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountTab.Size = new System.Drawing.Size(667, 370);
            this.AccountTab.TabIndex = 2;
            this.AccountTab.Text = "Comptes";
            this.AccountTab.UseVisualStyleBackColor = true;
            // 
            // AccountCharts
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 60;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.AccountCharts.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.AccountCharts.Legends.Add(legend2);
            this.AccountCharts.Location = new System.Drawing.Point(6, 6);
            this.AccountCharts.Name = "AccountCharts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "CollectedSliceExploded=True";
            series2.Legend = "Legend1";
            series2.Name = "AccountProportions";
            series2.YValuesPerPoint = 4;
            this.AccountCharts.Series.Add(series2);
            this.AccountCharts.Size = new System.Drawing.Size(655, 352);
            this.AccountCharts.TabIndex = 0;
            this.AccountCharts.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCharts)).EndInit();
            this.StatisticsTabControl.ResumeLayout(false);
            this.GeneralInfoTab.ResumeLayout(false);
            this.GeneralInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NearExpiredReservationdataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentReservationdataListView)).EndInit();
            this.ItemTab.ResumeLayout(false);
            this.AccountTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountCharts)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ItemsCharts;
        private System.Windows.Forms.TabControl StatisticsTabControl;
        private System.Windows.Forms.TabPage GeneralInfoTab;
        private System.Windows.Forms.Label ReservationAmmountNbrLbl;
        private System.Windows.Forms.Label ReservationAmmountLbl;
        private System.Windows.Forms.Label AmmountofItemsNbrLbl;
        private System.Windows.Forms.Label AmmountOfItemsLbl;
        private System.Windows.Forms.TabPage ItemTab;
        private System.Windows.Forms.Label AmmountOfPacksLbl;
        private System.Windows.Forms.Label AmmountOfPackNbrLbl;
        private System.Windows.Forms.TabPage AccountTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccountCharts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.DataListView NearExpiredReservationdataListView;
        private BrightIdeasSoftware.DataListView RecentReservationdataListView;
        private System.Windows.Forms.Label AmmountOfInvoicesNbrLbl;
        private System.Windows.Forms.Label AmmountOfInvoicesLbl;
    }
}