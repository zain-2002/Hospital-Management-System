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
            string querry = "Select * from admin_tb";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader rd=cmd.ExecuteReader();
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

        private void button3_Click(object sender, EventArgs e)
        {
            MainFirst mf=new MainFirst();
            this.Hide();
            mf.Show();
        }

       
    }
}
