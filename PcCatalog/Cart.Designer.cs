
namespace PcCatalog
{
    partial class Cart
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
            this.label1 = new System.Windows.Forms.Label();
            this.CartPriceLabel = new System.Windows.Forms.Label();
            this.Bought_Products = new System.Windows.Forms.DataGridView();
            this.Back1_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PersonalInfoPanel = new System.Windows.Forms.Panel();
            this.LeaveShopPanel = new System.Windows.Forms.Panel();
            this.ShopButton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bought_Products)).BeginInit();
            this.PersonalInfoPanel.SuspendLayout();
            this.LeaveShopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // CartPriceLabel
            // 
            this.CartPriceLabel.AutoSize = true;
            this.CartPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartPriceLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CartPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CartPriceLabel.Location = new System.Drawing.Point(133, 349);
            this.CartPriceLabel.Name = "CartPriceLabel";
            this.CartPriceLabel.Size = new System.Drawing.Size(2, 27);
            this.CartPriceLabel.TabIndex = 1;
            // 
            // Bought_Products
            // 
            this.Bought_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bought_Products.Location = new System.Drawing.Point(29, 64);
            this.Bought_Products.Name = "Bought_Products";
            this.Bought_Products.RowTemplate.Height = 25;
            this.Bought_Products.Size = new System.Drawing.Size(368, 205);
            this.Bought_Products.TabIndex = 2;
            this.Bought_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bought_Products_CellClick);
            // 
            // Back1_Button
            // 
            this.Back1_Button.Location = new System.Drawing.Point(12, 406);
            this.Back1_Button.Name = "Back1_Button";
            this.Back1_Button.Size = new System.Drawing.Size(91, 32);
            this.Back1_Button.TabIndex = 4;
            this.Back1_Button.Text = "Back";
            this.Back1_Button.UseVisualStyleBackColor = true;
            this.Back1_Button.Click += new System.EventHandler(this.Back1_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "BGN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personal Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone Number:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(165, 58);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(131, 23);
            this.FirstNameBox.TabIndex = 10;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(165, 102);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(131, 23);
            this.LastNameBox.TabIndex = 11;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(165, 147);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(131, 23);
            this.PhoneNumberBox.TabIndex = 12;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Location = new System.Drawing.Point(135, 209);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(105, 35);
            this.PurchaseButton.TabIndex = 13;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(82, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Purchase successful!";
            // 
            // PersonalInfoPanel
            // 
            this.PersonalInfoPanel.Controls.Add(this.label3);
            this.PersonalInfoPanel.Controls.Add(this.label4);
            this.PersonalInfoPanel.Controls.Add(this.PurchaseButton);
            this.PersonalInfoPanel.Controls.Add(this.FirstNameBox);
            this.PersonalInfoPanel.Controls.Add(this.PhoneNumberBox);
            this.PersonalInfoPanel.Controls.Add(this.label5);
            this.PersonalInfoPanel.Controls.Add(this.label6);
            this.PersonalInfoPanel.Controls.Add(this.LastNameBox);
            this.PersonalInfoPanel.Location = new System.Drawing.Point(434, 47);
            this.PersonalInfoPanel.Name = "PersonalInfoPanel";
            this.PersonalInfoPanel.Size = new System.Drawing.Size(354, 271);
            this.PersonalInfoPanel.TabIndex = 15;
            // 
            // LeaveShopPanel
            // 
            this.LeaveShopPanel.Controls.Add(this.ShopButton);
            this.LeaveShopPanel.Controls.Add(this.LeaveButton);
            this.LeaveShopPanel.Controls.Add(this.label8);
            this.LeaveShopPanel.Controls.Add(this.label7);
            this.LeaveShopPanel.Location = new System.Drawing.Point(370, 371);
            this.LeaveShopPanel.Name = "LeaveShopPanel";
            this.LeaveShopPanel.Size = new System.Drawing.Size(226, 96);
            this.LeaveShopPanel.TabIndex = 16;
            // 
            // ShopButton
            // 
            this.ShopButton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ShopButton.Location = new System.Drawing.Point(219, 140);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(75, 23);
            this.ShopButton.TabIndex = 17;
            this.ShopButton.Text = "Shop";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(82, 140);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(75, 24);
            this.LeaveButton.TabIndex = 16;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Would you like to go back to the shop or leave?";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeaveShopPanel);
            this.Controls.Add(this.PersonalInfoPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back1_Button);
            this.Controls.Add(this.Bought_Products);
            this.Controls.Add(this.CartPriceLabel);
            this.Controls.Add(this.label1);
            this.Name = "Cart";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.Bought_Products)).EndInit();
            this.PersonalInfoPanel.ResumeLayout(false);
            this.PersonalInfoPanel.PerformLayout();
            this.LeaveShopPanel.ResumeLayout(false);
            this.LeaveShopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CartPriceLabel;
        private System.Windows.Forms.DataGridView Bought_Products;
        private System.Windows.Forms.Button Back1_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PersonalInfoPanel;
        private System.Windows.Forms.Panel LeaveShopPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button LeaveButton;
    }
}