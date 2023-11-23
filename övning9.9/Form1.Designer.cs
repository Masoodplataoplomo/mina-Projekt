namespace övning9._9
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
            this.lblSträng = new System.Windows.Forms.Label();
            this.tbxtecken1 = new System.Windows.Forms.TextBox();
            this.tbxtecken2 = new System.Windows.Forms.TextBox();
            this.tbxtecken3 = new System.Windows.Forms.TextBox();
            this.btnFörskjut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSträng
            // 
            this.lblSträng.AutoSize = true;
            this.lblSträng.Location = new System.Drawing.Point(417, 65);
            this.lblSträng.Name = "lblSträng";
            this.lblSträng.Size = new System.Drawing.Size(38, 13);
            this.lblSträng.TabIndex = 0;
            this.lblSträng.Text = "Sträng";
            // 
            // tbxtecken1
            // 
            this.tbxtecken1.Location = new System.Drawing.Point(383, 81);
            this.tbxtecken1.Name = "tbxtecken1";
            this.tbxtecken1.Size = new System.Drawing.Size(100, 20);
            this.tbxtecken1.TabIndex = 1;
            // 
            // tbxtecken2
            // 
            this.tbxtecken2.Location = new System.Drawing.Point(383, 107);
            this.tbxtecken2.Name = "tbxtecken2";
            this.tbxtecken2.Size = new System.Drawing.Size(100, 20);
            this.tbxtecken2.TabIndex = 2;
            // 
            // tbxtecken3
            // 
            this.tbxtecken3.Location = new System.Drawing.Point(383, 133);
            this.tbxtecken3.Name = "tbxtecken3";
            this.tbxtecken3.Size = new System.Drawing.Size(100, 20);
            this.tbxtecken3.TabIndex = 3;
            // 
            // btnFörskjut
            // 
            this.btnFörskjut.Location = new System.Drawing.Point(395, 159);
            this.btnFörskjut.Name = "btnFörskjut";
            this.btnFörskjut.Size = new System.Drawing.Size(75, 23);
            this.btnFörskjut.TabIndex = 4;
            this.btnFörskjut.Text = "Förskjut";
            this.btnFörskjut.UseVisualStyleBackColor = true;
            this.btnFörskjut.Click += new System.EventHandler(this.btnFörskjut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFörskjut);
            this.Controls.Add(this.tbxtecken3);
            this.Controls.Add(this.tbxtecken2);
            this.Controls.Add(this.tbxtecken1);
            this.Controls.Add(this.lblSträng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSträng;
        private System.Windows.Forms.TextBox tbxtecken1;
        private System.Windows.Forms.TextBox tbxtecken2;
        private System.Windows.Forms.TextBox tbxtecken3;
        private System.Windows.Forms.Button btnFörskjut;
    }
}

