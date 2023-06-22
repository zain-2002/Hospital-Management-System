using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public partial class select_dept : Form
    {
<<<<<<< HEAD
        public static int depart_id;
        public select_dept()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string query = "SELECT dname FROM department";

            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            comboBox1.Items.Clear();

            while (reader.Read())
            {
                string value = reader.GetString(reader.GetOrdinal("dname"));
                comboBox1.Items.Add(value);
            }

            reader.Close();
            con.Close();
        }

  


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
=======
        public select_dept()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "update Patients set dept_id=2 where patient_id=@id";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", Patientlogin.patientid);



            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                con.Close();
                cardiac gyna = new  cardiac();
                this.Hide();
                gyna.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af

            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
<<<<<<< HEAD

            string query = "select dept_id from department where dname=@dname";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@dname", selectedValue);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int idValue = reader.GetInt32(reader.GetOrdinal("dept_id"));

                dept_id.Text = idValue.ToString();
            }

            reader.Close();
            con.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            depart_id =Convert.ToInt32( dept_id.Text);
              Doctorsindept dc=new Doctorsindept(); 
            this.Hide();    
            dc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientchoice patientchoice = new patientchoice();
            patientchoice.Show();
            this.Hide();
=======
            string querry = "update Patients set dept_id=1 where patient_id=@id";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id",Patientlogin.patientid);
       


            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                con.Close();
                Gyna gyna = new Gyna();
                this.Hide();
                gyna.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }
            
        }

        private void neuro_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "update Patients set dept_id=3 where patient_id=@id";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", Patientlogin.patientid);



            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                con.Close();
                neuro gyna = new neuro();
                this.Hide();
                gyna.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }

        }

        private void ortho_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "update Patients set dept_id=4 where patient_id=@id";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", Patientlogin.patientid);



            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                con.Close();
                ortho gyna = new ortho();
                this.Hide();
                gyna.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }

>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af
        }
    }
}
