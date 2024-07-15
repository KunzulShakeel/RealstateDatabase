using System.Data;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
using REALSTATE_INFO;

namespace RealState_Project
{
    public partial class Sales : Form
    {
        private SqlConnection hConn;
        public Sales()
        {
            InitializeComponent();
            hConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            hConn.Open();

            String query = "Insert into SALES values (" + SID.Text + ",'" + PWISS.Text + "','" + PWAA.Text + "','" + PSBYAN.Text + "'," + PPSC.Text + ",'" + PITXRN.Text + ")";
            new SqlCommand(query, hConn).ExecuteNonQuery();
            hConn.Close();
            SID.Text = PWISS.Text = PWAA.Text = PSBYAN.Text = PPSC.Text = PITXRN.Text = null;
            MessageBox.Show("Data is saved");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from SALES", hConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            hGrid.DataSource = dt;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            hConn.Dispose();
            Application.Exit();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            hConn.Open();

            String query = "DELETE FROM SALES WHERE SALES_ID =" + SID.Text;
            new SqlCommand(query, hConn).ExecuteNonQuery();
            hConn.Close();
            SID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.sales.Hide();
            AllForms.buyer.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.sales.Hide();
            AllForms.salesForRent.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            hConn.Open();
            String query = "Select * from SALES where SALES_ID = " + SID.Text;
            SqlCommand command = new SqlCommand(query, hConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    PWISS.Text = reader["PROPERTY_WHICH_IS_SOLD"].ToString();
                    PWAA.Text = reader["PROPERTY_WHICH_ARE_AVAILABLE"].ToString();
                    PSBYAN.Text = reader["PROPERTY_SOLD_BY_AGENT_NAME"].ToString();
                    PPSC.Text = reader["PER_PROPERTY_SOLD_COMMISSION"].ToString();
                    PITXRN.Text = reader["PROPERTY_IS_TAX_PAID_OR_NOT"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            hConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            hConn.Open();

            String query = "Update SALES SET PROPERTY_WHICH_IS_SOLD = " + "'" + PWISS.Text + "',PROPERTY_WHICH_ARE_AVAILABLE = '" + PWAA.Text + "', PROPERTY_SOLD_BY_AGENT_NAME = '" + PSBYAN.Text
                + "',PER_PROPERTY_SOLD_COMMISSION = " + PPSC.Text + "',PROPERTY_IS_TAX_PAID_OR_NOT = " + PITXRN.Text + " where SALES_ID =" + SID.Text;
            new SqlCommand(query, hConn).ExecuteNonQuery();
            hConn.Close();
            SID.Text = PWISS.Text = PWAA.Text = PSBYAN.Text = PPSC.Text = PITXRN.Text = null;

            MessageBox.Show("Data is updated!");
        }
    }
}
