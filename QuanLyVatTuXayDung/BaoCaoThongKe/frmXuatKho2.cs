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
using System.Globalization;

namespace QuanLyVatTuXayDung.BaoCaoThongKe
{
    public partial class frmXuatKho2 : Form
    {
        DateTime tungay, denngay;
        BUS_BaoCaoThongKe busBC = new BUS_BaoCaoThongKe();
        public frmXuatKho2()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tungay = DateTime.ParseExact(dtpTuNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));
            denngay = DateTime.ParseExact(dtpDenNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));
            foreach (DataGridViewRow row in dgvXuatKho2.Rows)
            {
                try
                {
                    dgvXuatKho2.Rows.Remove(row);
                }
                catch (Exception) { }
            }
            dgvXuatKho2.DataSource = busBC.getTKXuatKho(dtpTuNgay.Text, dtpDenNgay.Text);
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            tungay = DateTime.ParseExact(dtpTuNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));
            denngay = DateTime.ParseExact(dtpDenNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));

            XuatKho2 f = new XuatKho2(tungay.ToString(), denngay.ToString());
            f.Show();
        }
    }
}
