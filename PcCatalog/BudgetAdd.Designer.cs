
namespace PcCatalog
{
    partial class BudgetAdd
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
            this.EnterBudgetLabel = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BudgetBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterBudgetLabel
            // 
            this.EnterBudgetLabel.AutoSize = true;
            this.EnterBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterBudgetLabel.Location = new System.Drawing.Point(350, 180);
            this.EnterBudgetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterBudgetLabel.Name = "EnterBudgetLabel";
            this.EnterBudgetLabel.Size = new System.Drawing.Size(191, 37);
            this.EnterBudgetLabel.TabIndex = 0;
            this.EnterBudgetLabel.Text = "Enter Budget:";
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enter.Location = new System.Drawing.Point(381, 294);
            this.Enter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(121, 36);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(526, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "BGN";
            // 
            // BudgetBox
            // 
            this.BudgetBox.Location = new System.Drawing.Point(367, 251);
            this.BudgetBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BudgetBox.Multiline = true;
            this.BudgetBox.Name = "BudgetBox";
            this.BudgetBox.Size = new System.Drawing.Size(151, 33);
            this.BudgetBox.TabIndex = 4;
            
            this.BudgetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BudgetBox_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(784, 549);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(129, 35);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BudgetAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 596);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BudgetBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.EnterBudgetLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BudgetAdd";
            this.Text = "BudgetAdd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BudgetAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterBudgetLabel;
        private new System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BudgetBox;
        private System.Windows.Forms.Button BackButton;
    }
}