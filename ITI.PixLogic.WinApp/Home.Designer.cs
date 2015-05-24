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
            this.SuspendLayout();
            // 
            // users_account_button
            // 
            this.users_account_button.Location = new System.Drawing.Point(46, 165);
            this.users_account_button.Name = "users_account_button";
            this.users_account_button.Size = new System.Drawing.Size(123, 23);
            this.users_account_button.TabIndex = 0;
            this.users_account_button.Text = "Comptes utilisateurs";
            this.users_account_button.UseVisualStyleBackColor = true;
            this.users_account_button.Click += new System.EventHandler(this.users_account_button_Click);
            // 
            // consumable_button
            // 
            this.consumable_button.Location = new System.Drawing.Point(539, 165);
            this.consumable_button.Name = "consumable_button";
            this.consumable_button.Size = new System.Drawing.Size(89, 23);
            this.consumable_button.TabIndex = 1;
            this.consumable_button.Text = "Consommables";
            this.consumable_button.UseVisualStyleBackColor = true;
            this.consumable_button.Click += new System.EventHandler(this.consumable_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 391);
            this.Controls.Add(this.consumable_button);
            this.Controls.Add(this.users_account_button);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button users_account_button;
        private System.Windows.Forms.Button consumable_button;
    }
}