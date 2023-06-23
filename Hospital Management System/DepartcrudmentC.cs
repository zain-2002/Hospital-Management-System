using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class DepartcrudmentC : Form
    {
        public DepartcrudmentC()
        {
            InitializeComponent();
            loadform();
        }
        public void loadform()
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "Select * from department";
            SqlDataAdapter adapter = new SqlDataAdapter(querry, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string querry = "delete from department where dept_id=@did";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@did", deptid.Text);
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

        private void update_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
           
            string q = "select * from department where dept_id=@did and dname=@dn";
            SqlCommand c = new SqlCommand(q, con);
            c.Parameters.AddWithValue("@did", Convert.ToInt32(deptid.Text));
            c.Parameters.AddWithValue("@dn", deptname.Text);
            SqlDataReader r= c.ExecuteReader();
            if (r.HasRows)
            {
                MessageBox.Show("Department already exists");
            }
            else
            {
                con.Close();
                con.Open();
                string querry = "update department set dname=@dname where dept_id=@did";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.Parameters.AddWithValue("@did", Convert.ToInt32(deptid.Text));
                cmd.Parameters.AddWithValue("@dname", deptname.Text);

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
           
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["AAZ"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                string q = "select * from department where dname=@dn";
                SqlCommand c = new SqlCommand(q, con);
                c.Parameters.AddWithValue("@did", Convert.ToInt32(deptid.Text));
                c.Parameters.AddWithValue("@dn", deptname.Text);
                SqlDataReader r = c.ExecuteReader();
                if (r.HasRows)
                {
                    MessageBox.Show("Department already exists");
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string querry = "insert into department values (@did,@dname)";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.Parameters.AddWithValue("@did", Convert.ToInt32(deptid.Text));
                    cmd.Parameters.AddWithValue("@dname", deptname.Text);


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
            }
            catch
            {
                MessageBox.Show("Id already used!!!");
            }
               
            }
           



        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deptid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
            deptname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
