namespace Övning11._4
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
            this.GrpCourse = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LblPoints = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblEnd = new System.Windows.Forms.Label();
            this.LblIsActive = new System.Windows.Forms.Label();
            this.TxtPoints = new System.Windows.Forms.TextBox();
            this.TxtStart = new System.Windows.Forms.TextBox();
            this.TxtEnd = new System.Windows.Forms.TextBox();
            this.LblActiveResult = new System.Windows.Forms.Label();
            this.LbxCourses = new System.Windows.Forms.ListBox();
            this.LblCourses = new System.Windows.Forms.Label();
            this.GrpCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpCourse
            // 
            this.GrpCourse.Controls.Add(this.LblActiveResult);
            this.GrpCourse.Controls.Add(this.TxtEnd);
            this.GrpCourse.Controls.Add(this.TxtStart);
            this.GrpCourse.Controls.Add(this.TxtPoints);
            this.GrpCourse.Controls.Add(this.LblIsActive);
            this.GrpCourse.Controls.Add(this.LblEnd);
            this.GrpCourse.Controls.Add(this.LblStart);
            this.GrpCourse.Controls.Add(this.LblPoints);
            this.GrpCourse.Controls.Add(this.TxtCode);
            this.GrpCourse.Controls.Add(this.LblCode);
            this.GrpCourse.Controls.Add(this.TxtName);
            this.GrpCourse.Controls.Add(this.lblName);
            this.GrpCourse.Location = new System.Drawing.Point(101, 42);
            this.GrpCourse.Name = "GrpCourse";
            this.GrpCourse.Size = new System.Drawing.Size(159, 244);
            this.GrpCourse.TabIndex = 0;
            this.GrpCourse.TabStop = false;
            this.GrpCourse.Text = "Selected Course";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Namn";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(9, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(144, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(7, 66);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(32, 13);
            this.LblCode.TabIndex = 2;
            this.LblCode.Text = "Code";
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(53, 59);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 20);
            this.TxtCode.TabIndex = 3;
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Location = new System.Drawing.Point(7, 100);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(36, 13);
            this.LblPoints.TabIndex = 4;
            this.LblPoints.Text = "Points";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(6, 138);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(29, 13);
            this.LblStart.TabIndex = 5;
            this.LblStart.Text = "Start";
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Location = new System.Drawing.Point(6, 176);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(26, 13);
            this.LblEnd.TabIndex = 6;
            this.LblEnd.Text = "End";
            // 
            // LblIsActive
            // 
            this.LblIsActive.AutoSize = true;
            this.LblIsActive.Location = new System.Drawing.Point(7, 215);
            this.LblIsActive.Name = "LblIsActive";
            this.LblIsActive.Size = new System.Drawing.Size(45, 13);
            this.LblIsActive.TabIndex = 7;
            this.LblIsActive.Text = "IsActive";
            // 
            // TxtPoints
            // 
            this.TxtPoints.Location = new System.Drawing.Point(103, 93);
            this.TxtPoints.Name = "TxtPoints";
            this.TxtPoints.Size = new System.Drawing.Size(50, 20);
            this.TxtPoints.TabIndex = 8;
            // 
            // TxtStart
            // 
            this.TxtStart.Location = new System.Drawing.Point(53, 131);
            this.TxtStart.Name = "TxtStart";
            this.TxtStart.Size = new System.Drawing.Size(100, 20);
            this.TxtStart.TabIndex = 9;
            // 
            // TxtEnd
            // 
            this.TxtEnd.Location = new System.Drawing.Point(53, 169);
            this.TxtEnd.Name = "TxtEnd";
            this.TxtEnd.Size = new System.Drawing.Size(100, 20);
            this.TxtEnd.TabIndex = 10;
            // 
            // LblActiveResult
            // 
            this.LblActiveResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblActiveResult.Location = new System.Drawing.Point(113, 205);
            this.LblActiveResult.Name = "LblActiveResult";
            this.LblActiveResult.Size = new System.Drawing.Size(40, 23);
            this.LblActiveResult.TabIndex = 11;
            // 
            // LbxCourses
            // 
            this.LbxCourses.FormattingEnabled = true;
            this.LbxCourses.Location = new System.Drawing.Point(309, 58);
            this.LbxCourses.Name = "LbxCourses";
            this.LbxCourses.Size = new System.Drawing.Size(155, 134);
            this.LbxCourses.TabIndex = 1;
            this.LbxCourses.SelectedIndexChanged += new System.EventHandler(this.LbxCourses_SelectedIndexChanged);
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.Location = new System.Drawing.Point(309, 39);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(45, 13);
            this.LblCourses.TabIndex = 2;
            this.LblCourses.Text = "Courses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCourses);
            this.Controls.Add(this.LbxCourses);
            this.Controls.Add(this.GrpCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpCourse.ResumeLayout(false);
            this.GrpCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpCourse;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtEnd;
        private System.Windows.Forms.TextBox TxtStart;
        private System.Windows.Forms.TextBox TxtPoints;
        private System.Windows.Forms.Label LblIsActive;
        private System.Windows.Forms.Label LblEnd;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblActiveResult;
        private System.Windows.Forms.ListBox LbxCourses;
        private System.Windows.Forms.Label LblCourses;
    }
}

