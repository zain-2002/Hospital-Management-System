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
    public partial class doctor_login : Form
    {
        public static int doc_id=0;
        public doctor_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 0)
            {
                MessageBox.Show("Can not insert negative values");
                
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string querry = "Select * from doctors where doctor_id=@did and dpass=@dpas";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@did", textBox1.Text);
                cmd.Parameters.AddWithValue("@dpas", textBox2.Text);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    MessageBox.Show("Success");
                    con.Close();
                    doc_id = Convert.ToInt32(textBox1.Text);
                    Doctoractionchoice dc = new Doctoractionchoice();
                    this.Hide();
                    dc.Show();
                }
                else
                {
                    MessageBox.Show("Failure");
                    con.Close();
                }

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            MainFirst mf=new MainFirst();
            this.Hide();
            mf.Show();  
        }

<<<<<<< HEAD
=======
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctor_login_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af
    }
}
