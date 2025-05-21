using HR_MANAGEMENT_SYSTEM.form3;
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
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "Members";
            if (comboBox1.SelectedItem is members mem)
            {
                if (mem.id == 0)
                {
                    panel1.Visible = false;
                    return;
                }
                panel1.Visible = true;
                switch (mem.m)
                {
                    case "Kim Camille manggay":
                        loadform(new kim());
                        break;
                    case "John patrick elemino":
                        loadform(new hyug());
                        break;
                    case "Eurika mae bolivar":
                        loadform(new Euri());
                        break;
                    case "Erika mae corvera":
                        loadform(new Erika());
                        break;
                    case "Henlyn fruto":
                        loadform(new frutos());
                        break;
                    default:
                        MessageBox.Show("Unknown member.");
                        break;
                }
            }
        }



        private void aboutus_Load(object sender, EventArgs e)
        {
            var mem = new List<members> {
        new members() { id = 1, m = "Kim Camille manggay" },
        new members() { id = 2, m = "John patrick elemino" },
        new members() { id = 3, m = "Eurika mae bolivar" },
        new members() { id = 4, m = "Erika mae corvera" },
        new members() { id = 5, m = "Henlyn fruto" }
    };

            comboBox1.DataSource = mem;
            comboBox1.DisplayMember = "m";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = 0;

            panel1.Visible = false;
        }
    }
}