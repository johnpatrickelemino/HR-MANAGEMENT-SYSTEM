using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGEMENT_SYSTEM
{
    class Email

    {
        public void SendEmail(string email, string OTP)
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
                                <title>OTP Verification</title>
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
                                    .otp-code {{
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
                                    <h2>🔑 Your One-Time Password (OTP)</h2>
                                    <p>Use the following OTP to verify your identity:</p>
                                    <div class=""otp-code"">{OTP}</div>
                                    <p>This code is valid for 5 minutes.</p>
                                    <p class=""footer"">© 2025 Your Company. All rights reserved.</p>
                                </div>
                            </body>
                            </html>";
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = "OTP",
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
    }
}
