using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class Registration_Form : Form
    {
        SqlConnection con = new SqlConnection("server=ATMECSINLT-698\\SQLEXPRESS;database = db; trusted_connection=true;");
        public Registration_Form()
        {
            InitializeComponent();
        }
        //  VALIDATION FOR PASSWORD.
        public bool ValidatePassword()
        {
            string patternPassword = @"^(?=.*\d)(?=.*[!#$%&'()*+,-./:;<=>?@[\]^_`{|}~])(?=.*[a-z])(?=.*[A-Z]).{8,15}$";

            string a = txt_PSW.Text;
            string b = txt_CP.Text;
            if (a != b)
            {
                MessageBox.Show("Password Mismatch !");
            }
            else if (!string.IsNullOrEmpty(a))
            {
                if (Regex.IsMatch(a, patternPassword))
                {
                    return true;
                }
                else if (!Regex.IsMatch(a, patternPassword))
                {
                    MessageBox.Show("Password must contain an UPPERCASE & lowercase characters, numericals & special characters");

                }
            }
            return false;
        }
        // Validation for Firstname and Lastname
        private bool ValidateFirstName()
        {
            bool name;
            if(txt_FN.Text == "")
            {
                MessageBox.Show("First name should not be empty");
                name = false;
                return name;
            }
            else if (Regex.Match(txt_FN.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                name = true;
            }
            else
            {
                MessageBox.Show(" First name should not contain numbers .");
                name = false;
            }
            return name;
        }

        private bool ValidateLastName()
        {
            bool name;
            if (txt_LN.Text == "")
            {
                MessageBox.Show("LastName should not be empty");
                name = false;
                return name;

            }
            else if (Regex.Match(txt_LN.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                name = true;
            }
            else
            {
                MessageBox.Show(" Lastname should not contain numbers .");
                name = false;
            }
            return name;
        }

        // VALIDATE PHONENUMBER
        private bool ValidateMobilenumber()
        {
            bool number;
            if (txt_MN.Text == "")
            {
                MessageBox.Show("phone number should not be empty");
                number = false;
                return number;
            }
            else if (Regex.Match(txt_MN.Text, (@"^(\d{1,2})?\-?\d{10}$")).Success && txt_MN.Text.Length == 10)
            {
                number = true;
            }
            else
            {
                MessageBox.Show(" phone number is invalid.");
                number = false;
            }
            return number;
        }

        // VALIDATION FOR Emailid
        private bool ValidateEmail()
        {
            bool email;
            if (txt_EId.Text == "")
            {
                MessageBox.Show(" Email should not be empty ");
                email = false;
                return email;
            }
            else if (Regex.Match(txt_EId.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.ECMAScript).Success)
            {
                email = true;
            }
            else
            {
                MessageBox.Show("Ivalid Emailid");
                email = false;
            }
            return email;
        }
             private void Btn_Register_Click(object sender, EventArgs e)
        {
                if (txt_FN.Text == "" || txt_LN.Text == "" || txt_EId.Text == "" || txt_MN.Text == "" || txt_UN.Text == "" || txt_PSW.Text == "" || txt_CP.Text == "")
                {
                    MessageBox.Show("Feilds should not  be empty!!!");
                }


                else if (ValidateFirstName() && ValidateLastName() && ValidatePassword() && ValidateEmail() && ValidateMobilenumber())
                {
                    con.Close();
                    SqlCommand cmd = new SqlCommand("SPRegistration", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", txt_FN.Text);
                    cmd.Parameters.AddWithValue("@lastname", txt_LN.Text);
                    cmd.Parameters.AddWithValue("@Mobilenumber", txt_MN.Text);
                    cmd.Parameters.AddWithValue("Emailid", txt_EId.Text);
                    cmd.Parameters.AddWithValue("@username", txt_UN.Text);
                    cmd.Parameters.AddWithValue("@password", txt_PSW.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Employee details are inserted succesfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Operation was unsuccesfull");


                        Login_form lf = new Login_form();
                        lf.Show();
                    }
                }
            }

        }
    }



     










