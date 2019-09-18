using System;

using System.Windows.Forms;
using System.Configuration;
namespace Sample
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //I have to accept user name and  password and check them with app.config credentials
            //if the credentials are satify with given input, then we have to go to Calculate Form
       
            if (textBox1.Text ==ConfigurationSettings.AppSettings["userName"].ToString()  && textBox2.Text == ConfigurationSettings.AppSettings["password"].ToString())
            {
                Calculator calculator = new Calculator();
                
                calculator.Show();
            }
            else
            {
                MessageBox.Show("Please Enter userName and Password");
            }
        }
    }
}
