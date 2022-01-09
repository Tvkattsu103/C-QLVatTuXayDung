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
    public class DAL_BaoCaoThongKe : DBConnection
    {
        public DataTable getTonKho()
        {
            string str = string.Format("select tenVatTu, soLuong from VatTu");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
        public DataTable getTKNhapKho(string tungay, string denngay)
        {
            string str = string.Format("select vatTu, soLuong, ngayNhap, ghiChu from Don inner join NhapKho on Don.maNhapXuat = NhapKho.maNhap "+
                "where ngayNhap > {0} and ngayNhap < '{1}'",tungay, denngay);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["ngayNhap"].ToString());
                dtb.Rows[i - 1]["ngayNhap"] = ngay.ToString(@"dd/MM/yyyy", new CultureInfo("en-US"));
            }
            return dtb;
        }
        public DataTable getTKXuatKho(string tungay, string denngay)
        {
            string str = string.Format("select vatTu, soLuong, ngayXuat, ghiChu from Don inner join XuatKho on Don.maNhapXuat = XuatKho.maXuat " +
                "where ngayXuat > {0} and ngayXuat < '{1}'", tungay, denngay);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            for (int i = 1; i <= dtb.Rows.Count; i++)
            {
                DateTime ngay = DateTime.Parse(dtb.Rows[i - 1]["ngayXuat"].ToString());
                dtb.Rows[i - 1]["ngayXuat"] = ngay.ToString(@"dd/MM/yyyy", new CultureInfo("en-US"));
            }
            return dtb;
        }
    }
}
