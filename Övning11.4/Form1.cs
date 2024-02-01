using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._4
{
    public partial class Form1 : Form
    {
        List<Course> MyCourseList = new List<Course>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
            ShowDataInListBox();
            ShowData(0);

        }
        void ShowDataInListBox()
        {
            LbxCourses.Items.Clear();
            foreach (Course item in MyCourseList)
            {
                LbxCourses.Items.Add(item.Name);
            }
            LbxCourses.SelectedIndex = 0;
        }


        void ShowData(int i)
        {
            Debug.Print("Data in Instance");
            Debug.Print(" Name: " + MyCourseList[i].Name);
            TxtName.Text = MyCourseList[i].Name;
            Debug.Print(" Code: " + MyCourseList[i].Code);
            TxtCode.Text = MyCourseList[i].Code;
            Debug.Print(" Points: " + MyCourseList[i].Points.ToString());
            TxtPoints.Text = MyCourseList[i].Points.ToString();
            Debug.Print(" Start : " + MyCourseList[i].Start.ToShortDateString());
            TxtStart.Text = MyCourseList[i].Start.ToString();
            Debug.Print(" Name: " + MyCourseList[i].End.ToShortDateString());
            TxtEnd.Text = MyCourseList[i].End.ToString(); 


            if (MyCourseList[i].IsActive(DateTime.Now)) 
            {
                LblActiveResult.BackColor = Color.Green; 
            }
            else 
            {
             LblActiveResult.BackColor = Color.Red; 
            }

        }
        void LoadData()
        {
            Course tmpCourse = new Course();
            tmpCourse.Name = " Matematik4 ";
            tmpCourse.Code = " MATMAT04 ";
            tmpCourse.Points = 100;
            tmpCourse.Start = DateTime.Parse(" 2018-08-17");
            tmpCourse.End = DateTime.Parse(" 2022-06-17");
            MyCourseList.Add(tmpCourse);
            tmpCourse = new Course();
            tmpCourse.Name = " Matematik5 ";
            tmpCourse.Code = " MATMAT05 ";
            tmpCourse.Points = 100;
            tmpCourse.Start = DateTime.Parse(" 2018-08-17");
            tmpCourse.End = DateTime.Parse(" 2025-06-17");
            MyCourseList.Add(tmpCourse);
        }

        private void LbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData(LbxCourses.SelectedIndex);
        }

    }

}
