namespace Övning_11._7
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
            this.tbxnamn = new System.Windows.Forms.TextBox();
            this.tbxpoäng = new System.Windows.Forms.TextBox();
            this.btnregistera = new System.Windows.Forms.Button();
            this.lbxsoldater = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poäng";
            // 
            // tbxnamn
            // 
            this.tbxnamn.Location = new System.Drawing.Point(439, 88);
            this.tbxnamn.Name = "tbxnamn";
            this.tbxnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxnamn.TabIndex = 2;
            // 
            // tbxpoäng
            // 
            this.tbxpoäng.Location = new System.Drawing.Point(439, 128);
            this.tbxpoäng.Name = "tbxpoäng";
            this.tbxpoäng.Size = new System.Drawing.Size(100, 20);
            this.tbxpoäng.TabIndex = 3;
            // 
            // btnregistera
            // 
            this.btnregistera.Location = new System.Drawing.Point(549, 107);
            this.btnregistera.Name = "btnregistera";
            this.btnregistera.Size = new System.Drawing.Size(75, 23);
            this.btnregistera.TabIndex = 4;
            this.btnregistera.Text = "Registera";
            this.btnregistera.UseVisualStyleBackColor = true;
            this.btnregistera.Click += new System.EventHandler(this.btnregistera_Click);
            // 
            // lbxsoldater
            // 
            this.lbxsoldater.FormattingEnabled = true;
            this.lbxsoldater.Location = new System.Drawing.Point(383, 157);
            this.lbxsoldater.Name = "lbxsoldater";
            this.lbxsoldater.Size = new System.Drawing.Size(241, 199);
            this.lbxsoldater.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxsoldater);
            this.Controls.Add(this.btnregistera);
            this.Controls.Add(this.tbxpoäng);
            this.Controls.Add(this.tbxnamn);
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
        private System.Windows.Forms.TextBox tbxnamn;
        private System.Windows.Forms.TextBox tbxpoäng;
        private System.Windows.Forms.Button btnregistera;
        private System.Windows.Forms.ListBox lbxsoldater;
    }
}

