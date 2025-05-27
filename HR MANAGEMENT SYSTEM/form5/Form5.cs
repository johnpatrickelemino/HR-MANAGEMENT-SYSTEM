using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Form5 : Form
    {
        private string connectionString;
        public Form5()
        {
            InitializeComponent();
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string username = guna2TextBox1.Text; 
                string newPassword = guna2TextBox3.Text;
                string confirmNewPassword = guna2TextBox2.Text;

                if (newPassword == confirmNewPassword)
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE admin SET password = @newPassword WHERE username = @username";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                            updateCmd.Parameters.AddWithValue("@username", username);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password changed successfully");
                            }
                            else
                            {
                                MessageBox.Show("Password change failed. Username may not exist.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
