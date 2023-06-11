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
    public partial class adminOptions : Form
    {
        public adminOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoc addDoc = new AddDoc();
            this.Hide();
            addDoc.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            managedoctorschedule ms=new managedoctorschedule();
            this.Hide();
            ms.Show();
        }

        private void managedepartment_Click(object sender, EventArgs e)
        {
            DepartcrudmentC c=new DepartcrudmentC();
            this.Hide();
            c.Show();
        }

        private void viewpatients_Click(object sender, EventArgs e)
        {
            adminviewpatients av=new adminviewpatients();
            this.Hide();
            av.Show();
        }
    }
}
