using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class appointmentbooking : Form
    {
        public appointmentbooking()
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
            string querry = "select * from Appointment where doctor_id=" + Doctorsindept.doctor_id;
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctorsindept g=new Doctorsindept();
            this.Hide();
            g.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan fromtime = from.Value.TimeOfDay;
            TimeSpan totime = to.Value.TimeOfDay;
            if (fromtime>=Doctorsindept.scfromtime && totime<=Doctorsindept.sctotime && Doctorsindept.day == date.Value.DayOfWeek.ToString())
            {
                string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "SELECT * FROM Appointment WHERE doctor_id = @doctorid AND ( ( @tf >= time_from AND  @tf < time_to) OR (@tt > time_from AND @tt <= time_to) OR (@tf <= time_from AND @tt >= time_to)) AND appointment_date = @ad ;\r\n";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@doctorid", Doctorsindept.doctor_id);
                cmd.Parameters.AddWithValue("@tf", from.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@tt", to.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@ad", date.Value.Date);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Appointment already exists. Please select a valid time!");
                    con.Close();
                }
                else
                {
                    con.Close();
                    string cn = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                    SqlConnection conec = new SqlConnection(cn);
                    conec.Open();

                    string query1 = "INSERT INTO Appointment (patient_id, doctor_id, time_from, time_to, appointment_date) VALUES (@pid, @docid, @timefrom, @timeto, @appointmentdate)";
                    SqlCommand cmd1 = new SqlCommand(query1, conec);
                    cmd1.Parameters.AddWithValue("@pid", Patientlogin.patientid);
                    cmd1.Parameters.AddWithValue("@docid", Doctorsindept.doctor_id);
                    cmd1.Parameters.AddWithValue("@timefrom", from.Value.TimeOfDay);
                    cmd1.Parameters.AddWithValue("@timeto", to.Value.TimeOfDay);
                    cmd1.Parameters.AddWithValue("@appointmentdate", date.Value.Date);

                    int b = cmd1.ExecuteNonQuery();
                    if (b > 0)
                    {
                        MessageBox.Show("Appointment added successfully!");
                        conec.Close();
                        loadform();

                        SqlConnection con3 = new SqlConnection(cn);
                        con3.Open();
                        string q3 = "SELECT MAX(appointment_id) FROM appointment;";
                        SqlCommand command = new SqlCommand(q3, con3);

                        int maxAppointmentId = 0; // Variable to store the maximum AppointmentId
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            maxAppointmentId = Convert.ToInt32(result);
                        }
                        con3.Close();

                        con3.Open();
                        string q4 = "INSERT INTO PatientDiseases (patient_id, doctor_id,appointment_id,description,dept_id,disease ) VALUES (@pid, @docid, @apid, @description, @deptid,@disease)";
                        SqlCommand cmd3 = new SqlCommand(q4, con3);
                        cmd3.Parameters.AddWithValue("@pid", Patientlogin.patientid);
                        cmd3.Parameters.AddWithValue("@docid", Doctorsindept.doctor_id);
                        cmd3.Parameters.AddWithValue("@apid", maxAppointmentId);
                        cmd3.Parameters.AddWithValue("@description", description.Text);
                        cmd3.Parameters.AddWithValue("@deptid", select_dept.depart_id);
                        cmd3.Parameters.AddWithValue("@disease", diseasen.Text);


                        int c = cmd3.ExecuteNonQuery();

                        if (c > 0)
                        {

                            patientchoice pc = new patientchoice();
                            this.Hide();
                            pc.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error Occured");
                        }

                    }
                    else
                    {
                        MessageBox.Show("An error occurred while adding the appointment!");
                        conec.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Enter the time between doctors schedule");
            }


        }





        private void available_docGyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
