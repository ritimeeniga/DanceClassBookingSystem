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
    public partial class AddClass : Form
    {
        public string ClassName { get; private set; }  // ✅ This is what ClassCatalogueForm reads

        public AddClass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtClassName.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a class name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClassName = input;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
