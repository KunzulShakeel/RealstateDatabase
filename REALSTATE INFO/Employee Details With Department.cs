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
    public partial class EmployeeDetailsWithDepartment : Form

    {
        private SqlConnection kConn;
        public EmployeeDetailsWithDepartment()
        {
            InitializeComponent();
            kConn = new SqlConnection("Server=SHAHEER\\SQLEXPRESS; DataBase=REALSTATE; Integrated Security=True;");
        }

        private void vbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [EMPLOYEE DETAILS WITH DEPARTMENT];", kConn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            kGrid.DataSource = dt;
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            kConn.Dispose();
            Application.Exit();
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            AllForms.employeeDetailsWithDepartment.Hide();
            AllForms.employee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllForms.employeeDetailsWithDepartment.Hide();
            AllForms.agent.Show();
        }
    }
}
