namespace Uppgift3._4
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
            this.lblUttag = new System.Windows.Forms.Label();
            this.lblbelopp = new System.Windows.Forms.Label();
            this.tbxBlopp = new System.Windows.Forms.TextBox();
            this.tbxUttag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(371, 149);
            this.btnKör.Margin = new System.Windows.Forms.Padding(2);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(56, 19);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Text";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblUttag
            // 
            this.lblUttag.AutoSize = true;
            this.lblUttag.Location = new System.Drawing.Point(323, 79);
            this.lblUttag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUttag.Name = "lblUttag";
            this.lblUttag.Size = new System.Drawing.Size(31, 13);
            this.lblUttag.TabIndex = 1;
            this.lblUttag.Text = "uttag";
            // 
            // lblbelopp
            // 
            this.lblbelopp.AutoSize = true;
            this.lblbelopp.Location = new System.Drawing.Point(323, 49);
            this.lblbelopp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbelopp.Name = "lblbelopp";
            this.lblbelopp.Size = new System.Drawing.Size(39, 13);
            this.lblbelopp.TabIndex = 2;
            this.lblbelopp.Text = "belopp";
            // 
            // tbxBlopp
            // 
            this.tbxBlopp.Location = new System.Drawing.Point(392, 49);
            this.tbxBlopp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBlopp.Name = "tbxBlopp";
            this.tbxBlopp.Size = new System.Drawing.Size(76, 20);
            this.tbxBlopp.TabIndex = 3;
            // 
            // tbxUttag
            // 
            this.tbxUttag.Location = new System.Drawing.Point(392, 79);
            this.tbxUttag.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUttag.Name = "tbxUttag";
            this.tbxUttag.Size = new System.Drawing.Size(76, 20);
            this.tbxUttag.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tbxUttag);
            this.Controls.Add(this.tbxBlopp);
            this.Controls.Add(this.lblbelopp);
            this.Controls.Add(this.lblUttag);
            this.Controls.Add(this.btnKör);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblUttag;
        private System.Windows.Forms.Label lblbelopp;
        private System.Windows.Forms.TextBox tbxBlopp;
        private System.Windows.Forms.TextBox tbxUttag;
    }
}

