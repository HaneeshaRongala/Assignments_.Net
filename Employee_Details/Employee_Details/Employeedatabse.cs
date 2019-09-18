using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class Employeedatabase : Form
    {

        SqlConnection con = new SqlConnection("server=ATMECSINLT-698\\SQLEXPRESS;database=db;trusted_connection=true;");
        public Employeedatabase(EmployeeUpdation updation)
        {
            InitializeComponent();
            GetCountries();
            GetStates();
            GetCities();
            GetDepartment();
            GetEducation();
            GetGender();
            if (updation != null)
            {
                txt_id.Text = updation.EmpId.ToString();
                txt_name.Text = updation.EmpName.ToString();
                txt_mobilenumber.Text = updation.Mobilenumber.ToString();
                cbo_gender.Text = updation.Gender.ToString();
                cbo_country.Text = updation.Country.ToString();
                cbo_State.Text = updation.State.ToString();
                cbo_City.Text = updation.City.ToString();
                cbo_department.Text = updation.Depname.ToString();
                cbo_Qualification.Text = updation.Qualification.ToString();
            }
        }

        //public Employeedatabase()
        //{
        //}

        // To fetch the list of countries into combobox
        private void GetCountries()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPCountry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Country--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_country.DisplayMember = "Countryname";
            cbo_country.ValueMember = "CId";
            cbo_country.DataSource = dt;
            con.Close();
        }
        // To fetch list of states into combobox
        private void GetStates()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select State--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_State.DisplayMember = "Statename";
            cbo_State.ValueMember = "CId";
            cbo_State.DataSource = dt;
            con.Close();
        }
        // To fetch list of Cities into Combobox
        private void GetCities()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPCity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select City--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_City.DisplayMember = "CityName";
            cbo_City.ValueMember = "CityId";
            cbo_City.DataSource = dt;
            con.Close();
          }
    // Fteching the list of Departments into Combobox
        private void GetDepartment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPDepartment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Department--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_department.DisplayMember = "DeptName";
            cbo_department.ValueMember = "DeptId";
            cbo_department.DataSource = dt;
            con.Close();
        }
        // Fetching list of Genders into Combobox
        private void GetGender()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPGender", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Gender--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_gender.DisplayMember = "Gendername";
            cbo_gender.ValueMember = "GenderId";
            cbo_gender.DataSource = dt;
            con.Close();
        }
        // Fetching list of Education details into Combobox
        private void GetEducation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPEducation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr;
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Qualification--" };
            dt.Rows.InsertAt(dr, 0);
            cbo_Qualification.DisplayMember = "Quaification";
            cbo_Qualification.ValueMember = "EducationId";
            cbo_Qualification.DataSource = dt;
            con.Close();
        }
        private void Cbo_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_country.SelectedValue.ToString() != null)
            { 
                DataRow dr;
                SqlCommand cmd = new SqlCommand("SELECT * FROM City WHERE SId=@SId", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@StateId", cbo_State.SelectedValue.ToString());
                DataTable ds = new DataTable();
                sda.Fill(ds);
                cbo_City.DataSource = ds;
                dr = ds.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Qualification--" };
                ds.Rows.InsertAt(dr, 0);
                cbo_City.DisplayMember = "Cityname";
                cbo_City.ValueMember = "CityId";
            }
        }
        private void Cbo_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_country != null&&(int)cbo_country.SelectedValue>0)
            {
                SqlCommand cmd = new SqlCommand("select * from State WHERE CId=@CountryId", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                cmd.Parameters.AddWithValue("@CountryId", cbo_country.SelectedValue.ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_country.DisplayMember = "Statename";
                cbo_country.ValueMember = "SId";
                cbo_country.DataSource = dt;
            }
        }
        private void Btn_Viewdetails_Click(object sender, EventArgs e)
        {
            employeegrid eg = new employeegrid();
            eg.Show();
            this.Hide();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPAddEmployeedetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", Convert.ToInt32(txt_id.Text));
            cmd.Parameters.AddWithValue("@EmpName", txt_name.Text);
            cmd.Parameters.AddWithValue("@MobileNumber", Convert.ToInt64(txt_mobilenumber.Text));
            cmd.Parameters.AddWithValue("@GenderId", Convert.ToInt32(cbo_gender.SelectedValue));
            cmd.Parameters.AddWithValue("@CountryId ", Convert.ToInt32(cbo_country.SelectedValue));
            cmd.Parameters.AddWithValue("@StateId", Convert.ToInt32(cbo_State.SelectedValue));
            cmd.Parameters.AddWithValue("@CityId ", Convert.ToInt32(cbo_City.SelectedValue));
            cmd.Parameters.AddWithValue("@DeptId", Convert.ToInt32(cbo_department.SelectedValue));
            cmd.Parameters.AddWithValue("@EducationId ", Convert.ToInt32(cbo_Qualification.SelectedValue));
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
            }
        }

    }
}

