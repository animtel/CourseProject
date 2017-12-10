using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.FreeSQLRequestForm
{
    public partial class FreeSQLRequests : Form
    {
        private const string ConnectionString = @"Data Source=DESKTOP-TDLQB1A\MSSQL2016DEV;Initial Catalog=bookstoredb;Integrated Security=True";

        public FreeSQLRequests()
        {
            InitializeComponent();
        }

        private void do_sql_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                var sqlDataAdapter = new SqlDataAdapter(TestInput.Text, sqlconn);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                resultsDataGridView.DataSource = dataTable;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
