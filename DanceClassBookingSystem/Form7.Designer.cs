namespace DanceClassBookingSystem
{
    partial class BalletClass
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
            txtStudentName = new TextBox();
            label3 = new Label();
            button7 = new Button();
            listBox1 = new ListBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button9);
            panel3.Controls.Add(txtStudentName);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(2, -9);
            panel3.Name = "panel3";
            panel3.Size = new Size(593, 468);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            panel3.DoubleClick += panel3_DoubleClick;
            panel3.Leave += panel3_Leave;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(223, 211, 245);
            button9.Location = new Point(97, 416);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 5;
            button9.Text = "REMOVE";
            button9.UseVisualStyleBackColor = false;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentName.Location = new Point(16, 371);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(377, 33);
            txtStudentName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Microsoft JhengHei UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 346);
            label3.Name = "label3";
            label3.Size = new Size(175, 22);
            label3.TabIndex = 2;
            label3.Text = "Enter Student Name ";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(223, 211, 245);
            button7.Location = new Point(16, 416);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
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
            // BalletClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "BalletClass";
            Text = "Form7";
            FormClosing += BalletClass_FormClosing;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button9;
        private TextBox txtStudentName;
        private Label label3;
        private Button button7;
        private ListBox listBox1;
    }
}