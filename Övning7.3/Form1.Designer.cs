namespace Övning7._3
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
            this.btnKasta = new System.Windows.Forms.Button();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(512, 69);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(154, 22);
            this.tbxTal.TabIndex = 3;
            // 
            // btnKasta
            // 
            this.btnKasta.Location = new System.Drawing.Point(424, 206);
            this.btnKasta.Name = "btnKasta";
            this.btnKasta.Size = new System.Drawing.Size(149, 50);
            this.btnKasta.TabIndex = 5;
            this.btnKasta.Text = "Kasta tärning";
            this.btnKasta.UseVisualStyleBackColor = true;
            this.btnKasta.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(408, 74);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(81, 16);
            this.lblAP.TabIndex = 6;
            this.lblAP.Text = "Antal prickar";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(512, 148);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(44, 16);
            this.lblResultat.TabIndex = 7;
            this.lblResultat.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.btnKasta);
            this.Controls.Add(this.tbxTal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.Button btnKasta;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblResultat;
    }
}

