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
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.MainMenuStrip_Imports_Users_Click);
            // 
            // exportationsToolStripMenuItem
            // 
            this.exportationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectsToolStripMenuItem,
            this.packsToolStripMenuItem,
            this.réservationsToolStripMenuItem,
            this.utilisateursToolStripMenuItem1,
            this.facturesToolStripMenuItem});
            this.exportationsToolStripMenuItem.Name = "exportationsToolStripMenuItem";
            this.exportationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.exportationsToolStripMenuItem.Text = "Exportations";
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.objectsToolStripMenuItem.Text = "Objets";
            // 
            // packsToolStripMenuItem
            // 
            this.packsToolStripMenuItem.Name = "packsToolStripMenuItem";
            this.packsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.packsToolStripMenuItem.Text = "Packs";
            // 
            // réservationsToolStripMenuItem
            // 
            this.réservationsToolStripMenuItem.Name = "réservationsToolStripMenuItem";
            this.réservationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.réservationsToolStripMenuItem.Text = "Réservations";
            // 
            // utilisateursToolStripMenuItem1
            // 
            this.utilisateursToolStripMenuItem1.Name = "utilisateursToolStripMenuItem1";
            this.utilisateursToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.utilisateursToolStripMenuItem1.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem1.Click += new System.EventHandler(this.MainMenuStrip_Exports_Users_Click);
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturesToolStripMenuItem.Text = "Factures";
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
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // HomeView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
	}
}