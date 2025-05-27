using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

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
            CheckedListBox checkedListBox1 = new CheckedListBox();
            checkedListBox1.Location = new Point(20, 60);
            checkedListBox1.Size = new Size(200, 100);
            checkedListBox1.Items.Add("Passed");
            checkedListBox1.CheckOnClick = true;
            this.Controls.Add(checkedListBox1);
        }

        private void applipic_Click(object sender, EventArgs e)
        {

        }
        private void info_Click(object sender, EventArgs e)
        {
        }
        private string currentFilePath;
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
                                currentFilePath = reader["filepath"].ToString();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(currentFilePath) && File.Exists(currentFilePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = currentFilePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Resume file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

