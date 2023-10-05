namespace uppgift_5._4
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
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(560, 67);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(141, 22);
            this.tbxTid.TabIndex = 0;
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(431, 70);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(27, 16);
            this.lblTid.TabIndex = 1;
            this.lblTid.Text = "Tid";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(557, 154);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(44, 16);
            this.lblSvar.TabIndex = 2;
            this.lblSvar.Text = "label2";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(526, 245);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(134, 36);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.tbxTid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
    }
}

