using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class employeegrid : Form
    {
        SqlConnection con = new SqlConnection("server=ATMECSINLT-698\\SQLEXPRESS;database=db;trusted_connection=true;");
        EmployeeUpdation eu = new EmployeeUpdation();
        private object txt_id;

        public employeegrid()
        {
            InitializeComponent();
            GetEmployeedetails();
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            Employeedatabase db = new Employeedatabase(null) ;
            db.Show();
            this.Hide();
        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPDeleteEmployeedetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", Convert.ToInt32(txt_id));
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                MessageBox.Show("Employee details are deleted succesfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation was unsuccesfull");
            }
        }
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (eu != null)
            {
                Employeedatabase e1 = new Employeedatabase(eu);
                e1.Show();
                this.Hide();
            }
        }
        private void GetEmployeedetails()
        {
            SqlCommand cmd = new SqlCommand("SPEmpdetailsDisplay", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            gv_employeedetails.DataSource = dt.Tables[0];
        }

        private void Gv_employeedetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in gv_employeedetails.Rows)
            {

                if (row.Cells[1].Value != null)
                {
                    eu.EmpId = Convert.ToInt32(row.Cells["EmpID"].Value);
                    eu.EmpName = row.Cells["EmpName"].Value.ToString();
                    eu.Mobilenumber = row.Cells["Mobilenumber"].Value.ToString();
                    eu.Gender = row.Cells["Gender"].Value.ToString();
                    eu.Country = row.Cells["Country"].Value.ToString();
                    eu.State = row.Cells["State"].Value.ToString();
                    eu.City = row.Cells["City"].Value.ToString();
                    eu.Depname = row.Cells["Deptname"].Value.ToString();
                    eu.Qualification = row.Cells["Qualification"].Value.ToString();
                }
            }
        }

    }
}

