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

namespace CourseProject.Forms.AuthorForms
{
    public partial class EditAuthor : Form //TODO!
    {
        internal protected string FIO;
        internal protected string YearBorn;
        internal protected bool flag;

        public EditAuthor(Authors currauthor)
        {
            InitializeComponent();
            TBYearAuthor.Text = currauthor.Year.ToString();
            TBFIOAuthor.Text = currauthor.FIO;
            flag = false;
        }

        private void ButChangeAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                FIO = TBFIOAuthor.Text;
                YearBorn = TBYearAuthor.Text;
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void ButCancelAuhtor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
