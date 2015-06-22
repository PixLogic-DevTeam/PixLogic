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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.importationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importationsToolStripMenuItem,
            this.exportationsToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(784, 24);
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
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs (PDF)";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.MainMenuStrip_Imports_Users_Click);
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
            this.facturesToolStripMenuItem1});
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // objetsToolStripMenuItem
            // 
            this.objetsToolStripMenuItem.Name = "objetsToolStripMenuItem";
            this.objetsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.objetsToolStripMenuItem.Text = "Objets";
            this.objetsToolStripMenuItem.Click += new System.EventHandler(this.objetsToolStripMenuItem_Click);
            // 
            // packsToolStripMenuItem1
            // 
            this.packsToolStripMenuItem1.Name = "packsToolStripMenuItem1";
            this.packsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.packsToolStripMenuItem1.Text = "Packs";
            this.packsToolStripMenuItem1.Click += new System.EventHandler(this.packsToolStripMenuItem1_Click);
            // 
            // réservationsToolStripMenuItem1
            // 
            this.réservationsToolStripMenuItem1.Name = "réservationsToolStripMenuItem1";
            this.réservationsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.réservationsToolStripMenuItem1.Text = "Réservations";
            this.réservationsToolStripMenuItem1.Click += new System.EventHandler(this.réservationsToolStripMenuItem1_Click);
            // 
            // utilisateursToolStripMenuItem2
            // 
            this.utilisateursToolStripMenuItem2.Name = "utilisateursToolStripMenuItem2";
            this.utilisateursToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.utilisateursToolStripMenuItem2.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem2.Click += new System.EventHandler(this.utilisateursToolStripMenuItem2_Click);
            // 
            // facturesToolStripMenuItem1
            // 
            this.facturesToolStripMenuItem1.Name = "facturesToolStripMenuItem1";
            this.facturesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.facturesToolStripMenuItem1.Text = "Factures";
            this.facturesToolStripMenuItem1.Click += new System.EventHandler(this.facturesToolStripMenuItem1_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réservationsToolStripMenuItem2});
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // réservationsToolStripMenuItem2
            // 
            this.réservationsToolStripMenuItem2.Name = "réservationsToolStripMenuItem2";
            this.réservationsToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
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
            // 
            // HomeView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "HomeView";
            this.Text = "PixLogic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
	}
}