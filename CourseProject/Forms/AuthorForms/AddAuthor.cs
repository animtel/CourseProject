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
        internal protected int Id;
        internal protected string Fio;
        internal protected int Year;
        internal protected bool flag;

        public AddAuthor(MainForm mainForm)
        {
            flag = false;
            _mainForm = mainForm;

            InitializeComponent();
        }

        private void ButAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                Fio = TBFIOAuthor.Text;
                Year = Int32.Parse(TBYearAuthor.Text);
                if (Year.ToString().Length <= 4 && Year > 0 && Year < DateTime.Now.Year)
                {
                    flag = true;
                    Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrectly entered year!");
            }
        }

        private void ButCancelAuhtor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
