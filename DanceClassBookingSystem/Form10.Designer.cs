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
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(368, 133);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(100, 23);
            txtClassName.TabIndex = 0;
            txtClassName.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(375, 255);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}