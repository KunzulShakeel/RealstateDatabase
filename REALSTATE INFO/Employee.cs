using System.Drawing;
using System.Xml.Linq;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using REALSTATE_INFO;
using System.Security.Cryptography;
namespace RealState_Project
{
    public partial class Employee : Form
    {
        private SqlConnection bConn;
        public Employee()
        {
            InitializeComponent();
            bConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }



        private void savebtn_Click(object sender, EventArgs e)
        {
            bConn.Open();

            String query = "INSERT INTO EMPLOYEE VALUES (" + EID.Text + ",'" + NFE.Text + "','" + PNOFE.Text + "','" + EOFE.Text + "'," + AOFE.Text + ",'" + WONPID.Text + "'," + DID.Text + "," + SALARY.Text + ")";
            new SqlCommand(query, bConn).ExecuteNonQuery();
            bConn.Close();
            EID.Text = NFE.Text = PNOFE.Text = EOFE.Text = AOFE.Text = WONPID.Text = DID.Text = SALARY.Text = null;
            MessageBox.Show("Data is saved");

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            bConn.Dispose();
            Application.Exit();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from EMPLOYEE", bConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            xGrid.DataSource = dt;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            bConn.Open();

            String query = "DELETE FROM EMPLOYEE WHERE EMPLOYEE_ID =" + EID.Text;
            new SqlCommand(query, bConn).ExecuteNonQuery();
            bConn.Close();
            EID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.employee.Hide();
            AllForms.departments.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.employee.Hide();
            AllForms.employeeDetailsWithDepartment.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            bConn.Open();
            String query = "Select * from EMPLOYEE where EMPLOYEE_ID = " + EID.Text;
            SqlCommand command = new SqlCommand(query, bConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    NFE.Text = reader["NAME_OF_EMPLOYEE"].ToString();
                    PNOFE.Text = reader["PHONE_NUMBER_OF_EMPLOYEE"].ToString();
                    EOFE.Text = reader["EMAIL_OF_EMPLOYEE"].ToString();
                    AOFE.Text = reader["ADDRESS_OF_EMPLOYEE"].ToString();
                    WONPID.Text = reader["WORKING_ON_PROJECT_ID"].ToString();
                    DID.Text = reader["DEPARTMENT_ID"].ToString();
                    SALARY.Text = reader["SALARY"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            bConn.Open();

            String query = "Update EMPLOYEE SET NAME_OF_EMPLOYEE = " + "'" + NFE.Text + "',PHONE_NUMBER_OF_EMPLOYEE = '" + PNOFE.Text + "', EMAIL_OF_EMPLOYEE = '" + EOFE.Text
                + "',ADDRESS_OF_EMPLOYEE = " + AOFE.Text + ",WORKING_ON_PROJECT_ID = '" + WONPID.Text + "',DEPARTMENT_ID = " + DID.Text + ",SALARY =" + SALARY.Text
                + " where EMPLOYEE_ID =" + EID.Text;
            new SqlCommand(query, bConn).ExecuteNonQuery();
            bConn.Close();
            EID.Text = NFE.Text = PNOFE.Text = EOFE.Text = AOFE.Text = WONPID.Text = DID.Text = SALARY.Text = null;
            MessageBox.Show("Data is updated!");
        }
    }
}
