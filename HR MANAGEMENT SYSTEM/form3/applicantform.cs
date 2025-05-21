using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_MANAGEMENT_SYSTEM.form3
{
    public partial class applicantform : Form
    {
        public applicantform()
        {
            InitializeComponent();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passed_Click(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox1 = new CheckedListBox();
            checkedListBox1.Location = new Point(20, 60); 
            checkedListBox1.Size = new Size(200, 100);
            checkedListBox1.Items.Add("Passed");
            checkedListBox1.CheckOnClick = true;
            this.Controls.Add(checkedListBox1);
        }
    }
}
