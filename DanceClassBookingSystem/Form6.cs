using System;
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
    public partial class JazzClass : Form
    {
        private List<string> allStudents = AppData.Students;
        private List<string> enrolledStudents = new List<string>();

        public JazzClass()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var available = AppData.Students.Except(enrolledStudents).ToList();

            if (available.Count == 0)
            {
                MessageBox.Show("No students available to add.");
                return;
            }

            // Optional: Let user choose from available list
            var picker = new StudentPicker(available);
            if (picker.ShowDialog() == DialogResult.OK && picker.SelectedStudent != null)
            {
                enrolledStudents.Add(picker.SelectedStudent);
                RefreshRoster();
            }
        }

        private void RefreshRoster()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = enrolledStudents;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selected = listBox1.SelectedItem.ToString();
                enrolledStudents.Remove(selected);
                RefreshRoster();
            }
            else
            {
                MessageBox.Show("Please select a student to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
