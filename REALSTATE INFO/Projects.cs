using System.Data;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Data.SqlClient;
using REALSTATE_INFO;
using System.Security.Policy;

namespace RealState_Project
{
    public partial class Projects : Form
    {
        private SqlConnection jConn;
        public Projects()
        {
            InitializeComponent();
            jConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            jConn.Open();

            String query = "Insert into PROJECT values (" + PIDE.Text + ",'" + PNEE.Text + ")";
            new SqlCommand(query, jConn).ExecuteNonQuery();
            jConn.Close();
            PIDE.Text = PNEE.Text = null;
            MessageBox.Show("Data is saved");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            jConn.Dispose();
            Application.Exit();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            jConn.Open();

            String query = "DELETE FROM PROJECT WHERE PROJECT_ID =" + PIDE.Text;
            new SqlCommand(query, jConn).ExecuteNonQuery();
            jConn.Close();
            PIDE.Text = null;

            MessageBox.Show("Data is Deleted");
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from PROJECT", jConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            jGrid.DataSource = dt;
        }

        private void BACKBTN_Click(object sender, EventArgs e)
        {
            AllForms.projects.Hide();
            AllForms.salesForRent.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            jConn.Open();
            String query = "Select * from PROJECT where PROJECT_ID = " + PIDE.Text;
            SqlCommand command = new SqlCommand(query, jConn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    PNEE.Text = reader["PROJECT_NAME"].ToString();

                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            jConn.Close();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            jConn.Open();

            String query = "Update PROJECT SET PROJECT_NAME = " + "'" + PNEE.Text + " where PROJECT_ID =" + PIDE.Text;
            new SqlCommand(query, jConn).ExecuteNonQuery();
            jConn.Close();
            PIDE.Text = PNEE.Text = null;
            MessageBox.Show("Data is updated!");
        }

        private void NXTBTN_Click(object sender, EventArgs e)
        {
            AllForms.projects.Hide();
            AllForms.propertyWhichAreAvailableForSale.Show();
            
        }
    }
}
