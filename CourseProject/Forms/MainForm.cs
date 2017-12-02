using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.Models;
using CourseProject.Forms;
using CourseProject.Forms.AuthorForms;
using CourseProject.Forms.BookForms;
using CourseProject.Forms.ReaderForms;
using CourseProject.Forms.Serieses;
using System.Data.SqlClient;
using Dapper;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        public LibraryDbContext _db;
        private string _connectionString = @"Data Source=DESKTOP-TDLQB1A\MSSQL2016DEV;Initial Catalog=bookstoredb;Integrated Security=True";

        public MainForm()
        {
            _db = new LibraryDbContext();
            InitializeComponent();
        }

        #region BooksOperation

        private void ButAddBook_Click(object sender, EventArgs e)
        {
            AddBook _bookform = new Forms.BookForms.AddBook(this);
            _bookform.ShowDialog();
            if (_bookform.flag)
            {
                try
                {
                    _db.Books.Add(new Books
                    {
                        Name = _bookform.Name,
                        Author = Int32.Parse(_bookform.Author),
                        Amount = _bookform.Amount,
                        Price = _bookform.Price,
                        SeriesId = Int32.Parse(_bookform.Serieses),
                        Publishing = _bookform.Publishing,
                        Year = Int32.Parse(_bookform.Year)
                    });

                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButDeleteBook_Click(object sender, EventArgs e)
        {
            int idOfBook = Int32.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());
            _db.Books.Remove(_db.Books.Single(item => item.Id == idOfBook));
        }

        private void ButEditBook_Click(object sender, EventArgs e)
        {
            int idOfBook = Int32.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());

            Forms.BookForms.EditAuthor _bookform = new Forms.BookForms.EditAuthor(this, _db.Books.Single(item => item.Id == idOfBook));

            _bookform.ShowDialog();
            if (_bookform.flag)
            {
                try
                {

                    using (IDbConnection db = new SqlConnection(_connectionString))
                    {

                        var sqlQuery = "UPDATE dbo.Books SET Name = @Name, Author = @Author, Publishing = @Publishing, Year = @Year, Amount = @Amount, Price = @Price, SeriesId = @SeriesId WHERE Id = @Id";
                        db.Execute(sqlQuery, new Books
                        {
                            Name = _bookform.Name,
                            Author = Int32.Parse(_bookform.Author),
                            Amount = _bookform.Amount,
                            Price = _bookform.Price,
                            SeriesId = Int32.Parse(_bookform.Serieses),
                            Publishing = _bookform.Publishing,
                            Year = Int32.Parse(_bookform.Year)
                        });
                    }

                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region AuthorsOperation
        private void ButAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor _authorForm = new AddAuthor(this);
            _authorForm.ShowDialog();
            if (_authorForm.flag)
            {
                try
                {
                    _db.Authors.Add(new Authors {
                        FIO = _authorForm.Fio,
                        Year = _authorForm.Year
                    });

                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void ButDeleteAuthor_Click(object sender, EventArgs e)
        {
            int idOfAuthor = Int32.Parse(dataGridAuthors.CurrentRow.Cells[0].Value.ToString());
            _db.Authors.Remove(_db.Authors.Single(item => item.Id == idOfAuthor));
        }

        private void ButEditAuthor_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridAuthors.CurrentRow.Cells[0].Value.ToString());
            Authors curauthor = _db.Authors.Single(item => item.Id == id);
            Forms.AuthorForms.EditAuthor editAuthor = new Forms.AuthorForms.EditAuthor(curauthor);
            editAuthor.ShowDialog();
            if (editAuthor.flag)
            {
                try
                {
                    curauthor.FIO = editAuthor.FIO;
                    curauthor.Year = Int32.Parse(editAuthor.YearBorn);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region ReadersOperations
        private void ButAddReader_Click(object sender, EventArgs e)
        {
            AddReader new_reader = new AddReader();
            new_reader.ShowDialog();
            if (new_reader.flag)
            {
                try
                {
                    _db.Readers.Add(new Readers
                    {
                        FIO = new_reader.FIO,
                        Address = new_reader.adress,
                        Telephone = new_reader.telephone,
                    });
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButEditReader_Click(object sender, EventArgs e)
        {
            int idOfReader = Int32.Parse(dataGridReaders.CurrentRow.Cells[0].Value.ToString());

            EditReader _readerForm = new EditReader(this, _db.Readers.Single(item => item.Id == idOfReader));

            _readerForm.ShowDialog();
            if (_readerForm.flag)
            {
                try
                {

                    using (IDbConnection db = new SqlConnection(_connectionString))
                    {

                        var sqlQuery = "UPDATE dbo.Readers SET FIO = @Fio, Address = @Address, Telephone = @Telephone WHERE Id = @Id";
                        db.Execute(sqlQuery, new Readers
                        {
                            FIO = _readerForm.Fio,
                            Address = _readerForm.Address,
                            Telephone = _readerForm.Telephone
                        });
                    }

                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButDeleteReader_Click(object sender, EventArgs e)
        {
            int idOfReader = Int32.Parse(dataGridReaders.CurrentRow.Cells[0].Value.ToString());
            _db.Readers.Remove(_db.Readers.Single(item => item.Id == idOfReader));
        }
        #endregion


        #region SeriesesOperations
        private void ButAddSeries_Click(object sender, EventArgs e)
        {
            AddSeries new_series = new AddSeries(this);
            new_series.ShowDialog();
            if (new_series.flag)
            {
                try
                {
                    _db.BookSerieses.Add(new Serieses
                    {
                        Name = new_series.Name,
                        First_Book = new_series.FirstBookID,
                        Last_Book = new_series.LastBookID,
                        Author = new_series.AuthorID
                    });
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButDeleteSeries_Click(object sender, EventArgs e)
        {
            try
            {
                int seriesesID = Int32.Parse(dataGridSerieses.CurrentRow.Cells[0].Value.ToString());
                _db.BookSerieses.Remove(_db.BookSerieses.Single(item => item.Id == seriesesID));
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButEditSeries_Click(object sender, EventArgs e)
        {
            int idOfSeries = Int32.Parse(dataGridSerieses.CurrentRow.Cells[0].Value.ToString());

            EditSeries _seriesForm = new EditSeries(this, _db.BookSerieses.Single(item => item.Id == idOfSeries));

            _seriesForm.ShowDialog();
            if (_seriesForm.flag)
            {
                try
                {

                    using (IDbConnection db = new SqlConnection(_connectionString))
                    {

                        var sqlQuery = "UPDATE dbo.BookSerieses SET Name = @Name, First_Book = @First_Bookm, Last_Book = @Last_Book WHERE Id = @Id";
                        db.Execute(sqlQuery, new Serieses
                        {
                            Name = _seriesForm.Name,
                            First_Book = _seriesForm.FirstBook,
                            Last_Book = _seriesForm.LastBook,
                            Author = _seriesForm.Author
                        });
                    }

                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

    }
}
