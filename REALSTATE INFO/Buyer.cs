using System.Data;
using System;
using System.Security.Cryptography;
using System.Drawing;
using System.Data.SqlClient;
using REALSTATE_INFO;
namespace RealState_Project
{
    public partial class Buyer : Form
    {
        private SqlConnection gConn;
        public Buyer()
        {
            InitializeComponent();
            gConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            gConn.Open();

            String query = "Insert into BUYER values (" + BID.Text + ",'" + BN.Text + "','" + PNOFB.Text + "','" + EOFB.Text + "'," + ONWL.Text + ",'" + R.Text + ")";
            new SqlCommand(query, gConn).ExecuteNonQuery();
            gConn.Close();
            BID.Text = BN.Text = PNOFB.Text = EOFB.Text = ONWL.Text = R.Text = null;
            MessageBox.Show("Data is saved");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from BUYER", gConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gGrid.DataSource = dt;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            gConn.Dispose();
            Application.Exit();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            gConn.Open();

            String query = "DELETE FROM BUYER WHERE BUYER_ID =" + BID.Text;
            new SqlCommand(query, gConn).ExecuteNonQuery();
            gConn.Close();
            BID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.buyer.Hide();
            AllForms.propertyWhichAreAvailableForRent.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.buyer.Hide();
            AllForms.sales.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            gConn.Open();
            String query = "Select * from BUYER where BUYER_ID = " + BID.Text;
            SqlCommand command = new SqlCommand(query, gConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    BN.Text = reader["BUYER_NAME"].ToString();
                    PNOFB.Text = reader["PHONE_NUMBER_OF_BUYER"].ToString();
                    EOFB.Text = reader["EMAIL_OF_BUYER"].ToString();
                    ONWL.Text = reader["ON_WHICH_LOCATION"].ToString();
                    R.Text = reader["REQUIREMENTS"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            gConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            gConn.Open();

            String query = "Update BUYER SET BUYER_NAME = " + "'" + BN.Text + "',PHONE_NUMBER_OF_BUYER = '" + PNOFB.Text + "', EMAIL_OF_BUYER = '" + EOFB.Text
                + "',ON_WHICH_LOCATION = " + ONWL.Text + "',REQUIREMENTS = " + R.Text + " where BUYER_ID =" + BID.Text;
            new SqlCommand(query, gConn).ExecuteNonQuery();
            gConn.Close();
            BID.Text = BN.Text = PNOFB.Text = EOFB.Text = ONWL.Text = R.Text = null;

            MessageBox.Show("Data is updated!");
        }
    }
}
