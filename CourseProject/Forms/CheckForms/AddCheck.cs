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
    public partial class AddCheck : Form
    {
        internal protected int BookID;
        internal protected int ReaderID;
        internal protected bool flag;
        private List<string> _BooksInf;
        private List<string> _ReadersInf;

        public AddCheck(MainForm mainform)
        {
            InitializeComponent();
            GetInfo(mainform);
            flag = false;
            CBBookID.DataSource = _BooksInf;
            CBReader.DataSource = _ReadersInf;
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
            if (Int32.TryParse(CBBookID.Text.Split(' ')[0], out bkid) && Int32.TryParse(CBReader.Text.Split(' ')[0], out readid))
            {
                BookID = bkid;
                ReaderID = readid;
                flag = true;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
