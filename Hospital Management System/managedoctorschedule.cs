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
    public partial class managedoctorschedule : Form
    {
        public static int doctor_id = 0;public static string doctor_name = "";
        public managedoctorschedule()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "Select * from Doctors";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void managescedule_Click(object sender, EventArgs e)
        {
            schedulecrud sc=new schedulecrud();
            this.Hide();
            sc.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doctor_id =Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value);
            doctor_name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }
    }
}
