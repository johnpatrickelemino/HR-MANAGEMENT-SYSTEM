using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
