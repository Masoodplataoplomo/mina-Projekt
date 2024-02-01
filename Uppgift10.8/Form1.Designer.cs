namespace Uppgift10._8
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
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.tbxVisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tid i seckunder";
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(463, 91);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(100, 20);
            this.tbxTid.TabIndex = 1;
            // 
            // tbxVisa
            // 
            this.tbxVisa.Location = new System.Drawing.Point(380, 134);
            this.tbxVisa.Name = "tbxVisa";
            this.tbxVisa.ReadOnly = true;
            this.tbxVisa.Size = new System.Drawing.Size(183, 20);
            this.tbxVisa.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.TextBox tbxVisa;
        private System.Windows.Forms.Button button1;
    }
}

