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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_MouseEnter(object sender, EventArgs e)
        {
            if(txtusername.Text == "Username")
            {
                txtusername.Clear();    
            }
        }

        private void txtpassword_MouseEnter(object sender, EventArgs e)
        {


            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "select * from Masteruser where Username = '"+txtusername.Text+ "' and UserPassword = '"+txtpassword.Text+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0 )
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and Passwor","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingupPAge ads = new SingupPAge();
            ads.Show();
        }
    }
}
