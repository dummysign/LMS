using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txtemial.Text != "" && txtenno.Text != "" && txtdep.Text != "" && txtsem.Text != "" && txtcont.Text != "")

            {

                String stname = txtname.Text;
                String stemail = txtemial.Text;
                String stenno = txtenno.Text;
                String stdep = txtdep.Text;
                Int64 stsem = Int64.Parse(txtsem.Text);
                Int64 stcontact = Int64.Parse(txtcont.Text);
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "insert into Student (sname,scontact,senrollno,sdepartment,ssem,semail) values ( '" + stname + "','" + stcontact + "','" + stenno + "',' " + stdep + "','" + stsem + "','" + stemail + "')";
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Save ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtname.Clear();
                    txtemial.Clear();
                    txtenno.Clear();
                    txtdep.Clear();
                    txtsem.Clear();
                    txtcont.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Text Field Can not be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You want to Cancel", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtemial.Clear();
            txtenno.Clear();
            txtdep.Clear();
            txtsem.Clear();
            txtcont.Clear();
        }
    }
}
