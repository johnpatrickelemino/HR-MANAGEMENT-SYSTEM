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
            applicantform form = new applicantform();
            loadform(new applicantform());
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
