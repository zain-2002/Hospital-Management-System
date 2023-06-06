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
    public partial class AddDoc : Form
    {
        public AddDoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "insert into Doctors values (@did,@dname,@special,@cn,@em,@dadress,@cnic,@dpass)";
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
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }



        }
    }
}
