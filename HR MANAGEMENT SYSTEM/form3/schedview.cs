using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;

namespace HR_MANAGEMENT_SYSTEM.form3
{
    public partial class schedview : Form
    {
        public schedview()
        {
            InitializeComponent();
        }

        private void schedview_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            string applicantFullName = fullname.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT fullname, address, gmail, jobtitle, age, sex, file, image FROM applicants WHERE fullname LIKE @fullname";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fullname", "%" + applicantFullName + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fullname.Text = reader["fullname"].ToString();
                                address.Text = reader["address"].ToString();
                                gmail.Text = reader["gmail"].ToString();
                                jobtitle.Text = reader["jobtitle"].ToString();
                                age.Text = reader["age"].ToString();
                                sex.Text = reader["sex"].ToString();
                                if (reader["image"] != DBNull.Value)
                                {
                                    byte[] imageBytes = (byte[])reader["image"];
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        applipic.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Applicant not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gmail_TextChanged(object sender, EventArgs e)
        {

        }
        public static void Sendsched(string email, string Schedule, string stage, string Time)
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

                string htmlBody = $@"
            <html>
                <head>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            background-color: #f4f4f4;
                            padding: 20px;
                        }}
                        .email-container {{
                            background-color: #ffffff;
                            padding: 20px;
                            border-radius: 8px;
                            border: 1px solid #ddd;
                            max-width: 600px;
                            margin: auto;
                        }}
                        h2 {{
                            color: #333;
                            text-align: center;
                        }}
                        .content {{
                            font-size: 16px;
                            line-height: 1.5;
                            color: #555;
                        }}
                        .footer {{
                            font-size: 12px;
                            color: #888;
                            text-align: center;
                            margin-top: 20px;
                        }}
                    </style>
                </head>
                <body>
                    <div class='email-container'>
                        <h2>Interview Scheduled</h2>
                        <p class='content'>Dear Applicant,</p>
                        <p class='content'>We are pleased to inform you that your interview has been scheduled.</p>
                        <p class='content'><strong>{stage}:</strong></p>
                        <p class='content'><strong>Date:</strong> {Schedule}</p>
                        <p class='content'><strong>Time:</strong> {Time}</p>
                        <p class='content'>Please ensure to be available at the given time. We look forward to meeting you!</p>
                        <div class='footer'>
                            <p>Best regards,</p>
                            <p>Collegio de montalban</p>
                        </div>
                    </div>
                </body>
            </html>";

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = "Interview Schedule",
                    Body = htmlBody,
                    IsBodyHtml = true
                };

                mail.To.Add(email);
                client.Send(mail);

                Console.WriteLine("HTML Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sched_Load(object sender, EventArgs e)
        {
            var recruitment = new List<Recruitment> {
        new Recruitment() { id = 1, recruitment = "initial interview" },
        new Recruitment() { id = 2, recruitment = "demo" },
        new Recruitment() { id = 3, recruitment = "final interview" }
    };

            comboBox1.DataSource = recruitment;
            comboBox1.DisplayMember = "recruitment";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = 0;
            guna2DateTimePicker1.Format = DateTimePickerFormat.Time;
            guna2DateTimePicker1.ShowUpDown = true;
            guna2DateTimePicker2.Format = DateTimePickerFormat.Short;
            guna2DateTimePicker2.ShowUpDown = false;
            guna2DateTimePicker2.Value = DateTime.Now;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              string stage = comboBox1.SelectedValue.ToString();
        
        }

       

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (TimeOnly.TryParse(textBox1.Text, out TimeOnly userTime))
            {
                guna2DateTimePicker1.Value = DateTime.Today.Add(userTime.ToTimeSpan());
            }
            else
            {
                MessageBox.Show("Invalid time format. Please use HH:mm or hh:mm tt (e.g. 14:30 or 2:30 PM).");
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string date = guna2DateTimePicker1.Value.ToString("MM/dd/yyyy");
            string Time = guna2DateTimePicker2.Value.ToString("HH:mm"); // Ensures 24-hour format
            string Schedule = $"{date} {Time}";
            string stage = comboBox1.SelectedItem.ToString();
            Sendsched(gmail.Text, Schedule, stage, Time);
            MessageBox.Show("Schedule sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
