namespace Övning5._3
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
            this.lblPrngar = new System.Windows.Forms.Label();
            this.lblPris = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxPengar = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblPrngar
            // 
            this.lblPrngar.AutoSize = true;
            this.lblPrngar.Location = new System.Drawing.Point(375, 45);
            this.lblPrngar.Name = "lblPrngar";
            this.lblPrngar.Size = new System.Drawing.Size(82, 16);
            this.lblPrngar.TabIndex = 1;
            this.lblPrngar.Text = "Mina pengar";
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(375, 100);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(75, 16);
            this.lblPris.TabIndex = 2;
            this.lblPris.Text = "Varans pris";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(473, 164);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(44, 16);
            this.lblSvar.TabIndex = 3;
            this.lblSvar.Text = "label4";
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(513, 97);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 22);
            this.tbxPris.TabIndex = 4;
            // 
            // tbxPengar
            // 
            this.tbxPengar.Location = new System.Drawing.Point(513, 42);
            this.tbxPengar.Name = "tbxPengar";
            this.tbxPengar.Size = new System.Drawing.Size(100, 22);
            this.tbxPengar.TabIndex = 5;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(460, 214);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 6;
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
            this.Controls.Add(this.tbxPengar);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblPris);
            this.Controls.Add(this.lblPrngar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrngar;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxPengar;
        private System.Windows.Forms.Button btnKör;
    }
}

