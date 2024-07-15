using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using REALSTATE_INFO;
using System.Security.Cryptography;
namespace RealState_Project
{
    public partial class Manager : Form
    {
        private SqlConnection aConn;
        public Manager()
        {
            InitializeComponent();
            aConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            aConn.Open();

            String query = "Insert into REAL_STATE_INFO values (" + MID.Text + ",'" + NOFM.Text + "','" + PNOFM.Text + "','" + EOFM.Text + "'," + AOFM.Text + ",'" + WONPID.Text + "'," + HIDOFD.Text + "," + SALARY.Text + ")";
            new SqlCommand(query, aConn).ExecuteNonQuery();
            aConn.Close();
            MID.Text = NOFM.Text = PNOFM.Text = EOFM.Text = AOFM.Text = WONPID.Text = HIDOFD.Text = SALARY.Text = null;
            MessageBox.Show("Data is saved");

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            aConn.Dispose();
            Application.Exit();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from MANAGER", aConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            aGrid.DataSource = dt;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            aConn.Open();

            String query = "DELETE FROM MANAGER WHERE MANAGER_ID =" + MID.Text;
            new SqlCommand(query, aConn).ExecuteNonQuery();
            aConn.Close();
            MID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.manager.Hide();
            AllForms.realstate_Info.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.manager.Hide();
            AllForms.departments.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            aConn.Open();
            String query = "Select * from MANAGER where MANAGER_ID = " + MID.Text;
            SqlCommand command = new SqlCommand(query, aConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    NOFM.Text = reader["NAME_OF_MANAGER"].ToString();
                    PNOFM.Text = reader["PHONE_NUMBER_OF_MANAGER"].ToString();
                    EOFM.Text = reader["EMAIL_OF_MANAGER"].ToString();
                    AOFM.Text = reader["ADDRESS_OF_MANAGER"].ToString();
                    WONPID.Text = reader["WORKING_ON_PROJECT_ID"].ToString();
                    HIDOFD.Text = reader["HANDLING_ID_OF_DEPARTMENT"].ToString();
                    SALARY.Text = reader["SALARY"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            aConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            aConn.Open();

            String query = "Update MANAGER SET NAME_OF_MANAGER = " + "'" + NOFM.Text + "',PHONE_NUMBER_OF_MANAGER = '" + PNOFM.Text + "', EMAIL_OF_MANAGER = '" + EOFM.Text
                + "',ADDRESS_OF_MANAGER = " + AOFM.Text + ",WORKING_ON_PROJECT_ID = '" + WONPID.Text + "',HANDLING_ID_OF_DEPARTMENT = " + HIDOFD.Text + ",SALARY =" + SALARY.Text
                + " where MANAGER_ID =" + MID.Text;
            new SqlCommand(query, aConn).ExecuteNonQuery();
            aConn.Close();
            MID.Text = NOFM.Text = PNOFM.Text = EOFM.Text = AOFM.Text = WONPID.Text = HIDOFD.Text = SALARY.Text = null;
            MessageBox.Show("Data is updated!");
        }
    }
}
