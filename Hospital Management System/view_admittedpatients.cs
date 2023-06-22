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
    public partial class view_admittedpatients : Form
    {
        public view_admittedpatients()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select * from asfahanview";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

      

        private void back_Click(object sender, EventArgs e)
        {
            Doctoractionchoice  doctoractionchoice = new Doctoractionchoice();
            doctoractionchoice.Show();  
            this.Hide();
        }
    }
}
