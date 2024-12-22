namespace LMS
{
    partial class ReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexist = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datgrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbook = new System.Windows.Forms.Label();
            this.issuedate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtIssuedate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnexist);
            this.panel2.Controls.Add(this.btnrefresh);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 543);
            this.panel2.TabIndex = 2;
            // 
            // btnexist
            // 
            this.btnexist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexist.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.Location = new System.Drawing.Point(217, 335);
            this.btnexist.Name = "btnexist";
            this.btnexist.Size = new System.Drawing.Size(83, 31);
            this.btnexist.TabIndex = 5;
            this.btnexist.Text = "Exits";
            this.btnexist.UseVisualStyleBackColor = true;
            this.btnexist.Click += new System.EventHandler(this.btnexist_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(90, 335);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 31);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(98, 263);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(182, 35);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search Student";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(90, 204);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(210, 28);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Enrollment Number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // datgrid
            // 
            this.datgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrid.Location = new System.Drawing.Point(392, 0);
            this.datgrid.Name = "datgrid";
            this.datgrid.RowHeadersWidth = 51;
            this.datgrid.RowTemplate.Height = 24;
            this.datgrid.Size = new System.Drawing.Size(824, 315);
            this.datgrid.TabIndex = 8;
            this.datgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgrid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnreturn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtIssuedate);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.issuedate);
            this.panel1.Controls.Add(this.txtbook);
            this.panel1.Location = new System.Drawing.Point(388, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 226);
            this.panel1.TabIndex = 9;
            // 
            // txtbook
            // 
            this.txtbook.AutoSize = true;
            this.txtbook.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbook.Location = new System.Drawing.Point(78, 48);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(90, 21);
            this.txtbook.TabIndex = 0;
            this.txtbook.Text = "Book Name";
            // 
            // issuedate
            // 
            this.issuedate.AutoSize = true;
            this.issuedate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedate.Location = new System.Drawing.Point(78, 97);
            this.issuedate.Name = "issuedate";
            this.issuedate.Size = new System.Drawing.Size(120, 21);
            this.issuedate.TabIndex = 1;
            this.issuedate.Text = "Book Issue Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Return Date";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(238, 48);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(307, 28);
            this.txtname.TabIndex = 3;
            // 
            // txtIssuedate
            // 
            this.txtIssuedate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedate.Location = new System.Drawing.Point(238, 94);
            this.txtIssuedate.Name = "txtIssuedate";
            this.txtIssuedate.Size = new System.Drawing.Size(307, 28);
            this.txtIssuedate.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 28);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Gray;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreturn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(599, 97);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(107, 28);
            this.btnreturn.TabIndex = 6;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Gray;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(599, 143);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(107, 28);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datgrid);
            this.Controls.Add(this.panel2);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView datgrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label issuedate;
        private System.Windows.Forms.Label txtbook;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIssuedate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
    }
}