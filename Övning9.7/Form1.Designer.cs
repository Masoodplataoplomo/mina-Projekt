namespace Övning9._7
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
            this.tbxNivå = new System.Windows.Forms.TextBox();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNivå
            // 
            this.tbxNivå.Location = new System.Drawing.Point(574, 67);
            this.tbxNivå.Name = "tbxNivå";
            this.tbxNivå.Size = new System.Drawing.Size(33, 20);
            this.tbxNivå.TabIndex = 0;
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(326, 38);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxUtdata.Size = new System.Drawing.Size(239, 157);
            this.tbxUtdata.TabIndex = 1;
            this.tbxUtdata.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nivå";
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(574, 176);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(45, 19);
            this.btnVisa.TabIndex = 3;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.tbxNivå);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNivå;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisa;
    }
}

