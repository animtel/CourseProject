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
    public partial class AddAuthor : Form
    {

        MainForm _mainForm;
        internal protected bool flag = true;
        internal protected string FIO;
        internal protected string YearBorn;

        public AddAuthor(MainForm mainForm)
        {
            _mainForm = mainForm;
            flag = false;
            InitializeComponent();
        }

        private void ButAddAuthor_Click(object sender, EventArgs e)
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
    }
}
