namespace övning7._2
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
            this.tbxÅlder = new System.Windows.Forms.TextBox();
            this.lblÅlder = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxÅlder
            // 
            this.tbxÅlder.Location = new System.Drawing.Point(523, 90);
            this.tbxÅlder.Name = "tbxÅlder";
            this.tbxÅlder.Size = new System.Drawing.Size(123, 22);
            this.tbxÅlder.TabIndex = 0;
            this.tbxÅlder.Text = "30";
            // 
            // lblÅlder
            // 
            this.lblÅlder.AutoSize = true;
            this.lblÅlder.Location = new System.Drawing.Point(426, 96);
            this.lblÅlder.Name = "lblÅlder";
            this.lblÅlder.Size = new System.Drawing.Size(39, 16);
            this.lblÅlder.TabIndex = 1;
            this.lblÅlder.Text = "Ålder";
            // 
            // lblSvar
            // 
            this.lblSvar.Location = new System.Drawing.Point(429, 172);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(217, 22);
            this.lblSvar.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(457, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 37);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblÅlder);
            this.Controls.Add(this.tbxÅlder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxÅlder;
        private System.Windows.Forms.Label lblÅlder;
        private System.Windows.Forms.TextBox lblSvar;
        private System.Windows.Forms.Button btnOK;
    }
}

