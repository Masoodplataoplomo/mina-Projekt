namespace Uppgift_3._4B
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
            this.tbxsvar = new System.Windows.Forms.TextBox();
            this.lblUttag = new System.Windows.Forms.Label();
            this.lblUttag2 = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxsvar
            // 
            this.tbxsvar.Location = new System.Drawing.Point(553, 87);
            this.tbxsvar.Name = "tbxsvar";
            this.tbxsvar.Size = new System.Drawing.Size(100, 20);
            this.tbxsvar.TabIndex = 0;
            // 
            // lblUttag
            // 
            this.lblUttag.AutoSize = true;
            this.lblUttag.Location = new System.Drawing.Point(478, 87);
            this.lblUttag.Name = "lblUttag";
            this.lblUttag.Size = new System.Drawing.Size(34, 13);
            this.lblUttag.TabIndex = 2;
            this.lblUttag.Text = "uttag ";
            // 
            // lblUttag2
            // 
            this.lblUttag2.AutoSize = true;
            this.lblUttag2.Location = new System.Drawing.Point(573, 176);
            this.lblUttag2.Name = "lblUttag2";
            this.lblUttag2.Size = new System.Drawing.Size(34, 13);
            this.lblUttag2.TabIndex = 3;
            this.lblUttag2.Text = "uttag ";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(553, 211);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 4;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblUttag2);
            this.Controls.Add(this.lblUttag);
            this.Controls.Add(this.tbxsvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxsvar;
        private System.Windows.Forms.Label lblUttag;
        private System.Windows.Forms.Label lblUttag2;
        private System.Windows.Forms.Button btnKör;
    }
}

