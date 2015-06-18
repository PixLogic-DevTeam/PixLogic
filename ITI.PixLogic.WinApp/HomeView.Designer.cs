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
            this.users_account_button = new System.Windows.Forms.Button();
            this.consumable_button = new System.Windows.Forms.Button();
            this.CapitalizedBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursformatPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donnéesformatCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consommablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immobilisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // users_account_button
            // 
            this.users_account_button.Location = new System.Drawing.Point(56, 54);
            this.users_account_button.Name = "users_account_button";
            this.users_account_button.Size = new System.Drawing.Size(131, 41);
            this.users_account_button.TabIndex = 0;
            this.users_account_button.Text = "Comptes utilisateurs";
            this.users_account_button.UseVisualStyleBackColor = true;
            this.users_account_button.Click += new System.EventHandler(this.users_account_button_Click);
            // 
            // consumable_button
            // 
            this.consumable_button.Location = new System.Drawing.Point(56, 149);
            this.consumable_button.Name = "consumable_button";
            this.consumable_button.Size = new System.Drawing.Size(131, 41);
            this.consumable_button.TabIndex = 1;
            this.consumable_button.Text = "Consommables";
            this.consumable_button.UseVisualStyleBackColor = true;
            this.consumable_button.Click += new System.EventHandler(this.consumable_button_Click);
            // 
            // CapitalizedBtn
            // 
            this.CapitalizedBtn.Location = new System.Drawing.Point(56, 101);
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
            this.aideToolStripMenuItem,
            this.exportationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
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
            // exportationsToolStripMenuItem
            // 
            this.exportationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursformatPDFToolStripMenuItem,
            this.donnéesformatCSVToolStripMenuItem});
            this.exportationsToolStripMenuItem.Name = "exportationsToolStripMenuItem";
            this.exportationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.exportationsToolStripMenuItem.Text = "Exportations";
            // 
            // utilisateursformatPDFToolStripMenuItem
            // 
            this.utilisateursformatPDFToolStripMenuItem.Name = "utilisateursformatPDFToolStripMenuItem";
            this.utilisateursformatPDFToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.utilisateursformatPDFToolStripMenuItem.Text = "Utilisateurs (format PDF)";
            this.utilisateursformatPDFToolStripMenuItem.Click += new System.EventHandler(this.utilisateursformatPDFToolStripMenuItem_Click);
            // 
            // donnéesformatCSVToolStripMenuItem
            // 
            this.donnéesformatCSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comptesToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.réservationsToolStripMenuItem,
            this.contactToolStripMenuItem1,
            this.consommablesToolStripMenuItem,
            this.immobilisableToolStripMenuItem,
            this.packsToolStripMenuItem,
            this.entreprisesToolStripMenuItem,
            this.marquesToolStripMenuItem,
            this.etatsToolStripMenuItem});
            this.donnéesformatCSVToolStripMenuItem.Name = "donnéesformatCSVToolStripMenuItem";
            this.donnéesformatCSVToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.donnéesformatCSVToolStripMenuItem.Text = "Données (format CSV)";
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.facturesToolStripMenuItem.Text = "Factures";
            // 
            // réservationsToolStripMenuItem
            // 
            this.réservationsToolStripMenuItem.Name = "réservationsToolStripMenuItem";
            this.réservationsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.réservationsToolStripMenuItem.Text = "Réservations";
            // 
            // contactToolStripMenuItem1
            // 
            this.contactToolStripMenuItem1.Name = "contactToolStripMenuItem1";
            this.contactToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.contactToolStripMenuItem1.Text = "Contact";
            // 
            // consommablesToolStripMenuItem
            // 
            this.consommablesToolStripMenuItem.Name = "consommablesToolStripMenuItem";
            this.consommablesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.consommablesToolStripMenuItem.Text = "Consommables";
            // 
            // immobilisableToolStripMenuItem
            // 
            this.immobilisableToolStripMenuItem.Name = "immobilisableToolStripMenuItem";
            this.immobilisableToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.immobilisableToolStripMenuItem.Text = "Immobilisable";
            // 
            // packsToolStripMenuItem
            // 
            this.packsToolStripMenuItem.Name = "packsToolStripMenuItem";
            this.packsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.packsToolStripMenuItem.Text = "Packs";
            // 
            // entreprisesToolStripMenuItem
            // 
            this.entreprisesToolStripMenuItem.Name = "entreprisesToolStripMenuItem";
            this.entreprisesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.entreprisesToolStripMenuItem.Text = "Entreprises";
            // 
            // marquesToolStripMenuItem
            // 
            this.marquesToolStripMenuItem.Name = "marquesToolStripMenuItem";
            this.marquesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.marquesToolStripMenuItem.Text = "Marques";
            // 
            // etatsToolStripMenuItem
            // 
            this.etatsToolStripMenuItem.Name = "etatsToolStripMenuItem";
            this.etatsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.etatsToolStripMenuItem.Text = "Etats";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(841, 354);
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
        private System.Windows.Forms.ToolStripMenuItem exportationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursformatPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donnéesformatCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consommablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immobilisableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreprisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatsToolStripMenuItem;
    }
}