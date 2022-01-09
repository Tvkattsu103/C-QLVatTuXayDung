using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyVatTuXayDung;
using QuanLyVatTuXayDung.InAn;

namespace QuanLyVatTuXayDung.BaoCaoThongKe
{
    public partial class frmTonKho : Form
    {
        BUS_BaoCaoThongKe busBC = new BUS_BaoCaoThongKe();
        public frmTonKho()
        {
            InitializeComponent();
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            dgvTonKho.DataSource = busBC.getTonKho();
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            TonKho f = new TonKho();
            f.Show();
        }
    }
}
