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
    public partial class StudentProfiles : Form
    {
        private List<string> students = new List<string>();
        public StudentProfiles()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            if (!string.IsNullOrEmpty(studentName))
            {
                students.Add(studentName);
                students.Sort(); // Sort the list alphabetically
                UpdateListBox();
                txtStudentName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a student name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) // Changed button8 to listBox1
            {
                students.Remove(listBox1.SelectedItem.ToString()); // Changed button8 to listBox1
                listBox1.Items.Remove(listBox1.SelectedItem); // Changed button8 to listBox1
            }
            else
            {
                MessageBox.Show("Please select a student to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string searchQuery = txtStudentName.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filter and sort results
            List<string> filteredStudents = students.Where(s => s.ToLower().Contains(searchQuery)).OrderBy(s => s).ToList();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(filteredStudents.ToArray());

            if (filteredStudents.Count == 0)
            {
                MessageBox.Show("No matching students found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear(); // Clear current items
            listBox1.Items.AddRange(students.ToArray()); // Re-add sorted list
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home retHome = new Home();
            retHome.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reminders reminder = new Reminders();
            reminder.Show();
            this.Hide();
        }
    }
}
