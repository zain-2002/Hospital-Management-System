using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Hospital_Management_System
{
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSignup adminSignup = new AdminSignup();
            this.Hide();
            adminSignup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con=new SqlConnection(cs);
            con.Open();
            string querry = "Select * from admin_tb where id=@id and username=@usrname and apassword=@pas and email=@email";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", uid.Text);
            cmd.Parameters.AddWithValue("@usrname", uname.Text);
            cmd.Parameters.AddWithValue("@pas", password.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);

            SqlDataReader rd =cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Success");
                con.Close();
                adminOptions ao = new adminOptions();
                this.Hide();
                ao.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFirst mf=new MainFirst();
            this.Hide();
            mf.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

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

    }
}
