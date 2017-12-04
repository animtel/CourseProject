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

namespace CourseProject.Forms.ReaderForms
{
    public partial class EditReader : Form
    {
        MainForm _mainForm;
        internal protected string Fio;
        internal protected string Address;
        internal protected string Telephone;

        internal protected bool flag;

        public EditReader(MainForm mainForm, Readers currentReader)
        {
            _mainForm = mainForm;
            flag = false;
            InitializeComponent();
            TBFio.Text = currentReader.FIO;
            TBAddress.Text = currentReader.Address;
            TBTelephone.Text = currentReader.Telephone;
        }

        private void ButEditReader_Click(object sender, EventArgs e)
        {
            try
            {
                Fio = TBFio.Text;
                Address = TBAddress.Text;
                Telephone = TBTelephone.Text;
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
