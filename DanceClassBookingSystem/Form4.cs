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
    public partial class Reminders : Form
    {

        private class Reminder
        {
            public string Text { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }

            public override string ToString()
            {
                DateTime now = DateTime.Now;
                string status = FormatDueDate(DueDate, now);
                string display = $"{Text} - Due: {status}";

                if (DueDate <= now.AddMinutes(60))
                    return "⚠ " + display;
                else
                    return display;
            }

            private static string FormatDueDate(DateTime dueDate, DateTime now)
            {
                TimeSpan timeLeft = dueDate - now;

                if (timeLeft.TotalMinutes <= 0)
                    return "❗ EXPIRED";
                else if (timeLeft.TotalMinutes <= 60)
                    return "⏳ SOON";
                else if (timeLeft.TotalHours < 24)
                    return $"in {Math.Floor(timeLeft.TotalHours)} hours";
                else
                    return $"on {dueDate:MMM dd, yyyy hh:mm tt}";
            }
        }



        private List<Reminder> reminders = new List<Reminder>();

        public Reminders()
        {
            InitializeComponent();

            // Ensure the ListBox is selectable
            listReminders.SelectionMode = SelectionMode.One;
            listReminders.Enabled = true;
            listReminders.TabStop = true;

            // Hook up event handlers
            listReminders.MouseClick += listReminders_MouseClick;
            button9.Click += button9_Click;
            reminderTimer.Tick += reminderTimer_Tick;
            reminderTimer.Start();
        }



        private void listReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reminder selectedreminder = listReminders.SelectedItem as Reminder;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReminder.Text))
            {
                MessageBox.Show("Please enter a reminder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the reminder to the list
            reminders.Add(new Reminder
            {
                Text = txtReminder.Text,
                Description = txtDescription.Text, // Store the description
                DueDate = dtpDueDate.Value // Date and time from DateTimePicker
            });

            txtReminder.Clear();
            txtDescription.Clear(); // Clear description after adding
            UpdateListBox();
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            // Refresh only the ListBox items text without clearing them
            for (int i = 0; i < listReminders.Items.Count; i++)
            {
                if (listReminders.Items[i] is Reminder reminder)
                {
                    listReminders.Items[i] = reminder; // This will trigger ToString() to update the display
                }
            }
        }


        private void UpdateListBox()
        {
            listReminders.Items.Clear();

            // Sort reminders before displaying
            foreach (var reminder in reminders.OrderBy(r => r.DueDate))
            {
                listReminders.Items.Add(reminder); // Add Reminder object itself
            }
        }


        private string FormatDueDate(DateTime dueDate, DateTime now)
        {
            TimeSpan timeLeft = dueDate - now;

            if (timeLeft.TotalMinutes <= 0)
                return "❗ EXPIRED";
            else if (timeLeft.TotalMinutes <= 60)
                return "⏳ SOON";
            else if (timeLeft.TotalHours < 24)
                return $"in {Math.Floor(timeLeft.TotalHours)} hours";
            else
                return $"on {dueDate:MMM dd, yyyy hh:mm tt}";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listReminders.SelectedItem is Reminder selectedReminder)
            {
                // Remove the selected reminder
                reminders.Remove(selectedReminder);

                // Update display
                UpdateListBox();

                // Exit early if nothing left
                if (reminders.Count == 0)
                {
                    txtDescription.Clear();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select a reminder to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (listReminders.SelectedItem is Reminder selectedReminder)
            {
                MessageBox.Show(
                    $"Reminder: {selectedReminder.Text}\n\nDescription:\n{selectedReminder.Description}",
                    "Reminder Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Please select a reminder to view.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listReminders_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listReminders.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                listReminders.SelectedIndex = index; // Select the clicked item
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassCat newForm = new ClassCat();
            newForm.Show();
            this.Hide();
        }

        private void Reminders_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
