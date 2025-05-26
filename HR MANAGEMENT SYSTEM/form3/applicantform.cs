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
            string connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT image FROM Applicants WHERE fullname = @fullname;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullname", fullname);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                byte[] imgData = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    applipic.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No image found for this applicant.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
  
    }
}
