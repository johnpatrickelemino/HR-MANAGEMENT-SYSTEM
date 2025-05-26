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

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class eval : Form
    {
        private string connectionString;
        public eval()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.showPanel.Controls.Count > 0)
                this.showPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.showPanel.Controls.Add(f);
            this.showPanel.Tag = f;
            f.Show();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=hr;uid=root;pwd=your_password;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT fullname FROM applicants";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear(); // Clear previous items if any

                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["fullname"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading fullnames: " + ex.Message);
                }
            }
            applicantform form = new applicantform();
            loadform(new applicantform());
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
