using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employeeinfo
{
    public partial class Employeeinfo : Form
    {
        SqlConnection con = new SqlConnection("server=ATMECSINLT-698\\SQLEXPRESS;database=mydatabase;trusted_connection=true;");
        public Employeeinfo()
        {
            InitializeComponent();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {


            // opening the connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employeeinfo", con);
            // dataadapter is a class set of data commands which wil fill the dataset
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // dataset is a class which consists of set of tablets and occupies some memory of data
            DataSet dt = new DataSet();
            da.Fill(dt);
            Employeeinfo_grid.DataSource = dt.Tables[0];
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            con.Close();
            // Inserting 
            SqlCommand cmd = new SqlCommand("INSERT INTO Employeeinfo(EmpId,EmpName,EmpSalary)VALUES(@EmpId,@EmpName,@EmpSalary)", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            //Using the Parameters of the Employee table
            cmd.Parameters.AddWithValue("@EmpId", Convert.ToInt64(EmployeeId.Text));
            cmd.Parameters.AddWithValue("@EmpName", EmployeeName.Text);
            cmd.Parameters.AddWithValue("@EmpSalary", EmployeeSalary.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Employee information into database", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            con.Close();
            //Updating the values 
            SqlCommand cmd = new SqlCommand("UPDATE Employeeinfo SET EmpName=@EmpName,EmpSalary=@EmpSalary WHERE EmpId=@EmpId", con);
            cmd.CommandType = CommandType.Text;
            //Using the Parameters of the Employee table
            cmd.Parameters.AddWithValue("@EmpId", Convert.ToInt64(EmployeeId.Text));
            cmd.Parameters.AddWithValue("@EmpName", EmployeeName.Text);
            cmd.Parameters.AddWithValue("@EmpSalary", EmployeeSalary.Text);
            //Opens the db connection
            con.Open();
            //This will execute the insert query
            cmd.ExecuteNonQuery();
            //Closes the connection
            con.Close();
            MessageBox.Show("Updated the Employee Information", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            con.Close();
            //Deleting the values 
            SqlCommand cmd = new SqlCommand("DELETE FROM Employeeinfo WHERE EmpName=@EmpName", con);
            cmd.CommandType = CommandType.Text;
            //Using the Parameters of the Employee table
            cmd.Parameters.AddWithValue("@EmpId", Convert.ToInt64(EmployeeId.Text));
            cmd.Parameters.AddWithValue("@EmpName", EmployeeName.Text);
            cmd.Parameters.AddWithValue("@EmpSalary", EmployeeSalary.Text);
            //Opens the db connection
            con.Open();
            //This will execute the insert query
            cmd.ExecuteNonQuery();
            //Closes the connection
            con.Close();
            MessageBox.Show("Deleted the Employee Information", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Employeeinfo_grid_SelectionChanged_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in Employeeinfo_grid.SelectedRows)
            {
                EmployeeId.Text = row.Cells[0].Value.ToString();
                EmployeeName.Text = row.Cells[1].Value.ToString();
                EmployeeSalary.Text = row.Cells[2].Value.ToString();
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {

            EmployeeId.Text = " ";
            EmployeeName.Text = " ";
            EmployeeSalary.Text = " ";

        }
    }
}
