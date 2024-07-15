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
    public partial class PropertyWhichAreAvailableForRent : Form
    {

        private SqlConnection zConn;
        public PropertyWhichAreAvailableForRent()

        {
            InitializeComponent();
            zConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void vbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [AVAILABLE PROPERTY FOR RENT];", zConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            zGrid.DataSource = dt;
        }

        private void extbtn_Click(object sender, EventArgs e)
        {

            zConn.Dispose();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllForms.propertyWhichAreAvailableForRent.Hide();
            AllForms.buyer.Show();
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            AllForms.propertyWhichAreAvailableForRent.Hide();
            AllForms.propertyForRent.Show();
        }
    }
}
