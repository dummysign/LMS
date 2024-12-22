using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You want to exits","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbooks ads = new Addbooks();
            ads.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook ads = new ViewBook();
            ads.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ads = new AddStudent();
            ads.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent ads = new ViewStudent();
            ads.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            IssueBook ads = new IssueBook();
            ads.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook ads = new ReturnBook();
            ads.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BookDetails ads = new BookDetails();
            ads.Show();

        }
    }
}
