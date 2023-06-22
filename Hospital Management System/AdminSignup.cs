using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Hospital_Management_System
{
    public partial class AdminSignup : Form
    {
        public AdminSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "adminsignup @id,@username,@apassword,@email,@contactno";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@apassword", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@contactno", textBox5.Text);

            con.InfoMessage += Connection_InfoMessage;
          


            int a = cmd.ExecuteNonQuery();  
            if (a>0)
            {
             
                Adminlogin adminlogin = new Adminlogin();
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
        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // Retrieve the print statement from the event args
            string printStatement = e.Message;

            // Display the print statement in a MessageBox or any other desired way
            MessageBox.Show(printStatement);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminlogin adminlogin = new Adminlogin();
            this.Hide();
            adminlogin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_MouseLeave(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
