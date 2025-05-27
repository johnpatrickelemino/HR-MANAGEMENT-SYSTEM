using Guna.UI2.WinForms;
using research;
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
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Utilities.Encoders;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Professor : Form
    {
        private string connectionString;
        public Professor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
                Title = "Select a PDF File"
            };

            if (File.ShowDialog() == DialogResult.OK)
            {
                string selectedPdfPath = File.FileName;

                guna2TextBox5.Text = selectedPdfPath;

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
                Title = "Select a PDF File"
            };

            if (File.ShowDialog() == DialogResult.OK)
            {
                string selectedPdfPath = File.FileName;

                guna2TextBox6.Text = selectedPdfPath;

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
                Title = "Select a PDF File"
            };

            if (File.ShowDialog() == DialogResult.OK)
            {
                string selectedPdfPath = File.FileName;

                guna2TextBox7.Text = selectedPdfPath;

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*",
                Title = "Select a PDF File"
            };

            if (File.ShowDialog() == DialogResult.OK)
            {
                string selectedPdfPath = File.FileName;

                guna2TextBox8.Text = selectedPdfPath;

            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            connectionString = "Server=localhost;Database=hr;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                Connection conn = new Connection();
                string diplomaFile = guna2TextBox5.Text;
                string licenseFile = guna2TextBox6.Text;
                string transcriptFile = guna2TextBox7.Text;
                string validIdFile = guna2TextBox8.Text;
                if (string.IsNullOrWhiteSpace(diplomaFile) ||
               string.IsNullOrWhiteSpace(licenseFile) ||
               string.IsNullOrWhiteSpace(transcriptFile) ||
               string.IsNullOrWhiteSpace(validIdFile))
                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string fileQuery = @"INSERT INTO Professor_files (diplomaFile, licenseFile, transcriptFile, valididFile) VALUES (@diplomaFile, @licenseFile, @transcriptFile, @validIdFile)";
                using (MySqlCommand cmd = new MySqlCommand(fileQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@diplomaFile", diplomaFile);
                    cmd.Parameters.AddWithValue("@licenseFile", licenseFile);
                    cmd.Parameters.AddWithValue("@transcriptFile", transcriptFile);
                    cmd.Parameters.AddWithValue("@validIdFile", validIdFile);
                    cmd.ExecuteNonQuery();
                }
                int result = 0;
                if (result > 0)
                {
                    MessageBox.Show("Failed to save application.");
                }
                else
                {
                    MessageBox.Show("Application saved successfully!");
                }
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
