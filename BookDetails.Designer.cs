namespace LMS
{
    partial class BookDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.issuegrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.returngrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.issuegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returngrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(429, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
            // 
            // issuegrid
            // 
            this.issuegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuegrid.Location = new System.Drawing.Point(-1, 54);
            this.issuegrid.Name = "issuegrid";
            this.issuegrid.RowHeadersWidth = 51;
            this.issuegrid.RowTemplate.Height = 24;
            this.issuegrid.Size = new System.Drawing.Size(1058, 228);
            this.issuegrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(425, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Book";
            // 
            // returngrid
            // 
            this.returngrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returngrid.Location = new System.Drawing.Point(-1, 328);
            this.returngrid.Name = "returngrid";
            this.returngrid.RowHeadersWidth = 51;
            this.returngrid.RowTemplate.Height = 24;
            this.returngrid.Size = new System.Drawing.Size(1058, 228);
            this.returngrid.TabIndex = 3;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1058, 504);
            this.Controls.Add(this.returngrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.issuegrid);
            this.Controls.Add(this.label1);
            this.Name = "BookDetails";
            this.Text = "BookDetails";
            this.Load += new System.EventHandler(this.BookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issuegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returngrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView issuegrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView returngrid;
    }
}