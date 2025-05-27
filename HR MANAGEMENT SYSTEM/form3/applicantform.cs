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
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HR_MANAGEMENT_SYSTEM.form3
{
    public partial class applicantform : Form
    {
        private string connectionString;
        public applicantform()
        {
            InitializeComponent();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passed_Click(object sender, EventArgs e)
        {
            SendEvaluationReport(gmail.Text, "Congratulations! You have passed the evaluation process. We will contact you soon for the next steps in your application.");
            MessageBox.Show("Evaluation report sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void SendEvaluationReport(string email, string evaluationReport)
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
                    <html>
                        <head>
                            <style>
                                body {{
                                    font-family: Arial, sans-serif;
                                    background-color: #f4f4f4;
                                    margin: 0;
                                    padding: 20px;
                                }}
                                .email-container {{
                                    background-color: #ffffff;
                                    padding: 20px;
                                    border-radius: 8px;
                                    border: 1px solid #ddd;
                                    width: 100%;
                                    max-width: 600px;
                                    margin: 0 auto;
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
                                <h2>Evaluation Report</h2>
                                <p class='content'>Dear Applicant,</p>
                                <p class='content'>Here is your evaluation report:</p>
                                <p class='content'><strong>{evaluationReport}</strong></p>
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
                    Subject = "Evaluation Report",
                    Body = htmlBody,
                    IsBodyHtml = true
                };

                mail.To.Add(email);

                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applipic_Click(object sender, EventArgs e)
        {

        }
        private void info_Click(object sender, EventArgs e)
        {
        }
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            string applicantFullName = fullname.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT fullname, address, gmail, jobtitle, age, sex, file, image, filepath FROM applicants WHERE fullname LIKE @fullname";
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
                            else //paano ka nag insert ng image? sa db
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void failed_Click(object sender, EventArgs e)
        {
            SendEvaluationReport(gmail.Text, "We regret to inform you that you have not passed the evaluation process. Thank you for your interest in our company.");
            MessageBox.Show("Evaluation report sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}

