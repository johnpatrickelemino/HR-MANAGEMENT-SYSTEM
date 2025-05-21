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

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Professor : Form
    {
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
            Connection conn = new Connection();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
