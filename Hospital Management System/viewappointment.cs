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
    public partial class viewappointment : Form
    {
        int apid;
        public viewappointment()
        {
            InitializeComponent();
            loadform();

        }
        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "SELECT * FROM Appointment where patient_id=" + Patientlogin.patientid;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;

            dr.Close();
            con.Close();
        }
        private void back_Click(object sender, EventArgs e)
        {
            patientchoice pc = new patientchoice();
            this.Hide();
            pc.Show();  
        }

       
    }
}
