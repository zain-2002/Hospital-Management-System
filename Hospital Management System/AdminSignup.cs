﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Hospital_Management_System
{
    public partial class AdminSignup : Form
    {
        public AdminSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "insert into admin_tb values (@id,@username,@pass,@email,@cn)";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@cn", textBox5.Text);

            int a = cmd.ExecuteNonQuery();  
            if (a>0)
            {
                MessageBox.Show("Success");
                Adminlogin adminlogin = new Adminlogin();
                this.Hide();
                adminlogin.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Failure");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminlogin adminlogin = new Adminlogin();
            this.Hide();
            adminlogin.Show();
        }
    }
}