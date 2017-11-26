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

namespace CourseProject.Forms.BookForms
{
    public partial class EditBook : Form
    {
        MainForm _mainForm;
        internal protected int Id;
        internal protected string Name;
        internal protected string Author;
        internal protected string Publishing;
        internal protected string Year;
        internal protected int Amount;
        internal protected string Price;
        internal protected string Serieses;

        internal protected bool flag;

        public EditBook(MainForm mainform, Books currentBook)
        {
            flag = false;
            _mainForm = mainform;

            InitializeComponent();
            CBAuthors.DataSource = GetAuthors();
            CBSeriesBook.DataSource = GetSerieses();

            InitializeComponent();
            TBNameOfBook.Text = currentBook.Name;
            CBAuthors.Items.AddRange(GetAuthors().ToArray());
            CBAuthors.SelectedText = GetAuthors().Single(item => item.Contains(currentBook.Author.ToString() + ' '));
            TBPriceBook.Text = currentBook.Price;
            TBPublishingBook.Text = currentBook.Publishing;
            TBAmountBook.Value = currentBook.Amount;
            TBYear.Text = currentBook.Year.ToString();
            CBSeriesBook.Items.AddRange(GetSerieses().ToArray());
            CBSeriesBook.SelectedText = GetSerieses().Single(item => item.Contains(currentBook.SeriesId.ToString() + ' '));
        }

        private List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (var item in _mainForm._db.Authprs)
            {
                authors.Add(item.Id + " " + item.FIO);
            }
            return authors;
        }

        private List<string> GetSerieses()
        {
            List<string> Serieses = new List<string>();
            foreach (var item in _mainForm._db.BookSerieses)
            {
                Serieses.Add(item.Id + " " + item.Name);
            }
            return Serieses;
        }

        private void ButAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                Name = TBNameOfBook.Text;
                Author = CBAuthors.Text.Split(' ')[0];
                Publishing = TBPublishingBook.Text;
                Year = TBYear.Text;
                Amount = Int32.Parse(TBAmountBook.TextAlign.ToString());
                Price = TBPriceBook.Text;
                Serieses = CBSeriesBook.Text.Split(' ')[0];
                flag = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}
