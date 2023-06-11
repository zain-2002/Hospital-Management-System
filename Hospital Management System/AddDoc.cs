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

namespace Hospital_Management_System
{
    public partial class AddDoc : Form
    {
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

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void contactno_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void specialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cnic_TextChanged(object sender, EventArgs e)
        {


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








        
    }
}
