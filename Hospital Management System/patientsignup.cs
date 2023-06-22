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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class patientsignup : Form
    {
        public patientsignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "insert into patients (patient_id,pname,ppass,gmail,contact_number,gender,date_of_birth,paddress) values (@id,@username,@pass,@email,@cn,@gender,@dob,@paddress)";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@username", patientname.Text);
            cmd.Parameters.AddWithValue("@pass", patientpassword.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@cn", contactno.Text);
            cmd.Parameters.AddWithValue("@gender", genderbox.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@paddress", address.Text);
           

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Success");
                Patientlogin adminlogin = new Patientlogin();
                this.Hide();
                adminlogin.Show();
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
            Patientlogin pl= new Patientlogin();
            this.Hide();
            pl.Show();
        }

<<<<<<< HEAD
        private void email_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(email.Text, @"^[a-zA-Z0-9_.+-]+@gmail\.com$"))
            {
                email.Focus();
                errorProvider1.SetError(email, "Please enter a valid Gmail address.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void patientsignup_Load(object sender, EventArgs e)
        {

        }
=======
      
>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af
    }
}
