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
    public class BUS_HeThong
    {
        DAL_HeThong dalHT = new DAL_HeThong(); 
        public string DangNhap(string username, string pass)
        {
            return dalHT.DangNhap(username, pass);
        }
        public bool isAdmin(string id)
        {
            return dalHT.isAdmin(id);
        }
        public DataTable getThongTin(string id)
        {
            return dalHT.getThongTin(id);
        }
        public bool ktMKCu(string id, string password)
        {
            return dalHT.ktMKCu(id, password);
        }
        public bool luuMKMoi(string id, string password)
        {
            return dalHT.luuMKMoi(id, password);
        }
    }
}
