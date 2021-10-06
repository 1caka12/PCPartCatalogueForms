
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
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSalesDataGrid)).BeginInit();
            this.shopCostPanel.SuspendLayout();
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
            // 
            // productSalesDataGrid
            // 
            this.productSalesDataGrid.AllowUserToAddRows = false;
            this.productSalesDataGrid.AllowUserToDeleteRows = false;
            this.productSalesDataGrid.AllowUserToOrderColumns = true;
            this.productSalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSalesDataGrid.Location = new System.Drawing.Point(218, 106);
            this.productSalesDataGrid.Name = "productSalesDataGrid";
            this.productSalesDataGrid.RowTemplate.Height = 25;
            this.productSalesDataGrid.Size = new System.Drawing.Size(320, 216);
            this.productSalesDataGrid.TabIndex = 2;
            this.productSalesDataGrid.Visible = false;
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
            this.shopCostPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.shopCostPanel_Paint);
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
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}