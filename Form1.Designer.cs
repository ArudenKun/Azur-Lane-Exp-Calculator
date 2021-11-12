
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbCurrentLevel = new System.Windows.Forms.ComboBox();
            this.cmbTargetLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblExpNeeded = new System.Windows.Forms.Label();
            this.chkboxUR = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCurrentLevel
            // 
            this.cmbCurrentLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentLevel.FormattingEnabled = true;
            this.cmbCurrentLevel.Location = new System.Drawing.Point(128, 24);
            this.cmbCurrentLevel.Name = "cmbCurrentLevel";
            this.cmbCurrentLevel.Size = new System.Drawing.Size(121, 23);
            this.cmbCurrentLevel.TabIndex = 0;
            // 
            // cmbTargetLevel
            // 
            this.cmbTargetLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLevel.FormattingEnabled = true;
            this.cmbTargetLevel.Location = new System.Drawing.Point(128, 53);
            this.cmbTargetLevel.Name = "cmbTargetLevel";
            this.cmbTargetLevel.Size = new System.Drawing.Size(121, 23);
            this.cmbTargetLevel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Level";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblExpNeeded
            // 
            this.lblExpNeeded.AutoSize = true;
            this.lblExpNeeded.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpNeeded.Location = new System.Drawing.Point(12, 148);
            this.lblExpNeeded.Name = "lblExpNeeded";
            this.lblExpNeeded.Size = new System.Drawing.Size(70, 21);
            this.lblExpNeeded.TabIndex = 7;
            this.lblExpNeeded.Text = "----------";
            this.lblExpNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxUR
            // 
            this.chkboxUR.AutoSize = true;
            this.chkboxUR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkboxUR.Location = new System.Drawing.Point(12, 87);
            this.chkboxUR.Name = "chkboxUR";
            this.chkboxUR.Size = new System.Drawing.Size(119, 19);
            this.chkboxUR.TabIndex = 9;
            this.chkboxUR.Text = "Check If UR Ship";
            this.chkboxUR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exp Needed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkboxUR);
            this.Controls.Add(this.lblExpNeeded);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTargetLevel);
            this.Controls.Add(this.cmbCurrentLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblExpNeeded;
        private System.Windows.Forms.CheckBox chkboxUR;
        private System.Windows.Forms.Label label3;
    }
}

