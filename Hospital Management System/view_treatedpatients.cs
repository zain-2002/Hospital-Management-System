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
    public partial class view_treatedpatients : Form
    {
        public view_treatedpatients()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Doctoractionchoice  doctoractionchoice  = new Doctoractionchoice();
            doctoractionchoice.Show();
            this.Hide();
        }
    }
}
