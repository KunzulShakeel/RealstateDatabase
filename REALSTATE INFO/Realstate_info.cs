using REALSTATE_INFO;
using System.Data;
using System.Data.SqlClient;

namespace RealState_Project
{
    public partial class Realstate_info : Form
    {
        private SqlConnection xConn;

        public Realstate_info()
        {
            InitializeComponent();
            xConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            xConn.Open();

            String query = "Insert into REAL_STATE_INFO values (" + RSID.Text + ",'" + nrsl.Text + "','" + on.Text + "','" + lrs.Text + "'," + pnrs.Text + ",'" + ersl.Text + "'," + nofe.Text + "," + noofd.Text + ")";
            new SqlCommand(query, xConn).ExecuteNonQuery();
            xConn.Close();
            RSID.Text = nrsl.Text = on.Text = lrs.Text = pnrs.Text = ersl.Text = nofe.Text = noofd.Text = null;
            MessageBox.Show("Data is saved");

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            xConn.Dispose();
            Application.Exit();

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from REAL_STATE_INFO", xConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            xGrid.DataSource = dt;


        }



        private void Deletebtn_Click(object sender, EventArgs e)
        {
            xConn.Open();

            String query = "DELETE FROM REAL_STATE_INFO WHERE REALSTATE_ID =" + RSID.Text;
            new SqlCommand(query, xConn).ExecuteNonQuery();
            xConn.Close();
            RSID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void RSIDlabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.realstate_Info.Hide();
            AllForms.manager.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            xConn.Open();
            String query = "Select * from REAL_STATE_INFO where REALSTATE_ID = " + RSID.Text;
            SqlCommand command = new SqlCommand(query, xConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    nrsl.Text = reader["NAME_OF_REALSTATE"].ToString();
                    on.Text = reader["OWNER_NAME"].ToString();
                    lrs.Text = reader["LOCATION_OF_REALSTATE"].ToString();
                    pnrs.Text = reader["PHONE_NUMBER_OF_REALSTATE"].ToString();
                    ersl.Text = reader["EMAIL_OF_REALSTATE"].ToString();
                    nofe.Text = reader["NO_OF_EMPLOYEE"].ToString();
                    noofd.Text = reader["NO_OF_DEP"].ToString();
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            xConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            xConn.Open();

            String query = "Update REAL_STATE_INFO SET NAME_OF_REALSTATE = " + "'" + nrsl.Text + "',OWNER_NAME = '" + on.Text + "', LOCATION_OF_REALSTATE = '" + lrs.Text
                + "',PHONE_NUMBER_OF_REALSTATE = " + pnrs.Text + ",EMAIL_OF_REALSTATE = '" + ersl.Text + "',NO_OF_EMPLOYEE = " + nofe.Text + ",NO_OF_DEP =" + noofd.Text
                + " where REALSTATE_ID =" + RSID.Text;
            new SqlCommand(query, xConn).ExecuteNonQuery();
            xConn.Close();
            RSID.Text = nrsl.Text = on.Text = lrs.Text = pnrs.Text = ersl.Text = nofe.Text = noofd.Text = null;
            MessageBox.Show("Data is updated!");

        }

        private void RSID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}