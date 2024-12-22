using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Addbooks : Form
    {
        public Addbooks()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            if(txtbkname.Text != "" && txtauthname.Text != "" && txtPub.Text != "" && txtPdate.Text != ""&& txtPrice.Text != "" && txtQua.Text != ""){
                String bookname = txtbkname.Text;
                String Authname = txtauthname.Text;
                String PubName = txtPub.Text;
                String Pubdate = txtPdate.Text;
                Int64 PPrice = Int64.Parse(txtPrice.Text);
                Int64 Quan = Int64.Parse(txtQua.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                con.Open();
                sqlCommand.CommandText = "insert into newbook (bname,bAut,bPub,bPDate,bPrice,bQuan) values ( '" + bookname + "','" + Authname + "','" + PubName + "',' " + Pubdate + "','" + PPrice + "','" + Quan + "')";
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Save ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbkname.Clear();
                txtauthname.Clear();
                txtPub.Clear();
                txtQua.Clear();
                txtPrice.Clear();
            }
            else {
                MessageBox.Show("Text Field Can not be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You want to Cancel", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateExcelTemplate();
        }
        private void GenerateExcelTemplate()
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Explicitly specify namespace

            string filePath = "BookTemplate.xlsx";

            using (OfficeOpenXml.ExcelPackage package = new OfficeOpenXml.ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Book Template");

                // Add headers
                worksheet.Cells[1, 1].Value = "Book Name";
                worksheet.Cells[1, 2].Value = "Author Name";
                worksheet.Cells[1, 3].Value = "Publisher Name";
                worksheet.Cells[1, 4].Value = "Publish Date (YYYY-MM-DD)";
                worksheet.Cells[1, 5].Value = "Price";
                worksheet.Cells[1, 6].Value = "Quantity";

                // Style the headers
                using (var range = worksheet.Cells[1, 1, 1, 6])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                // Auto-fit columns
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Save the Excel file
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }

            MessageBox.Show($"Template saved to {filePath}");
        }

        private void btnuploadexcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Select Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ProcessUploadedExcel(filePath);
            }
        }
        private void ProcessUploadedExcel(string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                using (SqlConnection con = new SqlConnection("data source = DESKTOP-R27G0NV ; database = dbschool ; integrated security = True"))
                {
                    con.Open();
                    for (int row = 2; row <= rowCount; row++) // Skip header row
                    {
                        string bookName = worksheet.Cells[row, 1].Text;
                        string authorName = worksheet.Cells[row, 2].Text;
                        string publisherName = worksheet.Cells[row, 3].Text;
                        string publishDate = worksheet.Cells[row, 4].Text;
                        decimal price = decimal.Parse(worksheet.Cells[row, 5].Text);
                        int quantity = int.Parse(worksheet.Cells[row, 6].Text);

                        string query = "INSERT INTO newbook (bname,bAut,bPub,bPDate,bPrice,bQuan) " +
                                       "VALUES (@BookName, @AuthorName, @PublisherName, @PublishDate, @Price, @Quantity)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BookName", bookName);
                            cmd.Parameters.AddWithValue("@AuthorName", authorName);
                            cmd.Parameters.AddWithValue("@PublisherName", publisherName);
                            cmd.Parameters.AddWithValue("@PublishDate", DateTime.Parse(publishDate));
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Books added successfully!");
            }
        }

    }
}
