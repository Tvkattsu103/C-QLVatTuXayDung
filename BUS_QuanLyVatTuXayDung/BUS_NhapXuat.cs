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
    public class BUS_NhapXuat
    {
        DAL_NhapXuat dalNX = new DAL_NhapXuat();
        public bool themNhapKho(string nhanvien, string ngaynhap, string nhacc, string ghichu)
        {
            return dalNX.themNhapKho(nhanvien, ngaynhap, nhacc, ghichu);
        }
        public bool luuNhapKho(string manhap, string nhanvien, string ngaynhap, string nhacc, string ghichu)
        {
            return dalNX.luuNhapKho(manhap, nhanvien, ngaynhap, nhacc, ghichu);
        }
        public bool xoaNhapKho(string manhap)
        {
            return dalNX.xoaNhapKho(manhap);
        }
        public DataTable getNhapKho()
        {
            return dalNX.getNhapKho();
        }
        public DataTable getNhapKhoBangMa(int manhap)
        {
            return dalNX.getNhapKhoBangMa(manhap);
        }
        public bool themDon(string vattu, string sl, string dongia, string manhap)
        {
            return dalNX.themDon(vattu, sl, dongia, manhap);
        }
        public bool luuDon(int madon, string vattu, string sl, string dongia)
        {
            return dalNX.luuDon(madon, vattu, sl, dongia);
        }
        public bool xoaDon(int madon)
        {
            return dalNX.xoaDon(madon);
        }
        public DataTable getDonNhap(int manhap)
        {
            return dalNX.getDonNhap(manhap);
        }
        public DataTable getDonNhapBangMa(int madon)
        {
            return dalNX.getDonNhapBangMa(madon);
        }
        public bool tongTien(int manhap)
        {
            return dalNX.tongTien(manhap);
        }

        public DataTable getXuatKho()
        {
            return dalNX.getXuatKho();
        }
        public bool themXuatKho(string nhanvien, string ngaynhap, string ghichu, string dathanhtoan)
        {
            return dalNX.themXuatKho(nhanvien, ngaynhap, ghichu, dathanhtoan);
        }
        public bool luuXuatKho(string maxuat, string nhanvien, string ngaynhap, string ghichu, string dathanhtoan)
        {
            return dalNX.luuXuatKho(maxuat, nhanvien, ngaynhap, ghichu, dathanhtoan);
        }
        public bool xoaXuatKho(string maxuat)
        {
            return dalNX.xoaXuatKho(maxuat);
        }
        public DataTable getDonXuat(int maxuat)
        {
            return dalNX.getDonXuat(maxuat);
        }
        public DataTable getXuatKhoBangMa(int maxuat)
        {
            return dalNX.getXuatKhoBangMa(maxuat);
        }
        public bool tongTienXuat(int maxuat)
        {
            return dalNX.tongTienXuat(maxuat);
        }
    }
}
