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
    public partial class available_docGyna : Form
    {
        public available_docGyna()
        {
            InitializeComponent();
            to.Format = DateTimePickerFormat.Time;
            to.ShowUpDown = true;  
            from.Format = DateTimePickerFormat.Time; 
            from.ShowUpDown = true;
            loadform();
            this.FormClosing += available_docGyna_FormClosing;
         
        }


        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select * from Appointment where doctor_id=" + Gyna.doctor_id;
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gyna g=new Gyna();
            this.Hide();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select * from Appointment where doctor_id=" + Gyna.doctor_id+ " and time_from=@tf and time_to=@tt and appointment_date=@ad";
          SqlCommand cmd =new SqlCommand(querry,con);
            cmd.Parameters.AddWithValue("@tf",from.Value.TimeOfDay);
            cmd.Parameters.AddWithValue("@tt", to.Value.TimeOfDay);
            cmd.Parameters.AddWithValue("@ad", date.Value.Date);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows==true)
            {
                MessageBox.Show("Appointment already exists select valid time !!!");
                con.Close();
            }
            else
            {
                
                con.Close();
                string cn = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                SqlConnection conec = new SqlConnection(cn);
                conec.Open();
                string querry1 = "insert into Appointment values (@pid,@docid,@timefrom,@timeto,@appointmentdate)";
                SqlCommand cmd1 = new SqlCommand(querry1, conec);
                cmd1.Parameters.AddWithValue("@pid", Patientlogin.patientid);
                cmd1.Parameters.AddWithValue("@docid", Gyna.doctor_id);
                cmd1.Parameters.AddWithValue("@timefrom", from.Value.TimeOfDay);
                cmd1.Parameters.AddWithValue("@timeto", to.Value.TimeOfDay);
                cmd1.Parameters.AddWithValue("@appointmentdate", date.Value.Date);

                int b = cmd1.ExecuteNonQuery();
                if (b > 0)
                {

                    MessageBox.Show("Appointment added sucessfully !!!");
                    conec.Close();
                    loadform();

                    string cn3 = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                    SqlConnection con3 = new SqlConnection(cn3);
                    con3.Open();
                    string querry2 = "update Patients set pdisease=@pd, disease_description=@ddesc where patient_id="+Patientlogin.patientid;
                    SqlCommand cmd2 = new SqlCommand(querry2, con3);
                    cmd2.Parameters.AddWithValue("@pd",diseasen.Text);
                    cmd2.Parameters.AddWithValue("@ddesc",description.Text);

                    int c= cmd2.ExecuteNonQuery();
                    if (c>0)
                    {
                     
                        patientchoice pc = new patientchoice();
                        this.Hide();
                        pc.Show();
                        con3.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                        con3.Close();
                    }



                }
                else
                {
                    MessageBox.Show("Error Occured !!!");
                    conec.Close();

                }

            }
            

        }

        private void available_docGyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
