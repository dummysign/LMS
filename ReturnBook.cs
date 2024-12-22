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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LMS
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        int count;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "select * from Ibook where st_erroll = '" + txtsearch.Text + "' and st_return_date is null";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);



                    SqlCommand sqlCommand1 = new SqlCommand();
                    sqlCommand1.Connection = con;
                    sqlCommand1.CommandText = "select count(st_erroll) from Ibook where st_erroll = '" + txtsearch.Text + "' and st_return_date is null";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                    DataSet DS = new DataSet();
                    sqlDataAdapter1.Fill(DS);



                    count = int.Parse(DS.Tables[0].Rows[0][0].ToString());


                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        datgrid.DataSource = ds.Tables[0];
                        //txtsname.Text = ds.Tables[0].Rows[0][1].ToString();
                        //txtscontact.Text = ds.Tables[0].Rows[0][2].ToString();
                        //txtssem.Text = ds.Tables[0].Rows[0][5].ToString();
                        //txtsdep.Text = ds.Tables[0].Rows[0][4].ToString();
                        //txtsemail.Text = ds.Tables[0].Rows[0][6].ToString();
                        //    txtem.Text = ds.Tables[0].Rows[0][6].ToString();
                        con.Close();
                    }
                    else
                    {
                        //txtsname.Clear();
                        //txtsdep.Clear();
                        //txtssem.Clear();
                        //txtsemail.Clear();
                        //txtscontact.Clear();
                        MessageBox.Show("No Data Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Somethins Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }

            }
            else
            {
                if (MessageBox.Show("Are You Sure You want to delete", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

    


        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        int bid;
        private void datgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(datgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "select * from Ibook where id = '" + bid + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtname.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtIssuedate.Text = ds.Tables[0].Rows[0][7].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtname.Clear();
                txtIssuedate.Clear();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtIssuedate.Clear();
            panel1.Visible = false; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            con.Open();
            sqlCommand.CommandText = "update  Ibook set st_return_date = '" + dateTimePicker1.Text + "' where id = '" + bid + "'";
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Update ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtname.Clear();
            txtIssuedate.Clear();
            panel1.Visible = false;
        }
    }
}
