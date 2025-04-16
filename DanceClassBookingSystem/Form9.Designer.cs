namespace DanceClassBookingSystem
{
    partial class BallroomClass
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
            panel3.Location = new Point(1, -9);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 408);
            panel3.TabIndex = 4;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(223, 211, 245);
            button9.Location = new Point(157, 332);
            button9.Name = "button9";
            button9.Size = new Size(117, 37);
            button9.TabIndex = 5;
            button9.Text = "REMOVE";
            button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(223, 211, 245);
            button7.Location = new Point(16, 332);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 1;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
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
            // BallroomClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 381);
            Controls.Add(panel3);
            Name = "BallroomClass";
            Text = "Form9";
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