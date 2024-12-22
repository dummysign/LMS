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
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "select * from Ibook where  st_return_date is null";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);



                SqlCommand sqlCommand1 = new SqlCommand();
                sqlCommand1.Connection = con;
                sqlCommand1.CommandText = "select* from Ibook where  st_return_date is not null";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                DataSet DS = new DataSet();
                sqlDataAdapter1.Fill(DS);



                if (ds.Tables[0].Rows.Count > 0)
                {

                    issuegrid.DataSource = ds.Tables[0];

                    con.Close();
                }
                else
                {

                    MessageBox.Show("No Data Found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (DS.Tables[0].Rows.Count > 0)
                {

                    returngrid.DataSource = DS.Tables[0];
                 
                    con.Close();
                }
                else
                {
                
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
    }
}
