using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QuanLyVatTuXayDung;

namespace BUS_QuanLyVatTuXayDung
{
    public class BUS_BaoCaoThongKe
    {
        DAL_BaoCaoThongKe dalBC = new DAL_BaoCaoThongKe();
        public DataTable getTonKho()
        {
            return dalBC.getTonKho();
        }
        public DataTable getTKNhapKho(string tungay, string denngay)
        {
            return dalBC.getTKNhapKho(tungay, denngay);
        }
        public DataTable getTKXuatKho(string tungay, string denngay)
        {
            return dalBC.getTKXuatKho(tungay, denngay);
        }
    }
}
