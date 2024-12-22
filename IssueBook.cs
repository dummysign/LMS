using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "select  bname from newbook ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string namee = ds.Tables[0].Rows[i]["bname"].ToString();
                        comboBox1.Items.Add(namee);
                    }
                       
                }
              
                else
                {

                }
            }
            catch (Exception ex)
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
                    sqlCommand.CommandText = "select * from Student where senrollno = '" + txtsearch.Text + "'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);



                    SqlCommand sqlCommand1 = new SqlCommand();
                    sqlCommand1.Connection = con;
                    sqlCommand1.CommandText = "select count(st_erroll) from Ibook where st_erroll = '" + txtsearch.Text + "' and st_return_date is not null";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                    DataSet DS = new DataSet();
                    sqlDataAdapter1.Fill(DS);



                    count = int.Parse(DS.Tables[0].Rows[0][0].ToString());


                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtsname.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtscontact.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtssem.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtsdep.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtsemail.Text = ds.Tables[0].Rows[0][6].ToString();
                        //    txtem.Text = ds.Tables[0].Rows[0][6].ToString();
                        con.Close();
                    }
                    else
                    {
                        txtsname.Clear();
                        txtsdep.Clear();
                        txtssem.Clear();
                        txtsemail.Clear();
                        txtscontact.Clear();
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

        private void btnissue_Click(object sender, EventArgs e)
        {
            if(txtname.Text != "")
            {
                if(comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    String studentname = txtsname.Text;
                    String dep = txtsdep.Text;
                    String semester = txtssem.Text;
                    Int64 contactnumber =Int64.Parse(txtscontact.Text);
                    String bookname = comboBox1.Text;
                    String enrollnumber = txtsearch.Text;
                    String email = txtsemail.Text;
                    String bookissuedate = issuedatepicker.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = con;
                        con.Open();
                        sqlCommand.CommandText = "insert into Ibook (st_erroll,st_name,st_dep,st_sem,st_contact,st_nane,st_issue_date,st_bookname) values ( '" + enrollnumber + "','" + studentname + "','" + dep + "',' " + semester + "','" + contactnumber + "','" + email + "','"+ bookissuedate + "','"+ bookname + "')";
                        sqlCommand.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Save ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsname.Clear();
                        txtsdep.Clear();
                        txtssem.Clear();
                        txtscontact.Clear();
                        txtsearch.Clear();
                        txtsemail.Clear();
                        issuedatepicker.Value = DateTime.Now;
                        comboBox1.Text = "";


                    }
                    catch(Exception ex)
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
                    MessageBox.Show("Select Book. Or Maximum Number of Book Was Reached", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text == "")
            {
                txtsname.Clear();
                txtsdep.Clear();
                txtssem.Clear();
                txtscontact.Clear();
                txtsearch.Clear();
                txtsemail.Clear();
            }
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
