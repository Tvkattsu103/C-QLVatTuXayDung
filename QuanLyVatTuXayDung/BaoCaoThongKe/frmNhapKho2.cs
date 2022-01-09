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
    public partial class frmNhapKho2 : Form
    {
        DateTime tungay, denngay;
        BUS_BaoCaoThongKe busBC = new BUS_BaoCaoThongKe();
        public frmNhapKho2()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tungay = DateTime.ParseExact(dtpTuNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));
            denngay = DateTime.ParseExact(dtpDenNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));
            foreach (DataGridViewRow row in dgvNhapKho2.Rows)
            {
                try
                {
                    dgvNhapKho2.Rows.Remove(row);
                }
                catch (Exception) { }
            }
            DataTable dt = busBC.getTKNhapKho(dtpTuNgay.Text, dtpDenNgay.Text);
            if (dt.Rows.Count > 0)
            {
                dgvNhapKho2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có thông tin để hiển thị");
            }
            
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            //DataTable dt = busBC.getTKNhapKho();

            //TK_NhapKho cr = new TK_NhapKho();
            //cr.Database.Tables["table"].SetDataSource(dt);
            tungay = DateTime.ParseExact(dtpTuNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));
            denngay = DateTime.ParseExact(dtpDenNgay.Text, @"dd/MM/yyyy", new CultureInfo("en-US"));

            NhapKho2 f = new NhapKho2(tungay.ToString(), denngay.ToString());
            f.Show();
        }
    }
}
