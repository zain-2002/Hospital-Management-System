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
    public partial class Patientdiseases : Form
    {
        public static int appid;
        public static int ptid;
        public Patientdiseases()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select  pd.patient_id,p.pname,pd.Disease,pd.doctor_id,d.dname,pd.admitted,pd.appointment_id,ap.appointment_date,pd.dept_id,dp.dname from PatientDiseases AS pd INNER JOIN  Patients AS p ON pd.patient_id = p.patient_id INNER JOIN  Doctors AS d ON pd.doctor_id = d.doctor_id INNER JOIN  Department AS dp ON d.dept_id = dp.dept_id INNER JOIN  Appointment AS ap ON pd.appointment_id = ap.appointment_id where p.patient_id="+adminviewpatients.patientid;
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminviewpatients vp=new adminviewpatients();
            this.Hide();
            vp.Show();
        }

        private void viewtreatment_Click(object sender, EventArgs e)
        {
            bool check = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[5].Value);
            appid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
            ptid= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            if (!check)
            {
                patient_viewnotadmithistory vs = new patient_viewnotadmithistory();
                this.Hide();
                vs.Show();
            }
            else
            {
                viewadmithistory vh=new viewadmithistory();
                this.Hide();
                vh.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
