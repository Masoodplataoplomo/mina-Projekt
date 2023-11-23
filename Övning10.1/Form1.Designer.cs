namespace Övning10._1
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
            this.lblRadie = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadie
            // 
            this.lblRadie.AutoSize = true;
            this.lblRadie.Location = new System.Drawing.Point(314, 89);
            this.lblRadie.Name = "lblRadie";
            this.lblRadie.Size = new System.Drawing.Size(38, 13);
            this.lblRadie.TabIndex = 0;
            this.lblRadie.Text = "Radie:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(314, 173);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(413, 86);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRadie.TabIndex = 2;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(413, 170);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(100, 20);
            this.tbxArea.TabIndex = 3;
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(374, 218);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(75, 23);
            this.btnBeräkna.TabIndex = 4;
            this.btnBeräkna.Text = "Beräkna";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeräkna);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.tbxRadie);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadie;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbxRadie;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Button btnBeräkna;
    }
}

