using Guna.UI2.WinForms;
using HR_MANAGEMENT_SYSTEM.form3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class sched : Form
    {
        string connectionString;
        public sched()
        {
            InitializeComponent();
            FillComboBox();
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
      
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

}
        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
        
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedName = comboBox1.SelectedItem.ToString();
                ShowApplicantDetails(selectedName);
                loadform(new schedview());
            }
        }
            void ShowApplicantDetails(string fullName)
            {
                string connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM Applicants WHERE fullname = @fullname";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@fullname", fullName);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                 string Name = reader["fullname"].ToString();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving details: " + ex.Message);
                    }//ano ba yun?weatch iisang info lang yung lumalabas 

                }//ok namn huh ibang pic yung nasa isa 
            }//baka naman na parehas mo
    }
}
