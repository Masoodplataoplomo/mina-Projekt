namespace uppgift10._3
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
            this.tbxtecken = new System.Windows.Forms.TextBox();
            this.tbxresultat = new System.Windows.Forms.TextBox();
            this.btnvisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tecken";
            // 
            // tbxtecken
            // 
            this.tbxtecken.Location = new System.Drawing.Point(452, 92);
            this.tbxtecken.Name = "tbxtecken";
            this.tbxtecken.Size = new System.Drawing.Size(100, 20);
            this.tbxtecken.TabIndex = 1;
            // 
            // tbxresultat
            // 
            this.tbxresultat.Location = new System.Drawing.Point(367, 145);
            this.tbxresultat.Name = "tbxresultat";
            this.tbxresultat.ReadOnly = true;
            this.tbxresultat.Size = new System.Drawing.Size(185, 20);
            this.tbxresultat.TabIndex = 2;
            // 
            // btnvisa
            // 
            this.btnvisa.Location = new System.Drawing.Point(420, 188);
            this.btnvisa.Name = "btnvisa";
            this.btnvisa.Size = new System.Drawing.Size(86, 23);
            this.btnvisa.TabIndex = 3;
            this.btnvisa.Text = "Visa resultat";
            this.btnvisa.UseVisualStyleBackColor = true;
            this.btnvisa.Click += new System.EventHandler(this.btnvisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvisa);
            this.Controls.Add(this.tbxresultat);
            this.Controls.Add(this.tbxtecken);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxtecken;
        private System.Windows.Forms.TextBox tbxresultat;
        private System.Windows.Forms.Button btnvisa;
    }
}

