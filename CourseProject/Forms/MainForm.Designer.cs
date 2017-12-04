namespace CourseProject
{
    partial class MainForm
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
            this.Library = new System.Windows.Forms.TabControl();
            this.TabBooks = new System.Windows.Forms.TabPage();
            this.ButSort = new System.Windows.Forms.Button();
            this.ButEditBook = new System.Windows.Forms.Button();
            this.ButDeleteBook = new System.Windows.Forms.Button();
            this.ButAddBook = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.TabAuthors = new System.Windows.Forms.TabPage();
            this.ButEditAuthor = new System.Windows.Forms.Button();
            this.ButDeleteAuthor = new System.Windows.Forms.Button();
            this.ButAddAuthor = new System.Windows.Forms.Button();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.TabReaders = new System.Windows.Forms.TabPage();
            this.ButEditReader = new System.Windows.Forms.Button();
            this.ButDeleteReader = new System.Windows.Forms.Button();
            this.ButAddReader = new System.Windows.Forms.Button();
            this.dataGridReaders = new System.Windows.Forms.DataGridView();
            this.TabChecks = new System.Windows.Forms.TabPage();
            this.BTSaveCheck = new System.Windows.Forms.Button();
            this.ButEditCheck = new System.Windows.Forms.Button();
            this.ButDelteCheck = new System.Windows.Forms.Button();
            this.ButAddCheck = new System.Windows.Forms.Button();
            this.dataGridChecks = new System.Windows.Forms.DataGridView();
            this.Series = new System.Windows.Forms.TabPage();
            this.ButEditSeries = new System.Windows.Forms.Button();
            this.ButDeleteSeries = new System.Windows.Forms.Button();
            this.ButAddSeries = new System.Windows.Forms.Button();
            this.dataGridSerieses = new System.Windows.Forms.DataGridView();
            this.saveCheck = new System.Windows.Forms.SaveFileDialog();
            this.CBChooseSort = new System.Windows.Forms.ComboBox();
            this.CBChooseSortAuthors = new System.Windows.Forms.ComboBox();
            this.ButSortAuthors = new System.Windows.Forms.Button();
            this.CBChooseSortReaders = new System.Windows.Forms.ComboBox();
            this.ButSortReaders = new System.Windows.Forms.Button();
            this.ButSortChecks = new System.Windows.Forms.Button();
            this.Library.SuspendLayout();
            this.TabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.TabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            this.TabReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReaders)).BeginInit();
            this.TabChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecks)).BeginInit();
            this.Series.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSerieses)).BeginInit();
            this.SuspendLayout();
            // 
            // Library
            // 
            this.Library.AccessibleName = "dfgdf";
            this.Library.Controls.Add(this.TabBooks);
            this.Library.Controls.Add(this.TabAuthors);
            this.Library.Controls.Add(this.TabReaders);
            this.Library.Controls.Add(this.TabChecks);
            this.Library.Controls.Add(this.Series);
            this.Library.Location = new System.Drawing.Point(0, -1);
            this.Library.Name = "Library";
            this.Library.SelectedIndex = 0;
            this.Library.Size = new System.Drawing.Size(933, 559);
            this.Library.TabIndex = 0;
            // 
            // TabBooks
            // 
            this.TabBooks.Controls.Add(this.CBChooseSort);
            this.TabBooks.Controls.Add(this.ButSort);
            this.TabBooks.Controls.Add(this.ButEditBook);
            this.TabBooks.Controls.Add(this.ButDeleteBook);
            this.TabBooks.Controls.Add(this.ButAddBook);
            this.TabBooks.Controls.Add(this.dataGridBooks);
            this.TabBooks.Location = new System.Drawing.Point(4, 22);
            this.TabBooks.Name = "TabBooks";
            this.TabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.TabBooks.Size = new System.Drawing.Size(925, 533);
            this.TabBooks.TabIndex = 0;
            this.TabBooks.Text = "Books";
            this.TabBooks.UseVisualStyleBackColor = true;
            // 
            // ButSort
            // 
            this.ButSort.Location = new System.Drawing.Point(480, 174);
            this.ButSort.Name = "ButSort";
            this.ButSort.Size = new System.Drawing.Size(75, 23);
            this.ButSort.TabIndex = 4;
            this.ButSort.Text = "Sort";
            this.ButSort.UseVisualStyleBackColor = true;
            this.ButSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButEditBook
            // 
            this.ButEditBook.Location = new System.Drawing.Point(20, 157);
            this.ButEditBook.Name = "ButEditBook";
            this.ButEditBook.Size = new System.Drawing.Size(75, 23);
            this.ButEditBook.TabIndex = 3;
            this.ButEditBook.Text = "Edit Book";
            this.ButEditBook.UseVisualStyleBackColor = true;
            this.ButEditBook.Click += new System.EventHandler(this.ButEditBook_Click);
            // 
            // ButDeleteBook
            // 
            this.ButDeleteBook.Location = new System.Drawing.Point(20, 98);
            this.ButDeleteBook.Name = "ButDeleteBook";
            this.ButDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteBook.TabIndex = 2;
            this.ButDeleteBook.Text = "Delete Book";
            this.ButDeleteBook.UseVisualStyleBackColor = true;
            this.ButDeleteBook.Click += new System.EventHandler(this.ButDeleteBook_Click);
            // 
            // ButAddBook
            // 
            this.ButAddBook.Location = new System.Drawing.Point(20, 35);
            this.ButAddBook.Name = "ButAddBook";
            this.ButAddBook.Size = new System.Drawing.Size(75, 23);
            this.ButAddBook.TabIndex = 1;
            this.ButAddBook.Text = "Add Book";
            this.ButAddBook.UseVisualStyleBackColor = true;
            this.ButAddBook.Click += new System.EventHandler(this.ButAddBook_Click);
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(6, 203);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.Size = new System.Drawing.Size(910, 324);
            this.dataGridBooks.TabIndex = 0;
            // 
            // TabAuthors
            // 
            this.TabAuthors.Controls.Add(this.CBChooseSortAuthors);
            this.TabAuthors.Controls.Add(this.ButSortAuthors);
            this.TabAuthors.Controls.Add(this.ButEditAuthor);
            this.TabAuthors.Controls.Add(this.ButDeleteAuthor);
            this.TabAuthors.Controls.Add(this.ButAddAuthor);
            this.TabAuthors.Controls.Add(this.dataGridAuthors);
            this.TabAuthors.Location = new System.Drawing.Point(4, 22);
            this.TabAuthors.Name = "TabAuthors";
            this.TabAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.TabAuthors.Size = new System.Drawing.Size(925, 533);
            this.TabAuthors.TabIndex = 1;
            this.TabAuthors.Text = "Authors";
            this.TabAuthors.UseVisualStyleBackColor = true;
            // 
            // ButEditAuthor
            // 
            this.ButEditAuthor.Location = new System.Drawing.Point(21, 142);
            this.ButEditAuthor.Name = "ButEditAuthor";
            this.ButEditAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButEditAuthor.TabIndex = 7;
            this.ButEditAuthor.Text = "Edit Author";
            this.ButEditAuthor.UseVisualStyleBackColor = true;
            this.ButEditAuthor.Click += new System.EventHandler(this.ButEditAuthor_Click);
            // 
            // ButDeleteAuthor
            // 
            this.ButDeleteAuthor.Location = new System.Drawing.Point(21, 83);
            this.ButDeleteAuthor.Name = "ButDeleteAuthor";
            this.ButDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteAuthor.TabIndex = 6;
            this.ButDeleteAuthor.Text = "Delete Author";
            this.ButDeleteAuthor.UseVisualStyleBackColor = true;
            this.ButDeleteAuthor.Click += new System.EventHandler(this.ButDeleteAuthor_Click);
            // 
            // ButAddAuthor
            // 
            this.ButAddAuthor.Location = new System.Drawing.Point(21, 20);
            this.ButAddAuthor.Name = "ButAddAuthor";
            this.ButAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButAddAuthor.TabIndex = 5;
            this.ButAddAuthor.Text = "Add Author";
            this.ButAddAuthor.UseVisualStyleBackColor = true;
            this.ButAddAuthor.Click += new System.EventHandler(this.ButAddAuthor_Click);
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(7, 188);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.Size = new System.Drawing.Size(910, 324);
            this.dataGridAuthors.TabIndex = 4;
            // 
            // TabReaders
            // 
            this.TabReaders.Controls.Add(this.CBChooseSortReaders);
            this.TabReaders.Controls.Add(this.ButSortReaders);
            this.TabReaders.Controls.Add(this.ButEditReader);
            this.TabReaders.Controls.Add(this.ButDeleteReader);
            this.TabReaders.Controls.Add(this.ButAddReader);
            this.TabReaders.Controls.Add(this.dataGridReaders);
            this.TabReaders.Location = new System.Drawing.Point(4, 22);
            this.TabReaders.Name = "TabReaders";
            this.TabReaders.Padding = new System.Windows.Forms.Padding(3);
            this.TabReaders.Size = new System.Drawing.Size(925, 533);
            this.TabReaders.TabIndex = 2;
            this.TabReaders.Text = "Readers";
            this.TabReaders.UseVisualStyleBackColor = true;
            // 
            // ButEditReader
            // 
            this.ButEditReader.Location = new System.Drawing.Point(21, 142);
            this.ButEditReader.Name = "ButEditReader";
            this.ButEditReader.Size = new System.Drawing.Size(75, 23);
            this.ButEditReader.TabIndex = 7;
            this.ButEditReader.Text = "Edit Reader";
            this.ButEditReader.UseVisualStyleBackColor = true;
            this.ButEditReader.Click += new System.EventHandler(this.ButEditReader_Click);
            // 
            // ButDeleteReader
            // 
            this.ButDeleteReader.Location = new System.Drawing.Point(21, 83);
            this.ButDeleteReader.Name = "ButDeleteReader";
            this.ButDeleteReader.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteReader.TabIndex = 6;
            this.ButDeleteReader.Text = "Delete Reader";
            this.ButDeleteReader.UseVisualStyleBackColor = true;
            this.ButDeleteReader.Click += new System.EventHandler(this.ButDeleteReader_Click);
            // 
            // ButAddReader
            // 
            this.ButAddReader.Location = new System.Drawing.Point(21, 20);
            this.ButAddReader.Name = "ButAddReader";
            this.ButAddReader.Size = new System.Drawing.Size(75, 23);
            this.ButAddReader.TabIndex = 5;
            this.ButAddReader.Text = "Add Reader";
            this.ButAddReader.UseVisualStyleBackColor = true;
            this.ButAddReader.Click += new System.EventHandler(this.ButAddReader_Click);
            // 
            // dataGridReaders
            // 
            this.dataGridReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReaders.Location = new System.Drawing.Point(7, 188);
            this.dataGridReaders.Name = "dataGridReaders";
            this.dataGridReaders.Size = new System.Drawing.Size(910, 324);
            this.dataGridReaders.TabIndex = 4;
            // 
            // TabChecks
            // 
            this.TabChecks.Controls.Add(this.ButSortChecks);
            this.TabChecks.Controls.Add(this.BTSaveCheck);
            this.TabChecks.Controls.Add(this.ButEditCheck);
            this.TabChecks.Controls.Add(this.ButDelteCheck);
            this.TabChecks.Controls.Add(this.ButAddCheck);
            this.TabChecks.Controls.Add(this.dataGridChecks);
            this.TabChecks.Location = new System.Drawing.Point(4, 22);
            this.TabChecks.Name = "TabChecks";
            this.TabChecks.Padding = new System.Windows.Forms.Padding(3);
            this.TabChecks.Size = new System.Drawing.Size(925, 533);
            this.TabChecks.TabIndex = 3;
            this.TabChecks.Text = "Checks";
            this.TabChecks.UseVisualStyleBackColor = true;
            // 
            // BTSaveCheck
            // 
            this.BTSaveCheck.Location = new System.Drawing.Point(344, 19);
            this.BTSaveCheck.Name = "BTSaveCheck";
            this.BTSaveCheck.Size = new System.Drawing.Size(75, 23);
            this.BTSaveCheck.TabIndex = 8;
            this.BTSaveCheck.Text = "Save Check";
            this.BTSaveCheck.UseVisualStyleBackColor = true;
            this.BTSaveCheck.Click += new System.EventHandler(this.BTSaveCheck_Click);
            // 
            // ButEditCheck
            // 
            this.ButEditCheck.Location = new System.Drawing.Point(21, 142);
            this.ButEditCheck.Name = "ButEditCheck";
            this.ButEditCheck.Size = new System.Drawing.Size(75, 23);
            this.ButEditCheck.TabIndex = 7;
            this.ButEditCheck.Text = "Edit Check";
            this.ButEditCheck.UseVisualStyleBackColor = true;
            // 
            // ButDelteCheck
            // 
            this.ButDelteCheck.Location = new System.Drawing.Point(21, 78);
            this.ButDelteCheck.Name = "ButDelteCheck";
            this.ButDelteCheck.Size = new System.Drawing.Size(75, 23);
            this.ButDelteCheck.TabIndex = 6;
            this.ButDelteCheck.Text = "Delete Check";
            this.ButDelteCheck.UseVisualStyleBackColor = true;
            this.ButDelteCheck.Click += new System.EventHandler(this.ButDelteCheck_Click);
            // 
            // ButAddCheck
            // 
            this.ButAddCheck.Location = new System.Drawing.Point(21, 20);
            this.ButAddCheck.Name = "ButAddCheck";
            this.ButAddCheck.Size = new System.Drawing.Size(75, 23);
            this.ButAddCheck.TabIndex = 5;
            this.ButAddCheck.Text = "Add Check";
            this.ButAddCheck.UseVisualStyleBackColor = true;
            // 
            // dataGridChecks
            // 
            this.dataGridChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChecks.Location = new System.Drawing.Point(7, 188);
            this.dataGridChecks.Name = "dataGridChecks";
            this.dataGridChecks.Size = new System.Drawing.Size(910, 324);
            this.dataGridChecks.TabIndex = 4;
            // 
            // Series
            // 
            this.Series.Controls.Add(this.ButEditSeries);
            this.Series.Controls.Add(this.ButDeleteSeries);
            this.Series.Controls.Add(this.ButAddSeries);
            this.Series.Controls.Add(this.dataGridSerieses);
            this.Series.Location = new System.Drawing.Point(4, 22);
            this.Series.Name = "Series";
            this.Series.Padding = new System.Windows.Forms.Padding(3);
            this.Series.Size = new System.Drawing.Size(925, 533);
            this.Series.TabIndex = 4;
            this.Series.Text = "Series";
            this.Series.UseVisualStyleBackColor = true;
            // 
            // ButEditSeries
            // 
            this.ButEditSeries.Location = new System.Drawing.Point(21, 142);
            this.ButEditSeries.Name = "ButEditSeries";
            this.ButEditSeries.Size = new System.Drawing.Size(75, 23);
            this.ButEditSeries.TabIndex = 11;
            this.ButEditSeries.Text = "Edit Series";
            this.ButEditSeries.UseVisualStyleBackColor = true;
            this.ButEditSeries.Click += new System.EventHandler(this.ButEditSeries_Click);
            // 
            // ButDeleteSeries
            // 
            this.ButDeleteSeries.Location = new System.Drawing.Point(21, 78);
            this.ButDeleteSeries.Name = "ButDeleteSeries";
            this.ButDeleteSeries.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteSeries.TabIndex = 10;
            this.ButDeleteSeries.Text = "Delete Check";
            this.ButDeleteSeries.UseVisualStyleBackColor = true;
            this.ButDeleteSeries.Click += new System.EventHandler(this.ButDeleteSeries_Click);
            // 
            // ButAddSeries
            // 
            this.ButAddSeries.Location = new System.Drawing.Point(21, 20);
            this.ButAddSeries.Name = "ButAddSeries";
            this.ButAddSeries.Size = new System.Drawing.Size(75, 23);
            this.ButAddSeries.TabIndex = 9;
            this.ButAddSeries.Text = "Add Series";
            this.ButAddSeries.UseVisualStyleBackColor = true;
            this.ButAddSeries.Click += new System.EventHandler(this.ButAddSeries_Click);
            // 
            // dataGridSerieses
            // 
            this.dataGridSerieses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSerieses.Location = new System.Drawing.Point(7, 188);
            this.dataGridSerieses.Name = "dataGridSerieses";
            this.dataGridSerieses.Size = new System.Drawing.Size(910, 324);
            this.dataGridSerieses.TabIndex = 8;
            // 
            // CBChooseSort
            // 
            this.CBChooseSort.FormattingEnabled = true;
            this.CBChooseSort.Items.AddRange(new object[] {
            "Name",
            "Publishing",
            "Author",
            "Year",
            "Amount",
            "Price"});
            this.CBChooseSort.Location = new System.Drawing.Point(312, 174);
            this.CBChooseSort.Name = "CBChooseSort";
            this.CBChooseSort.Size = new System.Drawing.Size(121, 21);
            this.CBChooseSort.TabIndex = 5;
            this.CBChooseSort.Text = "Name";
            // 
            // CBChooseSortAuthors
            // 
            this.CBChooseSortAuthors.FormattingEnabled = true;
            this.CBChooseSortAuthors.Items.AddRange(new object[] {
            "Fio",
            "Year"});
            this.CBChooseSortAuthors.Location = new System.Drawing.Point(340, 144);
            this.CBChooseSortAuthors.Name = "CBChooseSortAuthors";
            this.CBChooseSortAuthors.Size = new System.Drawing.Size(121, 21);
            this.CBChooseSortAuthors.TabIndex = 9;
            this.CBChooseSortAuthors.Text = "Fio";
            // 
            // ButSortAuthors
            // 
            this.ButSortAuthors.Location = new System.Drawing.Point(508, 144);
            this.ButSortAuthors.Name = "ButSortAuthors";
            this.ButSortAuthors.Size = new System.Drawing.Size(75, 23);
            this.ButSortAuthors.TabIndex = 8;
            this.ButSortAuthors.Text = "Sort";
            this.ButSortAuthors.UseVisualStyleBackColor = true;
            this.ButSortAuthors.Click += new System.EventHandler(this.ButSortAuthors_Click);
            // 
            // CBChooseSortReaders
            // 
            this.CBChooseSortReaders.FormattingEnabled = true;
            this.CBChooseSortReaders.Items.AddRange(new object[] {
            "Fio",
            "Address",
            "Telephone"});
            this.CBChooseSortReaders.Location = new System.Drawing.Point(325, 161);
            this.CBChooseSortReaders.Name = "CBChooseSortReaders";
            this.CBChooseSortReaders.Size = new System.Drawing.Size(121, 21);
            this.CBChooseSortReaders.TabIndex = 9;
            this.CBChooseSortReaders.Text = "Fio";
            // 
            // ButSortReaders
            // 
            this.ButSortReaders.Location = new System.Drawing.Point(493, 161);
            this.ButSortReaders.Name = "ButSortReaders";
            this.ButSortReaders.Size = new System.Drawing.Size(75, 23);
            this.ButSortReaders.TabIndex = 8;
            this.ButSortReaders.Text = "Sort";
            this.ButSortReaders.UseVisualStyleBackColor = true;
            this.ButSortReaders.Click += new System.EventHandler(this.ButSortReaders_Click);
            // 
            // ButSortChecks
            // 
            this.ButSortChecks.Location = new System.Drawing.Point(477, 133);
            this.ButSortChecks.Name = "ButSortChecks";
            this.ButSortChecks.Size = new System.Drawing.Size(75, 23);
            this.ButSortChecks.TabIndex = 9;
            this.ButSortChecks.Text = "Sort By Date";
            this.ButSortChecks.UseVisualStyleBackColor = true;
            this.ButSortChecks.Click += new System.EventHandler(this.ButSortChecks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 560);
            this.Controls.Add(this.Library);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Library";
            this.Library.ResumeLayout(false);
            this.TabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.TabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            this.TabReaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReaders)).EndInit();
            this.TabChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChecks)).EndInit();
            this.Series.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSerieses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Library;
        private System.Windows.Forms.TabPage TabBooks;
        private System.Windows.Forms.TabPage TabAuthors;
        private System.Windows.Forms.TabPage TabReaders;
        private System.Windows.Forms.TabPage TabChecks;
        private System.Windows.Forms.Button ButEditBook;
        private System.Windows.Forms.Button ButDeleteBook;
        private System.Windows.Forms.Button ButAddBook;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.Button ButEditAuthor;
        private System.Windows.Forms.Button ButDeleteAuthor;
        private System.Windows.Forms.Button ButAddAuthor;
        private System.Windows.Forms.DataGridView dataGridAuthors;
        private System.Windows.Forms.Button ButEditReader;
        private System.Windows.Forms.Button ButDeleteReader;
        private System.Windows.Forms.Button ButAddReader;
        private System.Windows.Forms.DataGridView dataGridReaders;
        private System.Windows.Forms.Button ButEditCheck;
        private System.Windows.Forms.Button ButDelteCheck;
        private System.Windows.Forms.Button ButAddCheck;
        private System.Windows.Forms.DataGridView dataGridChecks;
        private System.Windows.Forms.TabPage Series;
        private System.Windows.Forms.Button ButEditSeries;
        private System.Windows.Forms.Button ButDeleteSeries;
        private System.Windows.Forms.Button ButAddSeries;
        private System.Windows.Forms.DataGridView dataGridSerieses;
        private System.Windows.Forms.SaveFileDialog saveCheck;
        private System.Windows.Forms.Button BTSaveCheck;
        private System.Windows.Forms.Button ButSort;
        private System.Windows.Forms.ComboBox CBChooseSort;
        private System.Windows.Forms.ComboBox CBChooseSortAuthors;
        private System.Windows.Forms.Button ButSortAuthors;
        private System.Windows.Forms.ComboBox CBChooseSortReaders;
        private System.Windows.Forms.Button ButSortReaders;
        private System.Windows.Forms.Button ButSortChecks;
    }
}

