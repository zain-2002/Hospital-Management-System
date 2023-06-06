using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class neuro : Form
    {
        public neuro()
        {
          
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select * from Doctors where dept_id=3";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_dept select_Dept = new select_dept();
            this.Hide();
            select_Dept.Show();
            int a;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
