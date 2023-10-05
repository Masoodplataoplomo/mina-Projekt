namespace övning3._1
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
            this.btnkör = new System.Windows.Forms.Button();
            this.lblTal = new System.Windows.Forms.Label();
            this.lblKvadrat = new System.Windows.Forms.Label();
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnkör
            // 
            this.btnkör.Location = new System.Drawing.Point(315, 230);
            this.btnkör.Name = "btnkör";
            this.btnkör.Size = new System.Drawing.Size(123, 39);
            this.btnkör.TabIndex = 0;
            this.btnkör.Text = "Beräkna kvadraten";
            this.btnkör.UseVisualStyleBackColor = true;
            this.btnkör.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Location = new System.Drawing.Point(224, 81);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(22, 13);
            this.lblTal.TabIndex = 1;
            this.lblTal.Text = "Tal";
            // 
            // lblKvadrat
            // 
            this.lblKvadrat.AutoSize = true;
            this.lblKvadrat.Location = new System.Drawing.Point(359, 204);
            this.lblKvadrat.Name = "lblKvadrat";
            this.lblKvadrat.Size = new System.Drawing.Size(35, 13);
            this.lblKvadrat.TabIndex = 2;
            this.lblKvadrat.Text = "label2";
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(279, 78);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(199, 20);
            this.tbxTal.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(625, 498);
            this.Controls.Add(this.tbxTal);
            this.Controls.Add(this.lblKvadrat);
            this.Controls.Add(this.lblTal);
            this.Controls.Add(this.btnkör);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkör;
        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.Label lblKvadrat;
        private System.Windows.Forms.TextBox tbxTal;
    }
}

