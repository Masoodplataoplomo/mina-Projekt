namespace Övning7._5
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
            this.tbxnr = new System.Windows.Forms.TextBox();
            this.lblveckodag = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(353, 266);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(150, 55);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Visa Veckodag";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxnr
            // 
            this.tbxnr.Location = new System.Drawing.Point(441, 100);
            this.tbxnr.Name = "tbxnr";
            this.tbxnr.Size = new System.Drawing.Size(128, 22);
            this.tbxnr.TabIndex = 1;
            // 
            // lblveckodag
            // 
            this.lblveckodag.AutoSize = true;
            this.lblveckodag.Location = new System.Drawing.Point(284, 103);
            this.lblveckodag.Name = "lblveckodag";
            this.lblveckodag.Size = new System.Drawing.Size(106, 16);
            this.lblveckodag.TabIndex = 2;
            this.lblveckodag.Text = "Veckodagens nr";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(409, 209);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(44, 16);
            this.lblSvar.TabIndex = 3;
            this.lblSvar.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblveckodag);
            this.Controls.Add(this.tbxnr);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxnr;
        private System.Windows.Forms.Label lblveckodag;
        private System.Windows.Forms.Label lblSvar;
    }
}

