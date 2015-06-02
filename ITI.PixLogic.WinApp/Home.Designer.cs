namespace ITI.PixLogic.WinApp
{
    partial class Home
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
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.léquipePixLogicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // users_account_button
            // 
            this.users_account_button.Location = new System.Drawing.Point(46, 165);
            this.users_account_button.Name = "users_account_button";
            this.users_account_button.Size = new System.Drawing.Size(131, 26);
            this.users_account_button.TabIndex = 0;
            this.users_account_button.Text = "Comptes utilisateurs";
            this.users_account_button.UseVisualStyleBackColor = true;
            this.users_account_button.Click += new System.EventHandler(this.users_account_button_Click);
            // 
            // consumable_button
            // 
            this.consumable_button.Location = new System.Drawing.Point(402, 165);
            this.consumable_button.Name = "consumable_button";
            this.consumable_button.Size = new System.Drawing.Size(131, 26);
            this.consumable_button.TabIndex = 1;
            this.consumable_button.Text = "Consommables";
            this.consumable_button.UseVisualStyleBackColor = true;
            this.consumable_button.Click += new System.EventHandler(this.consumable_button_Click);
            // 
            // CapitalizedBtn
            // 
            this.CapitalizedBtn.Location = new System.Drawing.Point(223, 165);
            this.CapitalizedBtn.Name = "CapitalizedBtn";
            this.CapitalizedBtn.Size = new System.Drawing.Size(131, 26);
            this.CapitalizedBtn.TabIndex = 2;
            this.CapitalizedBtn.Text = "Immobilisables";
            this.CapitalizedBtn.UseVisualStyleBackColor = true;
            this.CapitalizedBtn.Click += new System.EventHandler(this.CapitalizedBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDeDonnéeToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportDeDonnéeToolStripMenuItem
            // 
            this.exportDeDonnéeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem});
            this.exportDeDonnéeToolStripMenuItem.Name = "exportDeDonnéeToolStripMenuItem";
            this.exportDeDonnéeToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.exportDeDonnéeToolStripMenuItem.Text = "Import de données";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.léquipePixLogicToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // léquipePixLogicToolStripMenuItem
            // 
            this.léquipePixLogicToolStripMenuItem.Name = "léquipePixLogicToolStripMenuItem";
            this.léquipePixLogicToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.léquipePixLogicToolStripMenuItem.Text = "L\'équipe PixLogic";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 391);
            this.Controls.Add(this.CapitalizedBtn);
            this.Controls.Add(this.consumable_button);
            this.Controls.Add(this.users_account_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
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
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem léquipePixLogicToolStripMenuItem;
    }
}