namespace Övning7._4
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
            this.components = new System.ComponentModel.Container();
            this.lblLåtar = new System.Windows.Forms.Label();
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxpris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLåtar
            // 
            this.lblLåtar.AutoSize = true;
            this.lblLåtar.Location = new System.Drawing.Point(322, 117);
            this.lblLåtar.Name = "lblLåtar";
            this.lblLåtar.Size = new System.Drawing.Size(66, 16);
            this.lblLåtar.TabIndex = 0;
            this.lblLåtar.Text = "Antal låtar";
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(452, 114);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(142, 22);
            this.tbxAntal.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(399, 253);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(133, 49);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "beräkna priset ";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxpris
            // 
            this.tbxpris.Location = new System.Drawing.Point(325, 187);
            this.tbxpris.Name = "tbxpris";
            this.tbxpris.ReadOnly = true;
            this.tbxpris.Size = new System.Drawing.Size(269, 22);
            this.tbxpris.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxpris);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxAntal);
            this.Controls.Add(this.lblLåtar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLåtar;
        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxpris;
    }
}

