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

        private void ButAddBook_Click(object sender, EventArgs e)
        {
            AddBook _bookform = new AddBook(this);
            _bookform.ShowDialog();
            if (_bookform.flag)
            {
                try
                {
                    _db.Books.Add(new Books {
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

        private void ButEditBook_Click(object sender, EventArgs e)
        {
            int idOfBook = Int32.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());

            EditBook _bookform = new EditBook(this, _db.Books.Single(item => item.Id == idOfBook));

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

        private void ButDeleteBook_Click(object sender, EventArgs e)
        {
            int idOfBook = Int32.Parse(DataGrid.CurrentRow.Cells[0].Value.ToString());
            //TODO DELETING
        }

        private void ButAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor _authorForm = new AddAuthor(this);
            _authorForm.ShowDialog();
            if (_authorForm.flag)
            {
                try
                {
                    _db.Authprs.Add(new Authors
                    {
                        FIO = _authorForm.FIO,
                        Year = Int32.Parse(_authorForm.YearBorn)
                    });
                    _db.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
