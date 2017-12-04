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

namespace CourseProject.Forms.Serieses
{
    public partial class EditSeries : Form
    {
        MainForm _mainForm;
        internal protected string Name;
        internal protected int FirstBook;
        internal protected int LastBook;
        internal protected int Author;
        internal protected bool flag;


        public EditSeries(MainForm mainForm, Models.Serieses currentSeries)
        {
            _mainForm = mainForm;
            InitializeComponent();

            TBName.Text = currentSeries.Name;
            TBFirstName.Text = currentSeries.First_Book.ToString();
            TBLastName.Text = currentSeries.Last_Book.ToString();
            TBAuthor.Text = currentSeries.Author.ToString();
        }

        private void ButAddSeries_Click(object sender, EventArgs e)
        {
            try
            {
                Name = TBName.Text;
                FirstBook = Int32.Parse(TBFirstName.Text);
                LastBook = Int32.Parse(TBLastName.Text);
                Author = Int32.Parse(TBAuthor.Text);
                flag = true;
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
