using Guna.UI2.WinForms;
using HR_MANAGEMENT_SYSTEM.form3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.Net;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class sched : Form
    {
        string connectionString;
        public sched()
        {
            InitializeComponent();
            FillComboBox();
        }
        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }
        void FillComboBox()
        {
            connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT fullname FROM Applicants;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear();
                        while (reader.Read())
                        {
                            string sName = reader["fullname"].ToString();
                            comboBox1.Items.Add(sName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading databases: " + ex.Message);
                }
            }
        }
        private void sched_Load(object sender, EventArgs e)
        {
            var recruitment = new List<Recruitment> {
        new Recruitment() { id = 1, recruitment = "initial interview" },
        new Recruitment() { id = 2, recruitment = "demo" },
        new Recruitment() { id = 3, recruitment = "final interview" }
    };

            comboBox2.DataSource = recruitment;
            comboBox2.DisplayMember = "recruitment";
            comboBox2.ValueMember = "id";
            comboBox2.SelectedIndex = 0;
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

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SendEmail(string email, string OTP)
        {

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        public void Sendemail(string email, string Sched)
        {
            try
            {
                string senderEmail = "johnpatrickelemino@gmail.com";
                string senderPassword = "hhju ltxf lbiv bxzb";

                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                string htmlBody = @$"
<html lang=""en"">
    <head> 
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <title>Your Schedule</title>
        <style>
            body {{
                font-family: Arial, sans-serif;
                background-color: #f4f4f4;
                padding: 20px;
                text-align: center;
            }}
            .email-container {{
                max-width: 500px;
                background: #fff;
                padding: 20px;
                border-radius: 8px;
                box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
                margin: auto;
            }}
            .schedule {{
                font-size: 24px;
                font-weight: bold;
                color: #333;
                padding: 10px;
                background: #e0e0e0;
                border-radius: 5px;
                display: inline-block;
                margin: 10px 0;
            }}
            .footer {{
                font-size: 12px;
                color: #666;
                margin-top: 20px;
            }}
        </style>
    </head>
    <body>
        <div class=""email-container"">
            <h2>📅 Your Schedule</h2>
            <div class=""schedule"">{Sched}</div>

            <p class=""footer"">© 2025 Your Company. All rights reserved.</p>
        </div>
    </body>
</html>";

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = "Schedule",
                    Body = htmlBody,
                    IsBodyHtml = true
                };

                mail.To.Add(email);

                client.Send(mail);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            schedview form = new schedview();
            loadform(new schedview());
        }
    }
}
