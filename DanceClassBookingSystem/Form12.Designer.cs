namespace DanceClassBookingSystem
{
    partial class DynamicClassForm
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
            listBox1 = new ListBox();
            button9 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(75, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(562, 274);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(223, 211, 245);
            button9.Location = new Point(209, 362);
            button9.Name = "button9";
            button9.Size = new Size(117, 37);
            button9.TabIndex = 8;
            button9.Text = "REMOVE";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(223, 211, 245);
            button7.Location = new Point(75, 362);
            button7.Name = "button7";
            button7.Size = new Size(117, 37);
            button7.TabIndex = 7;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // DynamicClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(listBox1);
            Name = "DynamicClassForm";
            Text = "Form12";
            Load += DynamicClassForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button9;
        private Button button7;
    }
}