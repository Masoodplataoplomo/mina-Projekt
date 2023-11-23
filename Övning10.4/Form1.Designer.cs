namespace Övning10._4
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
            this.lblHöjd = new System.Windows.Forms.Label();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHöjd
            // 
            this.lblHöjd.AutoSize = true;
            this.lblHöjd.Location = new System.Drawing.Point(320, 41);
            this.lblHöjd.Name = "lblHöjd";
            this.lblHöjd.Size = new System.Drawing.Size(32, 13);
            this.lblHöjd.TabIndex = 0;
            this.lblHöjd.Text = "Höjd:";
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(407, 34);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 1;
            this.tbxHöjd.TextChanged += new System.EventHandler(this.tbxHöjd_TextChanged);
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(545, 34);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Rita Triangel";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.lblHöjd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHöjd;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Button btnKör;
    }
}

