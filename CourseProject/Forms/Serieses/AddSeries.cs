using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.Serieses
{
    public partial class AddSeries : Form //TODO!
    {
        internal protected string Name;
        internal protected int FirstBookID;
        internal protected int LastBookID;
        internal protected int AuthorID;
        internal protected bool flag;
        private List<string> _AuthorInf;
        private List<string> _BookInf;
        private List<string> _BookInf1;

        public AddSeries(MainForm mainform)
        {
            InitializeComponent();
            GetInfo(mainform);
            CBAuthor.DataSource = _AuthorInf;
            CBFirstName.DataSource = _BookInf;
            CBLastName.DataSource = _BookInf1;
            flag = false;
        }

        private void GetInfo(MainForm mainform)
        {
            _AuthorInf = new List<string>();
            foreach (var item in mainform._db.Authors.ToList())
            {
                _AuthorInf.Add(item.Id + " " + item.FIO);
            }
            _BookInf = new List<string>();
            _BookInf1 = new List<string>();
            foreach (var item in mainform._db.Books.ToList())
            {
                _BookInf.Add(item.Id + " \"" + item.Name + "\" " + item.Year.ToString());
                _BookInf1.Add(item.Id + " \"" + item.Name + "\" " + item.Year.ToString());
            }
        }

     
        private void ButAddSeries_Click_1(object sender, EventArgs e)
        {
            Name = TBName.Text;
            FirstBookID = Int32.Parse(CBFirstName.Text.Split(' ')[0]);
            LastBookID = Int32.Parse(CBLastName.Text.Split(' ')[0]);
            AuthorID = Int32.Parse(CBAuthor.Text.Split(' ')[0]);
            flag = true;
            Close();
        }

        private void ButCancel_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}
