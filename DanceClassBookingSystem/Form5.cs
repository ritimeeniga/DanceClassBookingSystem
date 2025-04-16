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
    public partial class ClassCat : Form
    {
        public ClassCat()
        {
            InitializeComponent();
        }

        private void ClassCat_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            JazzClass jazz = new JazzClass();
            jazz.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            BalletClass ballet = new BalletClass();
            ballet.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HipHopClass hipHop = new HipHopClass();
            hipHop.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BallroomClass ballroom = new BallroomClass();
            ballroom.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Open the popup form to enter a class name
            using (AddClass popup = new AddClass())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string className = popup.ClassName;
                    AddClassButton(className);
                }
            }
        }

       private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (AddClass popup = new AddClass())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string className = popup.ClassName;  // ✅ Works if ClassName is public
                    AddClassButton(className);
                }
            }
        }

        private void AddClassButton(string className)
        {
            // Optional: prevent duplicate buttons
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Button btn && btn.Text == className)
                {
                    MessageBox.Show("Class already exists.");
                    return;
                }
            }

            // Create new class button dynamically
            Button newClassButton = new Button();
            newClassButton.Text = className;
            newClassButton.AutoSize = true;
            newClassButton.Margin = new Padding(5);

            newClassButton.Click += (s, e) =>
            {
                var classForm = new DynamicClassForm(className); // replace with your class form
                classForm.ShowDialog();
            };

            flowLayoutPanel1.Controls.Add(newClassButton);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            AddClass newClass2 = new AddClass();
            newClass2.Show();
        }
    }
}
