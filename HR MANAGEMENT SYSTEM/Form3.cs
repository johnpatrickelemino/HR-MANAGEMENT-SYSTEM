using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            sidebartransit.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new eval());
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {

        }
        bool menuexpand = false;
        private void menutransits_Tick(object sender, EventArgs e)
        {
            if (menuexpand == false)
            {
                flowLayoutPanel2.Height += 10;
                if (flowLayoutPanel2.Height >= 200)
                {

                    menutransits.Stop();
                    menuexpand = true;
                }
            }
            else
            {
                flowLayoutPanel2.Height -= 10;
                if (flowLayoutPanel2.Height <= 50)
                {
                    menutransits.Stop();
                    menuexpand = false;

                }
            }

        
        }
        bool sidebarExpand = true;
        private void sidebartransit_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width <= 36)
                {
                    sidebarExpand = false;
                    sidebartransit.Stop();

                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width >= 183)
                {
                    sidebarExpand = true;
                    sidebartransit.Stop();

                }
            }
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            loadform(new aboutus());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menutransits.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void schedbtn_Click(object sender, EventArgs e)
        {
            loadform(new sched());



        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewabtn_Click(object sender, EventArgs e)
        {
            loadform(new view());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new dashboard());
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
