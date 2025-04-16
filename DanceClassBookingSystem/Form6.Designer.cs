namespace DanceClassBookingSystem
{
    partial class JazzClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            button9 = new Button();
            button7 = new Button();
            listBox1 = new ListBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(0, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 409);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(223, 211, 245);
            button9.Location = new Point(150, 333);
            button9.Name = "button9";
            button9.Size = new Size(117, 37);
            button9.TabIndex = 5;
            button9.Text = "REMOVE";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(223, 211, 245);
            button7.Location = new Point(16, 333);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 1;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.WhiteSmoke;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(562, 274);
            listBox1.TabIndex = 0;
            // 
            // JazzClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 245);
            ClientSize = new Size(591, 393);
            Controls.Add(panel3);
            Name = "JazzClass";
            Text = "JazzClass";
            FormClosing += JazzClass_FormClosing;
            Load += Form6_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button9;
        private Button button7;
        private ListBox listBox1;
    }
}