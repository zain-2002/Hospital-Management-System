using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class adminviewpatients : Form
    {
        public static int patientid;
        public adminviewpatients()
        {
            InitializeComponent();
            loadform();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

        }
        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "Select * from patients";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patient_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            patientpassword.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            patientname.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            genderbox.Text= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            contactno.Text= dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            address.Text= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            email.Text= dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            patientid =Convert.ToInt32( patient_id.Text);
        }

      

        private void add_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string q = "select * from patients where patient_id=@did  ";
            SqlCommand c = new SqlCommand(q, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(patient_id.Text));

            SqlDataReader r = c.ExecuteReader();
            if (r.HasRows)
            {
                MessageBox.Show("Patient already exists");
            }
            else
            {
                con.Close();
                con.Open();

                string querry = "insert into Patients  values (@did,@pass,@dname,@dob,@gender,@cn,@address,@gmail)";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(patient_id.Text));
                cmd.Parameters.AddWithValue("@pass", patientpassword.Text);
                cmd.Parameters.AddWithValue("@dname", patientname.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@gender",genderbox.Text);
                cmd.Parameters.AddWithValue("@cn", contactno.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@gmail", email.Text);




                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Success");
                    con.Close();
                    loadform();
                }
                else
                {
                    MessageBox.Show("Failure");
                    con.Close();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string q = "select * from patients where patient_id=@did  and pname=@pn";
            SqlCommand c = new SqlCommand(q, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(patient_id.Text));
            c.Parameters.AddWithValue("@pn", patientname.Text);

            SqlDataReader r = c.ExecuteReader();
            if (r.HasRows)
            {
                MessageBox.Show("patient already exists");
            }
            else
            {
                con.Close();
                con.Open();
                string querry = "update patients set ppass=@pas,pname=@name,date_of_birth=@dob,gender=@gen,contact_number=@cn,paddress=@address,gmail=@gmail where patient_id=@pid";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(patient_id.Text));
                cmd.Parameters.AddWithValue("@pas", patientpassword.Text);
                cmd.Parameters.AddWithValue("@name", patientname.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@gen", genderbox.Text);
                cmd.Parameters.AddWithValue("@cn", contactno.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@gmail", email.Text);



                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Success");
                    con.Close();
                    loadform();
                }
                else
                {
                    MessageBox.Show("Failure");
                    con.Close();
                }

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "delete from patients where patient_id=@did ";
            SqlCommand c = new SqlCommand(querry, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(patient_id.Text));
            int a = c.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Success");
                con.Close();
                loadform();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patientdiseases pd =new Patientdiseases();
            this.Hide();
            pd.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            adminOptions adminOptions   = new adminOptions();
            this.Hide();
            adminOptions.Show();
        }
    }
}
