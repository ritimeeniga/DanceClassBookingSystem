namespace DanceClassBookingSystem
{
    partial class Reminders
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            dtpDueDate = new DateTimePicker();
            txtDescription = new TextBox();
            label4 = new Label();
            button9 = new Button();
            txtReminder = new TextBox();
            label3 = new Label();
            button7 = new Button();
            listReminders = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            reminderTimer = new System.Windows.Forms.Timer(components);
            button8 = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 32);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 6;
            label1.Text = "REMINDERS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dtpDueDate);
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(txtReminder);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(listReminders);
            panel3.Location = new Point(307, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 468);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Microsoft JhengHei UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 389);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 9;
            label5.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(16, 414);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(189, 23);
            dtpDueDate.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(243, 342);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(321, 68);
            txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Microsoft JhengHei UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 317);
            label4.Name = "label4";
            label4.Size = new Size(143, 22);
            label4.TabIndex = 6;
            label4.Text = "Add Description:";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(223, 211, 245);
            button9.Location = new Point(423, 416);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 5;
            button9.Text = "REMOVE";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // txtReminder
            // 
            txtReminder.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReminder.Location = new Point(16, 342);
            txtReminder.Name = "txtReminder";
            txtReminder.Size = new Size(189, 33);
            txtReminder.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Microsoft JhengHei UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 317);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 2;
            label3.Text = "Reminder:";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(223, 211, 245);
            button7.Location = new Point(329, 416);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 1;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // listReminders
            // 
            listReminders.BackColor = Color.WhiteSmoke;
            listReminders.FormattingEnabled = true;
            listReminders.ItemHeight = 15;
            listReminders.Location = new Point(16, 22);
            listReminders.Name = "listReminders";
            listReminders.Size = new Size(562, 274);
            listReminders.TabIndex = 0;
            listReminders.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(linkLabel5);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(73, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 468);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-207, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(405, 245);
            button6.Name = "button6";
            button6.Size = new Size(159, 198);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(221, 243);
            button5.Name = "button5";
            button5.Size = new Size(159, 198);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(35, 243);
            button4.Name = "button4";
            button4.Size = new Size(159, 198);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(405, 32);
            button3.Name = "button3";
            button3.Size = new Size(159, 198);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(221, 32);
            button2.Name = "button2";
            button2.Size = new Size(159, 198);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(35, 32);
            button1.Name = "button1";
            button1.Size = new Size(159, 198);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(3, 442);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(67, 15);
            linkLabel5.TabIndex = 5;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "User Profile";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel4.Location = new Point(12, 342);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(153, 24);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Class Catalogue";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkVisited = true;
            linkLabel3.Location = new Point(40, 264);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(107, 24);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Reminders";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(56, 117);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(65, 24);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Home";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(14, 190);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(153, 24);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Student Profiles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 27);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 0;
            label2.Text = "QUICK LINKS";
            // 
            // reminderTimer
            // 
            reminderTimer.Tick += reminderTimer_Tick;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(223, 211, 245);
            button8.Location = new Point(489, 262);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 10;
            button8.Text = "View";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Reminders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 245);
            ClientSize = new Size(975, 584);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Reminders";
            Text = "Reminders";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Button button9;
        private TextBox txtReminder;
        private Label label3;
        private Button button7;
        private ListBox listReminders;
        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label5;
        private DateTimePicker dtpDueDate;
        private TextBox txtDescription;
        private Label label4;
        private System.Windows.Forms.Timer reminderTimer;
        private Button button8;
    }
}