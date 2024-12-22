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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LMS
{
    public partial class SingupPAge : Form
    {
        public SingupPAge()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedrole = 0;   
            bool group1Selected = radiobtn1.Checked;

            if (radiobtn1.Checked)
            {
                selectedrole = 4;
            }
            else if(radiobtn2.Checked) 
            {
                selectedrole = 1;
            }
            else if (radiobtn3.Checked)
            {
                selectedrole = 4;
            }else 
            {
                MessageBox.Show("Please select an option in each group.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtname.Text != "" && txtemial.Text != "" && txtcontact.Text != "" && password.Text != "" && txtconfirmpass.Text != "")
            {
                String name = txtname.Text;
                String email = txtemial.Text;
                Int64 contact =Int64.Parse(txtcontact.Text) ;
                String pasword = password.Text;
                String confirmpass = txtconfirmpass.Text;
                String dob = dbpicker.Text;

                if (!confirmpass.Equals(pasword))
                {
                    MessageBox.Show("Password Not Match", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";

                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "insert into MasterUser (UserName,UserEmail,UserPassword,UserPhone_number,UserDate_of_birth,UserUserRole) values ( '"+name+"','" +email+"','" +pasword+"',' "+contact+"','"+dob+ "','"+selectedrole+"')";
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Save ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtname.Clear();
                    txtemial.Clear();
                    txtcontact.Clear();
                    password.Clear();
                    txtconfirmpass.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("SomeTHings Went Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                MessageBox.Show("Text Field Can not be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void password_MouseEnter(object sender, EventArgs e)
        {
            password.Clear();
            password.PasswordChar = '*';
        }

        private void txtconfirmpass_MouseEnter(object sender, EventArgs e)
        {
            txtconfirmpass.Clear();
            txtconfirmpass.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ads = new Form1();
            ads.Show();

        }
    }
}
