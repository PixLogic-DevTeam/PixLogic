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
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.importationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.utilisateursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.objetsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.packsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exportationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.objetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.packsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.réservationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.utilisateursToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.facturesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.réparationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.entreprisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.réservationsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.users_account_button = new System.Windows.Forms.Button();
			this.consumable_button = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.ItemsCharts = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.StatisticsTabControl = new System.Windows.Forms.TabControl();
			this.GeneralInfoTab = new System.Windows.Forms.TabPage();
			this.AmmountOfInvoicesNbrLbl = new System.Windows.Forms.Label();
			this.AmmountOfInvoicesLbl = new System.Windows.Forms.Label();
			this.AmmountOfPackNbrLbl = new System.Windows.Forms.Label();
			this.AmmountOfPacksLbl = new System.Windows.Forms.Label();
			this.ReservationAmmountNbrLbl = new System.Windows.Forms.Label();
			this.ReservationAmmountLbl = new System.Windows.Forms.Label();
			this.AmmountofItemsNbrLbl = new System.Windows.Forms.Label();
			this.AmmountOfItemsLbl = new System.Windows.Forms.Label();
			this.ItemTab = new System.Windows.Forms.TabPage();
			this.ConsummableItemNbrLbl = new System.Windows.Forms.Label();
			this.ReservableItemNbrLbl = new System.Windows.Forms.Label();
			this.AccountTab = new System.Windows.Forms.TabPage();
			this.ActiveAccNbrLbl = new System.Windows.Forms.Label();
			this.BannedAccNbrLbl = new System.Windows.Forms.Label();
			this.AccountCharts = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.CapitalizedBtn = new System.Windows.Forms.Button();
			this.MainMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemsCharts)).BeginInit();
			this.StatisticsTabControl.SuspendLayout();
			this.GeneralInfoTab.SuspendLayout();
			this.ItemTab.SuspendLayout();
			this.AccountTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AccountCharts)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importationsToolStripMenuItem,
            this.exportationsToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.réservationToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(836, 24);
			this.MainMenuStrip.TabIndex = 0;
			this.MainMenuStrip.Text = "MainMenuStrip";
			// 
			// importationsToolStripMenuItem
			// 
			this.importationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem});
			this.importationsToolStripMenuItem.Name = "importationsToolStripMenuItem";
			this.importationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.importationsToolStripMenuItem.Text = "Importations";
			// 
			// utilisateursToolStripMenuItem
			// 
			this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem1,
            this.objetsToolStripMenuItem1,
            this.packsToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.entreprisesToolStripMenuItem,
            this.contactsToolStripMenuItem1});
			this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
			this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.utilisateursToolStripMenuItem.Text = "CSV";
			// 
			// utilisateursToolStripMenuItem1
			// 
			this.utilisateursToolStripMenuItem1.Name = "utilisateursToolStripMenuItem1";
			this.utilisateursToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.utilisateursToolStripMenuItem1.Text = "Utilisateurs";
			this.utilisateursToolStripMenuItem1.Click += new System.EventHandler(this.utilisateursToolStripMenuItem1_Click);
			// 
			// objetsToolStripMenuItem1
			// 
			this.objetsToolStripMenuItem1.Name = "objetsToolStripMenuItem1";
			this.objetsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.objetsToolStripMenuItem1.Text = "Objets";
			this.objetsToolStripMenuItem1.Click += new System.EventHandler(this.objetsToolStripMenuItem1_Click);
			// 
			// packsToolStripMenuItem
			// 
			this.packsToolStripMenuItem.Name = "packsToolStripMenuItem";
			this.packsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.packsToolStripMenuItem.Text = "Packs";
			this.packsToolStripMenuItem.Click += new System.EventHandler(this.packsToolStripMenuItem_Click);
			// 
			// facturesToolStripMenuItem
			// 
			this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
			this.facturesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.facturesToolStripMenuItem.Text = "Factures";
			this.facturesToolStripMenuItem.Click += new System.EventHandler(this.facturesToolStripMenuItem_Click);
			// 
			// entreprisesToolStripMenuItem
			// 
			this.entreprisesToolStripMenuItem.Name = "entreprisesToolStripMenuItem";
			this.entreprisesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.entreprisesToolStripMenuItem.Text = "Entreprises";
			this.entreprisesToolStripMenuItem.Click += new System.EventHandler(this.entreprisesToolStripMenuItem_Click);
			// 
			// contactsToolStripMenuItem1
			// 
			this.contactsToolStripMenuItem1.Name = "contactsToolStripMenuItem1";
			this.contactsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.contactsToolStripMenuItem1.Text = "Contacts";
			this.contactsToolStripMenuItem1.Click += new System.EventHandler(this.contactsToolStripMenuItem1_Click);
			// 
			// exportationsToolStripMenuItem
			// 
			this.exportationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.pDFToolStripMenuItem});
			this.exportationsToolStripMenuItem.Name = "exportationsToolStripMenuItem";
			this.exportationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.exportationsToolStripMenuItem.Text = "Exportations";
			// 
			// cSVToolStripMenuItem
			// 
			this.cSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objetsToolStripMenuItem,
            this.packsToolStripMenuItem1,
            this.réservationsToolStripMenuItem1,
            this.utilisateursToolStripMenuItem2,
            this.facturesToolStripMenuItem1,
            this.réparationsToolStripMenuItem,
            this.contactsToolStripMenuItem2,
            this.entreprisesToolStripMenuItem1});
			this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
			this.cSVToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
			this.cSVToolStripMenuItem.Text = "CSV";
			this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
			// 
			// objetsToolStripMenuItem
			// 
			this.objetsToolStripMenuItem.Name = "objetsToolStripMenuItem";
			this.objetsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.objetsToolStripMenuItem.Text = "Objets";
			this.objetsToolStripMenuItem.Click += new System.EventHandler(this.objetsToolStripMenuItem_Click);
			// 
			// packsToolStripMenuItem1
			// 
			this.packsToolStripMenuItem1.Name = "packsToolStripMenuItem1";
			this.packsToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
			this.packsToolStripMenuItem1.Text = "Packs";
			this.packsToolStripMenuItem1.Click += new System.EventHandler(this.packsToolStripMenuItem1_Click);
			// 
			// réservationsToolStripMenuItem1
			// 
			this.réservationsToolStripMenuItem1.Name = "réservationsToolStripMenuItem1";
			this.réservationsToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
			this.réservationsToolStripMenuItem1.Text = "Réservations";
			this.réservationsToolStripMenuItem1.Click += new System.EventHandler(this.réservationsToolStripMenuItem1_Click);
			// 
			// utilisateursToolStripMenuItem2
			// 
			this.utilisateursToolStripMenuItem2.Name = "utilisateursToolStripMenuItem2";
			this.utilisateursToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
			this.utilisateursToolStripMenuItem2.Text = "Utilisateurs";
			this.utilisateursToolStripMenuItem2.Click += new System.EventHandler(this.utilisateursToolStripMenuItem2_Click);
			// 
			// facturesToolStripMenuItem1
			// 
			this.facturesToolStripMenuItem1.Name = "facturesToolStripMenuItem1";
			this.facturesToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
			this.facturesToolStripMenuItem1.Text = "Factures";
			this.facturesToolStripMenuItem1.Click += new System.EventHandler(this.facturesToolStripMenuItem1_Click);
			// 
			// réparationsToolStripMenuItem
			// 
			this.réparationsToolStripMenuItem.Name = "réparationsToolStripMenuItem";
			this.réparationsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.réparationsToolStripMenuItem.Text = "Réparations";
			// 
			// contactsToolStripMenuItem2
			// 
			this.contactsToolStripMenuItem2.Name = "contactsToolStripMenuItem2";
			this.contactsToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
			this.contactsToolStripMenuItem2.Text = "Contacts";
			// 
			// entreprisesToolStripMenuItem1
			// 
			this.entreprisesToolStripMenuItem1.Name = "entreprisesToolStripMenuItem1";
			this.entreprisesToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
			this.entreprisesToolStripMenuItem1.Text = "Entreprises";
			// 
			// pDFToolStripMenuItem
			// 
			this.pDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réservationsToolStripMenuItem2});
			this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
			this.pDFToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
			this.pDFToolStripMenuItem.Text = "PDF";
			// 
			// réservationsToolStripMenuItem2
			// 
			this.réservationsToolStripMenuItem2.Name = "réservationsToolStripMenuItem2";
			this.réservationsToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
			this.réservationsToolStripMenuItem2.Text = "Réservations";
			this.réservationsToolStripMenuItem2.Click += new System.EventHandler(this.réservationsToolStripMenuItem2_Click);
			// 
			// aProposToolStripMenuItem
			// 
			this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactsToolStripMenuItem});
			this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
			this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.aProposToolStripMenuItem.Text = "A propos";
			// 
			// contactsToolStripMenuItem
			// 
			this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
			this.contactsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.contactsToolStripMenuItem.Text = "Contacts";
			this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
			// 
			// réservationToolStripMenuItem
			// 
			this.réservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEquipmentToolStripMenuItem});
			this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
			this.réservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.réservationToolStripMenuItem.Text = "Réservation";
			// 
			// bookEquipmentToolStripMenuItem
			// 
			this.bookEquipmentToolStripMenuItem.Name = "bookEquipmentToolStripMenuItem";
			this.bookEquipmentToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.bookEquipmentToolStripMenuItem.Text = "Matériel";
			this.bookEquipmentToolStripMenuItem.Click += new System.EventHandler(this.bookEquipmentToolStripMenuItem_Click);
			// 
			// users_account_button
			// 
			this.users_account_button.Location = new System.Drawing.Point(693, 36);
			this.users_account_button.Name = "users_account_button";
			this.users_account_button.Size = new System.Drawing.Size(131, 41);
			this.users_account_button.TabIndex = 0;
			this.users_account_button.Text = "Comptes";
			this.users_account_button.UseVisualStyleBackColor = true;
			this.users_account_button.Click += new System.EventHandler(this.users_account_button_Click);
			// 
			// consumable_button
			// 
			this.consumable_button.Location = new System.Drawing.Point(693, 191);
			this.consumable_button.Name = "consumable_button";
			this.consumable_button.Size = new System.Drawing.Size(131, 41);
			this.consumable_button.TabIndex = 1;
			this.consumable_button.Text = "Consommables";
			this.consumable_button.UseVisualStyleBackColor = true;
			this.consumable_button.Visible = false;
			this.consumable_button.Click += new System.EventHandler(this.consumable_button_Click);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(693, 130);
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
			legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
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
			this.ItemTab.Controls.Add(this.ConsummableItemNbrLbl);
			this.ItemTab.Controls.Add(this.ReservableItemNbrLbl);
			this.ItemTab.Controls.Add(this.ItemsCharts);
			this.ItemTab.Location = new System.Drawing.Point(4, 22);
			this.ItemTab.Name = "ItemTab";
			this.ItemTab.Padding = new System.Windows.Forms.Padding(3);
			this.ItemTab.Size = new System.Drawing.Size(667, 370);
			this.ItemTab.TabIndex = 1;
			this.ItemTab.Text = "Objets";
			this.ItemTab.UseVisualStyleBackColor = true;
			// 
			// ConsummableItemNbrLbl
			// 
			this.ConsummableItemNbrLbl.AutoSize = true;
			this.ConsummableItemNbrLbl.Location = new System.Drawing.Point(448, 271);
			this.ConsummableItemNbrLbl.Name = "ConsummableItemNbrLbl";
			this.ConsummableItemNbrLbl.Size = new System.Drawing.Size(40, 13);
			this.ConsummableItemNbrLbl.TabIndex = 7;
			this.ConsummableItemNbrLbl.Text = "<error>";
			// 
			// ReservableItemNbrLbl
			// 
			this.ReservableItemNbrLbl.AutoSize = true;
			this.ReservableItemNbrLbl.Location = new System.Drawing.Point(182, 110);
			this.ReservableItemNbrLbl.Name = "ReservableItemNbrLbl";
			this.ReservableItemNbrLbl.Size = new System.Drawing.Size(40, 13);
			this.ReservableItemNbrLbl.TabIndex = 6;
			this.ReservableItemNbrLbl.Text = "<error>";
			// 
			// AccountTab
			// 
			this.AccountTab.Controls.Add(this.ActiveAccNbrLbl);
			this.AccountTab.Controls.Add(this.BannedAccNbrLbl);
			this.AccountTab.Controls.Add(this.AccountCharts);
			this.AccountTab.Location = new System.Drawing.Point(4, 22);
			this.AccountTab.Name = "AccountTab";
			this.AccountTab.Padding = new System.Windows.Forms.Padding(3);
			this.AccountTab.Size = new System.Drawing.Size(667, 370);
			this.AccountTab.TabIndex = 2;
			this.AccountTab.Text = "Comptes";
			this.AccountTab.UseVisualStyleBackColor = true;
			// 
			// ActiveAccNbrLbl
			// 
			this.ActiveAccNbrLbl.AutoSize = true;
			this.ActiveAccNbrLbl.Location = new System.Drawing.Point(81, 98);
			this.ActiveAccNbrLbl.Name = "ActiveAccNbrLbl";
			this.ActiveAccNbrLbl.Size = new System.Drawing.Size(40, 13);
			this.ActiveAccNbrLbl.TabIndex = 2;
			this.ActiveAccNbrLbl.Text = "<error>";
			// 
			// BannedAccNbrLbl
			// 
			this.BannedAccNbrLbl.AutoSize = true;
			this.BannedAccNbrLbl.Location = new System.Drawing.Point(427, 246);
			this.BannedAccNbrLbl.Name = "BannedAccNbrLbl";
			this.BannedAccNbrLbl.Size = new System.Drawing.Size(40, 13);
			this.BannedAccNbrLbl.TabIndex = 1;
			this.BannedAccNbrLbl.Text = "<error>";
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
			title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
			title2.DockedToChartArea = "ChartArea1";
			title2.Name = "AccountTitle";
			title2.Text = "Proportion des comptes";
			this.AccountCharts.Titles.Add(title2);
			// 
			// CapitalizedBtn
			// 
			this.CapitalizedBtn.Location = new System.Drawing.Point(693, 83);
			this.CapitalizedBtn.Name = "CapitalizedBtn";
			this.CapitalizedBtn.Size = new System.Drawing.Size(131, 41);
			this.CapitalizedBtn.TabIndex = 7;
			this.CapitalizedBtn.Text = "Matériel";
			this.CapitalizedBtn.UseVisualStyleBackColor = true;
			this.CapitalizedBtn.Click += new System.EventHandler(this.CapitalizedBtn_Click);
			// 
			// HomeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(836, 435);
			this.Controls.Add(this.CapitalizedBtn);
			this.Controls.Add(this.MainMenuStrip);
			this.Controls.Add(this.StatisticsTabControl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.consumable_button);
			this.Controls.Add(this.users_account_button);
			this.Name = "HomeView";
			this.Text = "PixLogic - Accueil";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.HomeView_Load);
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemsCharts)).EndInit();
			this.StatisticsTabControl.ResumeLayout(false);
			this.GeneralInfoTab.ResumeLayout(false);
			this.GeneralInfoTab.PerformLayout();
			this.ItemTab.ResumeLayout(false);
			this.ItemTab.PerformLayout();
			this.AccountTab.ResumeLayout(false);
			this.AccountTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AccountCharts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button users_account_button;
        private System.Windows.Forms.Button consumable_button;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart ItemsCharts;
        private System.Windows.Forms.TabControl StatisticsTabControl;
        private System.Windows.Forms.TabPage GeneralInfoTab;
        private System.Windows.Forms.Label ReservationAmmountNbrLbl;
        private System.Windows.Forms.Label ReservationAmmountLbl;
        private System.Windows.Forms.Label AmmountofItemsNbrLbl;
        private System.Windows.Forms.Label AmmountOfItemsLbl;
        private System.Windows.Forms.TabPage ItemTab;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem importationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem réservationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookEquipmentToolStripMenuItem;
        private System.Windows.Forms.Label AmmountOfPacksLbl;
        private System.Windows.Forms.Label AmmountOfPackNbrLbl;
        private System.Windows.Forms.TabPage AccountTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccountCharts;
        private System.Windows.Forms.Label AmmountOfInvoicesNbrLbl;
        private System.Windows.Forms.Label AmmountOfInvoicesLbl;
        private System.Windows.Forms.Label ReservableItemNbrLbl;
        private System.Windows.Forms.Label ConsummableItemNbrLbl;
        private System.Windows.Forms.Label ActiveAccNbrLbl;
        private System.Windows.Forms.Label BannedAccNbrLbl;
		private System.Windows.Forms.Button CapitalizedBtn;
		private System.Windows.Forms.ToolStripMenuItem objetsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem packsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entreprisesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem réparationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem entreprisesToolStripMenuItem1;
    }
}