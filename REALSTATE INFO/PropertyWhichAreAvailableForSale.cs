using REALSTATE_INFO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState_Project
{
    public partial class PropertyWhichAreAvailableForSale : Form
    {
        private SqlConnection jConn;

        public PropertyWhichAreAvailableForSale()
        {
            InitializeComponent();
            jConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            AllForms.propertyWhichAreAvailableForSale.Hide();
            AllForms.propertyForSale.Show();


        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            jConn.Dispose();
            Application.Exit();
        }

        private void vbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [AVAILABLE PROPERTIES FOR SALE];", jConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            jGrid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllForms.propertyWhichAreAvailableForSale.Hide();
            AllForms.propertyForRent.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void jGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
