namespace Övning_7._6
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
            this.lblnamn1 = new System.Windows.Forms.Label();
            this.lblnamn2 = new System.Windows.Forms.Label();
            this.tbxnamn1 = new System.Windows.Forms.TextBox();
            this.tbxnamn2 = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnamn1
            // 
            this.lblnamn1.AutoSize = true;
            this.lblnamn1.Location = new System.Drawing.Point(306, 81);
            this.lblnamn1.Name = "lblnamn1";
            this.lblnamn1.Size = new System.Drawing.Size(50, 16);
            this.lblnamn1.TabIndex = 0;
            this.lblnamn1.Text = "Namn1";
            // 
            // lblnamn2
            // 
            this.lblnamn2.AutoSize = true;
            this.lblnamn2.Location = new System.Drawing.Point(306, 154);
            this.lblnamn2.Name = "lblnamn2";
            this.lblnamn2.Size = new System.Drawing.Size(50, 16);
            this.lblnamn2.TabIndex = 1;
            this.lblnamn2.Text = "Namn2";
            // 
            // tbxnamn1
            // 
            this.tbxnamn1.Location = new System.Drawing.Point(456, 75);
            this.tbxnamn1.Name = "tbxnamn1";
            this.tbxnamn1.Size = new System.Drawing.Size(100, 22);
            this.tbxnamn1.TabIndex = 2;
            // 
            // tbxnamn2
            // 
            this.tbxnamn2.Location = new System.Drawing.Point(456, 151);
            this.tbxnamn2.Name = "tbxnamn2";
            this.tbxnamn2.Size = new System.Drawing.Size(100, 22);
            this.tbxnamn2.TabIndex = 3;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(309, 219);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(247, 22);
            this.tbxSvar.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(373, 275);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(130, 34);
            this.btnKör.TabIndex = 5;
            this.btnKör.Text = "Jämför namnen";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxnamn2);
            this.Controls.Add(this.tbxnamn1);
            this.Controls.Add(this.lblnamn2);
            this.Controls.Add(this.lblnamn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamn1;
        private System.Windows.Forms.Label lblnamn2;
        private System.Windows.Forms.TextBox tbxnamn1;
        private System.Windows.Forms.TextBox tbxnamn2;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.Button btnKör;
    }
}

