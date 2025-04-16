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

        JazzClass jazz = new JazzClass();
        BalletClass ballet = new BalletClass();
        HipHopClass hipHop = new HipHopClass();
        BallroomClass ballroom = new BallroomClass();

        private void button12_Click(object sender, EventArgs e)
        {
            jazz.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home newhome = new Home();
            newhome.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            ballet.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hipHop.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            ballroom.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (AddClass popup = new AddClass())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string className = popup.ClassName;

                    // 1. Get the index of the add button
                    int index = flowLayoutPanel1.Controls.GetChildIndex(button8);

                    // 2. Create new button
                    Button newClassButton = new Button();
                    newClassButton.Text = className;
                    newClassButton.Size = button8.Size;
                    newClassButton.Font = button12.Font;
                    newClassButton.ForeColor = button12.ForeColor;
                    newClassButton.AutoSize = button8.AutoSize;

                    newClassButton.Click += (s, args) =>
                    {
                        var classForm = new DynamicClassForm(className);
                        classForm.ShowDialog();
                    };

                    // 3. Replace in FlowLayoutPanel
                    flowLayoutPanel1.Controls.RemoveAt(index);
                    flowLayoutPanel1.Controls.Add(newClassButton);
                    flowLayoutPanel1.Controls.SetChildIndex(newClassButton, index);
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
                var classForm = new DynamicClassForm(className); // replace with class form
                classForm.ShowDialog();
            };

            flowLayoutPanel1.Controls.Add(newClassButton);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            using (AddClass popup = new AddClass())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    string className = popup.ClassName;

                    // 1. Get the index of the add button
                    int index = flowLayoutPanel1.Controls.GetChildIndex(button7);

                    // 2. Create new button
                    Button newClassButton2 = new Button();
                    newClassButton2.Text = className;
                    newClassButton2.Size = button7.Size;
                    newClassButton2.Font = button12.Font;
                    newClassButton2.ForeColor = button12.ForeColor;
                    newClassButton2.AutoSize = button7.AutoSize;

                    newClassButton2.Click += (s, args) =>
                    {
                        var classForm = new DynamicClassForm(className);
                        classForm.ShowDialog();
                    };

                    // 3. Replace in FlowLayoutPanel
                    flowLayoutPanel1.Controls.RemoveAt(index);
                    flowLayoutPanel1.Controls.Add(newClassButton2);
                    flowLayoutPanel1.Controls.SetChildIndex(newClassButton2, index);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Would you like to sign out?", "Confirm Sign Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Login newlogin = new Login();
                newlogin.Show();
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassCat newCat = new ClassCat();
            newCat.Show();
            this.Hide();
        }
    }
}
