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
    public partial class view : Form
    {
        private string connectionString; 
        public view()
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
                    string query = "SELECT DISTINCT fullname FROM Applicants ORDER BY fullname ASC;";
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
                }// yung mismong applicant ba or yung database pano magdadag ng applicant?
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading databases: " + ex.Message);
                }
            }
        }

        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }
       

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadform(new viewform());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
