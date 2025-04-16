namespace DanceClassBookingSystem
{
    partial class AddClass
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
            txtClassName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(48, 65);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(208, 23);
            txtClassName.TabIndex = 0;
            txtClassName.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(112, 108);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 38);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter New Class Name";
            // 
            // AddClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 211, 245);
            ClientSize = new Size(315, 172);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtClassName);
            Name = "AddClass";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClassName;
        private Button button1;
        private Label label1;
    }
}