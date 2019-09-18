using System;
using System.Configuration;
using System.Windows.Forms;

namespace Employeeinfo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ConfigurationSettings.AppSettings["UserName"] && textBox2.Text == ConfigurationSettings.AppSettings["Password"])
            {
                Employeeinfo emp = new Employeeinfo();
                emp.Show();
            }
            else
            {
                MessageBox.Show("Enter valid credentials");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}


