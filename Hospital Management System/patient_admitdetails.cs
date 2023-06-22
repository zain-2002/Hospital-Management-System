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
    public partial class patient_admitdetails : Form
    {
        public patient_admitdetails()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "select adt.checkup_no,adt.id,ah.patient_id,p.pname,adt.doctor_id,d.dname,adt.disease,adt.prescription,adt.detail,adt.treat_datetime from AdmittedTreatment as adt join admithistory as ah on adt.id=ah.id join Patients as p on ah.patient_id=p.patient_id join Doctors as d on adt.doctor_id=d.doctor_id  where adt.id="+viewadmithistory.ahid;
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
