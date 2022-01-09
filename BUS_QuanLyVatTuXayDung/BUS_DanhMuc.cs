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
    public class BUS_DanhMuc
    {
        DAL_DanhMuc dalDM = new DAL_DanhMuc();
        public bool themNhanVien(string taikhoan, string matkhau, string hoten, string quyen)
        {
            return dalDM.themNhanVien(taikhoan, matkhau, hoten, quyen);
        }
        public bool luuNhanVien(int manv, string taikhoan, string matkhau, string hoten, string quyen)
        {
            return dalDM.luuNhanVien(manv, taikhoan, matkhau, hoten, quyen);
        }
        public bool xoaNhanVien(int manv)
        {
            return dalDM.xoaNhanVien(manv);
        }
        public DataTable getDanhSachNhanVien()
        {
            return dalDM.getDanhSachNhanVien();
        }
        public DataTable getThongTinBangMa(int manv)
        {
            return dalDM.getThongTinBangMa(manv);
        }
        public bool xoaVatTu(int mavattu)
        {
            return dalDM.xoaVatTu(mavattu);
        }
        public DataTable getDanhSachVatTu()
        {
            return dalDM.getDanhSachVatTu();
        }
        public DataTable getThongTinVTBangMa(int maVatTu)
        {
            return dalDM.getThongTinVTBangMa(maVatTu);
        }
    }
}
