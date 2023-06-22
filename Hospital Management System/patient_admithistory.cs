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
    public partial class patient_admithistory : Form
    {
        public static int ahid;
        public patient_admithistory()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select ah.patient_id,p.pname,ah.appointment_id,ap.appointment_date,ah.doctor_id,d.dname,ah.id,ah.discharge_date from Admithistory as ah join Patients as p on ah.patient_id=p.patient_id join Appointment as ap on ah.appointment_id=ap.appointment_id join Doctors as d on ah.doctor_id=d.doctor_id where ah.patient_id=" + patient_patientdiseases.ptid;
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ahid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            patientadmittreatforpt ad = new patientadmittreatforpt();
            this.Hide();
            ad.Show();
        }

        private void patient_admithistory_Load(object sender, EventArgs e)
        {

        }
    }
}
