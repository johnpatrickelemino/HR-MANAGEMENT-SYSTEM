using Guna.UI2.WinForms;
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
    public partial class applicantform : Form
    {
        public applicantform()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

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

                guna2TextBox2.Text = selectedPdfPath;

            }


        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void fullnamebtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void gmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "jpg.files|*.jpg|png.files|*.png|All files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.ImageLocation = open.FileName;
            }
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jobtitleBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Job Title";
            if (comboBox1.SelectedItem is jobtitle Job)
            {
                if (Job.id == 0)
                {
                    mainpanel.Visible = false;
                    return;
                }
                mainpanel.Visible = true;
                switch (Job.job)
                    {
                        case "Professor":
                            loadform(new Professor());
                            break;
                        case "Nurse":
                            loadform(new nurse());
                            break;
                        case "Librarian":
                            loadform(new librarian());
                            break;
                        default:
                            MessageBox.Show("Unknown job title selected.");
                            break;
                    }
             }
        }

        private void applicantform_Load(object sender, EventArgs e)
        {
            var job = new List<jobtitle> {
        new jobtitle() { id = 1, job = "Professor" },
        new jobtitle() { id = 2, job = "Nurse" },
        new jobtitle() { id = 3, job = "Librarian" }
    };

            comboBox1.DataSource = job;
            comboBox1.DisplayMember = "job";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = 0;

            mainpanel.Visible = false;
        }
    }
}
