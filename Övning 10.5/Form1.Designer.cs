namespace Övning_10._5
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.Tal1 = new System.Windows.Forms.TextBox();
            this.Tal4 = new System.Windows.Forms.TextBox();
            this.Tal3 = new System.Windows.Forms.TextBox();
            this.Tal2 = new System.Windows.Forms.TextBox();
            this.btnByt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(329, 66);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(61, 13);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Innan Byte:";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(329, 117);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(55, 13);
            this.lblTal2.TabIndex = 1;
            this.lblTal2.Text = "Efter byte:";
            // 
            // Tal1
            // 
            this.Tal1.Location = new System.Drawing.Point(400, 63);
            this.Tal1.Name = "Tal1";
            this.Tal1.Size = new System.Drawing.Size(50, 20);
            this.Tal1.TabIndex = 2;
            // 
            // Tal4
            // 
            this.Tal4.Location = new System.Drawing.Point(484, 114);
            this.Tal4.Name = "Tal4";
            this.Tal4.Size = new System.Drawing.Size(51, 20);
            this.Tal4.TabIndex = 3;
            // 
            // Tal3
            // 
            this.Tal3.Location = new System.Drawing.Point(400, 114);
            this.Tal3.Name = "Tal3";
            this.Tal3.Size = new System.Drawing.Size(50, 20);
            this.Tal3.TabIndex = 4;
            // 
            // Tal2
            // 
            this.Tal2.Location = new System.Drawing.Point(484, 63);
            this.Tal2.Name = "Tal2";
            this.Tal2.Size = new System.Drawing.Size(51, 20);
            this.Tal2.TabIndex = 5;
            // 
            // btnByt
            // 
            this.btnByt.Location = new System.Drawing.Point(413, 167);
            this.btnByt.Name = "btnByt";
            this.btnByt.Size = new System.Drawing.Size(75, 23);
            this.btnByt.TabIndex = 6;
            this.btnByt.Text = "Byt plats";
            this.btnByt.UseVisualStyleBackColor = true;
            this.btnByt.Click += new System.EventHandler(this.btnByt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnByt);
            this.Controls.Add(this.Tal2);
            this.Controls.Add(this.Tal3);
            this.Controls.Add(this.Tal4);
            this.Controls.Add(this.Tal1);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.TextBox Tal1;
        private System.Windows.Forms.TextBox Tal4;
        private System.Windows.Forms.TextBox Tal3;
        private System.Windows.Forms.TextBox Tal2;
        private System.Windows.Forms.Button btnByt;
    }
}

