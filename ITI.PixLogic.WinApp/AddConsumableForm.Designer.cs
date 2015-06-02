namespace ITI.PixLogic.WinApp
{
    partial class AddConsumableForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            this.id_consumable = new System.Windows.Forms.Label();
            this.name_consumable = new System.Windows.Forms.Label();
            this.description_consumable = new System.Windows.Forms.Label();
            this.reservation_cost_consumable = new System.Windows.Forms.Label();
            this.invoice_consumable = new System.Windows.Forms.Label();
            this.current_state_consumable = new System.Windows.Forms.Label();
            this.Add_consumable_button = new System.Windows.Forms.Button();
            this.Name_consumable_txt = new System.Windows.Forms.TextBox();
            this.Description_consumable_txt = new System.Windows.Forms.TextBox();
            this.Invoice_consumable_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.consumablessubcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consumablessubcategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(125, 291);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(104, 17);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Sous-catégorie";
            // 
            // id_consumable
            // 
            this.id_consumable.AutoSize = true;
            this.id_consumable.Location = new System.Drawing.Point(125, 54);
            this.id_consumable.Name = "id_consumable";
            this.id_consumable.Size = new System.Drawing.Size(19, 17);
            this.id_consumable.TabIndex = 0;
            this.id_consumable.Text = "id";
            // 
            // name_consumable
            // 
            this.name_consumable.AutoSize = true;
            this.name_consumable.Location = new System.Drawing.Point(125, 99);
            this.name_consumable.Name = "name_consumable";
            this.name_consumable.Size = new System.Drawing.Size(37, 17);
            this.name_consumable.TabIndex = 1;
            this.name_consumable.Text = "Nom";
            // 
            // description_consumable
            // 
            this.description_consumable.AutoSize = true;
            this.description_consumable.Location = new System.Drawing.Point(125, 148);
            this.description_consumable.Name = "description_consumable";
            this.description_consumable.Size = new System.Drawing.Size(79, 17);
            this.description_consumable.TabIndex = 2;
            this.description_consumable.Text = "Description";
            // 
            // reservation_cost_consumable
            // 
            this.reservation_cost_consumable.AutoSize = true;
            this.reservation_cost_consumable.Location = new System.Drawing.Point(125, 188);
            this.reservation_cost_consumable.Name = "reservation_cost_consumable";
            this.reservation_cost_consumable.Size = new System.Drawing.Size(132, 17);
            this.reservation_cost_consumable.TabIndex = 3;
            this.reservation_cost_consumable.Text = "Coût de réservation";
            // 
            // invoice_consumable
            // 
            this.invoice_consumable.AutoSize = true;
            this.invoice_consumable.Location = new System.Drawing.Point(125, 337);
            this.invoice_consumable.Name = "invoice_consumable";
            this.invoice_consumable.Size = new System.Drawing.Size(56, 17);
            this.invoice_consumable.TabIndex = 5;
            this.invoice_consumable.Text = "Facture";
            // 
            // current_state_consumable
            // 
            this.current_state_consumable.AutoSize = true;
            this.current_state_consumable.Location = new System.Drawing.Point(125, 378);
            this.current_state_consumable.Name = "current_state_consumable";
            this.current_state_consumable.Size = new System.Drawing.Size(33, 17);
            this.current_state_consumable.TabIndex = 6;
            this.current_state_consumable.Text = "Etat";
            // 
            // Add_consumable_button
            // 
            this.Add_consumable_button.Location = new System.Drawing.Point(286, 430);
            this.Add_consumable_button.Name = "Add_consumable_button";
            this.Add_consumable_button.Size = new System.Drawing.Size(75, 23);
            this.Add_consumable_button.TabIndex = 7;
            this.Add_consumable_button.Text = "Ajouter";
            this.Add_consumable_button.UseVisualStyleBackColor = true;
            this.Add_consumable_button.Click += new System.EventHandler(this.Add_consumable_button_Click);
            // 
            // Name_consumable_txt
            // 
            this.Name_consumable_txt.Location = new System.Drawing.Point(330, 94);
            this.Name_consumable_txt.Name = "Name_consumable_txt";
            this.Name_consumable_txt.Size = new System.Drawing.Size(100, 22);
            this.Name_consumable_txt.TabIndex = 8;
            // 
            // Description_consumable_txt
            // 
            this.Description_consumable_txt.Location = new System.Drawing.Point(330, 143);
            this.Description_consumable_txt.Name = "Description_consumable_txt";
            this.Description_consumable_txt.Size = new System.Drawing.Size(100, 22);
            this.Description_consumable_txt.TabIndex = 9;
            // 
            // Invoice_consumable_txt
            // 
            this.Invoice_consumable_txt.Location = new System.Drawing.Point(330, 332);
            this.Invoice_consumable_txt.Name = "Invoice_consumable_txt";
            this.Invoice_consumable_txt.Size = new System.Drawing.Size(100, 22);
            this.Invoice_consumable_txt.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // consumablessubcategoriesBindingSource
            // 
            this.consumablessubcategoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.consumables_sub_categories);
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumablessubcategoriesBindingSource, "name", true));
            this.subCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(330, 284);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(244, 24);
            this.subCategoryComboBox.TabIndex = 15;
            this.subCategoryComboBox.Click += new System.EventHandler(this.subCategoryComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Catégorie principale";
            // 
            // mainCategoryComboBox
            // 
            this.mainCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainCategoryComboBox.FormattingEnabled = true;
            this.mainCategoryComboBox.Location = new System.Drawing.Point(330, 234);
            this.mainCategoryComboBox.Name = "mainCategoryComboBox";
            this.mainCategoryComboBox.Size = new System.Drawing.Size(244, 24);
            this.mainCategoryComboBox.TabIndex = 14;
            this.mainCategoryComboBox.Click += new System.EventHandler(this.mainCategoryComboBox_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(330, 378);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 24);
            this.stateComboBox.TabIndex = 18;
            this.stateComboBox.Click += new System.EventHandler(this.stateComboBox_Click);
            // 
            // AddConsumableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 592);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.mainCategoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Invoice_consumable_txt);
            this.Controls.Add(this.Description_consumable_txt);
            this.Controls.Add(this.Name_consumable_txt);
            this.Controls.Add(this.Add_consumable_button);
            this.Controls.Add(this.current_state_consumable);
            this.Controls.Add(this.invoice_consumable);
            this.Controls.Add(this.reservation_cost_consumable);
            this.Controls.Add(this.description_consumable);
            this.Controls.Add(this.name_consumable);
            this.Controls.Add(this.id_consumable);
            this.Name = "AddConsumableForm";
            this.Text = "AddConsumableForm";
            ((System.ComponentModel.ISupportInitialize)(this.consumablessubcategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_consumable;
        private System.Windows.Forms.Label name_consumable;
        private System.Windows.Forms.Label description_consumable;
        private System.Windows.Forms.Label reservation_cost_consumable;
        private System.Windows.Forms.Label invoice_consumable;
        private System.Windows.Forms.Label current_state_consumable;
        private System.Windows.Forms.Button Add_consumable_button;
        private System.Windows.Forms.TextBox Name_consumable_txt;
        private System.Windows.Forms.TextBox Description_consumable_txt;
        private System.Windows.Forms.TextBox Invoice_consumable_txt;
        private System.Windows.Forms.BindingSource consumableBindingSource;
        private System.Windows.Forms.BindingSource consumables_sub_categoriesBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource consumablessubcategoriesBindingSource;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mainCategoryComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
    }
}