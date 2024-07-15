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
    public partial class AgentDetailsWithWorkingprocject : Form
    {

        private SqlConnection LConn;
        public AgentDetailsWithWorkingprocject()
        {
            InitializeComponent();
            LConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            LConn.Dispose();
            Application.Exit();
        }

        private void vbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [AGENT DETAILS WITH PROJECT];", LConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LGrid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllForms.agentDetailsWithWorkingprocject.Hide();
            AllForms.aVALAIBLEAGENTS.Show();
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            AllForms.agentDetailsWithWorkingprocject.Hide();
            AllForms.agent.Show();
        }
    }
}
