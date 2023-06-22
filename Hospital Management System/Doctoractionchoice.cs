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
    public partial class Doctoractionchoice : Form
    {
        public Doctoractionchoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewappointmentstodoc vd= new viewappointmentstodoc();
            this.Hide();
            vd.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dealedpatients dp= new dealedpatients();
            this.Hide();
            dp.Show();
        }

        private void viewadmittedpatients_Click(object sender, EventArgs e)
        {
            view_admittedpatients dp= new view_admittedpatients();      
            this.Hide();
            dp.Show();
        }

        private void viewtreatedpatients_Click(object sender, EventArgs e)
        {
            view_treatedpatients   treatedpatients  = new view_treatedpatients();
               this.Hide(); 
            treatedpatients.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminOptions   adminOptions = new adminOptions();
            adminOptions.Show();
            this.Hide();
        }
    }
}
