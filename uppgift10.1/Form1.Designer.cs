namespace uppgift10._1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.tbxOmkrets = new System.Windows.Forms.TextBox();
            this.beräkna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Omkrets";
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(457, 72);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRadie.TabIndex = 2;
            // 
            // tbxOmkrets
            // 
            this.tbxOmkrets.Location = new System.Drawing.Point(457, 120);
            this.tbxOmkrets.Name = "tbxOmkrets";
            this.tbxOmkrets.ReadOnly = true;
            this.tbxOmkrets.Size = new System.Drawing.Size(100, 20);
            this.tbxOmkrets.TabIndex = 3;
            // 
            // beräkna
            // 
            this.beräkna.Location = new System.Drawing.Point(409, 165);
            this.beräkna.Name = "beräkna";
            this.beräkna.Size = new System.Drawing.Size(105, 23);
            this.beräkna.TabIndex = 4;
            this.beräkna.Text = "Beräkna omkrets";
            this.beräkna.UseVisualStyleBackColor = true;
            this.beräkna.Click += new System.EventHandler(this.beräkna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.beräkna);
            this.Controls.Add(this.tbxOmkrets);
            this.Controls.Add(this.tbxRadie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRadie;
        private System.Windows.Forms.TextBox tbxOmkrets;
        private System.Windows.Forms.Button beräkna;
    }
}

