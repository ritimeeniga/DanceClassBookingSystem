﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceClassBookingSystem
{
    public partial class DynamicClassForm : Form
    {
        private string className;
        private List<string> enrolledStudents = new List<string>();

        public DynamicClassForm(string className)
        {
            InitializeComponent();
            this.className = className;
            this.Text = $"{className} Roster";
            RefreshRoster();
        }

        private void RefreshRoster()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = enrolledStudents;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var available = AppData.Students.Except(enrolledStudents).ToList();

            var picker = new StudentPicker(available);
            if (picker.ShowDialog() == DialogResult.OK && picker.SelectedStudent != null)
            {
                enrolledStudents.Add(picker.SelectedStudent);
                RefreshRoster();
            }
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                enrolledStudents.Remove(listBox1.SelectedItem.ToString());
                RefreshRoster();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
