namespace Övning9._2
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
            this.btnVissa = new System.Windows.Forms.Button();
            this.tbxUdata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVissa
            // 
            this.btnVissa.Location = new System.Drawing.Point(447, 71);
            this.btnVissa.Name = "btnVissa";
            this.btnVissa.Size = new System.Drawing.Size(75, 23);
            this.btnVissa.TabIndex = 0;
            this.btnVissa.Text = "Vissa";
            this.btnVissa.UseVisualStyleBackColor = true;
            this.btnVissa.Click += new System.EventHandler(this.btnVissa_Click);
            // 
            // tbxUdata
            // 
            this.tbxUdata.Location = new System.Drawing.Point(349, 117);
            this.tbxUdata.Multiline = true;
            this.tbxUdata.Name = "tbxUdata";
            this.tbxUdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUdata.Size = new System.Drawing.Size(255, 127);
            this.tbxUdata.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxUdata);
            this.Controls.Add(this.btnVissa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVissa;
        private System.Windows.Forms.TextBox tbxUdata;
    }
}

