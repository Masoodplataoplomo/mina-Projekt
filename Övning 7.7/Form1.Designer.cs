namespace Övning_7._7
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
            this.lbltal1 = new System.Windows.Forms.Label();
            this.lbltal2 = new System.Windows.Forms.Label();
            this.tbxtal2 = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.tbxtal1 = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltal1
            // 
            this.lbltal1.AutoSize = true;
            this.lbltal1.Location = new System.Drawing.Point(339, 62);
            this.lbltal1.Name = "lbltal1";
            this.lbltal1.Size = new System.Drawing.Size(40, 16);
            this.lbltal1.TabIndex = 0;
            this.lbltal1.Text = "Tal 1 ";
            // 
            // lbltal2
            // 
            this.lbltal2.AutoSize = true;
            this.lbltal2.Location = new System.Drawing.Point(339, 132);
            this.lbltal2.Name = "lbltal2";
            this.lbltal2.Size = new System.Drawing.Size(37, 16);
            this.lbltal2.TabIndex = 1;
            this.lbltal2.Text = "Tal 2";
            // 
            // tbxtal2
            // 
            this.tbxtal2.Location = new System.Drawing.Point(456, 129);
            this.tbxtal2.Name = "tbxtal2";
            this.tbxtal2.Size = new System.Drawing.Size(100, 22);
            this.tbxtal2.TabIndex = 2;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(342, 200);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.ReadOnly = true;
            this.tbxSvar.Size = new System.Drawing.Size(214, 22);
            this.tbxSvar.TabIndex = 3;
            // 
            // tbxtal1
            // 
            this.tbxtal1.Location = new System.Drawing.Point(456, 59);
            this.tbxtal1.Name = "tbxtal1";
            this.tbxtal1.Size = new System.Drawing.Size(100, 22);
            this.tbxtal1.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(364, 254);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(172, 34);
            this.btnKör.TabIndex = 5;
            this.btnKör.Text = "Hitta minsta talet";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxtal1);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxtal2);
            this.Controls.Add(this.lbltal2);
            this.Controls.Add(this.lbltal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltal1;
        private System.Windows.Forms.Label lbltal2;
        private System.Windows.Forms.TextBox tbxtal2;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.TextBox tbxtal1;
        private System.Windows.Forms.Button btnKör;
    }
}

