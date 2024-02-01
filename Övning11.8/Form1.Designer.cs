namespace Övning11._8
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxsträcka = new System.Windows.Forms.TextBox();
            this.tbxtid = new System.Windows.Forms.TextBox();
            this.btnregistera = new System.Windows.Forms.Button();
            this.lbxlöppass = new System.Windows.Forms.ListBox();
            this.tbxnamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sträcka (km)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tid (min)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registera löppass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lisa över löppass";
            // 
            // tbxsträcka
            // 
            this.tbxsträcka.Location = new System.Drawing.Point(262, 72);
            this.tbxsträcka.Name = "tbxsträcka";
            this.tbxsträcka.Size = new System.Drawing.Size(100, 20);
            this.tbxsträcka.TabIndex = 4;
            // 
            // tbxtid
            // 
            this.tbxtid.Location = new System.Drawing.Point(262, 98);
            this.tbxtid.Name = "tbxtid";
            this.tbxtid.Size = new System.Drawing.Size(100, 20);
            this.tbxtid.TabIndex = 5;
            // 
            // btnregistera
            // 
            this.btnregistera.Location = new System.Drawing.Point(262, 161);
            this.btnregistera.Name = "btnregistera";
            this.btnregistera.Size = new System.Drawing.Size(100, 23);
            this.btnregistera.TabIndex = 6;
            this.btnregistera.Text = "Registera";
            this.btnregistera.UseVisualStyleBackColor = true;
            this.btnregistera.Click += new System.EventHandler(this.btnregistera_Click);
            // 
            // lbxlöppass
            // 
            this.lbxlöppass.FormattingEnabled = true;
            this.lbxlöppass.Location = new System.Drawing.Point(377, 61);
            this.lbxlöppass.Name = "lbxlöppass";
            this.lbxlöppass.Size = new System.Drawing.Size(180, 134);
            this.lbxlöppass.TabIndex = 7;
            // 
            // tbxnamn
            // 
            this.tbxnamn.Location = new System.Drawing.Point(262, 124);
            this.tbxnamn.Name = "tbxnamn";
            this.tbxnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxnamn.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Namn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxnamn);
            this.Controls.Add(this.lbxlöppass);
            this.Controls.Add(this.btnregistera);
            this.Controls.Add(this.tbxtid);
            this.Controls.Add(this.tbxsträcka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxsträcka;
        private System.Windows.Forms.TextBox tbxtid;
        private System.Windows.Forms.Button btnregistera;
        private System.Windows.Forms.ListBox lbxlöppass;
        private System.Windows.Forms.TextBox tbxnamn;
        private System.Windows.Forms.Label label5;
    }
}

