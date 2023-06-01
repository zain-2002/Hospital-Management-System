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
    public partial class Patientlogin : Form
    {
        public Patientlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "Select * from Patients where patient_id=@did and ppass=@dpas";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@did", textBox1.Text);
            cmd.Parameters.AddWithValue("@dpas", textBox2.Text);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Success");
                con.Close();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFirst mf = new MainFirst();
            this.Hide();
            mf.Show();
        }
    }
}
