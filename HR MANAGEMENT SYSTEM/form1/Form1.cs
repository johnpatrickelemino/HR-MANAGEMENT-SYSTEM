using research;
using System.Runtime.CompilerServices;

namespace HR_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        bool islogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void applicantform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Applicantform form = new Applicantform();
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void applicantbuton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Applicantform form = new Applicantform();
            form.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (!islogin)
            {

                Connection conn = new Connection();
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                if (conn.loginform(username, password))
                {
                    MessageBox.Show("login success");
                    islogin = true;
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                    if (form3.IsDisposed)
                    {
                        Form1 form1 = new Form1();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("login failed");

                }
            }
            else
            {
                MessageBox.Show("You are already logged in");
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
