using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentaNova2
{
    public partial class SelectDateTime : Form
    {
        private string selectedTime = "";

        private Dictionary<DateTime, List<string>> bookedSlots =
            new Dictionary<DateTime, List<string>>();
        public SelectDateTime()
        {
            InitializeComponent();
        }

        private void SelectDateTime_Load(object sender, EventArgs e)
        {
            bookedSlots.Add(
        new DateTime(2026, 6, 8),
        new List<string>()
        {
            "9:00 AM",
            "10:00 AM"
        });

            LoadAvailableSlots(monthCalendar1.SelectionStart);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadAvailableSlots(e.Start);
        }

        private void LoadAvailableSlots(DateTime selectedDate)
        {
            flowTimeSlots.Controls.Clear();

            DayOfWeek day = selectedDate.DayOfWeek;

            if (day == DayOfWeek.Sunday)
            {
                Label lbl = new Label();
                lbl.Text = "Closed on Sunday";
                lbl.AutoSize = true;

                flowTimeSlots.Controls.Add(lbl);
                return;
            }

            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime;

            if (day == DayOfWeek.Saturday)
                endTime = new TimeSpan(13, 0, 0);
            else
                endTime = new TimeSpan(17, 0, 0);

            List<string> booked = new List<string>();

            if (bookedSlots.ContainsKey(selectedDate.Date))
                booked = bookedSlots[selectedDate.Date];

            while (startTime < endTime)
            {
                if (!(startTime >= new TimeSpan(13, 0, 0)
                    && startTime < new TimeSpan(14, 0, 0)))
                {
                    string slot =
                        DateTime.Today.Add(startTime)
                        .ToString("h:mm tt");

                    if (!booked.Contains(slot))
                    {
                        Button btn = new Button();

                        btn.Text = slot;
                        btn.Width = 100;
                        btn.Height = 40;

                        btn.Click += TimeSlot_Click;

                        flowTimeSlots.Controls.Add(btn);
                    }
                }

                startTime = startTime.Add(
                    TimeSpan.FromMinutes(30));
            }
        }

        private void TimeSlot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            selectedTime = btn.Text;

            foreach (Control control in flowTimeSlots.Controls)
            {
                if (control is Button)
                    control.BackColor = SystemColors.Control;
            }

            btn.BackColor = Color.LightGreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedTime == "")
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            DateTime selectedDate = monthCalendar1.SelectionStart;

            MessageBox.Show(
                "Selected Date: " +
                selectedDate.ToShortDateString() +
                "\nSelected Time: " +
                selectedTime);
        }
    }
}
