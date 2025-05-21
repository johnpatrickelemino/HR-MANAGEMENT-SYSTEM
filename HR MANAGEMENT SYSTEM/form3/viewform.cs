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
    public partial class viewform : Form
    {
        public viewform()
        {
            InitializeComponent();
        }

        private void passed_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                string selectedItem = checkedListBox1.SelectedItem.ToString();
                MessageBox.Show("Selected item: " + selectedItem);
            }
        }
    }
}
