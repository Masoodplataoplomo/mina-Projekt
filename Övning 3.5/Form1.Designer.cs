namespace Övning_3._5
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
            this.lblFödd = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxFödd = new System.Windows.Forms.TextBox();
            this.bynKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFödd
            // 
            this.lblFödd.AutoSize = true;
            this.lblFödd.Location = new System.Drawing.Point(387, 118);
            this.lblFödd.Name = "lblFödd";
            this.lblFödd.Size = new System.Drawing.Size(69, 16);
            this.lblFödd.TabIndex = 0;
            this.lblFödd.Text = "Födelseår";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(387, 67);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(43, 16);
            this.lblNamn.TabIndex = 1;
            this.lblNamn.Text = "Namn";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(509, 188);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(44, 16);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label3";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(477, 64);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(165, 22);
            this.tbxNamn.TabIndex = 3;
            // 
            // tbxFödd
            // 
            this.tbxFödd.Location = new System.Drawing.Point(477, 115);
            this.tbxFödd.Name = "tbxFödd";
            this.tbxFödd.Size = new System.Drawing.Size(165, 22);
            this.tbxFödd.TabIndex = 4;
            // 
            // bynKör
            // 
            this.bynKör.Location = new System.Drawing.Point(512, 237);
            this.bynKör.Name = "bynKör";
            this.bynKör.Size = new System.Drawing.Size(75, 23);
            this.bynKör.TabIndex = 5;
            this.bynKör.Text = "Kör";
            this.bynKör.UseVisualStyleBackColor = true;
            this.bynKör.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bynKör);
            this.Controls.Add(this.tbxFödd);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblFödd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFödd;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxFödd;
        private System.Windows.Forms.Button bynKör;
    }
}

