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
    public partial class AddReader : Form 
    {
        internal protected string FIO;
        internal protected string adress;
        internal protected string telephone;
        internal protected bool flag;

        public AddReader()
        {
            InitializeComponent();
            flag = false;
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButAddReader_Click_1(object sender, EventArgs e)
        {
            FIO = TBFio.Text;
            adress = TBAddress.Text;
            telephone = TBTelephone.Text;
            flag = true;
            Close();
        }

        private void ButCancel_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}
