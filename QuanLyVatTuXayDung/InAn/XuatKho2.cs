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

namespace QuanLyVatTuXayDung.InAn
{
    public partial class XuatKho2 : Form
    {
        BUS_BaoCaoThongKe busBC = new BUS_BaoCaoThongKe();
        public XuatKho2()
        {
            InitializeComponent();
        }
        public XuatKho2(string tungay, string denngay)
        {
            InitializeComponent();
            //DataTable dt = busBC.getTKXuatKho(tungay, denngay);
            //TK_XuatKho cr = new TK_XuatKho();
            //cr.Database.Tables["table"].SetDataSource(dt);
        }
    }
}
