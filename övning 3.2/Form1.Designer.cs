namespace övning_3._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tal 1";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(217, 121);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(35, 13);
            this.lblSumma.TabIndex = 1;
            this.lblSumma.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tal 2";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(279, 39);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 20);
            this.tbxTal1.TabIndex = 3;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(279, 67);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 20);
            this.tbxTal2.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(279, 155);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 5;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(509, 360);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.Button btnKör;
    }
}

