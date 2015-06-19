namespace ITI.PixLogic.WinApp
{
    partial class AddConsumableView
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
			this.Current_state_consumable_txt = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.consumablessubcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mainCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.button_back = new System.Windows.Forms.Button();
			nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.consumablessubcategoriesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(94, 236);
			nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(78, 13);
			nameLabel.TabIndex = 14;
			nameLabel.Text = "Sous-catégorie";
			// 
			// id_consumable
			// 
			this.id_consumable.AutoSize = true;
			this.id_consumable.Location = new System.Drawing.Point(94, 44);
			this.id_consumable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.id_consumable.Name = "id_consumable";
			this.id_consumable.Size = new System.Drawing.Size(15, 13);
			this.id_consumable.TabIndex = 0;
			this.id_consumable.Text = "id";
			// 
			// name_consumable
			// 
			this.name_consumable.AutoSize = true;
			this.name_consumable.Location = new System.Drawing.Point(94, 80);
			this.name_consumable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.name_consumable.Name = "name_consumable";
			this.name_consumable.Size = new System.Drawing.Size(29, 13);
			this.name_consumable.TabIndex = 1;
			this.name_consumable.Text = "Nom";
			// 
			// description_consumable
			// 
			this.description_consumable.AutoSize = true;
			this.description_consumable.Location = new System.Drawing.Point(94, 120);
			this.description_consumable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.description_consumable.Name = "description_consumable";
			this.description_consumable.Size = new System.Drawing.Size(60, 13);
			this.description_consumable.TabIndex = 2;
			this.description_consumable.Text = "Description";
			// 
			// reservation_cost_consumable
			// 
			this.reservation_cost_consumable.AutoSize = true;
			this.reservation_cost_consumable.Location = new System.Drawing.Point(94, 153);
			this.reservation_cost_consumable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.reservation_cost_consumable.Name = "reservation_cost_consumable";
			this.reservation_cost_consumable.Size = new System.Drawing.Size(99, 13);
			this.reservation_cost_consumable.TabIndex = 3;
			this.reservation_cost_consumable.Text = "Coût de réservation";
			// 
			// invoice_consumable
			// 
			this.invoice_consumable.AutoSize = true;
			this.invoice_consumable.Location = new System.Drawing.Point(94, 274);
			this.invoice_consumable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.invoice_consumable.Name = "invoice_consumable";
			this.invoice_consumable.Size = new System.Drawing.Size(43, 13);
			this.invoice_consumable.TabIndex = 5;
			this.invoice_consumable.Text = "Facture";
			// 
			// current_state_consumable
			// 
			this.current_state_consumable.AutoSize = true;
			this.current_state_consumable.Location = new System.Drawing.Point(94, 307);
			this.current_state_consumable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.current_state_consumable.Name = "current_state_consumable";
			this.current_state_consumable.Size = new System.Drawing.Size(26, 13);
			this.current_state_consumable.TabIndex = 6;
			this.current_state_consumable.Text = "Etat";
			// 
			// Add_consumable_button
			// 
			this.Add_consumable_button.Location = new System.Drawing.Point(214, 349);
			this.Add_consumable_button.Margin = new System.Windows.Forms.Padding(2);
			this.Add_consumable_button.Name = "Add_consumable_button";
			this.Add_consumable_button.Size = new System.Drawing.Size(56, 19);
			this.Add_consumable_button.TabIndex = 7;
			this.Add_consumable_button.Text = "Ajouter";
			this.Add_consumable_button.UseVisualStyleBackColor = true;
			this.Add_consumable_button.Click += new System.EventHandler(this.Add_consumable_button_Click);
			// 
			// Name_consumable_txt
			// 
			this.Name_consumable_txt.Location = new System.Drawing.Point(248, 76);
			this.Name_consumable_txt.Margin = new System.Windows.Forms.Padding(2);
			this.Name_consumable_txt.Name = "Name_consumable_txt";
			this.Name_consumable_txt.Size = new System.Drawing.Size(76, 20);
			this.Name_consumable_txt.TabIndex = 8;
			// 
			// Description_consumable_txt
			// 
			this.Description_consumable_txt.Location = new System.Drawing.Point(248, 116);
			this.Description_consumable_txt.Margin = new System.Windows.Forms.Padding(2);
			this.Description_consumable_txt.Name = "Description_consumable_txt";
			this.Description_consumable_txt.Size = new System.Drawing.Size(76, 20);
			this.Description_consumable_txt.TabIndex = 9;
			// 
			// Invoice_consumable_txt
			// 
			this.Invoice_consumable_txt.Location = new System.Drawing.Point(248, 270);
			this.Invoice_consumable_txt.Margin = new System.Windows.Forms.Padding(2);
			this.Invoice_consumable_txt.Name = "Invoice_consumable_txt";
			this.Invoice_consumable_txt.Size = new System.Drawing.Size(76, 20);
			this.Invoice_consumable_txt.TabIndex = 12;
			// 
			// Current_state_consumable_txt
			// 
			this.Current_state_consumable_txt.Location = new System.Drawing.Point(248, 303);
			this.Current_state_consumable_txt.Margin = new System.Windows.Forms.Padding(2);
			this.Current_state_consumable_txt.Name = "Current_state_consumable_txt";
			this.Current_state_consumable_txt.Size = new System.Drawing.Size(76, 20);
			this.Current_state_consumable_txt.TabIndex = 13;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(248, 148);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(76, 20);
			this.textBox1.TabIndex = 14;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// consumablessubcategoriesBindingSource
			// 
			this.consumablessubcategoriesBindingSource.DataSource = typeof(ITI.PixLogic.DAL.Contexts.Items.ItemSubCategory);
			this.consumablessubcategoriesBindingSource.CurrentChanged += new System.EventHandler(this.consumablessubcategoriesBindingSource_CurrentChanged);
			// 
			// subCategoryComboBox
			// 
			this.subCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumablessubcategoriesBindingSource, "name", true));
			this.subCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.subCategoryComboBox.FormattingEnabled = true;
			this.subCategoryComboBox.Location = new System.Drawing.Point(248, 231);
			this.subCategoryComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.subCategoryComboBox.Name = "subCategoryComboBox";
			this.subCategoryComboBox.Size = new System.Drawing.Size(184, 21);
			this.subCategoryComboBox.TabIndex = 15;
			this.subCategoryComboBox.Click += new System.EventHandler(this.subCategoryComboBox_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(94, 196);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Catégorie principale";
			// 
			// mainCategoryComboBox
			// 
			this.mainCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mainCategoryComboBox.FormattingEnabled = true;
			this.mainCategoryComboBox.Location = new System.Drawing.Point(248, 190);
			this.mainCategoryComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.mainCategoryComboBox.Name = "mainCategoryComboBox";
			this.mainCategoryComboBox.Size = new System.Drawing.Size(184, 21);
			this.mainCategoryComboBox.TabIndex = 17;
			this.mainCategoryComboBox.Click += new System.EventHandler(this.mainCategoryComboBox_Click);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(366, 347);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(75, 23);
			this.button_back.TabIndex = 18;
			this.button_back.Text = "Retour";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// AddConsumableView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 481);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.mainCategoryComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.subCategoryComboBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Current_state_consumable_txt);
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
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddConsumableView";
			this.Text = "PixLogic - Ajouter un objet consommable";
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
        private System.Windows.Forms.TextBox Current_state_consumable_txt;
        private System.Windows.Forms.BindingSource consumableBindingSource;
        private System.Windows.Forms.BindingSource consumables_sub_categoriesBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource consumablessubcategoriesBindingSource;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mainCategoryComboBox;
        private System.Windows.Forms.Button button_back;
    }
}