namespace Uppgift5._3
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
            this.btnKör = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblTal = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.MaskedTextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(551, 293);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(565, 222);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(44, 16);
            this.lblSvar.TabIndex = 1;
            this.lblSvar.Text = "label1";
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Location = new System.Drawing.Point(490, 96);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(27, 16);
            this.lblTal.TabIndex = 2;
            this.lblTal.Text = "Tal";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(589, 93);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 22);
            this.tbxTal1.TabIndex = 3;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(589, 143);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 22);
            this.tbxTal2.TabIndex = 4;
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(489, 143);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(30, 16);
            this.lblTal2.TabIndex = 5;
            this.lblTal2.Text = "Tal ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.lblTal);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.MaskedTextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.Label lblTal2;
    }
}

