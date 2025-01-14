﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorHQ.Controllers;
using TutorHQ.Models;

namespace TutorHQ.Views.Student_Data
{
    public partial class Student_Proile : Form
    {
        public string id;
        public Student_Proile()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                dashboard.WindowState = FormWindowState.Maximized;
            }
            dashboard.Show();
        }

        private void Student_Proile_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                Console.WriteLine(id);
                Student student = StudentControllers.GetStudentDetailsByID(id);
                label24.Text = id;
                label13.Text = student.St_Name;
                label16.Text = student.Gender;
                label18.Text = student.NIC;
                label21.Text = student.Parent_Name;
                label22.Text = student.Parent_Relation;
                label12.Text = student.Select_Subjects;
                label19.Text = student.Phone_NO.ToString();
                label23.Text = student.Parent_Phone.ToString();



            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                dashboard.WindowState = FormWindowState.Maximized;
            }
            dashboard.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            AllStudentsData form = new AllStudentsData();
            form.Closed += (s, args) => this.Close();
            if (this.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            form.Show();
        }
    }
}
