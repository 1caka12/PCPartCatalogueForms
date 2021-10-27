
namespace PcCatalog
{
    partial class NewMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.productStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.processorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsCardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardDrivesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherboardsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerSuppliesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSalesDataGrid = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shopCostPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.toCartButton = new System.Windows.Forms.Button();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.AdminProductsPanel = new System.Windows.Forms.Panel();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.AdminDataBaseEditorPanel = new System.Windows.Forms.Panel();
            this.SaveCancelPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.CorrectionButton = new System.Windows.Forms.Button();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesDataGrid)).BeginInit();
            this.shopCostPanel.SuspendLayout();
            this.AdminProductsPanel.SuspendLayout();
            this.AdminDataBaseEditorPanel.SuspendLayout();
            this.SaveCancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productStrip,
            this.adminMenu,
            this.reportMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // productStrip
            // 
            this.productStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processorsMenuItem,
            this.graphicsCardsMenuItem,
            this.hardDrivesMenuItem,
            this.motherboardsMenuItem,
            this.powerSuppliesMenuItem,
            this.ramMenuItem,
            this.ssdMenuItem});
            this.productStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productStrip.Name = "productStrip";
            this.productStrip.Size = new System.Drawing.Size(58, 25);
            this.productStrip.Text = "Shop";
            this.productStrip.Click += new System.EventHandler(this.productStrip_Click);
            // 
            // processorsMenuItem
            // 
            this.processorsMenuItem.Name = "processorsMenuItem";
            this.processorsMenuItem.Size = new System.Drawing.Size(186, 26);
            this.processorsMenuItem.Text = "Processors";
            this.processorsMenuItem.Click += new System.EventHandler(this.processorMenuItem_Click);
            // 
            // graphicsCardsMenuItem
            // 
            this.graphicsCardsMenuItem.Name = "graphicsCardsMenuItem";
            this.graphicsCardsMenuItem.Size = new System.Drawing.Size(186, 26);
            this.graphicsCardsMenuItem.Text = "Graphics Cards";
            this.graphicsCardsMenuItem.Click += new System.EventHandler(this.graphicsCardsMenuItem_Click);
            // 
            // hardDrivesMenuItem
            // 
            this.hardDrivesMenuItem.Name = "hardDrivesMenuItem";
            this.hardDrivesMenuItem.Size = new System.Drawing.Size(186, 26);
            this.hardDrivesMenuItem.Text = "Hard Drives";
            this.hardDrivesMenuItem.Click += new System.EventHandler(this.hardDrivesMenuItem_Click);
            // 
            // motherboardsMenuItem
            // 
            this.motherboardsMenuItem.Name = "motherboardsMenuItem";
            this.motherboardsMenuItem.Size = new System.Drawing.Size(186, 26);
            this.motherboardsMenuItem.Text = "Motherboards";
            this.motherboardsMenuItem.Click += new System.EventHandler(this.motherboardsMenuItem_Click);
            // 
            // powerSuppliesMenuItem
            // 
            this.powerSuppliesMenuItem.Name = "powerSuppliesMenuItem";
            this.powerSuppliesMenuItem.Size = new System.Drawing.Size(186, 26);
            this.powerSuppliesMenuItem.Text = "Power Supplies";
            this.powerSuppliesMenuItem.Click += new System.EventHandler(this.powerSuppliesMenuItem_Click);
            // 
            // ramMenuItem
            // 
            this.ramMenuItem.Name = "ramMenuItem";
            this.ramMenuItem.Size = new System.Drawing.Size(186, 26);
            this.ramMenuItem.Text = "Ram";
            this.ramMenuItem.Click += new System.EventHandler(this.ramMenuItem_Click);
            // 
            // ssdMenuItem
            // 
            this.ssdMenuItem.Name = "ssdMenuItem";
            this.ssdMenuItem.Size = new System.Drawing.Size(186, 26);
            this.ssdMenuItem.Text = "Ssd";
            this.ssdMenuItem.Click += new System.EventHandler(this.ssdMenuItem_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(68, 25);
            this.adminMenu.Text = "Admin";
            this.adminMenu.Click += new System.EventHandler(this.adminMenu_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.reportMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(69, 25);
            this.reportMenu.Text = "Report";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Visible = false;
            // 
            // productSalesDataGrid
            // 
            this.productSalesDataGrid.AllowUserToAddRows = false;
            this.productSalesDataGrid.AllowUserToDeleteRows = false;
            this.productSalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSalesDataGrid.Location = new System.Drawing.Point(218, 88);
            this.productSalesDataGrid.Name = "productSalesDataGrid";
            this.productSalesDataGrid.RowTemplate.Height = 25;
            this.productSalesDataGrid.Size = new System.Drawing.Size(335, 234);
            this.productSalesDataGrid.TabIndex = 2;
            this.productSalesDataGrid.Visible = false;
            this.productSalesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productSalesDataGrid_CellClick);
            this.productSalesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productSalesDataGrid_CellContentClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(12, 411);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 27);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit Store";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cost:";
            // 
            // shopCostPanel
            // 
            this.shopCostPanel.Controls.Add(this.label2);
            this.shopCostPanel.Controls.Add(this.costLabel);
            this.shopCostPanel.Controls.Add(this.label1);
            this.shopCostPanel.Location = new System.Drawing.Point(247, 328);
            this.shopCostPanel.Name = "shopCostPanel";
            this.shopCostPanel.Size = new System.Drawing.Size(278, 47);
            this.shopCostPanel.TabIndex = 5;
            this.shopCostPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "BGN";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(43, 17);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 15);
            this.costLabel.TabIndex = 5;
            // 
            // toCartButton
            // 
            this.toCartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toCartButton.Location = new System.Drawing.Point(698, 402);
            this.toCartButton.Name = "toCartButton";
            this.toCartButton.Size = new System.Drawing.Size(81, 32);
            this.toCartButton.TabIndex = 6;
            this.toCartButton.Text = "Go to cart";
            this.toCartButton.UseVisualStyleBackColor = true;
            this.toCartButton.Visible = false;
            this.toCartButton.Click += new System.EventHandler(this.toCartButton_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(42, 16);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(54, 15);
            this.ProductLabel.TabIndex = 7;
            this.ProductLabel.Text = "Products";
            // 
            // AdminProductsPanel
            // 
            this.AdminProductsPanel.Controls.Add(this.ItemComboBox);
            this.AdminProductsPanel.Controls.Add(this.ProductLabel);
            this.AdminProductsPanel.Location = new System.Drawing.Point(12, 106);
            this.AdminProductsPanel.Name = "AdminProductsPanel";
            this.AdminProductsPanel.Size = new System.Drawing.Size(200, 120);
            this.AdminProductsPanel.TabIndex = 9;
            this.AdminProductsPanel.Visible = false;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(10, 51);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(150, 25);
            this.ItemComboBox.TabIndex = 32;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // AdminDataBaseEditorPanel
            // 
            this.AdminDataBaseEditorPanel.Controls.Add(this.SaveCancelPanel);
            this.AdminDataBaseEditorPanel.Controls.Add(this.ReturnButton);
            this.AdminDataBaseEditorPanel.Controls.Add(this.StatusBox);
            this.AdminDataBaseEditorPanel.Controls.Add(this.PriceBox);
            this.AdminDataBaseEditorPanel.Controls.Add(this.ModelBox);
            this.AdminDataBaseEditorPanel.Controls.Add(this.label5);
            this.AdminDataBaseEditorPanel.Controls.Add(this.label4);
            this.AdminDataBaseEditorPanel.Controls.Add(this.label3);
            this.AdminDataBaseEditorPanel.Controls.Add(this.RemoveProductButton);
            this.AdminDataBaseEditorPanel.Controls.Add(this.CorrectionButton);
            this.AdminDataBaseEditorPanel.Controls.Add(this.NewProductButton);
            this.AdminDataBaseEditorPanel.Location = new System.Drawing.Point(0, 328);
            this.AdminDataBaseEditorPanel.Name = "AdminDataBaseEditorPanel";
            this.AdminDataBaseEditorPanel.Size = new System.Drawing.Size(800, 117);
            this.AdminDataBaseEditorPanel.TabIndex = 10;
            this.AdminDataBaseEditorPanel.Visible = false;
            // 
            // SaveCancelPanel
            // 
            this.SaveCancelPanel.Controls.Add(this.SaveButton);
            this.SaveCancelPanel.Controls.Add(this.CancelButton);
            this.SaveCancelPanel.Location = new System.Drawing.Point(307, 53);
            this.SaveCancelPanel.Name = "SaveCancelPanel";
            this.SaveCancelPanel.Size = new System.Drawing.Size(143, 61);
            this.SaveCancelPanel.TabIndex = 12;
            this.SaveCancelPanel.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(37, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(37, 28);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(676, 74);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(109, 23);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.Text = "Return To Main";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(539, 17);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(100, 23);
            this.StatusBox.TabIndex = 8;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(351, 17);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(100, 23);
            this.PriceBox.TabIndex = 7;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(190, 18);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.ReadOnly = true;
            this.ModelBox.Size = new System.Drawing.Size(100, 23);
            this.ModelBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status(1 or 0)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Location = new System.Drawing.Point(22, 74);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(121, 23);
            this.RemoveProductButton.TabIndex = 2;
            this.RemoveProductButton.Text = "Remove Product";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // CorrectionButton
            // 
            this.CorrectionButton.Location = new System.Drawing.Point(22, 46);
            this.CorrectionButton.Name = "CorrectionButton";
            this.CorrectionButton.Size = new System.Drawing.Size(121, 23);
            this.CorrectionButton.TabIndex = 1;
            this.CorrectionButton.Text = "Correction";
            this.CorrectionButton.UseVisualStyleBackColor = true;
            this.CorrectionButton.Click += new System.EventHandler(this.CorrectionButton_Click);
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(22, 17);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(118, 23);
            this.NewProductButton.TabIndex = 0;
            this.NewProductButton.Text = "New";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminDataBaseEditorPanel);
            this.Controls.Add(this.AdminProductsPanel);
            this.Controls.Add(this.toCartButton);
            this.Controls.Add(this.shopCostPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productSalesDataGrid);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "NewMain";
            this.Text = "NewMain";
            this.Load += new System.EventHandler(this.NewMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesDataGrid)).EndInit();
            this.shopCostPanel.ResumeLayout(false);
            this.shopCostPanel.PerformLayout();
            this.AdminProductsPanel.ResumeLayout(false);
            this.AdminProductsPanel.PerformLayout();
            this.AdminDataBaseEditorPanel.ResumeLayout(false);
            this.AdminDataBaseEditorPanel.PerformLayout();
            this.SaveCancelPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem productStrip;
        private System.Windows.Forms.ToolStripMenuItem processorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsCardsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardDrivesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherboardsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerSuppliesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenu;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.DataGridView productSalesDataGrid;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel shopCostPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button toCartButton;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Panel AdminProductsPanel;
        private System.Windows.Forms.Panel AdminDataBaseEditorPanel;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.Button CorrectionButton;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel SaveCancelPanel;
    }
}