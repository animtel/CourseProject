namespace CourseProject.Forms.BookForms
{
    partial class AddBook
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
            this.ButAddBook = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.TBNameOfBook = new System.Windows.Forms.TextBox();
            this.TBPublishingBook = new System.Windows.Forms.TextBox();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.TBAmountBook = new System.Windows.Forms.NumericUpDown();
            this.TBPriceBook = new System.Windows.Forms.TextBox();
            this.CBSeriesBook = new System.Windows.Forms.ComboBox();
            this.LabelNameBook = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelPublishing = new System.Windows.Forms.Label();
            this.LabelYear = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelSeries = new System.Windows.Forms.Label();
            this.CBAuthors = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBAmountBook)).BeginInit();
            this.SuspendLayout();
            // 
            // ButAddBook
            // 
            this.ButAddBook.Location = new System.Drawing.Point(133, 294);
            this.ButAddBook.Name = "ButAddBook";
            this.ButAddBook.Size = new System.Drawing.Size(75, 23);
            this.ButAddBook.TabIndex = 0;
            this.ButAddBook.Text = "Enter";
            this.ButAddBook.UseVisualStyleBackColor = true;
            this.ButAddBook.Click += new System.EventHandler(this.ButAddBook_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(15, 294);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 1;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // TBNameOfBook
            // 
            this.TBNameOfBook.Location = new System.Drawing.Point(98, 16);
            this.TBNameOfBook.Name = "TBNameOfBook";
            this.TBNameOfBook.Size = new System.Drawing.Size(121, 20);
            this.TBNameOfBook.TabIndex = 2;
            // 
            // TBPublishingBook
            // 
            this.TBPublishingBook.Location = new System.Drawing.Point(98, 92);
            this.TBPublishingBook.Name = "TBPublishingBook";
            this.TBPublishingBook.Size = new System.Drawing.Size(121, 20);
            this.TBPublishingBook.TabIndex = 4;
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(98, 136);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(121, 20);
            this.TBYear.TabIndex = 5;
            // 
            // TBAmountBook
            // 
            this.TBAmountBook.Location = new System.Drawing.Point(98, 176);
            this.TBAmountBook.Name = "TBAmountBook";
            this.TBAmountBook.Size = new System.Drawing.Size(121, 20);
            this.TBAmountBook.TabIndex = 6;
            // 
            // TBPriceBook
            // 
            this.TBPriceBook.Location = new System.Drawing.Point(98, 222);
            this.TBPriceBook.Name = "TBPriceBook";
            this.TBPriceBook.Size = new System.Drawing.Size(121, 20);
            this.TBPriceBook.TabIndex = 7;
            // 
            // CBSeriesBook
            // 
            this.CBSeriesBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSeriesBook.FormattingEnabled = true;
            this.CBSeriesBook.Location = new System.Drawing.Point(98, 258);
            this.CBSeriesBook.Name = "CBSeriesBook";
            this.CBSeriesBook.Size = new System.Drawing.Size(121, 21);
            this.CBSeriesBook.TabIndex = 8;
            // 
            // LabelNameBook
            // 
            this.LabelNameBook.AutoSize = true;
            this.LabelNameBook.Location = new System.Drawing.Point(12, 16);
            this.LabelNameBook.Name = "LabelNameBook";
            this.LabelNameBook.Size = new System.Drawing.Size(74, 13);
            this.LabelNameBook.TabIndex = 9;
            this.LabelNameBook.Text = "Name of book";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(12, 54);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(38, 13);
            this.LabelAuthor.TabIndex = 10;
            this.LabelAuthor.Text = "Author";
            // 
            // LabelPublishing
            // 
            this.LabelPublishing.AutoSize = true;
            this.LabelPublishing.Location = new System.Drawing.Point(12, 92);
            this.LabelPublishing.Name = "LabelPublishing";
            this.LabelPublishing.Size = new System.Drawing.Size(55, 13);
            this.LabelPublishing.TabIndex = 11;
            this.LabelPublishing.Text = "Publishing";
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(12, 136);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(29, 13);
            this.LabelYear.TabIndex = 12;
            this.LabelYear.Text = "Year";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Location = new System.Drawing.Point(12, 176);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(43, 13);
            this.LabelAmount.TabIndex = 13;
            this.LabelAmount.Text = "Amount";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(12, 222);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(31, 13);
            this.LabelPrice.TabIndex = 14;
            this.LabelPrice.Text = "Price";
            // 
            // LabelSeries
            // 
            this.LabelSeries.AutoSize = true;
            this.LabelSeries.Location = new System.Drawing.Point(12, 258);
            this.LabelSeries.Name = "LabelSeries";
            this.LabelSeries.Size = new System.Drawing.Size(80, 13);
            this.LabelSeries.TabIndex = 15;
            this.LabelSeries.Text = "Series of books";
            // 
            // CBAuthors
            // 
            this.CBAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAuthors.FormattingEnabled = true;
            this.CBAuthors.Location = new System.Drawing.Point(98, 54);
            this.CBAuthors.Name = "CBAuthors";
            this.CBAuthors.Size = new System.Drawing.Size(121, 21);
            this.CBAuthors.TabIndex = 16;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 351);
            this.Controls.Add(this.CBAuthors);
            this.Controls.Add(this.LabelSeries);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.LabelPublishing);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.LabelNameBook);
            this.Controls.Add(this.CBSeriesBook);
            this.Controls.Add(this.TBPriceBook);
            this.Controls.Add(this.TBAmountBook);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.TBPublishingBook);
            this.Controls.Add(this.TBNameOfBook);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButAddBook);
            this.Name = "AddBook";
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.TBAmountBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButAddBook;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.TextBox TBNameOfBook;
        private System.Windows.Forms.TextBox TBPublishingBook;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.NumericUpDown TBAmountBook;
        private System.Windows.Forms.TextBox TBPriceBook;
        private System.Windows.Forms.ComboBox CBSeriesBook;
        private System.Windows.Forms.Label LabelNameBook;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelPublishing;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelSeries;
        private System.Windows.Forms.ComboBox CBAuthors;
    }
}