using System;
using System.Collections.Generic;
using System.ComponentModel;
<<<<<<< HEAD
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
=======
using System.Data;
>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class patientchoice : Form
    {
        public patientchoice()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
      
=======
        private void button4_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af

        private void button1_Click(object sender, EventArgs e)
        {
            select_dept appointment = new select_dept();  
            this.Hide();
            appointment.Show(); 
        }
<<<<<<< HEAD



        private void button3_Click(object sender, EventArgs e)
        {
            viewappointment vp = new viewappointment(); 
            this.Hide();
            vp.Show();
        }


      
           
        

        private void button2_Click(object sender, EventArgs e)
        {
            patient_patientdiseases pd = new patient_patientdiseases();
            this.Hide();
            pd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Patientlogin patientlogin = new Patientlogin();
            this.Hide();
            patientlogin.Show();
        }
=======
>>>>>>> 6ad67cd0fcf0d6f2ac968f817693bca97099a2af
    }
}
