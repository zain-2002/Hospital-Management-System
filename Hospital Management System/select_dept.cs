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

            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
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

        }
    }
}
