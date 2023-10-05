namespace Uppgift_7._2
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
            this.lbllängd = new System.Windows.Forms.Label();
            this.tbxslag = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllängd
            // 
            this.lbllängd.AutoSize = true;
            this.lbllängd.Location = new System.Drawing.Point(284, 106);
            this.lbllängd.Name = "lbllängd";
            this.lbllängd.Size = new System.Drawing.Size(83, 16);
            this.lbllängd.TabIndex = 0;
            this.lbllängd.Text = "Slaget längd";
            // 
            // tbxslag
            // 
            this.tbxslag.Location = new System.Drawing.Point(408, 100);
            this.tbxslag.Name = "tbxslag";
            this.tbxslag.Size = new System.Drawing.Size(100, 22);
            this.tbxslag.TabIndex = 1;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(287, 175);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(221, 22);
            this.tbxSvar.TabIndex = 2;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(343, 222);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(113, 31);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "OK ";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxslag);
            this.Controls.Add(this.lbllängd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllängd;
        private System.Windows.Forms.TextBox tbxslag;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.Button btnKör;
    }
}

