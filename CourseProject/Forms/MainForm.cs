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
            dataGridAuthors.DataSource = _db.Authors.ToList();
            dataGridBooks.DataSource = _db.Books.ToList();
            dataGridReaders.DataSource = _db.Readers.ToList();
            dataGridSerieses.DataSource = _db.BookSerieses.ToList();
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
                    int? nullId;
                    var IsNullSeries = _bookform.Serieses == String.Empty;
                    if (IsNullSeries)
                    {
                        nullId = null;
                    }
                    else
                    {
                        nullId = Int32.Parse(_bookform.Serieses);
                    }
                    Books book = new Books()
                    {
                        Name = _bookform.Name,
                        Author = Int32.Parse(_bookform.Author),
                        Amount = _bookform.Amount,
                        Price = _bookform.Price,
                        SeriesId = nullId,
                        Publishing = _bookform.Publishing,
                        Year = Int32.Parse(_bookform.Year)
                    };
                    _db.Books.Add(book);

                    _db.SaveChanges();
                    dataGridBooks.DataSource = _db.Books.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                int? idOfBook = Int32.Parse(dataGridBooks.CurrentRow.Cells[0].Value.ToString());
                var isIdNull = idOfBook == null || idOfBook == 0;
                if (!isIdNull)
                {
                    _db.Books.Remove(_db.Books.Single(item => item.Id == idOfBook));
                    _db.SaveChanges();
                    dataGridBooks.DataSource = _db.Books.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сори используется в сериях...");
            }
            
        }

        private void ButEditBook_Click(object sender, EventArgs e)
        {
            int idOfBook = Int32.Parse(dataGridBooks.CurrentRow.Cells[0].Value.ToString());

            Books currentBook = _db.Books.Single(item => item.Id == idOfBook);
            EditBook editBook = new EditBook(this, currentBook);
            editBook.ShowDialog();
            if (editBook.flag)
            {
                try
                {
                    currentBook.Name = editBook.Name;
                    currentBook.Price = editBook.Price;
                    currentBook.Publishing = editBook.Publishing;
                    currentBook.Amount = editBook.Amount;
                    currentBook.Author = Int32.Parse(editBook.Author);
                    currentBook.Year = Int32.Parse(editBook.Year);
                    currentBook.SeriesId = Int32.Parse(editBook.Serieses);
                    _db.SaveChanges();
                    dataGridBooks.DataSource = _db.Books.ToList();
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
                    Authors aut = new Authors() { FIO = _authorForm.Fio, Year = _authorForm.Year };
                    _db.Authors.Add(aut);
                    _db.SaveChanges();
                    dataGridAuthors.DataSource = _db.Authors.ToList();
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
            _db.SaveChanges();
            dataGridAuthors.DataSource = _db.Authors.ToList();

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
                    dataGridAuthors.DataSource = _db.Authors.ToList();
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
                    dataGridReaders.DataSource = _db.Readers.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButEditReader_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridReaders.CurrentRow.Cells[0].Value.ToString());
            Readers currentReader = _db.Readers.Single(item => item.Id == id);
            EditReader editReader = new EditReader(this, currentReader);
            editReader.ShowDialog();
            if (editReader.flag)
            {
                try
                {
                    currentReader.FIO = editReader.Fio;
                    currentReader.Address = editReader.Address;
                    currentReader.Telephone = editReader.Telephone;
                    _db.SaveChanges();
                    dataGridReaders.DataSource = _db.Readers.ToList();
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
            _db.SaveChanges();
            dataGridReaders.DataSource = _db.Readers.ToList();

        }
        #endregion

        #region ChecksOperation

        private void ButDelteCheck_Click(object sender, EventArgs e)
        {
            int idOfCheck = Int32.Parse(dataGridChecks.CurrentRow.Cells[0].Value.ToString());
            _db.Checks.Remove(_db.Checks.Single(Item => Item.Id == idOfCheck));
            _db.SaveChanges();
            dataGridChecks.DataSource = _db.Checks.ToList();
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
                    dataGridSerieses.DataSource = _db.BookSerieses.ToList();

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
                dataGridSerieses.DataSource = _db.BookSerieses.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButEditSeries_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridSerieses.CurrentRow.Cells[0].Value.ToString());
            Serieses currentSeries = _db.BookSerieses.Single(item => item.Id == id);
            EditSeries editSeries = new EditSeries(this, currentSeries);
            editSeries.ShowDialog();
            if (editSeries.flag)
            {
                try
                {
                    currentSeries.Last_Book = editSeries.LastBook;
                    currentSeries.First_Book = editSeries.FirstBook;
                    currentSeries.Author = editSeries.Author;
                    currentSeries.Name = editSeries.Name;
                    _db.SaveChanges();
                    dataGridSerieses.DataSource = _db.BookSerieses.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void BTSaveCheck_Click(object sender, EventArgs e)
        {
            saveCheck.Filter = "TXT Text|*.txt";
            saveCheck.Title = "Save a report file";
            saveCheck.ShowDialog();
            if (saveCheck.FileName != "")
            {
                System.IO.StreamWriter fileSave = new System.IO.StreamWriter(saveCheck.FileName);
                int idOfCheck = Int32.Parse(dataGridChecks.CurrentRow.Cells[0].Value.ToString());
                Checks check = _db.Checks.Single(item => item.Id == idOfCheck);
                string chen = DateTime.Now + "\r\n\r\n";
                chen += "Bank requisites                          XXXXXXXXxx\r\n";
                chen += "Cafe requisites                          XXXXXXXXxx\r\n";
                chen += "Book name                                " + _db.Books.Find(check.Book_Id).Name + "\r\n";
                chen += "Fio of reader                            " + _db.Readers.Find(check.Reader_Id).FIO + "\r\n";
                chen += "Date                                     " + check.Date + "\r\n";
                fileSave.Write(chen);
                fileSave.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textFromCB = CBChooseSort.Text.ToLower();
            if (textFromCB == "name")
            {
                dataGridBooks.DataSource = _db.Books.OrderBy(item => item.Name).ToList();
            }
            if (textFromCB == "author")
            {
                dataGridBooks.DataSource = _db.Books.OrderBy(item => item.Author).ToList();
            }
            if (textFromCB == "publishing")
            {
                dataGridBooks.DataSource = _db.Books.OrderBy(item => item.Publishing).ToList();
            }
            if (textFromCB == "year")
            {
                dataGridBooks.DataSource = _db.Books.OrderBy(item => item.Year).ToList();
            }
            if (textFromCB == "amount")
            {
                dataGridBooks.DataSource = _db.Books.OrderBy(item => item.Amount).ToList();
            }
            if (textFromCB == "price")
            {
                dataGridBooks.DataSource = _db.Books.OrderBy(item => item.Price).ToList();
            }
        }

        private void ButSortAuthors_Click(object sender, EventArgs e)
        {
            var textFromCb = CBChooseSortAuthors.Text.ToLower();
            if (textFromCb == "fio")
            {
                dataGridAuthors.DataSource = _db.Authors.OrderBy(item => item.FIO).ToList();
            }
            if (textFromCb == "year")
            {
                dataGridAuthors.DataSource = _db.Authors.OrderBy(item => item.FIO).ToList();
            }
        }

        private void ButSortReaders_Click(object sender, EventArgs e)
        {
            var textFromCb = CBChooseSortReaders.Text.ToLower();
            if (textFromCb == "fio")
            {
                dataGridReaders.DataSource = _db.Readers.OrderBy(item => item.FIO).ToList();
            }
            if (textFromCb == "address")
            {
                dataGridReaders.DataSource = _db.Readers.OrderBy(item => item.Address).ToList();
            }
            if (textFromCb == "telephone")
            {
                dataGridReaders.DataSource = _db.Readers.OrderBy(item => item.Telephone).ToList();
            }
        }

        private void ButSortChecks_Click(object sender, EventArgs e)
        {
            dataGridChecks.DataSource = _db.Checks.OrderBy(item => item.Date).ToList();
        }

        
    }
}








//private void MenuDishNameBNT_Click(object sender, EventArgs e)
//{
//    MainGrid.DataSource = null;
//    MainGrid.Refresh();
//    try
//    {
//        var c = _db.Menu.SqlQuery("SELECT * FROM Menu WHERE DishName LIKE '%" + MenuDishNameTB.Text + "%'");
//        MainGrid.DataSource = c.ToList();
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}