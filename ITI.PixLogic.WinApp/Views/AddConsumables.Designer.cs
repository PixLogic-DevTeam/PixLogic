namespace ITI.PixLogic.WinApp.Views
{
    partial class AddConsumables
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
            this.EAN13_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reference_textBox = new System.Windows.Forms.TextBox();
            this.Reference = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EAN13_textBox
            // 
            this.EAN13_textBox.Location = new System.Drawing.Point(216, 57);
            this.EAN13_textBox.Name = "EAN13_textBox";
            this.EAN13_textBox.Size = new System.Drawing.Size(100, 22);
            this.EAN13_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "EAN13";
            // 
            // Reference_textBox
            // 
            this.Reference_textBox.Location = new System.Drawing.Point(216, 106);
            this.Reference_textBox.Name = "Reference_textBox";
            this.Reference_textBox.Size = new System.Drawing.Size(100, 22);
            this.Reference_textBox.TabIndex = 2;
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.Location = new System.Drawing.Point(136, 106);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(74, 17);
            this.Reference.TabIndex = 3;
            this.Reference.Text = "Reference";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coût de réservation";
            // 
            // AddConsumables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.Reference_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EAN13_textBox);
            this.Name = "AddConsumables";
            this.Text = "AddConsumables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EAN13_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Reference_textBox;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}