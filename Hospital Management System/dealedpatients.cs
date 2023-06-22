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
    public partial class dealedpatients : Form
    {
        public dealedpatients()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select ap.appointment_id,ap.patient_id,ap.doctor_id,ap.time_from,ap.time_to,ap.appointment_date from appointment as ap join PatientDiseases as pd on ap.appointment_id=pd.appointment_id where pd.admitted is not null and pd.doctor_id=" + doctor_login.doc_id;
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
            Doctoractionchoice doctoractionchoice = new Doctoractionchoice();   
            this.Hide();
            doctoractionchoice.Show();  
        }
    }
}
