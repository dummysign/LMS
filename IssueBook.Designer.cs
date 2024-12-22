namespace LMS
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexist = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnissue = new System.Windows.Forms.Button();
            this.issuedatepicker = new System.Windows.Forms.DateTimePicker();
            this.txtsemail = new System.Windows.Forms.TextBox();
            this.txtscontact = new System.Windows.Forms.TextBox();
            this.txtssem = new System.Windows.Forms.TextBox();
            this.txtsdep = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtbookisdate = new System.Windows.Forms.Label();
            this.txtbook = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtcont = new System.Windows.Forms.Label();
            this.txtsem = new System.Windows.Forms.Label();
            this.txtdep = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(377, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(1, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 391);
            this.panel2.TabIndex = 1;
            // 
            // btnexist
            // 
            this.btnexist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexist.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexist.Location = new System.Drawing.Point(180, 335);
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
            this.btnrefresh.Location = new System.Drawing.Point(53, 335);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 31);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(66, 258);
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
            this.txtsearch.Location = new System.Drawing.Point(53, 199);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(210, 28);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Enrollment Number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnissue);
            this.panel3.Controls.Add(this.issuedatepicker);
            this.panel3.Controls.Add(this.txtsemail);
            this.panel3.Controls.Add(this.txtscontact);
            this.panel3.Controls.Add(this.txtssem);
            this.panel3.Controls.Add(this.txtsdep);
            this.panel3.Controls.Add(this.txtsname);
            this.panel3.Controls.Add(this.txtbookisdate);
            this.panel3.Controls.Add(this.txtbook);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.txtcont);
            this.panel3.Controls.Add(this.txtsem);
            this.panel3.Controls.Add(this.txtdep);
            this.panel3.Controls.Add(this.txtname);
            this.panel3.Location = new System.Drawing.Point(316, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 391);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(142, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Maximum 3 Books Can be Issue To 1 Studnet";
            // 
            // btnissue
            // 
            this.btnissue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnissue.BackColor = System.Drawing.Color.Silver;
            this.btnissue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnissue.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnissue.Location = new System.Drawing.Point(287, 324);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(130, 31);
            this.btnissue.TabIndex = 14;
            this.btnissue.Text = "Issue Book";
            this.btnissue.UseVisualStyleBackColor = false;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // issuedatepicker
            // 
            this.issuedatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issuedatepicker.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedatepicker.Location = new System.Drawing.Point(177, 280);
            this.issuedatepicker.Name = "issuedatepicker";
            this.issuedatepicker.Size = new System.Drawing.Size(265, 28);
            this.issuedatepicker.TabIndex = 13;
            // 
            // txtsemail
            // 
            this.txtsemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsemail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemail.Location = new System.Drawing.Point(179, 196);
            this.txtsemail.Name = "txtsemail";
            this.txtsemail.ReadOnly = true;
            this.txtsemail.Size = new System.Drawing.Size(263, 28);
            this.txtsemail.TabIndex = 11;
            // 
            // txtscontact
            // 
            this.txtscontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtscontact.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscontact.Location = new System.Drawing.Point(179, 152);
            this.txtscontact.Name = "txtscontact";
            this.txtscontact.ReadOnly = true;
            this.txtscontact.Size = new System.Drawing.Size(263, 28);
            this.txtscontact.TabIndex = 10;
            // 
            // txtssem
            // 
            this.txtssem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtssem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtssem.Location = new System.Drawing.Point(179, 109);
            this.txtssem.Name = "txtssem";
            this.txtssem.ReadOnly = true;
            this.txtssem.Size = new System.Drawing.Size(263, 28);
            this.txtssem.TabIndex = 9;
            // 
            // txtsdep
            // 
            this.txtsdep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsdep.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdep.Location = new System.Drawing.Point(179, 67);
            this.txtsdep.Name = "txtsdep";
            this.txtsdep.ReadOnly = true;
            this.txtsdep.Size = new System.Drawing.Size(263, 28);
            this.txtsdep.TabIndex = 8;
            // 
            // txtsname
            // 
            this.txtsname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsname.Location = new System.Drawing.Point(179, 28);
            this.txtsname.Name = "txtsname";
            this.txtsname.ReadOnly = true;
            this.txtsname.Size = new System.Drawing.Size(263, 28);
            this.txtsname.TabIndex = 7;
            // 
            // txtbookisdate
            // 
            this.txtbookisdate.AutoSize = true;
            this.txtbookisdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookisdate.Location = new System.Drawing.Point(29, 285);
            this.txtbookisdate.Name = "txtbookisdate";
            this.txtbookisdate.Size = new System.Drawing.Size(120, 21);
            this.txtbookisdate.TabIndex = 6;
            this.txtbookisdate.Text = "Book Issue Date";
            // 
            // txtbook
            // 
            this.txtbook.AutoSize = true;
            this.txtbook.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbook.Location = new System.Drawing.Point(29, 244);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(90, 21);
            this.txtbook.TabIndex = 5;
            this.txtbook.Text = "Book Name";
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(29, 201);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(107, 21);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "Student Email";
            // 
            // txtcont
            // 
            this.txtcont.AutoSize = true;
            this.txtcont.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcont.Location = new System.Drawing.Point(26, 158);
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(123, 21);
            this.txtcont.TabIndex = 3;
            this.txtcont.Text = "Student Contact";
            // 
            // txtsem
            // 
            this.txtsem.AutoSize = true;
            this.txtsem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsem.Location = new System.Drawing.Point(15, 116);
            this.txtsem.Name = "txtsem";
            this.txtsem.Size = new System.Drawing.Size(134, 21);
            this.txtsem.TabIndex = 2;
            this.txtsem.Text = "Student Semester";
            // 
            // txtdep
            // 
            this.txtdep.AutoSize = true;
            this.txtdep.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdep.Location = new System.Drawing.Point(26, 71);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(94, 21);
            this.txtdep.TabIndex = 1;
            this.txtdep.Text = "Department";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(26, 28);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(110, 21);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "Student Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 29);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnexist;
        private System.Windows.Forms.Label txtbook;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtcont;
        private System.Windows.Forms.Label txtsem;
        private System.Windows.Forms.Label txtdep;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.TextBox txtsemail;
        private System.Windows.Forms.TextBox txtscontact;
        private System.Windows.Forms.TextBox txtssem;
        private System.Windows.Forms.TextBox txtsdep;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label txtbookisdate;
        private System.Windows.Forms.DateTimePicker issuedatepicker;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}