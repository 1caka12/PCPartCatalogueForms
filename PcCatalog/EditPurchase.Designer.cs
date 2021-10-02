
namespace PcCatalog
{
    partial class EditPurchase
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
            this.EditGrid = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EditGrid
            // 
            this.EditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditGrid.Location = new System.Drawing.Point(242, 78);
            this.EditGrid.Name = "EditGrid";
            this.EditGrid.RowTemplate.Height = 25;
            this.EditGrid.Size = new System.Drawing.Size(324, 214);
            this.EditGrid.TabIndex = 0;
            this.EditGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGrid_CellClick);
            this.EditGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGrid_CellContentClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(377, 374);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditGrid);
            this.Name = "EditPurchase";
            this.Text = "EditPurchase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditPurchase_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EditGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditGrid;
        private System.Windows.Forms.Button CloseButton;
    }
}