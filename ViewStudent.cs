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
using System.Xml.Linq;

namespace LMS
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "select * from Student";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    datgrid.DataSource = ds.Tables[0];
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
      

        int bid;
        private void datgrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (datgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(datgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "select * from Student where stid = '" + bid + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtstname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtcont.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtenroll.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtdep.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtsem.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtem.Text = ds.Tables[0].Rows[0][6].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnbookname_TextChanged(object sender, EventArgs e)
        {
            if (btnbookname.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "select * from Student where sname like '" + btnbookname.Text + "%'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        datgrid.DataSource = ds.Tables[0];
                        con.Close();
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                try
                {

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "select * from Student";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        datgrid.DataSource = ds.Tables[0];
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();

                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnbookname.Clear();
            panel3.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtstname.Text != "" && txtenroll.Text != "" && txtdep.Text != "" && txtsem.Text != "" && txtcont.Text != "" && txtem.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                String stname = txtstname.Text;
                String stemail = txtem.Text;
                String stenno = txtenroll.Text;
                String stdep = txtdep.Text;
                Int64 stsem = Int64.Parse(txtsem.Text);
                Int64 stcontact = Int64.Parse(txtcont.Text);

                try
                {
                    //SqlConnection con = new SqlConnection();
                    //con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "update  Student set sname = '" + stname + "',  scontact = '" + stcontact + "', senrollno = '" + stenno + "', sdepartment ='" + stdep + "' , ssem = '" + stsem + "', semail = '" + stemail + "' where stid = '" + bid + "'";
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Update ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtstname.Clear();
                    txtem.Clear();
                    txtenroll.Clear();
                    txtdep.Clear();
                    txtsem.Clear();
                    txtcont.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Somethings went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Text Field Can not be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You want to delete", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "delete from   Student where stid = '" + bid + "'";
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Delete ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtstname.Clear();
                txtem.Clear();
                txtenroll.Clear();
                txtdep.Clear();
                txtsem.Clear();
                txtcont.Clear();
            }
            else
            {

            }
        }
    }
}