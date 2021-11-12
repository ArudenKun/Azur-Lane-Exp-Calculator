
namespace Azur_Lane_Exp_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCurrentLevel = new System.Windows.Forms.ComboBox();
            this.cmbTargetLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbRarity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpNeeded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCurrentLevel
            // 
            this.cmbCurrentLevel.FormattingEnabled = true;
            this.cmbCurrentLevel.Location = new System.Drawing.Point(65, 35);
            this.cmbCurrentLevel.Name = "cmbCurrentLevel";
            this.cmbCurrentLevel.Size = new System.Drawing.Size(121, 23);
            this.cmbCurrentLevel.TabIndex = 0;
            // 
            // cmbTargetLevel
            // 
            this.cmbTargetLevel.FormattingEnabled = true;
            this.cmbTargetLevel.Location = new System.Drawing.Point(65, 94);
            this.cmbTargetLevel.Name = "cmbTargetLevel";
            this.cmbTargetLevel.Size = new System.Drawing.Size(121, 23);
            this.cmbTargetLevel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Level";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(87, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbRarity
            // 
            this.cmbRarity.FormattingEnabled = true;
            this.cmbRarity.Location = new System.Drawing.Point(65, 156);
            this.cmbRarity.Name = "cmbRarity";
            this.cmbRarity.Size = new System.Drawing.Size(121, 23);
            this.cmbRarity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ship Rarity";
            // 
            // lblExpNeeded
            // 
            this.lblExpNeeded.AutoSize = true;
            this.lblExpNeeded.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpNeeded.Location = new System.Drawing.Point(147, 194);
            this.lblExpNeeded.Name = "lblExpNeeded";
            this.lblExpNeeded.Size = new System.Drawing.Size(34, 21);
            this.lblExpNeeded.TabIndex = 7;
            this.lblExpNeeded.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exp Needed: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExpNeeded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRarity);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTargetLevel);
            this.Controls.Add(this.cmbCurrentLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exp Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurrentLevel;
        private System.Windows.Forms.ComboBox cmbTargetLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cmbRarity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpNeeded;
        private System.Windows.Forms.Label label4;
    }
}

