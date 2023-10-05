namespace Uppgift_2._2
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
            this.btnvänster = new System.Windows.Forms.Button();
            this.btnhöger = new System.Windows.Forms.Button();
            this.lblFlytta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvänster
            // 
            this.btnvänster.Location = new System.Drawing.Point(250, 128);
            this.btnvänster.Name = "btnvänster";
            this.btnvänster.Size = new System.Drawing.Size(75, 23);
            this.btnvänster.TabIndex = 0;
            this.btnvänster.Text = "vänster";
            this.btnvänster.UseVisualStyleBackColor = true;
            this.btnvänster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhöger
            // 
            this.btnhöger.Location = new System.Drawing.Point(442, 128);
            this.btnhöger.Name = "btnhöger";
            this.btnhöger.Size = new System.Drawing.Size(75, 23);
            this.btnhöger.TabIndex = 1;
            this.btnhöger.Text = "höger";
            this.btnhöger.UseVisualStyleBackColor = true;
            this.btnhöger.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFlytta
            // 
            this.lblFlytta.AutoSize = true;
            this.lblFlytta.Location = new System.Drawing.Point(364, 224);
            this.lblFlytta.Name = "lblFlytta";
            this.lblFlytta.Size = new System.Drawing.Size(154, 20);
            this.lblFlytta.TabIndex = 2;
            this.lblFlytta.Text = "Vänster eller Höger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.lblFlytta);
            this.Controls.Add(this.btnhöger);
            this.Controls.Add(this.btnvänster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvänster;
        private System.Windows.Forms.Button btnhöger;
        private System.Windows.Forms.Label lblFlytta;
    }
}

