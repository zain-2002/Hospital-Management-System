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
        }
    }
}
