﻿namespace övning_3._3
{
    partial class Form1
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblMedel = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(335, 47);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(42, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Tal A ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(335, 89);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(39, 16);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Tal B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(335, 135);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(42, 16);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Tal C ";
            // 
            // lblMedel
            // 
            this.lblMedel.AutoSize = true;
            this.lblMedel.Location = new System.Drawing.Point(435, 217);
            this.lblMedel.Name = "lblMedel";
            this.lblMedel.Size = new System.Drawing.Size(44, 16);
            this.lblMedel.TabIndex = 3;
            this.lblMedel.Text = "label4";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(435, 180);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(44, 16);
            this.lblSumma.TabIndex = 4;
            this.lblSumma.Text = "label5";
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(458, 40);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 22);
            this.tbxA.TabIndex = 5;
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(458, 86);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 22);
            this.tbxB.TabIndex = 6;
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(458, 135);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 22);
            this.tbxC.TabIndex = 7;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(417, 262);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 8;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lblMedel);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblMedel;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.Button btnKör;
    }
}

