using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class MainFirst : Form
    {
        public MainFirst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminlogin lg= new Adminlogin();
            this.Hide();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor_login dl=new doctor_login();
            this.Hide();
            dl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patientlogin patientlogin = new Patientlogin();
            this.Hide();
            patientlogin.Show();
        }
    }
}
