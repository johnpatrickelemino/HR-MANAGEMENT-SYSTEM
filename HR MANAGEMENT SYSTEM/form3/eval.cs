using HR_MANAGEMENT_SYSTEM.form3;
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
            FillComboBox();
        }
        void FillComboBox()
        {
            connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT fullname FROM Applicants;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear();
                        while (reader.Read())
                        {
                           string sName = reader["fullname"].ToString();
                            comboBox1.Items.Add(sName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading databases: " + ex.Message);
                }
            }
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
            applicantform form = new applicantform();
            loadform(new applicantform());
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
