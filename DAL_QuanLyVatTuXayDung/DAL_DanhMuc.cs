using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_QuanLyVatTuXayDung
{
    public class DAL_DanhMuc : DBConnection
    {
        public bool themNhanVien(string taikhoan, string matkhau, string hoten, string quyen)
        {
            if(quyen == "Thủ kho")
            {
                quyen = "1";
            }
            else
            {
                quyen = "0";
            }
            string str = string.Format("insert into NhanVien(taiKhoan, matKhau, hoTen, quyen) "
                        + "values ('{0}','{1}',N'{2}','{3}')", taikhoan, matkhau, hoten, quyen);
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
        public bool luuNhanVien(int manv, string taikhoan, string matkhau, string hoten, string quyen)
        {
            if (quyen == "Thủ kho")
            {
                quyen = "1";
            }
            else
            {
                quyen = "0";
            }
            string str = string.Format("update NhanVien set taiKhoan = '{0}', matKhau = '{1}', hoTen = N'{2}', quyen = '{3}' "
                        + "where maNv = '{4}'", taikhoan, matkhau, hoten, quyen, manv);
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
        public bool xoaNhanVien(int manv)
        {
            string str = string.Format("delete from NhanVien where maNv = '{0}'", manv);
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
        public DataTable getDanhSachNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select maNv, taiKhoan, matKhau, hoTen, quyen "
                                                    + "from NhanVien ", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dtb.Columns.Add("quyenSuDung");
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                if(dtb.Rows[i - 1]["quyen"].ToString() == "1")
                {
                    dtb.Rows[i - 1]["quyenSuDung"] = "Thủ kho";
                }
                else
                {
                    dtb.Rows[i - 1]["quyenSuDung"] = "Nhân viên";
                }
            }
            return dtb;
        }
        
        public DataTable getThongTinBangMa(int manv)
        {
            string str = string.Format("select maNv, taiKhoan, matKhau, hoTen, quyen "
                                                    + "from NhanVien where maNv = '{0}' ", manv);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool xoaVatTu(int mavattu)
        {
            string str = string.Format("delete from VatTu where maVatTu = '{0}'", mavattu);
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
        public DataTable getDanhSachVatTu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select maVatTu, tenVatTu, donVi, anh, gia, hangSX, ghiChu "
                                                    + "from VatTu ", con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
        public DataTable getThongTinVTBangMa(int maVatTu)
        {
            string str = string.Format("select maVatTu, tenVatTu, donVi, anh, gia, hangSX, ghiChu "
                                                    + "from VatTu where maVatTu = '{0}' ", maVatTu);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
}
