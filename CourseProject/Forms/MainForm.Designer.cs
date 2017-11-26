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
            this.ButEditBook = new System.Windows.Forms.Button();
            this.ButDeleteBook = new System.Windows.Forms.Button();
            this.ButAddBook = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.TabAuthors = new System.Windows.Forms.TabPage();
            this.ButEditAuthor = new System.Windows.Forms.Button();
            this.ButDeleteAuthor = new System.Windows.Forms.Button();
            this.ButAddAuthor = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TabReaders = new System.Windows.Forms.TabPage();
            this.ButEditReader = new System.Windows.Forms.Button();
            this.ButDeleteReader = new System.Windows.Forms.Button();
            this.ButAddReader = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TabChecks = new System.Windows.Forms.TabPage();
            this.ButEditCheck = new System.Windows.Forms.Button();
            this.ButDelteCheck = new System.Windows.Forms.Button();
            this.ButAddCheck = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Library.SuspendLayout();
            this.TabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.TabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TabReaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.TabChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Library
            // 
            this.Library.AccessibleName = "dfgdf";
            this.Library.Controls.Add(this.TabBooks);
            this.Library.Controls.Add(this.TabAuthors);
            this.Library.Controls.Add(this.TabReaders);
            this.Library.Controls.Add(this.TabChecks);
            this.Library.Location = new System.Drawing.Point(0, -1);
            this.Library.Name = "Library";
            this.Library.SelectedIndex = 0;
            this.Library.Size = new System.Drawing.Size(933, 559);
            this.Library.TabIndex = 0;
            // 
            // TabBooks
            // 
            this.TabBooks.Controls.Add(this.ButEditBook);
            this.TabBooks.Controls.Add(this.ButDeleteBook);
            this.TabBooks.Controls.Add(this.ButAddBook);
            this.TabBooks.Controls.Add(this.DataGrid);
            this.TabBooks.Location = new System.Drawing.Point(4, 22);
            this.TabBooks.Name = "TabBooks";
            this.TabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.TabBooks.Size = new System.Drawing.Size(925, 533);
            this.TabBooks.TabIndex = 0;
            this.TabBooks.Text = "Books";
            this.TabBooks.UseVisualStyleBackColor = true;
            this.TabBooks.Click += new System.EventHandler(this.TabBooks_Click);
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
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(6, 203);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(910, 324);
            this.DataGrid.TabIndex = 0;
            // 
            // TabAuthors
            // 
            this.TabAuthors.Controls.Add(this.ButEditAuthor);
            this.TabAuthors.Controls.Add(this.ButDeleteAuthor);
            this.TabAuthors.Controls.Add(this.ButAddAuthor);
            this.TabAuthors.Controls.Add(this.dataGridView2);
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
            // 
            // ButDeleteAuthor
            // 
            this.ButDeleteAuthor.Location = new System.Drawing.Point(21, 83);
            this.ButDeleteAuthor.Name = "ButDeleteAuthor";
            this.ButDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteAuthor.TabIndex = 6;
            this.ButDeleteAuthor.Text = "Delete Author";
            this.ButDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // ButAddAuthor
            // 
            this.ButAddAuthor.Location = new System.Drawing.Point(21, 20);
            this.ButAddAuthor.Name = "ButAddAuthor";
            this.ButAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButAddAuthor.TabIndex = 5;
            this.ButAddAuthor.Text = "Add Author";
            this.ButAddAuthor.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 188);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(910, 324);
            this.dataGridView2.TabIndex = 4;
            // 
            // TabReaders
            // 
            this.TabReaders.Controls.Add(this.ButEditReader);
            this.TabReaders.Controls.Add(this.ButDeleteReader);
            this.TabReaders.Controls.Add(this.ButAddReader);
            this.TabReaders.Controls.Add(this.dataGridView3);
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
            // 
            // ButDeleteReader
            // 
            this.ButDeleteReader.Location = new System.Drawing.Point(21, 83);
            this.ButDeleteReader.Name = "ButDeleteReader";
            this.ButDeleteReader.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteReader.TabIndex = 6;
            this.ButDeleteReader.Text = "Delete Reader";
            this.ButDeleteReader.UseVisualStyleBackColor = true;
            // 
            // ButAddReader
            // 
            this.ButAddReader.Location = new System.Drawing.Point(21, 20);
            this.ButAddReader.Name = "ButAddReader";
            this.ButAddReader.Size = new System.Drawing.Size(75, 23);
            this.ButAddReader.TabIndex = 5;
            this.ButAddReader.Text = "Add Reader";
            this.ButAddReader.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 188);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(910, 324);
            this.dataGridView3.TabIndex = 4;
            // 
            // TabChecks
            // 
            this.TabChecks.Controls.Add(this.ButEditCheck);
            this.TabChecks.Controls.Add(this.ButDelteCheck);
            this.TabChecks.Controls.Add(this.ButAddCheck);
            this.TabChecks.Controls.Add(this.dataGridView4);
            this.TabChecks.Location = new System.Drawing.Point(4, 22);
            this.TabChecks.Name = "TabChecks";
            this.TabChecks.Padding = new System.Windows.Forms.Padding(3);
            this.TabChecks.Size = new System.Drawing.Size(925, 533);
            this.TabChecks.TabIndex = 3;
            this.TabChecks.Text = "Checks";
            this.TabChecks.UseVisualStyleBackColor = true;
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
            this.ButDelteCheck.Location = new System.Drawing.Point(21, 83);
            this.ButDelteCheck.Name = "ButDelteCheck";
            this.ButDelteCheck.Size = new System.Drawing.Size(75, 23);
            this.ButDelteCheck.TabIndex = 6;
            this.ButDelteCheck.Text = "Delete Check";
            this.ButDelteCheck.UseVisualStyleBackColor = true;
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
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(7, 188);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(910, 324);
            this.dataGridView4.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.TabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TabReaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.TabChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button ButEditAuthor;
        private System.Windows.Forms.Button ButDeleteAuthor;
        private System.Windows.Forms.Button ButAddAuthor;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ButEditReader;
        private System.Windows.Forms.Button ButDeleteReader;
        private System.Windows.Forms.Button ButAddReader;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button ButEditCheck;
        private System.Windows.Forms.Button ButDelteCheck;
        private System.Windows.Forms.Button ButAddCheck;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

