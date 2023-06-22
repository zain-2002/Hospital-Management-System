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
    public partial class viewappointmentstodoc : Form
    {
        public static int app_id;
        public static int doc_id;
        public static int pat_id;


        public viewappointmentstodoc()
        {
            InitializeComponent();

            loadform();
        }
        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select ap.appointment_id,ap.patient_id,ap.doctor_id,ap.time_from,ap.time_to,ap.appointment_date from appointment as ap join PatientDiseases as pd on ap.appointment_id=pd.appointment_id where pd.admitted is  null and pd.doctor_id=" + doctor_login.doc_id;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;

            dr.Close();
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
             app_id =Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value); 
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "delete from PatientDiseases where appointment_id=@did";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@did", app_id);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                
                con.Close();

                con.Open();
                string querry2 = "delete from Appointment where appointment_id=@did";
                SqlCommand cm = new SqlCommand(querry2, con);
                cm.Parameters.AddWithValue("@did", app_id);
                int b = cm.ExecuteNonQuery();
                if (b > 0)
                {
                    MessageBox.Show("Success");
                    con.Close();
                    loadform();
                }
                else {
                    MessageBox.Show("Failure");
                    con.Close();

                }
            }
            else
            {
              
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc_id= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            pat_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            app_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Addpatienttreatment apt=new Addpatienttreatment();
            this.Hide();
            apt.Show(); 

        }

        private void back_Click(object sender, EventArgs e)
        {
            Doctoractionchoice dv= new Doctoractionchoice();
            this.Hide();
            dv.Show();
        }

   
    }
}
