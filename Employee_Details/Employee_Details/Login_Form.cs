using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        private void txt_UserNameEnter(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "Enter your Username")
            {
                txt_UserName.Text ="";
                txt_UserName.ForeColor = Color.Black;
            }
        }
        private void txt_UsernameLeave(object sender, EventArgs e)
        {
            if (txt_UserName.Text =="")
            {
                txt_UserName.Text = "Enter your Username";
                txt_UserName.ForeColor = Color.Silver;
            }

        }

        private void txt_PasswordEnter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Enter your Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.Black;

            }
        }

        private void txt_PasswordLeave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Enter your Password ";
                txt_Password.ForeColor = Color.Silver;
            }
        }
          private void Lnk_lbl_NewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form rf = new Registration_Form();
            rf.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Password = string.IsNullOrWhiteSpace(txt_Password.Text).ToString();

            if (string.IsNullOrWhiteSpace(txt_UserName.Text))
            {
                string Username = txt_UserName.Text;
            }
            if (!string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                SqlConnection conn = new SqlConnection("Server=ATMECSINLT-698\\SQLEXPRESS;database=db;Trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("SELECT * from Registration WHERE Username='" + txt_UserName.Text + "' and Password='" + txt_Password.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               // checking whether datatable has any rows or not
                    if (dt.Rows.Count == 1)
                {
                  employeegrid ed = new employeegrid();
                    ed.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter valid username and password");

                }
            }
        }
    }
    }



   














