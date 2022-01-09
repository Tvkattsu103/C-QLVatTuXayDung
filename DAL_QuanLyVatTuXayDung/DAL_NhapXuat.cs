using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DAL_QuanLyVatTuXayDung
{
    public class DAL_NhapXuat : DBConnection
    {
        public bool themNhapKho(string nhanvien, string ngaynhap, string nhacc, string ghichu)
        {
            string str = string.Format("insert into NhapKho(nhanVien, ngayNhap, nhaCC, ghiChu) "
                        + "values (N'{0}','{1}',N'{2}',N'{3}')", nhanvien, ngaynhap, nhacc, ghichu);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool luuNhapKho(string manhap, string nhanvien, string ngaynhap, string nhacc, string ghichu)
        {
            string str = string.Format("update NhapKho set nhanVien = N'{0}', ngayNhap = N'{1}', nhaCC = '{2}', ghiChu = N'{3}' "
                        + "where maNhap = '{4}'", nhanvien, ngaynhap, nhacc, ghichu, manhap);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool xoaNhapKho(string manhap)
        {
            string str = string.Format("delete from NhapKho where maNhap = '{0}'", manhap);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public DataTable getNhapKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("select maNhap, nhanVien, ngayNhap, nhaCC, ghiChu, tongTien "
                                                    + "from NhapKho ", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["ngayNhap"].ToString());
                dtb.Rows[i - 1]["ngayNhap"] = ngay.ToString(@"dd/MM/yyyy", new CultureInfo("en-US"));
            }

            return dtb;
        }
        public DataTable getNhapKhoBangMa(int manhap)
        {
            string str = string.Format("select maNhap, nhanVien, ngayNhap, nhaCC, ghiChu, tongTien "
                                                    + "from NhapKho where maNhap = '{0}' ", manhap);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool themDon(string vattu, string sl, string dongia, string manhap)
        {
            string str = string.Format("insert into Don(vatTu, soLuong, donGia, maNhapXuat) "
                        + "values (N'{0}','{1}','{2}',N'{3}')", vattu, sl, dongia, manhap);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool luuDon(int madon, string vattu, string sl, string dongia)
        {
            string str = string.Format("update Don set vatTu = N'{0}', soLuong = '{1}', donGia = '{2}' "
                        + "where maDon = '{3}'", vattu, sl, dongia, madon);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool xoaDon(int madon)
        {
            string str = string.Format("delete from Don where maDon = '{0}'", madon);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public DataTable getDonNhap(int manhap)
        {
            string str = string.Format("select maDon, vatTu, soLuong, donGia, maNhapXuat "
                                                    + "from Don where maNhapXuat = '{0}' ", manhap );
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtb.Columns.Add("thanhTien");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                int sl = int.Parse(dtb.Rows[i - 1]["soLuong"].ToString());
                int dongia = int.Parse(dtb.Rows[i - 1]["donGia"].ToString());
                dtb.Rows[i - 1]["thanhTien"] = sl*dongia;
            }

            return dtb;
        }
        public DataTable getDonNhapBangMa(int madon)
        {
            string str = string.Format("select maDon, vatTu, soLuong, donGia, maNhapXuat "
                                                    + "from Don where maDon = '{0}' ", madon);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtb.Columns.Add("thanhTien");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                int sl = int.Parse(dtb.Rows[i - 1]["soLuong"].ToString());
                int dongia = int.Parse(dtb.Rows[i - 1]["donGia"].ToString());
                dtb.Rows[i - 1]["thanhTien"] = sl * dongia;
            }
            return dtb;
        }
        public bool tongTien(int manhap)
        {
            int tongtien = 0;
            DataTable dtb = getDonNhap(manhap);
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                int thanhtien = int.Parse(dtb.Rows[i - 1]["thanhTien"].ToString());
                tongtien += thanhtien;
            }
            string str = string.Format("update NhapKho set tongTien = '{0}' "
                        + "where maNhap = '{1}'", tongtien, manhap);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }

        public DataTable getXuatKho()
        {
            SqlDataAdapter da = new SqlDataAdapter("select maXuat, nhanVien, ngayXuat, ghiChu, tongTien, daThanhToan "
                                                    + "from XuatKho ", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["ngayXuat"].ToString());
                dtb.Rows[i - 1]["ngayXuat"] = ngay.ToString(@"dd/MM/yyyy", new CultureInfo("en-US"));
            }

            return dtb;
        }
        public bool themXuatKho(string nhanvien, string ngaynhap, string ghichu, string dathanhtoan)
        {
            string str = string.Format("insert into NhapKho(nhanVien, ngayXuat, ghiChu, daThanhToan) "
                        + "values (N'{0}','{1}',N'{2}')", nhanvien, ngaynhap, ghichu, dathanhtoan);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool luuXuatKho(string maxuat, string nhanvien, string ngaynhap, string ghichu, string dathanhtoan)
        {
            string str = string.Format("update XuatKho set nhanVien = N'{0}', ngayXuat = '{1}', ghiChu = N'{2}', daThanhToan = '{3}' "
                        + "where maXuat = '{4}'", nhanvien, ngaynhap, ghichu, dathanhtoan, maxuat);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool xoaXuatKho(string maxuat)
        {
            string str = string.Format("delete from XuatKho where maXuat = '{0}'", maxuat);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public DataTable getDonXuat(int maxuat)
        {
            string str = string.Format("select maDon, vatTu, soLuong, donGia, maNhapXuat "
                                                    + "from Don where maNhapXuat = '{0}' ", maxuat);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtb.Columns.Add("thanhTien");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                int sl = int.Parse(dtb.Rows[i - 1]["soLuong"].ToString());
                int dongia = int.Parse(dtb.Rows[i - 1]["donGia"].ToString());
                dtb.Rows[i - 1]["thanhTien"] = sl * dongia;
            }

            return dtb;
        }
        public DataTable getXuatKhoBangMa(int maxuat)
        {
            string str = string.Format("select maXuat, nhanVien, ngayXuat, ghiChu, tongTien, daThanhToan "
                                                    + "from XuatKho where maXuat = '{0}' ", maxuat);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool tongTienXuat(int maxuat)
        {
            int tongtien = 0;
            DataTable dtb = getDonXuat(maxuat);
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                int thanhtien = int.Parse(dtb.Rows[i - 1]["thanhTien"].ToString());
                tongtien += thanhtien;
            }
            string str = string.Format("update XuatKho set tongTien = '{0}' "
                        + "where maXuat = '{1}'", tongtien, maxuat);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
