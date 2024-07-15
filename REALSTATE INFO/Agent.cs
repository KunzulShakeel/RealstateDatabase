using System.Data;
using System.Data.SqlClient;
using REALSTATE_INFO;

namespace RealState_Project
{
    public partial class Agent : Form
    {
        private SqlConnection cConn;
        public Agent()
        {
            InitializeComponent();
            cConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            cConn.Open();

            String query = "Insert into AGENT values (" + AID.Text + ",'" + AN.Text + "','" + PHOFA.Text + "','" + EOFA.Text + "','" + AOFA.Text + "'," + WONPID.Text + ",'" + HA.Text + "'," + SALARY.Text + ")";
            new SqlCommand(query, cConn).ExecuteNonQuery();
            cConn.Close();
            AID.Text = "";
            AN.Text = "";
            PHOFA.Text = "";
            EOFA.Text = "";
            AOFA.Text = "";
            WONPID.Text = "";
            HA.Text = ""; 
            SALARY.Text = "";
            MessageBox.Show("Data is saved");

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            cConn.Dispose();
            Application.Exit();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from AGENT", cConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cGrid.DataSource = dt;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            cConn.Open();

            String query = "DELETE FROM AGENT WHERE AGENT_ID =" + AID.Text;
            new SqlCommand(query, cConn).ExecuteNonQuery();
            cConn.Close();
            AID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.agentDetailsWithWorkingprocject.Show();
            AllForms.agent.Hide();
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.agent.Hide();
            AllForms.employeeDetailsWithDepartment.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            cConn.Open();
            String query = "Select * from AGENT where AGENT_ID = " + AID.Text;
            SqlCommand command = new SqlCommand(query, cConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    AN.Text = reader["AGENT_NAME"].ToString();
                    PHOFA.Text = reader["PHONE_NUMBER_OF_AGENT"].ToString();
                    EOFA.Text = reader["EMAIL_OF_AGENT"].ToString();
                    AOFA.Text = reader["ADDRESS_OF_AGENT"].ToString();
                    WONPID.Text = reader["WORKING_ON_PROJECT_ID"].ToString();
                    HA.Text = reader["HANDLING_AREAS"].ToString();
                    SALARY.Text = reader["SALARY"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            cConn.Open();

            String query = "Update AGENT SET AGENT_NAME = " + "'" + AN.Text + "',PHONE_NUMBER_OF_AGENT = '" + PHOFA.Text + "', EMAIL_OF_AGENT = '" + EOFA.Text
                + "',ADDRESS_OF_AGENT = " + AOFA.Text + ",WORKING_ON_PROJECT_ID = '" + WONPID.Text + "',HANDLING_AREAS = " + HA.Text + ",SALARY =" + SALARY.Text
                + " where AGENT_ID =" + AID.Text;
            new SqlCommand(query, cConn).ExecuteNonQuery();
            cConn.Close();
            AID.Text = AN.Text = PHOFA.Text = EOFA.Text = AOFA.Text = WONPID.Text = HA.Text = SALARY.Text = null;
            MessageBox.Show("Data is updated!");
        }
    }
}
