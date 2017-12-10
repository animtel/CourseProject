using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.CheckForms
{
    public partial class EditCheck : Form
    {
        internal protected int BookID;
        internal protected int ReaderID;
        internal protected bool flag;
        private List<string> _BooksInf;
        private List<string> _ReadersInf;

        public EditCheck(MainForm mainform, Checks currentCheck)
        {
            InitializeComponent();
            GetInfo(mainform);
            flag = false;
            CBBook.Items.AddRange(_BooksInf.ToArray());
            CBReader.Items.AddRange(_ReadersInf.ToArray());
            CBBook.SelectedIndex = CBBook.Items.IndexOf(_BooksInf.Single(item => item.Contains(currentCheck.Book_Id.ToString() + " ")));
            CBReader.SelectedIndex = CBBook.Items.IndexOf(_BooksInf.Single(item => item.Contains(currentCheck.Reader_Id.ToString() + " ")));
        }

        private void GetInfo(MainForm mainform)
        {
            _ReadersInf = new List<string>();
            foreach (var item in mainform._db.Readers.ToList())
            {
                _ReadersInf.Add(item.Id + " " + item.FIO);
            }
            _BooksInf = new List<string>();
            foreach (var item in mainform._db.Books.ToList())
            {
                _BooksInf.Add(item.Id + " \"" + item.Name + "\" " + item.Year.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bkid;
            int readid;
            if (Int32.TryParse(CBBook.Text.Split(' ')[0], out bkid) && Int32.TryParse(CBReader.Text.Split(' ')[0], out readid))
            {
                BookID = bkid;
                ReaderID = readid;
                flag = true;
                Close();
            }
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
