namespace LMS
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbookname = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.txtauthname = new System.Windows.Forms.TextBox();
            this.txtpubname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtqua = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtpubdate = new System.Windows.Forms.DateTimePicker();
            this.datgrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 154);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(577, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // btnbookname
            // 
            this.btnbookname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookname.Location = new System.Drawing.Point(343, 174);
            this.btnbookname.Name = "btnbookname";
            this.btnbookname.Size = new System.Drawing.Size(219, 28);
            this.btnbookname.TabIndex = 2;
            this.btnbookname.TextChanged += new System.EventHandler(this.btnbookname_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(587, 172);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refreash";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Publication Name";
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(188, 42);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(230, 28);
            this.txtbookname.TabIndex = 3;
            // 
            // txtauthname
            // 
            this.txtauthname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauthname.Location = new System.Drawing.Point(188, 103);
            this.txtauthname.Name = "txtauthname";
            this.txtauthname.Size = new System.Drawing.Size(230, 28);
            this.txtauthname.TabIndex = 4;
            // 
            // txtpubname
            // 
            this.txtpubname.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpubname.Location = new System.Drawing.Point(188, 164);
            this.txtpubname.Name = "txtpubname";
            this.txtpubname.Size = new System.Drawing.Size(230, 28);
            this.txtpubname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Book Purchase Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Book Price";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(634, 103);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(270, 28);
            this.txtprice.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Book Qunatity";
            // 
            // txtqua
            // 
            this.txtqua.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqua.Location = new System.Drawing.Point(634, 161);
            this.txtqua.Name = "txtqua";
            this.txtqua.Size = new System.Drawing.Size(270, 28);
            this.txtqua.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.txtpubdate);
            this.panel3.Controls.Add(this.txtqua);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtpubname);
            this.panel3.Controls.Add(this.txtauthname);
            this.panel3.Controls.Add(this.txtbookname);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 275);
            this.panel3.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(773, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(634, 229);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(80, 35);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(489, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtpubdate
            // 
            this.txtpubdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpubdate.Location = new System.Drawing.Point(634, 39);
            this.txtpubdate.Name = "txtpubdate";
            this.txtpubdate.Size = new System.Drawing.Size(270, 28);
            this.txtpubdate.TabIndex = 0;
            // 
            // datgrid
            // 
            this.datgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrid.Location = new System.Drawing.Point(1, 208);
            this.datgrid.Name = "datgrid";
            this.datgrid.RowHeadersWidth = 51;
            this.datgrid.RowTemplate.Height = 24;
            this.datgrid.Size = new System.Drawing.Size(937, 224);
            this.datgrid.TabIndex = 6;
            this.datgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datgrid_CellClick);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(960, 530);
            this.Controls.Add(this.datgrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnbookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btnbookname;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.TextBox txtauthname;
        private System.Windows.Forms.TextBox txtpubname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtqua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker txtpubdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView datgrid;
    }
}