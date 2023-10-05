namespace Uppgift_7._1
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
            this.lbltal = new System.Windows.Forms.Label();
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltal
            // 
            this.lbltal.AutoSize = true;
            this.lbltal.Location = new System.Drawing.Point(318, 106);
            this.lbltal.Name = "lbltal";
            this.lbltal.Size = new System.Drawing.Size(30, 16);
            this.lbltal.TabIndex = 0;
            this.lbltal.Text = "Tal:";
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(430, 103);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(100, 22);
            this.tbxTal.TabIndex = 1;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(321, 179);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(209, 22);
            this.tbxSvar.TabIndex = 2;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(379, 236);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(91, 29);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "OK";
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
            this.Controls.Add(this.tbxTal);
            this.Controls.Add(this.lbltal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltal;
        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.Button btnKör;
    }
}

