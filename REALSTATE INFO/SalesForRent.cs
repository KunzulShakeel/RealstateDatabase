using System.Data;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Data.SqlClient;
using REALSTATE_INFO;

namespace RealState_Project
{
    public partial class SalesForRent : Form
    {
        private SqlConnection iConn;
        public SalesForRent()
        {
            InitializeComponent();
            iConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            iConn.Open();

            String query = "Insert into SALES_FOR_RENT values (" + SRIDE.Text + ",'" + PAONRE.Text + "','" + PNAONRE.Text + "','" + PRBANE.Text + "'," + PPRCE.Text + ",'" + PITXRENOT.Text + ")";
            new SqlCommand(query, iConn).ExecuteNonQuery();
            iConn.Close();
            SRIDE.Text = PAONRE.Text = PNAONRE.Text = PRBANE.Text = PPRCE.Text = PITXRENOT.Text = null;
            MessageBox.Show("Data is saved");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            iConn.Dispose();
            Application.Exit();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            iConn.Open();

            String query = "DELETE FROM SALES_FOR_RENT WHERE SALES_FOR_RENT_ID =" + SRIDE.Text;
            new SqlCommand(query, iConn).ExecuteNonQuery();
            iConn.Close();
            SRIDE.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from SALES_FOR_RENT", iConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            iGrid.DataSource = dt;

        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.salesForRent.Hide();
            AllForms.sales.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.salesForRent.Hide();
            AllForms.projects.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            iConn.Open();
            String query = "Select * from SALES_FOR_RENT where SALES_FOR_RENT_ID = " + SRIDE.Text;
            SqlCommand command = new SqlCommand(query, iConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    PAONRE.Text = reader["PROPERTY_AVAILABLE_ON_RENT"].ToString();
                    PNAONRE.Text = reader["PROPERTY_NOT_AVAILABLE_ON_RENT"].ToString();
                    PRBANE.Text = reader["PROPERTY_RENTED_BY_AGENT_NAME"].ToString();
                    PPRCE.Text = reader["PER_PROPERTY_RENTED_COMMISSION"].ToString();
                    PITXRENOT.Text = reader["PROPERTY_IS_TAX_PAID_OR_NOT"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            iConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

            iConn.Open();

            String query = "Update SALES_FOR_RENT SET SALES_FOR_RENT_ID = " + "'" + PAONRE.Text + "',PROPERTY_NOT_AVAILABLE_ON_RENT = '" + PNAONRE.Text + "', PROPERTY_RENTED_BY_AGENT_NAME = '" + PRBANE.Text
                + "',PER_PROPERTY_RENTED_COMMISSION = " + PPRCE.Text + "',PROPERTY_IS_TAX_PAID_OR_NOT = " + PITXRENOT.Text + " where SALES_FOR_RENT_ID =" + SRIDE.Text;
            new SqlCommand(query, iConn).ExecuteNonQuery();
            iConn.Close(); 
            SRIDE.Text = PAONRE.Text = PNAONRE.Text = PRBANE.Text = PPRCE.Text = PITXRENOT.Text = null;
            MessageBox.Show("Data is updated!");
        }
    }
}