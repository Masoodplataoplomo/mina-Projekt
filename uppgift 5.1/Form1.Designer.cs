namespace uppgift_5._1
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
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.Tal = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(553, 105);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(100, 22);
            this.tbxTal.TabIndex = 0;
            // 
            // Tal
            // 
            this.Tal.AutoSize = true;
            this.Tal.Location = new System.Drawing.Point(450, 108);
            this.Tal.Name = "Tal";
            this.Tal.Size = new System.Drawing.Size(27, 16);
            this.Tal.TabIndex = 1;
            this.Tal.Text = "Tal";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(550, 172);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 16);
            this.lblSvar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "kör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.Tal);
            this.Controls.Add(this.tbxTal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.Label Tal;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button button1;
    }
}

