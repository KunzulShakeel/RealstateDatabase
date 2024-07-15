using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace REALSTATE_INFO
{
    public partial class Departments : Form
    {

        private SqlConnection dConn;

        public Departments()
        {
            InitializeComponent();
            dConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dConn.Open();

            String query = "Insert into DEPARTMENT values (" + DID.Text + ",'" + DN.Text + "','" + NOFEW.Text + "','" + EOFD.Text + "','" + PNOFD.Text + ")";
            new SqlCommand(query, dConn).ExecuteNonQuery();
            dConn.Close();
            DID.Text = DN.Text = NOFEW.Text = EOFD.Text = PNOFD.Text = null;
            MessageBox.Show("Data is saved");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            dConn.Dispose();
            Application.Exit();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from DEPARTMENT", dConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGrid.DataSource = dt;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            dConn.Open();

            String query = "DELETE FROM DEPARTMENT WHERE AGENT_ID =" + DID.Text;
            new SqlCommand(query, dConn).ExecuteNonQuery();
            dConn.Close();
            DID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.departments.Hide();
            AllForms.manager.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.departments.Hide();
            AllForms.employee.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            dConn.Open();
            String query = "Select * from DEPARTMENT where DEPARTMENT_ID = " + DID.Text;
            SqlCommand command = new SqlCommand(query, dConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    DN.Text = reader["DEPARTMENT_NAME"].ToString();
                    NOFEW.Text = reader["NO_OF_EMPLOYEE_WORKING"].ToString();
                    EOFD.Text = reader["EMAIL_OF_DEPARTMENT"].ToString();
                    PNOFD.Text = reader["PHONE_NUMBER_OF_DEPARTMENT"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            dConn.Open();

            String query = "Update DEPARTMENT SET DEPARTMENT_NAME = " + "'" + DN.Text + "',NO_OF_EMPLOYEE_WORKING = '" + NOFEW.Text + "', EMAIL_OF_DEPARTMENT = '" + EOFD.Text
                + "',PHONE_NUMBER_OF_DEPARTMENT = " + PNOFD.Text + " where DEPARTMENT_ID =" + DID.Text;
            new SqlCommand(query, dConn).ExecuteNonQuery();
            dConn.Close(); DID.Text = DN.Text = NOFEW.Text = EOFD.Text = PNOFD.Text = null;
            MessageBox.Show("Data is updated!");
        }
    }
}