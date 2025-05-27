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
    public partial class viewform : Form
    {
        public viewform()
        {
            InitializeComponent();
        }

        private void passed_Click(object sender, EventArgs e)
        {

        }
        private void SaveCheckedItems()
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }
            string result = string.Join(", ", checkedItems);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(SaveCheckedItems));
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
                    string query = "SELECT fullname, address, gmail, jobtitle, age, sex, file, image FROM applicants WHERE fullname LIKE @fullname";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fullname", "%" + applicantFullName + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
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
