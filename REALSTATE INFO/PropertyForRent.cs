using System.Data;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
using REALSTATE_INFO;
using RealState_Project;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RealState_Project
{
    public partial class PropertyForRent : Form
    {
        private SqlConnection fConn;
        public PropertyForRent()
        {
            InitializeComponent();
            fConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from PROPERTY_FOR_RENT", fConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            fGrid.DataSource = dt;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            fConn.Open();

            String query = "Insert into PROPERTY_FOR_RENT values (" + PFRID.Text + ",'" + PFROWNER.Text + "','" + AIDWONPFORR.Text + "','" + PRENT.Text + "'," + TNFROOMS.Text + ",'" + LOFPFRENT.Text + ")";
            new SqlCommand(query, fConn).ExecuteNonQuery();
            fConn.Close();
            PFRID.Text = PFROWNER.Text = AIDWONPFORR.Text = PRENT.Text = TNFROOMS.Text = LOFPFRENT.Text = "";
            MessageBox.Show("Data is saved");
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            fConn.Open();

            String query = "DELETE FROM PROPERTY_FOR_RENT WHERE PROPERTY_FOR_RENT_ID =" + PFRID.Text;
            new SqlCommand(query, fConn).ExecuteNonQuery();
            fConn.Close();
            PFRID.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            fConn.Dispose();
            Application.Exit();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            AllForms.propertyForRent.Hide();
            AllForms.propertyWhichAreAvailableForRent.Show();
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.propertyForRent.Hide();
            AllForms.propertyWhichAreAvailableForSale.Show();
        }

        private void PropertyForRent_Load(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            fConn.Open();
            String query = "Select * from PROPERTY_FOR_RENT where PROPERTY_FOR_RENT_ID = " + PFRID.Text;
            SqlCommand command = new SqlCommand(query, fConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    PFROWNER.Text = reader["PROPERTY__FOR_RENT_OWNER_NAME"].ToString();
                    AIDWONPFORR.Text = reader["AGENT_ID_WORKING_ON_PROPERTY_FOR_RENT"].ToString();
                    PRENT.Text = reader["PROPERTY_RENT"].ToString();
                    TNFROOMS.Text = reader["TOTAL_NUMBER_OF_ROOMS"].ToString();
                    LOFPFRENT.Text = reader["LOCATION_OF_PROPERTY_FOR_RENT"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            fConn.Open();

            String query = "Update PROPERTY_FOR_RENT SET PROPERTY__FOR_RENT_OWNER_NAME = " + "'" + PFROWNER.Text + "',AGENT_ID_WORKING_ON_PROPERTY_FOR_RENT = '" + AIDWONPFORR.Text + "', PROPERTY_RENT = '" + PRENT.Text
                + "',TOTAL_NUMBER_OF_ROOMS = " + TNFROOMS.Text + "',LOCATION_OF_PROPERTY_FOR_RENT = " + LOFPFRENT.Text + " where PROPERTY_FOR_RENT_ID =" + PFRID.Text;
            new SqlCommand(query, fConn).ExecuteNonQuery();
            fConn.Close();
            PFRID.Text = PFROWNER.Text = AIDWONPFORR.Text = PRENT.Text = TNFROOMS.Text = LOFPFRENT.Text = null;

            MessageBox.Show("Data is updated!");
        }

        private void btnCheap_Click(object sender, EventArgs e)
        {
            String query = "SELECT* FROM PROPERTY_FOR_RENT WHERE PROPERTY_RENT < (SELECT AVG(PROPERTY_RENT) FROM PROPERTY_FOR_RENT)";
            SqlCommand command = new SqlCommand(query, fConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            fGrid.DataSource = dt;
        }
    }
}

