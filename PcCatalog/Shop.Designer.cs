

namespace PcCatalog
{
    partial class Shop
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
            this.Cpu_Button = new System.Windows.Forms.Button();
            this.ListItems = new System.Windows.Forms.DataGridView();
            this.Gpu_Button = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.Hdd_Button = new System.Windows.Forms.Button();
            this.Mobo_Button = new System.Windows.Forms.Button();
            this.Psu_Button = new System.Windows.Forms.Button();
            this.Ram_Button = new System.Windows.Forms.Button();
            this.Ssd_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cart_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Budget_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveBoughtProducts = new System.Windows.Forms.Button();
            this.ReturnToListItems = new System.Windows.Forms.Button();
            this.EditGrid = new System.Windows.Forms.DataGridView();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.optionalPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrid)).BeginInit();
            this.optionalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cpu_Button
            // 
            this.Cpu_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cpu_Button.Location = new System.Drawing.Point(2, 1);
            this.Cpu_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Cpu_Button.Name = "Cpu_Button";
            this.Cpu_Button.Size = new System.Drawing.Size(83, 29);
            this.Cpu_Button.TabIndex = 0;
            this.Cpu_Button.Text = "CPU";
            this.Cpu_Button.UseVisualStyleBackColor = true;
            this.Cpu_Button.Click += new System.EventHandler(this.Cpu_Button_Click);
            // 
            // ListItems
            // 
            this.ListItems.AllowUserToAddRows = false;
            this.ListItems.AllowUserToDeleteRows = false;
            this.ListItems.AllowUserToOrderColumns = true;
            this.ListItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListItems.Location = new System.Drawing.Point(226, 54);
            this.ListItems.Name = "ListItems";
            this.ListItems.ReadOnly = true;
            this.ListItems.RowTemplate.Height = 25;
            this.ListItems.Size = new System.Drawing.Size(391, 228);
            this.ListItems.TabIndex = 1;
            this.ListItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItems_CellContentClick);
            // 
            // Gpu_Button
            // 
            this.Gpu_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gpu_Button.Location = new System.Drawing.Point(85, 1);
            this.Gpu_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Gpu_Button.Name = "Gpu_Button";
            this.Gpu_Button.Size = new System.Drawing.Size(83, 29);
            this.Gpu_Button.TabIndex = 2;
            this.Gpu_Button.Text = "GPU";
            this.Gpu_Button.UseVisualStyleBackColor = true;
            this.Gpu_Button.Click += new System.EventHandler(this.Gpu_Button_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(464, 331);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(2, 32);
            this.priceLabel.TabIndex = 4;
            // 
            // Hdd_Button
            // 
            this.Hdd_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hdd_Button.Location = new System.Drawing.Point(168, 1);
            this.Hdd_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Hdd_Button.Name = "Hdd_Button";
            this.Hdd_Button.Size = new System.Drawing.Size(83, 29);
            this.Hdd_Button.TabIndex = 5;
            this.Hdd_Button.Text = "HDD";
            this.Hdd_Button.UseVisualStyleBackColor = true;
            this.Hdd_Button.Click += new System.EventHandler(this.Hdd_Button_Click);
            // 
            // Mobo_Button
            // 
            this.Mobo_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mobo_Button.Location = new System.Drawing.Point(334, 1);
            this.Mobo_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Mobo_Button.Name = "Mobo_Button";
            this.Mobo_Button.Size = new System.Drawing.Size(83, 29);
            this.Mobo_Button.TabIndex = 6;
            this.Mobo_Button.Text = "MOBO";
            this.Mobo_Button.UseVisualStyleBackColor = true;
            this.Mobo_Button.Click += new System.EventHandler(this.Mobo_Button_Click);
            // 
            // Psu_Button
            // 
            this.Psu_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Psu_Button.Location = new System.Drawing.Point(251, 1);
            this.Psu_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Psu_Button.Name = "Psu_Button";
            this.Psu_Button.Size = new System.Drawing.Size(83, 29);
            this.Psu_Button.TabIndex = 7;
            this.Psu_Button.Text = "PSU";
            this.Psu_Button.UseVisualStyleBackColor = true;
            this.Psu_Button.Click += new System.EventHandler(this.Psu_Button_Click);
            // 
            // Ram_Button
            // 
            this.Ram_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ram_Button.Location = new System.Drawing.Point(417, 1);
            this.Ram_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Ram_Button.Name = "Ram_Button";
            this.Ram_Button.Size = new System.Drawing.Size(82, 29);
            this.Ram_Button.TabIndex = 8;
            this.Ram_Button.Text = "RAM";
            this.Ram_Button.UseVisualStyleBackColor = true;
            this.Ram_Button.Click += new System.EventHandler(this.Ram_Button_Click);
            // 
            // Ssd_Button
            // 
            this.Ssd_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ssd_Button.Location = new System.Drawing.Point(499, 1);
            this.Ssd_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Ssd_Button.Name = "Ssd_Button";
            this.Ssd_Button.Size = new System.Drawing.Size(82, 29);
            this.Ssd_Button.TabIndex = 9;
            this.Ssd_Button.Text = "SSD";
            this.Ssd_Button.UseVisualStyleBackColor = true;
            this.Ssd_Button.Click += new System.EventHandler(this.Ssd_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(258, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Cost:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(543, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "BGN";
            // 
            // Cart_Button
            // 
            this.Cart_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cart_Button.Location = new System.Drawing.Point(693, 409);
            this.Cart_Button.Name = "Cart_Button";
            this.Cart_Button.Size = new System.Drawing.Size(95, 29);
            this.Cart_Button.TabIndex = 13;
            this.Cart_Button.Text = "To Cart ";
            this.Cart_Button.UseVisualStyleBackColor = true;
            this.Cart_Button.Click += new System.EventHandler(this.Cart_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_Button.Location = new System.Drawing.Point(12, 409);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(88, 29);
            this.Back_Button.TabIndex = 14;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(295, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Budget";
            // 
            // Budget_Label
            // 
            this.Budget_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Budget_Label.AutoSize = true;
            this.Budget_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Budget_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Budget_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Budget_Label.Location = new System.Drawing.Point(464, 370);
            this.Budget_Label.Name = "Budget_Label";
            this.Budget_Label.Size = new System.Drawing.Size(2, 32);
            this.Budget_Label.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(543, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "BGN";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(523, 287);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(88, 29);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveBoughtProducts
            // 
            this.RemoveBoughtProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveBoughtProducts.Location = new System.Drawing.Point(359, 287);
            this.RemoveBoughtProducts.Name = "RemoveBoughtProducts";
            this.RemoveBoughtProducts.Size = new System.Drawing.Size(158, 29);
            this.RemoveBoughtProducts.TabIndex = 19;
            this.RemoveBoughtProducts.Text = "Remove Bought Products";
            this.RemoveBoughtProducts.UseVisualStyleBackColor = true;
            this.RemoveBoughtProducts.Click += new System.EventHandler(this.RemoveBoughtProducts_Click);
            // 
            // ReturnToListItems
            // 
            this.ReturnToListItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnToListItems.Location = new System.Drawing.Point(258, 287);
            this.ReturnToListItems.Name = "ReturnToListItems";
            this.ReturnToListItems.Size = new System.Drawing.Size(95, 29);
            this.ReturnToListItems.TabIndex = 20;
            this.ReturnToListItems.Text = "Return To Shop";
            this.ReturnToListItems.UseVisualStyleBackColor = true;
            this.ReturnToListItems.Visible = false;
            this.ReturnToListItems.Click += new System.EventHandler(this.ReturnToListItems_Click);
            // 
            // EditGrid
            // 
            this.EditGrid.AllowUserToAddRows = false;
            this.EditGrid.AllowUserToDeleteRows = false;
            this.EditGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EditGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.EditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditGrid.Location = new System.Drawing.Point(226, 54);
            this.EditGrid.Name = "EditGrid";
            this.EditGrid.RowTemplate.Height = 25;
            this.EditGrid.Size = new System.Drawing.Size(391, 228);
            this.EditGrid.TabIndex = 21;
            this.EditGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGrid_CellContentClick);
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(5, 80);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(160, 25);
            this.ItemComboBox.TabIndex = 32;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(2, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(797, 2);
            this.label5.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Products";
            // 
            // optionalPanel
            // 
            this.optionalPanel.Controls.Add(this.label6);
            this.optionalPanel.Controls.Add(this.ItemComboBox);
            this.optionalPanel.Location = new System.Drawing.Point(7, 86);
            this.optionalPanel.Name = "optionalPanel";
            this.optionalPanel.Size = new System.Drawing.Size(186, 146);
            this.optionalPanel.TabIndex = 35;
            this.optionalPanel.Visible = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionalPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditGrid);
            this.Controls.Add(this.ReturnToListItems);
            this.Controls.Add(this.RemoveBoughtProducts);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Budget_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Cart_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ssd_Button);
            this.Controls.Add(this.Ram_Button);
            this.Controls.Add(this.Psu_Button);
            this.Controls.Add(this.Mobo_Button);
            this.Controls.Add(this.Hdd_Button);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.Gpu_Button);
            this.Controls.Add(this.ListItems);
            this.Controls.Add(this.Cpu_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Shop";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrid)).EndInit();
            this.optionalPanel.ResumeLayout(false);
            this.optionalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cpu_Button;
        private System.Windows.Forms.DataGridView ListItems;
        private System.Windows.Forms.Button Gpu_Button;     
        private System.Windows.Forms.Button Hdd_Button;
        private System.Windows.Forms.Button Mobo_Button;
        private System.Windows.Forms.Button Psu_Button;
        private System.Windows.Forms.Button Ram_Button;
        private System.Windows.Forms.Button Ssd_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cart_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button EditButton;
        public System.Windows.Forms.Label Budget_Label;
        public System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button RemoveBoughtProducts;
        private System.Windows.Forms.Button ReturnToListItems;
        private System.Windows.Forms.DataGridView EditGrid;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel optionalPanel;
    }
}