﻿namespace Uppgift11._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxövning = new System.Windows.Forms.TextBox();
            this.tbxset = new System.Windows.Forms.TextBox();
            this.tbxrep = new System.Windows.Forms.TextBox();
            this.tbxvikt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxträningsprogram = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Övning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vikt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lägg in övning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "träningsprogram";
            // 
            // tbxövning
            // 
            this.tbxövning.Location = new System.Drawing.Point(280, 137);
            this.tbxövning.Name = "tbxövning";
            this.tbxövning.Size = new System.Drawing.Size(132, 20);
            this.tbxövning.TabIndex = 6;
            // 
            // tbxset
            // 
            this.tbxset.Location = new System.Drawing.Point(280, 163);
            this.tbxset.Name = "tbxset";
            this.tbxset.Size = new System.Drawing.Size(38, 20);
            this.tbxset.TabIndex = 7;
            // 
            // tbxrep
            // 
            this.tbxrep.Location = new System.Drawing.Point(324, 163);
            this.tbxrep.Name = "tbxrep";
            this.tbxrep.Size = new System.Drawing.Size(41, 20);
            this.tbxrep.TabIndex = 8;
            // 
            // tbxvikt
            // 
            this.tbxvikt.Location = new System.Drawing.Point(371, 163);
            this.tbxvikt.Name = "tbxvikt";
            this.tbxvikt.Size = new System.Drawing.Size(41, 20);
            this.tbxvikt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxträningsprogram
            // 
            this.lbxträningsprogram.FormattingEnabled = true;
            this.lbxträningsprogram.Location = new System.Drawing.Point(438, 137);
            this.lbxträningsprogram.Name = "lbxträningsprogram";
            this.lbxträningsprogram.Size = new System.Drawing.Size(129, 108);
            this.lbxträningsprogram.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxträningsprogram);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxvikt);
            this.Controls.Add(this.tbxrep);
            this.Controls.Add(this.tbxset);
            this.Controls.Add(this.tbxövning);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxövning;
        private System.Windows.Forms.TextBox tbxset;
        private System.Windows.Forms.TextBox tbxrep;
        private System.Windows.Forms.TextBox tbxvikt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxträningsprogram;
    }
}

