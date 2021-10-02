
namespace PcCatalog
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.Ssd_Button = new System.Windows.Forms.Button();
            this.Ram_Button = new System.Windows.Forms.Button();
            this.Psu_Button = new System.Windows.Forms.Button();
            this.Mobo_Button = new System.Windows.Forms.Button();
            this.Hdd_Button = new System.Windows.Forms.Button();
            this.Gpu_Button = new System.Windows.Forms.Button();
            this.Cpu_Button = new System.Windows.Forms.Button();
            this.ListItems = new System.Windows.Forms.DataGridView();
            this.NewProduct = new System.Windows.Forms.Button();
            this.CorrectionButton = new System.Windows.Forms.Button();
            this.ProductRemove = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.SalesPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SalesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ssd_Button
            // 
            this.Ssd_Button.Location = new System.Drawing.Point(45, 179);
            this.Ssd_Button.Name = "Ssd_Button";
            this.Ssd_Button.Size = new System.Drawing.Size(75, 23);
            this.Ssd_Button.TabIndex = 16;
            this.Ssd_Button.Text = "SSD";
            this.Ssd_Button.UseVisualStyleBackColor = true;
            // 
            // Ram_Button
            // 
            this.Ram_Button.Location = new System.Drawing.Point(45, 150);
            this.Ram_Button.Name = "Ram_Button";
            this.Ram_Button.Size = new System.Drawing.Size(75, 23);
            this.Ram_Button.TabIndex = 15;
            this.Ram_Button.Text = "RAM";
            this.Ram_Button.UseVisualStyleBackColor = true;
            // 
            // Psu_Button
            // 
            this.Psu_Button.Location = new System.Drawing.Point(45, 121);
            this.Psu_Button.Name = "Psu_Button";
            this.Psu_Button.Size = new System.Drawing.Size(75, 23);
            this.Psu_Button.TabIndex = 14;
            this.Psu_Button.Text = "PSU";
            this.Psu_Button.UseVisualStyleBackColor = true;
            // 
            // Mobo_Button
            // 
            this.Mobo_Button.Location = new System.Drawing.Point(45, 92);
            this.Mobo_Button.Name = "Mobo_Button";
            this.Mobo_Button.Size = new System.Drawing.Size(75, 23);
            this.Mobo_Button.TabIndex = 13;
            this.Mobo_Button.Text = "MOBO";
            this.Mobo_Button.UseVisualStyleBackColor = true;
            // 
            // Hdd_Button
            // 
            this.Hdd_Button.Location = new System.Drawing.Point(45, 62);
            this.Hdd_Button.Name = "Hdd_Button";
            this.Hdd_Button.Size = new System.Drawing.Size(75, 23);
            this.Hdd_Button.TabIndex = 12;
            this.Hdd_Button.Text = "HDD";
            this.Hdd_Button.UseVisualStyleBackColor = true;
            // 
            // Gpu_Button
            // 
            this.Gpu_Button.Location = new System.Drawing.Point(45, 32);
            this.Gpu_Button.Name = "Gpu_Button";
            this.Gpu_Button.Size = new System.Drawing.Size(75, 23);
            this.Gpu_Button.TabIndex = 11;
            this.Gpu_Button.Text = "GPU";
            this.Gpu_Button.UseVisualStyleBackColor = true;
            // 
            // Cpu_Button
            // 
            this.Cpu_Button.Location = new System.Drawing.Point(45, 3);
            this.Cpu_Button.Name = "Cpu_Button";
            this.Cpu_Button.Size = new System.Drawing.Size(75, 23);
            this.Cpu_Button.TabIndex = 10;
            this.Cpu_Button.Text = "CPU";
            this.Cpu_Button.UseVisualStyleBackColor = true;
            // 
            // ListItems
            // 
            this.ListItems.AllowUserToAddRows = false;
            this.ListItems.AllowUserToDeleteRows = false;
            this.ListItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListItems.Location = new System.Drawing.Point(216, 66);
            this.ListItems.Name = "ListItems";
            this.ListItems.ReadOnly = true;
            this.ListItems.RowTemplate.Height = 25;
            this.ListItems.Size = new System.Drawing.Size(391, 228);
            this.ListItems.TabIndex = 17;
            this.ListItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItems_CellClick);
            this.ListItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItems_CellValueChanged);
            // 
            // NewProduct
            // 
            this.NewProduct.Location = new System.Drawing.Point(23, 31);
            this.NewProduct.Name = "NewProduct";
            this.NewProduct.Size = new System.Drawing.Size(139, 23);
            this.NewProduct.TabIndex = 18;
            this.NewProduct.Text = "New";
            this.NewProduct.UseVisualStyleBackColor = true;
            this.NewProduct.Click += new System.EventHandler(this.NewProduct_Click);
            // 
            // CorrectionButton
            // 
            this.CorrectionButton.Location = new System.Drawing.Point(23, 59);
            this.CorrectionButton.Name = "CorrectionButton";
            this.CorrectionButton.Size = new System.Drawing.Size(139, 23);
            this.CorrectionButton.TabIndex = 19;
            this.CorrectionButton.Text = "Correction";
            this.CorrectionButton.UseVisualStyleBackColor = true;
            this.CorrectionButton.Click += new System.EventHandler(this.CorrectionButton_Click);
            // 
            // ProductRemove
            // 
            this.ProductRemove.Location = new System.Drawing.Point(23, 87);
            this.ProductRemove.Name = "ProductRemove";
            this.ProductRemove.Size = new System.Drawing.Size(139, 23);
            this.ProductRemove.TabIndex = 20;
            this.ProductRemove.Text = "Remove product";
            this.ProductRemove.UseVisualStyleBackColor = true;
            this.ProductRemove.Click += new System.EventHandler(this.ProductRemove_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(214, 30);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(49, 17);
            this.ModelLabel.TabIndex = 21;
            this.ModelLabel.Text = "Model:";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(269, 29);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(74, 23);
            this.ModelBox.TabIndex = 22;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(349, 31);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(36, 17);
            this.PriceLabel.TabIndex = 23;
            this.PriceLabel.Text = "Price";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(391, 29);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(62, 23);
            this.PriceBox.TabIndex = 24;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(469, 34);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(79, 15);
            this.StatusLabel.TabIndex = 25;
            this.StatusLabel.Text = "Status(1 or 0):";
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(554, 29);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(64, 23);
            this.StatusBox.TabIndex = 26;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(682, 406);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(106, 32);
            this.Back.TabIndex = 29;
            this.Back.Text = "Back To Main ";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Location = new System.Drawing.Point(335, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 56);
            this.panel1.TabIndex = 30;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(3, 31);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(139, 22);
            this.CancelButton.TabIndex = 31;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(139, 22);
            this.SaveButton.TabIndex = 32;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(12, 109);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(150, 25);
            this.ItemComboBox.TabIndex = 31;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cpu_Button);
            this.panel2.Controls.Add(this.Gpu_Button);
            this.panel2.Controls.Add(this.Hdd_Button);
            this.panel2.Controls.Add(this.Mobo_Button);
            this.panel2.Controls.Add(this.Psu_Button);
            this.panel2.Controls.Add(this.Ram_Button);
            this.panel2.Controls.Add(this.Ssd_Button);
            this.panel2.Location = new System.Drawing.Point(775, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 10);
            this.panel2.TabIndex = 32;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Products";
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(0, 1);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(0);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(84, 31);
            this.SalesButton.TabIndex = 34;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(-3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 2);
            this.label2.TabIndex = 35;
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(84, 1);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(87, 31);
            this.CustomersButton.TabIndex = 36;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // SalesPanel
            // 
            this.SalesPanel.Controls.Add(this.NewProduct);
            this.SalesPanel.Controls.Add(this.CorrectionButton);
            this.SalesPanel.Controls.Add(this.ModelLabel);
            this.SalesPanel.Controls.Add(this.ModelBox);
            this.SalesPanel.Controls.Add(this.PriceLabel);
            this.SalesPanel.Controls.Add(this.PriceBox);
            this.SalesPanel.Controls.Add(this.StatusLabel);
            this.SalesPanel.Controls.Add(this.ProductRemove);
            this.SalesPanel.Controls.Add(this.StatusBox);
            this.SalesPanel.Controls.Add(this.panel1);
            this.SalesPanel.Location = new System.Drawing.Point(0, 300);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.Size = new System.Drawing.Size(663, 144);
            this.SalesPanel.TabIndex = 37;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesPanel);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ListItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ListItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.SalesPanel.ResumeLayout(false);
            this.SalesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ssd_Button;
        private System.Windows.Forms.Button Ram_Button;
        private System.Windows.Forms.Button Psu_Button;
        private System.Windows.Forms.Button Mobo_Button;
        private System.Windows.Forms.Button Hdd_Button;
        private System.Windows.Forms.Button Gpu_Button;
        private System.Windows.Forms.Button Cpu_Button;
        private System.Windows.Forms.DataGridView ListItems;
        private System.Windows.Forms.Button NewProduct;
        private System.Windows.Forms.Button CorrectionButton;
        private System.Windows.Forms.Button ProductRemove;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Panel SalesPanel;
    }
}