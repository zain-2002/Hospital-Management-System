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
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class Doctorsindept : Form
    {
        public static int doctor_id;
        public static TimeSpan scfromtime;
        public static TimeSpan sctotime;
        public static string day;
        public Doctorsindept()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select d.doctor_id,d.dname,d.specialization,d.email,sc.[day],sc.[from],sc.[to] from Doctors as d join schedules as sc on d.doctor_id=sc.doctor_id where d.dept_id="+ select_dept.depart_id;
          SqlDataAdapter adapter = new SqlDataAdapter(querry,con);    
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;   
           con.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_dept select_Dept = new select_dept();
            this.Hide();
            select_Dept.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            day = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (dataGridView1.Rows[0].Cells[5].Value != null &&
    TimeSpan.TryParse(dataGridView1.Rows[0].Cells[5].Value.ToString(), out TimeSpan timeValue))
            {
                scfromtime = timeValue;
            }
            if (dataGridView1.Rows[0].Cells[6].Value != null &&
TimeSpan.TryParse(dataGridView1.Rows[0].Cells[6].Value.ToString(), out TimeSpan timeValue1))
            {
                sctotime = timeValue1;
            }
            appointmentbooking appointment = new appointmentbooking();
            this.Hide();
            appointment.Show();   
        }

       
    }
}
