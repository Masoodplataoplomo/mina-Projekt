namespace övning8._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxSpelet.SuspendLayout();
            this.gbxSpeldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(401, 106);
            this.btnStartaSpelet.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(68, 20);
            this.btnStartaSpelet.TabIndex = 2;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Location = new System.Drawing.Point(401, 146);
            this.btnSpelaIgen.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(68, 20);
            this.btnSpelaIgen.TabIndex = 3;
            this.btnSpelaIgen.Text = "Spela igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            this.btnSpelaIgen.Click += new System.EventHandler(this.btnSpelaIgen_Click);
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Controls.Add(this.label3);
            this.gbxSpelet.Controls.Add(this.label2);
            this.gbxSpelet.Controls.Add(this.label1);
            this.gbxSpelet.Location = new System.Drawing.Point(131, 180);
            this.gbxSpelet.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSpelet.Size = new System.Drawing.Size(338, 118);
            this.gbxSpelet.TabIndex = 4;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Location = new System.Drawing.Point(244, 46);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.Size = new System.Drawing.Size(89, 61);
            this.tbxMinaResultat.TabIndex = 9;
            // 
            // btnGissa
            // 
            this.btnGissa.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnGissa.Location = new System.Drawing.Point(151, 46);
            this.btnGissa.Margin = new System.Windows.Forms.Padding(2);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(66, 33);
            this.btnGissa.TabIndex = 8;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = false;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(68, 54);
            this.tbxGissa.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(51, 21);
            this.tbxGissa.TabIndex = 7;
            // 
            // lblResultat
            // 
            this.lblResultat.Location = new System.Drawing.Point(7, 86);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(2);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(114, 21);
            this.lblResultat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gissa ett tal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datorns tal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mina resultat";
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Controls.Add(this.label4);
            this.gbxSpeldata.Location = new System.Drawing.Point(131, 93);
            this.gbxSpeldata.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSpeldata.Size = new System.Drawing.Size(217, 74);
            this.gbxSpeldata.TabIndex = 5;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.ItemHeight = 14;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(92, 13);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(120, 46);
            this.lbxStörstaTalet.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Strösta talet:";
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(76, 26);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(35, 13);
            this.lblDatornsTal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(867, 597);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.gbxSpeldata.ResumeLayout(false);
            this.gbxSpeldata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartaSpelet;
        private System.Windows.Forms.Button btnSpelaIgen;
        private System.Windows.Forms.GroupBox gbxSpelet;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.TextBox lblResultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSpeldata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.ListBox lbxStörstaTalet;
        private System.Windows.Forms.Label lblDatornsTal;
    }
}

