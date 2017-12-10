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
            this.ButTheMostExpensiveBook = new System.Windows.Forms.Button();
            this.ButAllBooks = new System.Windows.Forms.Button();
            this.LabWhatSearch = new System.Windows.Forms.Label();
            this.ButBooksNameSearch = new System.Windows.Forms.Button();
            this.TBBooksNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButBooksPriceFilter = new System.Windows.Forms.Button();
            this.CBBooksPriceFilter = new System.Windows.Forms.ComboBox();
            this.TBBooksPriceFilter = new System.Windows.Forms.TextBox();
            this.ButBooksYearFilter = new System.Windows.Forms.Button();
            this.CBBooksYearFilter = new System.Windows.Forms.ComboBox();
            this.TBBooksYearFilter = new System.Windows.Forms.TextBox();
            this.CBChooseSort = new System.Windows.Forms.ComboBox();
            this.ButSort = new System.Windows.Forms.Button();
            this.ButEditBook = new System.Windows.Forms.Button();
            this.ButDeleteBook = new System.Windows.Forms.Button();
            this.ButAddBook = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.TabAuthors = new System.Windows.Forms.TabPage();
            this.ButSqlReq = new System.Windows.Forms.Button();
            this.ButAuthorFIOSearch = new System.Windows.Forms.Button();
            this.TBAuthorFIOSearch = new System.Windows.Forms.TextBox();
            this.ButAllAuthors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButAuthorsYearFilter = new System.Windows.Forms.Button();
            this.CBAuthorsYearFilter = new System.Windows.Forms.ComboBox();
            this.TBAuthorsYearFilter = new System.Windows.Forms.TextBox();
            this.CBChooseSortAuthors = new System.Windows.Forms.ComboBox();
            this.ButSortAuthors = new System.Windows.Forms.Button();
            this.ButEditAuthor = new System.Windows.Forms.Button();
            this.ButDeleteAuthor = new System.Windows.Forms.Button();
            this.ButAddAuthor = new System.Windows.Forms.Button();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.TabReaders = new System.Windows.Forms.TabPage();
            this.ButAllReaders = new System.Windows.Forms.Button();
            this.CBChooseSortReaders = new System.Windows.Forms.ComboBox();
            this.ButSortReaders = new System.Windows.Forms.Button();
            this.ButEditReader = new System.Windows.Forms.Button();
            this.ButDeleteReader = new System.Windows.Forms.Button();
            this.ButAddReader = new System.Windows.Forms.Button();
            this.dataGridReaders = new System.Windows.Forms.DataGridView();
            this.TabChecks = new System.Windows.Forms.TabPage();
            this.ButAllChecks = new System.Windows.Forms.Button();
            this.ButSortChecks = new System.Windows.Forms.Button();
            this.BTSaveCheck = new System.Windows.Forms.Button();
            this.ButEditCheck = new System.Windows.Forms.Button();
            this.ButDelteCheck = new System.Windows.Forms.Button();
            this.ButAddCheck = new System.Windows.Forms.Button();
            this.dataGridChecks = new System.Windows.Forms.DataGridView();
            this.Series = new System.Windows.Forms.TabPage();
            this.ButAllSerieses = new System.Windows.Forms.Button();
            this.ButEditSeries = new System.Windows.Forms.Button();
            this.ButDeleteSeries = new System.Windows.Forms.Button();
            this.ButAddSeries = new System.Windows.Forms.Button();
            this.dataGridSerieses = new System.Windows.Forms.DataGridView();
            this.saveCheck = new System.Windows.Forms.SaveFileDialog();
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
            this.TabBooks.Controls.Add(this.ButTheMostExpensiveBook);
            this.TabBooks.Controls.Add(this.ButAllBooks);
            this.TabBooks.Controls.Add(this.LabWhatSearch);
            this.TabBooks.Controls.Add(this.ButBooksNameSearch);
            this.TabBooks.Controls.Add(this.TBBooksNameSearch);
            this.TabBooks.Controls.Add(this.label2);
            this.TabBooks.Controls.Add(this.label1);
            this.TabBooks.Controls.Add(this.ButBooksPriceFilter);
            this.TabBooks.Controls.Add(this.CBBooksPriceFilter);
            this.TabBooks.Controls.Add(this.TBBooksPriceFilter);
            this.TabBooks.Controls.Add(this.ButBooksYearFilter);
            this.TabBooks.Controls.Add(this.CBBooksYearFilter);
            this.TabBooks.Controls.Add(this.TBBooksYearFilter);
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
            // ButTheMostExpensiveBook
            // 
            this.ButTheMostExpensiveBook.Location = new System.Drawing.Point(312, 119);
            this.ButTheMostExpensiveBook.Name = "ButTheMostExpensiveBook";
            this.ButTheMostExpensiveBook.Size = new System.Drawing.Size(121, 23);
            this.ButTheMostExpensiveBook.TabIndex = 18;
            this.ButTheMostExpensiveBook.Text = "The most expensive book";
            this.ButTheMostExpensiveBook.UseVisualStyleBackColor = true;
            this.ButTheMostExpensiveBook.Click += new System.EventHandler(this.ButTheMostExpensiveBook_Click_1);
            // 
            // ButAllBooks
            // 
            this.ButAllBooks.Location = new System.Drawing.Point(841, 174);
            this.ButAllBooks.Name = "ButAllBooks";
            this.ButAllBooks.Size = new System.Drawing.Size(75, 23);
            this.ButAllBooks.TabIndex = 17;
            this.ButAllBooks.Text = "All Books";
            this.ButAllBooks.UseVisualStyleBackColor = true;
            this.ButAllBooks.Click += new System.EventHandler(this.ButAllBooks_Click);
            // 
            // LabWhatSearch
            // 
            this.LabWhatSearch.AutoSize = true;
            this.LabWhatSearch.Location = new System.Drawing.Point(222, 151);
            this.LabWhatSearch.Name = "LabWhatSearch";
            this.LabWhatSearch.Size = new System.Drawing.Size(84, 13);
            this.LabWhatSearch.TabIndex = 16;
            this.LabWhatSearch.Text = "Search by name";
            // 
            // ButBooksNameSearch
            // 
            this.ButBooksNameSearch.Location = new System.Drawing.Point(439, 146);
            this.ButBooksNameSearch.Name = "ButBooksNameSearch";
            this.ButBooksNameSearch.Size = new System.Drawing.Size(75, 23);
            this.ButBooksNameSearch.TabIndex = 15;
            this.ButBooksNameSearch.Text = "Serch";
            this.ButBooksNameSearch.UseVisualStyleBackColor = true;
            this.ButBooksNameSearch.Click += new System.EventHandler(this.ButBooksNameSearch_Click);
            // 
            // TBBooksNameSearch
            // 
            this.TBBooksNameSearch.Location = new System.Drawing.Point(312, 148);
            this.TBBooksNameSearch.Name = "TBBooksNameSearch";
            this.TBBooksNameSearch.Size = new System.Drawing.Size(121, 20);
            this.TBBooksNameSearch.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Year filter";
            // 
            // ButBooksPriceFilter
            // 
            this.ButBooksPriceFilter.Location = new System.Drawing.Point(841, 71);
            this.ButBooksPriceFilter.Name = "ButBooksPriceFilter";
            this.ButBooksPriceFilter.Size = new System.Drawing.Size(75, 23);
            this.ButBooksPriceFilter.TabIndex = 11;
            this.ButBooksPriceFilter.Text = "Enter";
            this.ButBooksPriceFilter.UseVisualStyleBackColor = true;
            this.ButBooksPriceFilter.Click += new System.EventHandler(this.ButBooksPriceFilter_Click);
            // 
            // CBBooksPriceFilter
            // 
            this.CBBooksPriceFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBBooksPriceFilter.FormattingEnabled = true;
            this.CBBooksPriceFilter.Items.AddRange(new object[] {
            ">=",
            "<= ",
            "=",
            "<>"});
            this.CBBooksPriceFilter.Location = new System.Drawing.Point(714, 72);
            this.CBBooksPriceFilter.Name = "CBBooksPriceFilter";
            this.CBBooksPriceFilter.Size = new System.Drawing.Size(121, 21);
            this.CBBooksPriceFilter.TabIndex = 10;
            this.CBBooksPriceFilter.Text = ">=";
            // 
            // TBBooksPriceFilter
            // 
            this.TBBooksPriceFilter.Location = new System.Drawing.Point(608, 73);
            this.TBBooksPriceFilter.Name = "TBBooksPriceFilter";
            this.TBBooksPriceFilter.Size = new System.Drawing.Size(100, 20);
            this.TBBooksPriceFilter.TabIndex = 9;
            // 
            // ButBooksYearFilter
            // 
            this.ButBooksYearFilter.Location = new System.Drawing.Point(841, 8);
            this.ButBooksYearFilter.Name = "ButBooksYearFilter";
            this.ButBooksYearFilter.Size = new System.Drawing.Size(75, 23);
            this.ButBooksYearFilter.TabIndex = 8;
            this.ButBooksYearFilter.Text = "Enter";
            this.ButBooksYearFilter.UseVisualStyleBackColor = true;
            this.ButBooksYearFilter.Click += new System.EventHandler(this.ButBooksYearFilter_Click);
            // 
            // CBBooksYearFilter
            // 
            this.CBBooksYearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBBooksYearFilter.FormattingEnabled = true;
            this.CBBooksYearFilter.Items.AddRange(new object[] {
            ">=",
            "<= ",
            "=",
            "<>"});
            this.CBBooksYearFilter.Location = new System.Drawing.Point(714, 8);
            this.CBBooksYearFilter.Name = "CBBooksYearFilter";
            this.CBBooksYearFilter.Size = new System.Drawing.Size(121, 21);
            this.CBBooksYearFilter.TabIndex = 7;
            this.CBBooksYearFilter.Text = ">=";
            // 
            // TBBooksYearFilter
            // 
            this.TBBooksYearFilter.Location = new System.Drawing.Point(608, 9);
            this.TBBooksYearFilter.Name = "TBBooksYearFilter";
            this.TBBooksYearFilter.Size = new System.Drawing.Size(100, 20);
            this.TBBooksYearFilter.TabIndex = 6;
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
            // ButSort
            // 
            this.ButSort.Location = new System.Drawing.Point(439, 174);
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
            this.TabAuthors.Controls.Add(this.ButSqlReq);
            this.TabAuthors.Controls.Add(this.ButAuthorFIOSearch);
            this.TabAuthors.Controls.Add(this.TBAuthorFIOSearch);
            this.TabAuthors.Controls.Add(this.ButAllAuthors);
            this.TabAuthors.Controls.Add(this.label3);
            this.TabAuthors.Controls.Add(this.ButAuthorsYearFilter);
            this.TabAuthors.Controls.Add(this.CBAuthorsYearFilter);
            this.TabAuthors.Controls.Add(this.TBAuthorsYearFilter);
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
            // ButSqlReq
            // 
            this.ButSqlReq.Location = new System.Drawing.Point(761, 159);
            this.ButSqlReq.Name = "ButSqlReq";
            this.ButSqlReq.Size = new System.Drawing.Size(75, 23);
            this.ButSqlReq.TabIndex = 20;
            this.ButSqlReq.Text = "Make SQL Request";
            this.ButSqlReq.UseVisualStyleBackColor = true;
            this.ButSqlReq.Click += new System.EventHandler(this.ButSqlReq_Click);
            // 
            // ButAuthorFIOSearch
            // 
            this.ButAuthorFIOSearch.Location = new System.Drawing.Point(508, 115);
            this.ButAuthorFIOSearch.Name = "ButAuthorFIOSearch";
            this.ButAuthorFIOSearch.Size = new System.Drawing.Size(75, 23);
            this.ButAuthorFIOSearch.TabIndex = 19;
            this.ButAuthorFIOSearch.Text = "Search";
            this.ButAuthorFIOSearch.UseVisualStyleBackColor = true;
            this.ButAuthorFIOSearch.Click += new System.EventHandler(this.ButAuthorFIOSearch_Click);
            // 
            // TBAuthorFIOSearch
            // 
            this.TBAuthorFIOSearch.Location = new System.Drawing.Point(340, 118);
            this.TBAuthorFIOSearch.Name = "TBAuthorFIOSearch";
            this.TBAuthorFIOSearch.Size = new System.Drawing.Size(121, 20);
            this.TBAuthorFIOSearch.TabIndex = 18;
            // 
            // ButAllAuthors
            // 
            this.ButAllAuthors.Location = new System.Drawing.Point(842, 159);
            this.ButAllAuthors.Name = "ButAllAuthors";
            this.ButAllAuthors.Size = new System.Drawing.Size(75, 23);
            this.ButAllAuthors.TabIndex = 17;
            this.ButAllAuthors.Text = "All Authors";
            this.ButAllAuthors.UseVisualStyleBackColor = true;
            this.ButAllAuthors.Click += new System.EventHandler(this.ButAllAuthors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Year filter";
            // 
            // ButAuthorsYearFilter
            // 
            this.ButAuthorsYearFilter.Location = new System.Drawing.Point(842, 6);
            this.ButAuthorsYearFilter.Name = "ButAuthorsYearFilter";
            this.ButAuthorsYearFilter.Size = new System.Drawing.Size(75, 23);
            this.ButAuthorsYearFilter.TabIndex = 15;
            this.ButAuthorsYearFilter.Text = "Enter";
            this.ButAuthorsYearFilter.UseVisualStyleBackColor = true;
            this.ButAuthorsYearFilter.Click += new System.EventHandler(this.ButAuthorsYearFilter_Click);
            // 
            // CBAuthorsYearFilter
            // 
            this.CBAuthorsYearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBAuthorsYearFilter.FormattingEnabled = true;
            this.CBAuthorsYearFilter.Items.AddRange(new object[] {
            ">=",
            "<= ",
            "=",
            "<>"});
            this.CBAuthorsYearFilter.Location = new System.Drawing.Point(663, 8);
            this.CBAuthorsYearFilter.Name = "CBAuthorsYearFilter";
            this.CBAuthorsYearFilter.Size = new System.Drawing.Size(121, 21);
            this.CBAuthorsYearFilter.TabIndex = 14;
            this.CBAuthorsYearFilter.Text = ">=";
            // 
            // TBAuthorsYearFilter
            // 
            this.TBAuthorsYearFilter.Location = new System.Drawing.Point(537, 10);
            this.TBAuthorsYearFilter.Name = "TBAuthorsYearFilter";
            this.TBAuthorsYearFilter.Size = new System.Drawing.Size(100, 20);
            this.TBAuthorsYearFilter.TabIndex = 13;
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
            this.TabReaders.Controls.Add(this.ButAllReaders);
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
            // ButAllReaders
            // 
            this.ButAllReaders.Location = new System.Drawing.Point(842, 159);
            this.ButAllReaders.Name = "ButAllReaders";
            this.ButAllReaders.Size = new System.Drawing.Size(75, 23);
            this.ButAllReaders.TabIndex = 10;
            this.ButAllReaders.Text = "All Readers";
            this.ButAllReaders.UseVisualStyleBackColor = true;
            this.ButAllReaders.Click += new System.EventHandler(this.ButAllReaders_Click);
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
            this.TabChecks.Controls.Add(this.ButAllChecks);
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
            // ButAllChecks
            // 
            this.ButAllChecks.Location = new System.Drawing.Point(842, 159);
            this.ButAllChecks.Name = "ButAllChecks";
            this.ButAllChecks.Size = new System.Drawing.Size(75, 23);
            this.ButAllChecks.TabIndex = 10;
            this.ButAllChecks.Text = "All Checks";
            this.ButAllChecks.UseVisualStyleBackColor = true;
            this.ButAllChecks.Click += new System.EventHandler(this.ButAllChecks_Click);
            // 
            // ButSortChecks
            // 
            this.ButSortChecks.Location = new System.Drawing.Point(196, 78);
            this.ButSortChecks.Name = "ButSortChecks";
            this.ButSortChecks.Size = new System.Drawing.Size(75, 23);
            this.ButSortChecks.TabIndex = 9;
            this.ButSortChecks.Text = "Sort By Date";
            this.ButSortChecks.UseVisualStyleBackColor = true;
            this.ButSortChecks.Click += new System.EventHandler(this.ButSortChecks_Click);
            // 
            // BTSaveCheck
            // 
            this.BTSaveCheck.Location = new System.Drawing.Point(115, 78);
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
            this.ButEditCheck.Click += new System.EventHandler(this.ButEditCheck_Click);
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
            this.ButAddCheck.Click += new System.EventHandler(this.ButAddCheck_Click);
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
            this.Series.Controls.Add(this.ButAllSerieses);
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
            // ButAllSerieses
            // 
            this.ButAllSerieses.Location = new System.Drawing.Point(842, 159);
            this.ButAllSerieses.Name = "ButAllSerieses";
            this.ButAllSerieses.Size = new System.Drawing.Size(75, 23);
            this.ButAllSerieses.TabIndex = 12;
            this.ButAllSerieses.Text = "All serieses";
            this.ButAllSerieses.UseVisualStyleBackColor = true;
            this.ButAllSerieses.Click += new System.EventHandler(this.ButAllSerieses_Click);
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
            this.ButDeleteSeries.Location = new System.Drawing.Point(21, 80);
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
            this.TabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.TabAuthors.ResumeLayout(false);
            this.TabAuthors.PerformLayout();
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
        private System.Windows.Forms.Button ButBooksYearFilter;
        private System.Windows.Forms.ComboBox CBBooksYearFilter;
        private System.Windows.Forms.TextBox TBBooksYearFilter;
        private System.Windows.Forms.Button ButBooksPriceFilter;
        private System.Windows.Forms.ComboBox CBBooksPriceFilter;
        private System.Windows.Forms.TextBox TBBooksPriceFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButAuthorsYearFilter;
        private System.Windows.Forms.ComboBox CBAuthorsYearFilter;
        private System.Windows.Forms.TextBox TBAuthorsYearFilter;
        private System.Windows.Forms.Label LabWhatSearch;
        private System.Windows.Forms.Button ButBooksNameSearch;
        private System.Windows.Forms.TextBox TBBooksNameSearch;
        private System.Windows.Forms.Button ButAllBooks;
        private System.Windows.Forms.Button ButAllAuthors;
        private System.Windows.Forms.Button ButAllReaders;
        private System.Windows.Forms.Button ButAllChecks;
        private System.Windows.Forms.Button ButAllSerieses;
        private System.Windows.Forms.Button ButAuthorFIOSearch;
        private System.Windows.Forms.TextBox TBAuthorFIOSearch;
        private System.Windows.Forms.Button ButSqlReq;
        private System.Windows.Forms.Button ButTheMostExpensiveBook;
    }
}

