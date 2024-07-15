using System.Data;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
using REALSTATE_INFO;
using System.Xml.Linq;

namespace RealState_Project
{
    public partial class PropertyForSale : Form
    {
        private SqlConnection eConn;
        public PropertyForSale()
        {
            InitializeComponent();
            eConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            eConn.Open();

            String query = "Insert into REAL_STATE_INFO values (" + PID.Text + ",'" + POWN.Text + "','" + AIDWONP.Text + "','" + PP.Text + "'," + TNOFR.Text + ",'" + LOFP.Text + ")";
            new SqlCommand(query, eConn).ExecuteNonQuery();
            eConn.Close();
            PID.Text = POWN.Text = AIDWONP.Text = PP.Text = TNOFR.Text = LOFP.Text = null;
            MessageBox.Show("Data is saved");

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            eConn.Open();

            String query = "DELETE FROM PROPERTY_FOR_SALE WHERE PROPERTY_ID =" + PID.Text;
            new SqlCommand(query, eConn).ExecuteNonQuery();
            eConn.Close();
            PID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from PROPERTY_FOR_SALE", eConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            eGrid.DataSource = dt;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            eConn.Dispose();
            Application.Exit();
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.aVALAIBLEAGENTS.Show();
            AllForms.propertyForSale.Hide();
        }

        private void nextbtn_Click(object sender, EventArgs e)

        {
            AllForms.propertyForSale.Hide();
            AllForms.propertyWhichAreAvailableForSale.Show();

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            eConn.Open();
            String query = "Select * from PROPERTY_FOR_SALE where PROPERTY_ID = " + PID.Text;
            SqlCommand command = new SqlCommand(query, eConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    POWN.Text = reader["PROPERTY_OWNER_NAME"].ToString();
                    AIDWONP.Text = reader["AGENT_ID_WORKING_ON_PROPERTY"].ToString();
                    PP.Text = reader["PROPERTY_PRICE"].ToString();
                    TNOFR.Text = reader["TOTAL_NUMBER_OF_ROOMS"].ToString();
                    LOFP.Text = reader["LOCATION_OF_PROPERTY"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            eConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            eConn.Open();

            String query = "Update PROPERTY_FOR_SALE SET PROPERTY_OWNER_NAME = " + "'" + POWN.Text + "',AGENT_ID_WORKING_ON_PROPERTY = '" + AIDWONP.Text + "', PROPERTY_PRICE = '" + PP.Text
                + "',TOTAL_NUMBER_OF_ROOMS = " + TNOFR.Text + "',LOCATION_OF_PROPERTY = " + LOFP.Text + " where PROPERTY_ID =" + PID.Text;
            new SqlCommand(query, eConn).ExecuteNonQuery();
            eConn.Close();
            PID.Text = POWN.Text = AIDWONP.Text = PP.Text = TNOFR.Text = LOFP.Text = null;

            MessageBox.Show("Data is updated!");
        }

        private void btn_cheap_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM PROPERTY_FOR_SALE WHERE PROPERTY_PRICE < (SELECT AVG(PROPERTY_PRICE) FROM PROPERTY_FOR_SALE)";
            SqlCommand command = new SqlCommand(query, eConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            eGrid.DataSource = dt;
        }
    }
}