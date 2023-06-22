using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Hospital_Management_System
{
    public partial class AddDoc : Form
    {
        Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
        public AddDoc()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "insert into Doctors values (@did,@dname,@special,@cn,@em,@dadress,@cnic,@dpass,@depid)";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@did", Convert.ToInt32(id.Text));
            cmd.Parameters.AddWithValue("@dname", name.Text);
            cmd.Parameters.AddWithValue("@special", specialization.Text);
            cmd.Parameters.AddWithValue("@cn", contactno.Text);
            cmd.Parameters.AddWithValue("@em", email.Text);
            cmd.Parameters.AddWithValue("@dadress", address.Text);
            cmd.Parameters.AddWithValue("@cnic", cnic.Text);
            cmd.Parameters.AddWithValue("@dpass", password.Text);
            cmd.Parameters.AddWithValue("@depid", dept_id.Text);

            int a = cmd.ExecuteNonQuery();
            if (a>0)
            {
                MessageBox.Show("Success");
                con.Close();
                viewandeditdoctors ve= new viewandeditdoctors();
                this.Hide();
                ve.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminOptions ao=new adminOptions();
            this.Hide();
            ao.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
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

        //private void email_Leave(object sender, EventArgs e)
        //{
        //    if (Regex.IsMatch(email.Text, @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}") ==false)
        //    {
        //        email.Focus();
        //        errorProvider1.SetError(this.email, "invalid");
        //    }
        //    else
        //    {
        //        errorProvider1.Clear();
        //    }
        //}
    }
}
