using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {

            panel3.Visible = false;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "select * from newbook";
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
        private void datgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(datgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection();
                con.Open();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "select * from newbook where bid = '" + bid + "'";
                sqlCommand.Connection = con;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtbookname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtauthname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtpubname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtpubdate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtprice.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtqua.Text = ds.Tables[0].Rows[0][6].ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Username and Passwor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnbookname_TextChanged(object sender, EventArgs e)
        {
            if(btnbookname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "select * from newbook where bname like '"+btnbookname.Text+"%'";
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
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    con.Open();
                    sqlCommand.CommandText = "select * from newbook";
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnbookname.Clear();
            panel3.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtauthname.Text != "" && txtpubname.Text != "" && txtpubdate.Text != "" && txtprice.Text != "" && txtqua.Text != "")
            {
                String bookname = txtbookname.Text;
                String Authname = txtauthname.Text;
                String PubName = txtpubname.Text;
                String Pubdate = txtpubdate.Text;
                String PPrice = txtprice.Text;
                Int64 Quan = Int64.Parse(txtqua.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "update  newbook set bname = '"+ bookname + "',  bAut = '"+ Authname + "', bPub = '"+Authname+"', bPDate ='"+ Pubdate + "' , bPrice = '"+ PPrice + "', bQuan = '"+Quan+"' where bid = '"+ bid + "'";
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Update ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbookname.Clear();
                txtauthname.Clear();
                txtpubname.Clear();
                txtprice.Clear();
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
                sqlCommand.CommandText = "delete from   newbook where bid = '" + bid + "'";
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Delete ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbookname.Clear();
                txtauthname.Clear();
                txtpubname.Clear();
                txtprice.Clear();
            }else
            {

            }
        }
    }
}
