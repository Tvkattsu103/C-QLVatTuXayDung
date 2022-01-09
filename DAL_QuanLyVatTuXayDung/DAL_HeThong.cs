using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLyVatTuXayDung
{
    public class DAL_HeThong : DBConnection
    {
        public string DangNhap(string username, string pass)
        {
            string str = string.Format("select maNv from NhanVien where taiKhoan ='{0}' and matKhau = '{1}'", username, pass);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if (dtb.Rows.Count != 0)
            {
                return dtb.Rows[0]["maNv"].ToString();
            }
            return null;
        }
        public bool isAdmin(string id)
        {
            string str = string.Format("select quyen from NhanVien where maNv ='{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if (String.Compare(dtb.Rows[0]["quyen"].ToString(), "1", true) == 0)
            {
                return true;
            }
            return false;
        }
        public DataTable getThongTin(string id)
        {
            string str = string.Format("select * from NhanVien where maNv ='{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb; //Contain 4 fields: id, name, email, ord
        }
        public bool ktMKCu(string id, string password)
        {
            string str = string.Format("select * from NhanVien where maNv ='{0}' and matKhau ='{1}'", id, password);
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            if (dtb.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
        public bool luuMKMoi(string id, string password)
        {
            string str = string.Format("update NhanVien set matKhau = '{0}' where maNv= '{1}'", password, id);
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
