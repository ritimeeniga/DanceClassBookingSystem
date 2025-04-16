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
    public partial class StudentPicker : Form
    {
        public StudentPicker(List<string> availableStudents)
        {
            InitializeComponent();
            listBox1.DataSource = availableStudents;
        }

        public string SelectedStudent { get; private set; }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedStudent = listBox1.SelectedItem as string;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
    
}
