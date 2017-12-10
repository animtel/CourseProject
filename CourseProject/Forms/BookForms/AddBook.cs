using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.BookForms
{
    public partial class AddBook : Form
    {
        MainForm _mainForm;
        internal protected int Id;
        internal protected string Author;
        internal protected string Publishing;
        internal protected string Year;
        internal protected int Amount;
        internal protected string Price;
        internal protected string Serieses;

        internal protected bool flag;

        public AddBook(MainForm mainForm)
        {
            flag = false;
            _mainForm = mainForm;
            
            InitializeComponent();
            CBAuthors.DataSource = GetAuthors();
            CBSeriesBook.DataSource = GetSerieses();
        }

        private List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (var item in _mainForm._db.Authors)
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
            Serieses.Add("Haven't series");
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
                if (Int32.Parse(Year) >= DateTime.Now.Year || Int32.Parse(Year) < 0)
                {
                    throw new Exception();
                }
                Amount = Int32.Parse(TBAmountBook.Value.ToString());
                Price = TBPriceBook.Text;
                Serieses = CBSeriesBook.Text.Split(' ')[0];
                flag = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
