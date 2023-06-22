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
    public partial class patient_viewnotadmithistory : Form
    {
        public patient_viewnotadmithistory()
        {
            InitializeComponent();
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True; // Enable text wrapping for the row
            dataGridView1.RowTemplate.Height = 200; // Set the desired height for the row

            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select nap.patient_id,p.pname,pd.disease,pd.[description],d.doctor_id,d.dname,nap.prescription,nap.guidline,nap.appointment_id,ap.appointment_date FROM  NotAdmittedTreatment AS nap JOIN  Patients AS p ON nap.patient_id = p.patient_id JOIN  PatientDiseases AS pd ON nap.patient_id = pd.patient_id  AND nap.appointment_id = pd.appointment_id JOIN  Appointment AS ap ON nap.appointment_id = ap.appointment_id JOIN Doctors AS d ON nap.doctor_id = d.doctor_id where nap.appointment_id=" + Patientdiseases.appid;
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.Columns[7].Width = 400;
            dataGridView1.Columns[3].Width = 400;
            dataGridView1.Rows[0].Height = 50; 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patientdiseases pd= new Patientdiseases();
            this.Hide();
            pd.Show();
        }
    }
}
