namespace Övning7._1
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
            this.lblLiterbensin = new System.Windows.Forms.Label();
            this.tbxBensin = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(373, 283);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(144, 44);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Ok";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLiterbensin
            // 
            this.lblLiterbensin.AutoSize = true;
            this.lblLiterbensin.Location = new System.Drawing.Point(297, 134);
            this.lblLiterbensin.Name = "lblLiterbensin";
            this.lblLiterbensin.Size = new System.Drawing.Size(75, 16);
            this.lblLiterbensin.TabIndex = 1;
            this.lblLiterbensin.Text = "Liter bensin";
            // 
            // tbxBensin
            // 
            this.tbxBensin.Location = new System.Drawing.Point(475, 128);
            this.tbxBensin.Name = "tbxBensin";
            this.tbxBensin.Size = new System.Drawing.Size(125, 22);
            this.tbxBensin.TabIndex = 2;
            // 
            // lblSvar
            // 
            this.lblSvar.Location = new System.Drawing.Point(300, 214);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.ReadOnly = true;
            this.lblSvar.Size = new System.Drawing.Size(300, 22);
            this.lblSvar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxBensin);
            this.Controls.Add(this.lblLiterbensin);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblLiterbensin;
        private System.Windows.Forms.TextBox tbxBensin;
        private System.Windows.Forms.TextBox lblSvar;
    }
}

