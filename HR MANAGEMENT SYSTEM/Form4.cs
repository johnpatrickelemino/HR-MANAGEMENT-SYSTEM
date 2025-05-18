using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Form4 : Form
    {
        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new Dictionary<string, (string, DateTime)>();
        public Form4()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string email = emailt.Text;
            string userOTP = guna2TextBox2.Text;
            string otp = otpStorage.ContainsKey(email) ? otpStorage[email].otp : null;
           
            if(HR_MANAGEMENT_SYSTEM.OTP.VerifyOtp(email, userOTP))
            {
                MessageBox.Show("OTP verified successfully.");
                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }

           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
          


           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = emailt.Text;
            HR_MANAGEMENT_SYSTEM.OTP.SendOtp(email);




        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}

