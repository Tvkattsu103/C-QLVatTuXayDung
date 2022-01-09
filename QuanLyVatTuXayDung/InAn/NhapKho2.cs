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
    public partial class NhapKho2 : Form
    {
        BUS_BaoCaoThongKe busBC = new BUS_BaoCaoThongKe();
        public NhapKho2()
        {
            InitializeComponent();
        }
        public NhapKho2(string tungay, string denngay)
        {
            InitializeComponent();
            //DataTable dt = busBC.getTKNhapKho(tungay, denngay); 
            //TK_NhapKho cr = new TK_NhapKho();
            //cr.Database.Tables["table"].SetDataSource(dt);
        }
    }
}
