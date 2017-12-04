namespace CourseProject.Forms.Serieses
{
    partial class AddSeries
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.LableNameSer = new System.Windows.Forms.Label();
            this.LabelFirstBook = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelAuthorSeries = new System.Windows.Forms.Label();
            this.ButAddSeries = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.CBFirstName = new System.Windows.Forms.ComboBox();
            this.CBLastName = new System.Windows.Forms.ComboBox();
            this.CBAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(159, 39);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            // 
            // LableNameSer
            // 
            this.LableNameSer.AutoSize = true;
            this.LableNameSer.Location = new System.Drawing.Point(12, 39);
            this.LableNameSer.Name = "LableNameSer";
            this.LableNameSer.Size = new System.Drawing.Size(121, 13);
            this.LableNameSer.TabIndex = 4;
            this.LableNameSer.Text = "Name of series of books";
            // 
            // LabelFirstBook
            // 
            this.LabelFirstBook.AutoSize = true;
            this.LabelFirstBook.Location = new System.Drawing.Point(13, 91);
            this.LabelFirstBook.Name = "LabelFirstBook";
            this.LabelFirstBook.Size = new System.Drawing.Size(95, 13);
            this.LabelFirstBook.TabIndex = 5;
            this.LabelFirstBook.Text = "First book of series";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(16, 140);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(96, 13);
            this.LabelLastName.TabIndex = 6;
            this.LabelLastName.Text = "Last book of series";
            // 
            // LabelAuthorSeries
            // 
            this.LabelAuthorSeries.AutoSize = true;
            this.LabelAuthorSeries.Location = new System.Drawing.Point(15, 190);
            this.LabelAuthorSeries.Name = "LabelAuthorSeries";
            this.LabelAuthorSeries.Size = new System.Drawing.Size(38, 13);
            this.LabelAuthorSeries.TabIndex = 7;
            this.LabelAuthorSeries.Text = "Author";
            // 
            // ButAddSeries
            // 
            this.ButAddSeries.Location = new System.Drawing.Point(159, 221);
            this.ButAddSeries.Name = "ButAddSeries";
            this.ButAddSeries.Size = new System.Drawing.Size(75, 23);
            this.ButAddSeries.TabIndex = 8;
            this.ButAddSeries.Text = "Enter";
            this.ButAddSeries.UseVisualStyleBackColor = true;
            this.ButAddSeries.Click += new System.EventHandler(this.ButAddSeries_Click_1);
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(19, 220);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 9;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click_1);
            // 
            // CBFirstName
            // 
            this.CBFirstName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFirstName.FormattingEnabled = true;
            this.CBFirstName.Location = new System.Drawing.Point(159, 91);
            this.CBFirstName.Name = "CBFirstName";
            this.CBFirstName.Size = new System.Drawing.Size(121, 21);
            this.CBFirstName.TabIndex = 10;
            // 
            // CBLastName
            // 
            this.CBLastName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLastName.FormattingEnabled = true;
            this.CBLastName.Location = new System.Drawing.Point(159, 140);
            this.CBLastName.Name = "CBLastName";
            this.CBLastName.Size = new System.Drawing.Size(121, 21);
            this.CBLastName.TabIndex = 11;
            // 
            // CBAuthor
            // 
            this.CBAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAuthor.FormattingEnabled = true;
            this.CBAuthor.Location = new System.Drawing.Point(159, 190);
            this.CBAuthor.Name = "CBAuthor";
            this.CBAuthor.Size = new System.Drawing.Size(121, 21);
            this.CBAuthor.TabIndex = 12;
            // 
            // AddSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CBAuthor);
            this.Controls.Add(this.CBLastName);
            this.Controls.Add(this.CBFirstName);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButAddSeries);
            this.Controls.Add(this.LabelAuthorSeries);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstBook);
            this.Controls.Add(this.LableNameSer);
            this.Controls.Add(this.TBName);
            this.Name = "AddSeries";
            this.Text = "AddSeries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LableNameSer;
        private System.Windows.Forms.Label LabelFirstBook;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelAuthorSeries;
        private System.Windows.Forms.Button ButAddSeries;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.ComboBox CBFirstName;
        private System.Windows.Forms.ComboBox CBLastName;
        private System.Windows.Forms.ComboBox CBAuthor;
    }
}