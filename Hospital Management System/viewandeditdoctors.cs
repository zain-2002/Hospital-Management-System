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
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class viewandeditdoctors : Form
    {
      public static int docid = 0,  depid = 0;
      public static string docname = "", contactno = "",specialization = "", email = "", docaddress = "", cnic = "", docpass = "";

        private void DELETE_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "delete from Doctors where doctor_id=@did";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@did", docid);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            docid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            docname= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            specialization= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            contactno= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            docaddress = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cnic = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            docpass = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            depid= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value);
        }

        public viewandeditdoctors()
        {
            InitializeComponent();

            loadform();
        }
        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "Select * from doctors";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            AddDoc ad=new AddDoc();
            this.Hide();
            ad.Show();
        }

        private void adminoption_Click(object sender, EventArgs e)
        {
           adminOptions ao=new adminOptions();
            this.Hide();
            ao.Show();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            UpdateDoctors up=new UpdateDoctors();   
            this.Hide();
            up.Show();
        }
    }
}
