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
    public partial class UpdateDoctors : Form
    {
        public UpdateDoctors()
        {
            InitializeComponent();
            id.Text = viewandeditdoctors.docid.ToString();
            name.Text = viewandeditdoctors.docname;
            password.Text = viewandeditdoctors.docpass;
            specialization.Text = viewandeditdoctors.specialization;
            email.Text = viewandeditdoctors.email;
            contactno.Text = viewandeditdoctors.contactno.ToString();
            address.Text = viewandeditdoctors.docaddress;
            cnic.Text = viewandeditdoctors.cnic;
            departmentid.Text = viewandeditdoctors.depid.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            viewandeditdoctors v = new viewandeditdoctors();
            this.Hide();
            v.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "update doctors set doctor_id=@did,dname=@dname,specialization=@special,contact_number=@cn,email=@em,daddress=@dadress,cnic=@cnic,dpass=@dpass,dept_id=@depid where doctor_id=@did";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@did", Convert.ToInt32(id.Text));
            cmd.Parameters.AddWithValue("@dname", name.Text);
            cmd.Parameters.AddWithValue("@special", specialization.Text);
            cmd.Parameters.AddWithValue("@cn", contactno.Text);
            cmd.Parameters.AddWithValue("@em", email.Text);
            cmd.Parameters.AddWithValue("@dadress", address.Text);
            cmd.Parameters.AddWithValue("@cnic", cnic.Text);
            cmd.Parameters.AddWithValue("@dpass", password.Text);
            cmd.Parameters.AddWithValue("@depid", departmentid.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Success");
                con.Close();
                viewandeditdoctors ve = new viewandeditdoctors();
                this.Hide();
                ve.Show();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }


        }

        
    }
}