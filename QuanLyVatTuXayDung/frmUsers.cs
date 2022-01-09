using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuXayDung
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(string));
            dt.Columns.Add("EmployeeName", typeof(string));

            dt.Rows.Add("ID01", "Tuan");
            dt.Rows.Add("ID02", "Nghia");

            dataGridView1.DataSource = dt;
        }
    }
}
