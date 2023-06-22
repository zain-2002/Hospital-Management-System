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
    public partial class Addpatienttreatment : Form
    {
        public Addpatienttreatment()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select p.pname,pd.disease,pd.[description] from Patients as p join PatientDiseases as pd on p.patient_id=pd.patient_id where pd.appointment_id=" +viewappointmentstodoc.app_id ;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                pat_name.Text = dr.GetString(0);
                diseasename.Text = dr.GetString(1);
                diseasedescription.Text = dr.GetString(2);
                con.Close();    
            }
            else
            {
                MessageBox.Show("Error Occured");
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="YES")
            {
                string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string q = "update PatientDiseases set admitted=@admitted where appointment_id=" + viewappointmentstodoc.app_id;
                SqlCommand cmd4 = new SqlCommand(q, con);
                cmd4.Parameters.AddWithValue("@admitted",(comboBox1.Text=="YES") ? true : false );
                con.Open();
                int d=cmd4.ExecuteNonQuery();   
                if (d>0)
                {
                    con.Close();
                }
                else { 
                    
                 con.Close(); 
                }   



                string querry = "insert into admithistory (patient_id,appointment_id,doctor_id) values (@pid,@dapid,@docid)";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@pid", viewappointmentstodoc.pat_id);
                cmd.Parameters.AddWithValue("@dapid", viewappointmentstodoc.app_id);
                cmd.Parameters.AddWithValue("@docid", viewappointmentstodoc.doc_id);
                con.Open();


                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    con.Close();
                    con.Open();

                    string querry1 = "select max(id) from admithistory";
                    SqlCommand cmd1 = new SqlCommand(querry1, con);
                    int maxId = (int)cmd1.ExecuteScalar();
                    con.Close();

                    con.Open();

                    string querry2 = "insert into AdmittedTreatment values (@id,@pid,@docid,@desease,@prescription,@detail,@treatdatetime,@guideline)";
                    SqlCommand cmd2 = new SqlCommand(querry2, con);
                    cmd2.Parameters.AddWithValue("@id", maxId);
                    cmd2.Parameters.AddWithValue("@pid", viewappointmentstodoc.pat_id);
                    cmd2.Parameters.AddWithValue("@docid", viewappointmentstodoc.doc_id);
                    cmd2.Parameters.AddWithValue("@desease", diseasename.Text);
                    cmd2.Parameters.AddWithValue("@prescription",prescription.Text );
                    cmd2.Parameters.AddWithValue("@detail", diseasedescription.Text);
                    cmd2.Parameters.AddWithValue("@treatdatetime",DateTime.Now );
                    cmd2.Parameters.AddWithValue("@guideline", guideline.Text);
                    int c= cmd2.ExecuteNonQuery();  
                    if (c > 0)
                    {
                        MessageBox.Show("Successfully added");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failure");
                        con.Close();

                    }


                }
                else
                {
                    MessageBox.Show("Failure");
                    con.Close();
                }

            }
            else if (comboBox1.Text == "NO")
            {
                string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string querry = "insert into NotAdmittedTreatment  values (@pid,@dapid,@docid,@prescription,@guideline)";
                SqlCommand cmd = new SqlCommand(querry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@pid", viewappointmentstodoc.pat_id);
                cmd.Parameters.AddWithValue("@dapid", viewappointmentstodoc.app_id);
                cmd.Parameters.AddWithValue("@docid", viewappointmentstodoc.doc_id);
                cmd.Parameters.AddWithValue("@prescription",prescription.Text );
                cmd.Parameters.AddWithValue("@guideline", guideline.Text);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Successfully added");
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Failure");
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Insert admit details");
            }
        }

        
    }
}
