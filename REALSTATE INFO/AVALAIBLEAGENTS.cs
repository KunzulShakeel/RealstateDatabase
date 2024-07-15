using REALSTATE_INFO;
using RealState_Project;
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
    public partial class AVALAIBLEAGENTS : Form
    {
        private SqlConnection MConn;
        public AVALAIBLEAGENTS()
        {
            InitializeComponent();
            MConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            MConn.Dispose();
            Application.Exit();
        }

        private void vbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [AVAILABLE AGENTS];", MConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MGrid.DataSource = dt;
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            AllForms.aVALAIBLEAGENTS.Hide();
            AllForms.agentDetailsWithWorkingprocject.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllForms.aVALAIBLEAGENTS.Hide();
            AllForms.propertyForSale.Show();
        }
    }
}

    