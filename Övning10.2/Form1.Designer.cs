namespace Övning10._2
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
            this.lblRadie = new System.Windows.Forms.Label();
            this.lblHöjd = new System.Windows.Forms.Label();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.tbxVolym = new System.Windows.Forms.TextBox();
            this.btnVolym = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadie
            // 
            this.lblRadie.AutoSize = true;
            this.lblRadie.Location = new System.Drawing.Point(397, 85);
            this.lblRadie.Name = "lblRadie";
            this.lblRadie.Size = new System.Drawing.Size(35, 13);
            this.lblRadie.TabIndex = 0;
            this.lblRadie.Text = "Radie";
            // 
            // lblHöjd
            // 
            this.lblHöjd.AutoSize = true;
            this.lblHöjd.Location = new System.Drawing.Point(397, 120);
            this.lblHöjd.Name = "lblHöjd";
            this.lblHöjd.Size = new System.Drawing.Size(29, 13);
            this.lblHöjd.TabIndex = 1;
            this.lblHöjd.Text = "Höjd";
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(458, 117);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 2;
            this.tbxHöjd.TextChanged += new System.EventHandler(this.tbxHöjd_TextChanged);
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(458, 82);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRadie.TabIndex = 3;
            this.tbxRadie.TextChanged += new System.EventHandler(this.tbxRadie_TextChanged);
            // 
            // tbxVolym
            // 
            this.tbxVolym.Location = new System.Drawing.Point(469, 164);
            this.tbxVolym.Name = "tbxVolym";
            this.tbxVolym.ReadOnly = true;
            this.tbxVolym.Size = new System.Drawing.Size(89, 20);
            this.tbxVolym.TabIndex = 4;
            // 
            // btnVolym
            // 
            this.btnVolym.Location = new System.Drawing.Point(400, 164);
            this.btnVolym.Name = "btnVolym";
            this.btnVolym.Size = new System.Drawing.Size(53, 23);
            this.btnVolym.TabIndex = 6;
            this.btnVolym.Text = "Volym";
            this.btnVolym.UseVisualStyleBackColor = true;
            this.btnVolym.Click += new System.EventHandler(this.btnVolym_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolym);
            this.Controls.Add(this.tbxVolym);
            this.Controls.Add(this.tbxRadie);
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.lblHöjd);
            this.Controls.Add(this.lblRadie);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadie;
        private System.Windows.Forms.Label lblHöjd;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.TextBox tbxRadie;
        private System.Windows.Forms.TextBox tbxVolym;
        private System.Windows.Forms.Button btnVolym;
    }
}

