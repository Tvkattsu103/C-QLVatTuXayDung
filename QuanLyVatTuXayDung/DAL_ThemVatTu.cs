using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace QuanLyVatTuXayDung.DAL
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;uid=sa;pwd=123;database=QLVatTuXayDung");
    }
    public class DAL_ThemVatTu : DBConnection
    {
        public bool themVatTu(string tenvattu, string gia, string donvi, string hangsx, string ghichu, Image anh)
        {
            
            string str = "insert into VatTu(tenVatTu, gia, donVi, hangSX, ghiChu, anh) "
                        + "values (@tenvattu,@gia,@donvi,@hangsx,@ghichu,@anh)";
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@tenvattu", tenvattu.Trim());
                    cmd.Parameters.AddWithValue("@gia", gia.Trim());
                    cmd.Parameters.AddWithValue("@donvi", donvi.Trim());
                    cmd.Parameters.AddWithValue("@hangsx", hangsx.Trim());
                    cmd.Parameters.AddWithValue("@ghichu", ghichu.Trim());

                    MemoryStream ms = new MemoryStream();
                    anh.Save(ms, anh.RawFormat);
                    cmd.Parameters.AddWithValue("@anh", ms.ToArray());

                    cmd.ExecuteNonQuery();
                }
                    
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool luuVatTu(string mavattu, string tenvattu, string gia, string donvi, string hangsx, string ghichu, Image anh)
        {

            string str = "update VatTu set tenVatTu = @tenvattu, gia = @gia, donVi = @donvi, hangSX = @hangsx, ghiChu = @ghichu, anh = @anh "
                        + "where maVatTu = @mavattu";
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(str, con))
                {
                    cmd.Parameters.AddWithValue("@tenvattu", tenvattu.Trim());
                    cmd.Parameters.AddWithValue("@gia", gia.Trim());
                    cmd.Parameters.AddWithValue("@donvi", donvi.Trim());
                    cmd.Parameters.AddWithValue("@hangsx", hangsx.Trim());
                    cmd.Parameters.AddWithValue("@ghichu", ghichu.Trim());

                    cmd.Parameters.AddWithValue("@mavattu", mavattu.Trim());

                    MemoryStream ms = new MemoryStream();
                    anh.Save(ms, anh.RawFormat);
                    cmd.Parameters.AddWithValue("@anh", ms.ToArray());

                    cmd.ExecuteNonQuery();
                }

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
