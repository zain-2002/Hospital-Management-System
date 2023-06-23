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
    public partial class schedulecrud : Form
    {
        public schedulecrud()
        {
            InitializeComponent();
            To.Format = DateTimePickerFormat.Time;
            To.ShowUpDown = true;
            From.Format = DateTimePickerFormat.Time;
            From.ShowUpDown = true;
            doc_id.Text = managedoctorschedule.doctor_id.ToString();
            doc_name.Text=managedoctorschedule.doctor_name.ToString();
            loadform();
        }
                    
        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "Select * from schedules";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void add_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string q = "select * from schedules where doctor_id=@did and day=@day ";
            SqlCommand c = new SqlCommand(q, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(doc_id.Text));
            c.Parameters.AddWithValue("@day", comboBox1.Text);

            SqlDataReader r = c.ExecuteReader();
            if (r.HasRows)
            {
                MessageBox.Show("schedule already exists");
            }
            else
            {
                con.Close();
                con.Open();
                
                string querry = "insert into Schedules (doctor_id,doctorname,[day],[from],[to]) values (@did,@dname,@day,@from,@to)";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(doc_id.Text));
                cmd.Parameters.AddWithValue("@dname", doc_name.Text);
                cmd.Parameters.AddWithValue("@day", comboBox1.Text);
                cmd.Parameters.AddWithValue("@from", From.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@to", To.Value.TimeOfDay);



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

            string q = "select * from schedules where doctor_id=@did and day=@day ";
            SqlCommand c = new SqlCommand(q, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(doc_id.Text));
            c.Parameters.AddWithValue("@day", comboBox1.Text);

            SqlDataReader r = c.ExecuteReader();
            if (r.HasRows)
            {
                MessageBox.Show("schedule already exists");
            }
            else
            {
                con.Close();
                con.Open();
                string querry = "update schedules set doctor_id=@did,dname=@dname,[day]=@day,[from]=@from,[to]=@to where doctor_id=@did";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(doc_id.Text));
                cmd.Parameters.AddWithValue("@dname", doc_name.Text);
                cmd.Parameters.AddWithValue("@day",comboBox1.Text);
                cmd.Parameters.AddWithValue("@from", From.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@to", To.Value.TimeOfDay);


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
            string querry = "delete from schedules where doctor_id=@did and day=@day";
            SqlCommand c = new SqlCommand(querry, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(doc_id.Text));
            c.Parameters.AddWithValue("@day", comboBox1.Text);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doc_id.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            doc_name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            From.Text= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            To.Text= dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
