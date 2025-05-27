using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Form3 : Form
    {
        public bool islogin = true;
        public Form3()
        {
            InitializeComponent();
        }
        string pin = "1234";
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
            MessageBox.Show("enter pin to access the system", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string pin = Microsoft.VisualBasic.Interaction.InputBox("Enter PIN", "PIN", "", -1, -1);
            if (pin == this.pin)
            { 
                loadform(new eval());
            }
            else
            {
                MessageBox.Show("Access denied", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            if (islogin == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("You are not logged in.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
            MessageBox.Show("enter pin to access the system", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string pin = Microsoft.VisualBasic.Interaction.InputBox("Enter PIN", "PIN", "", -1, -1);
            if (pin == this.pin)
            {
                loadform(new sched());
            }
            else
            {
                MessageBox.Show("Access denied", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewabtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter pin to access the system", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string pin = Microsoft.VisualBasic.Interaction.InputBox("Enter PIN", "PIN", "", -1, -1);
            if (pin == this.pin)
            {
               loadform(new view());
            }
            else
            {
                MessageBox.Show("Access denied", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
