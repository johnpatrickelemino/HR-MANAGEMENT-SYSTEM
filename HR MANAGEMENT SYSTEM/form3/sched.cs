using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class sched : Form
    {
        public sched()
        {
            InitializeComponent();
        }

        private void sched_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Format = DateTimePickerFormat.Time;
            guna2DateTimePicker1.ShowUpDown = true;
            guna2DateTimePicker2.Format = DateTimePickerFormat.Short;
            guna2DateTimePicker2.ShowUpDown = false;
            guna2DateTimePicker2.Value = DateTime.Now;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (TimeOnly.TryParse(guna2TextBox2.Text, out TimeOnly userTime))
            {
                guna2DateTimePicker1.Value = DateTime.Today.Add(userTime.ToTimeSpan());
            }
            else
            {
                MessageBox.Show("Invalid time format. Please use HH:mm or hh:mm tt (e.g. 14:30 or 2:30 PM).");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(guna2DateTimePicker2.Text, out DateTime selectedDate))
            {

                guna2DateTimePicker2.Value = selectedDate.Date;
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter a valid date like MM/dd/yyyy.");
            }
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
