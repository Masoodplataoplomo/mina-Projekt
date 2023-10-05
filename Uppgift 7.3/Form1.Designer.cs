namespace Uppgift_7._3
{
    partial class btnOK
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
            this.lblvind = new System.Windows.Forms.Label();
            this.tbxlängd = new System.Windows.Forms.TextBox();
            this.tbxvind = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllängd
            // 
            this.lbllängd.AutoSize = true;
            this.lbllängd.Location = new System.Drawing.Point(312, 52);
            this.lbllängd.Name = "lbllängd";
            this.lbllängd.Size = new System.Drawing.Size(67, 16);
            this.lbllängd.TabIndex = 0;
            this.lbllängd.Text = "Längd (M)";
            // 
            // lblvind
            // 
            this.lblvind.AutoSize = true;
            this.lblvind.Location = new System.Drawing.Point(312, 113);
            this.lblvind.Name = "lblvind";
            this.lblvind.Size = new System.Drawing.Size(93, 16);
            this.lblvind.TabIndex = 1;
            this.lblvind.Text = "Vindtyrka(m/s)";
            // 
            // tbxlängd
            // 
            this.tbxlängd.Location = new System.Drawing.Point(456, 46);
            this.tbxlängd.Name = "tbxlängd";
            this.tbxlängd.Size = new System.Drawing.Size(100, 22);
            this.tbxlängd.TabIndex = 3;
            // 
            // tbxvind
            // 
            this.tbxvind.Location = new System.Drawing.Point(456, 113);
            this.tbxvind.Name = "tbxvind";
            this.tbxvind.Size = new System.Drawing.Size(100, 22);
            this.tbxvind.TabIndex = 4;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(315, 183);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.ReadOnly = true;
            this.tbxSvar.Size = new System.Drawing.Size(241, 22);
            this.tbxSvar.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxvind);
            this.Controls.Add(this.tbxlängd);
            this.Controls.Add(this.lblvind);
            this.Controls.Add(this.lbllängd);
            this.Name = "btnOK";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllängd;
        private System.Windows.Forms.Label lblvind;
        private System.Windows.Forms.TextBox tbxlängd;
        private System.Windows.Forms.TextBox tbxvind;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.Button button1;
    }
}

