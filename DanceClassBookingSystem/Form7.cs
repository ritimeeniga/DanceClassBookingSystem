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
    public partial class BalletClass : Form
    {
        public BalletClass()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel3_Leave(object sender, EventArgs e)
        {

        }

        private void BalletClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the user clicked the X (not calling Close() from code)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close
                this.Hide();     // Hide the form instead
            }
        }
    }
}
