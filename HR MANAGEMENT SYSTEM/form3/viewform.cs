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
        private void SaveCheckedItems()
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedItems.Add(item.ToString());
            }
            string result = string.Join(", ", checkedItems);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(SaveCheckedItems));
         }
     }
}
