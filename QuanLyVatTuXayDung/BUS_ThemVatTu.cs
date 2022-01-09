using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVatTuXayDung.DAL;
using System.Drawing;

namespace QuanLyVatTuXayDung.BUS
{
    class BUS_ThemVatTu
    {
        DAL_ThemVatTu dalTVT = new DAL_ThemVatTu();
        public bool themVatTu(string tenvattu, string gia, string donvi, string hangsx, string ghichu, Image anh)
        {
            return dalTVT.themVatTu(tenvattu, gia, donvi, hangsx, ghichu, anh);
        }
        public bool luuVatTu(string mavattu, string tenvattu, string gia, string donvi, string hangsx, string ghichu, Image anh)
        {
            return dalTVT.luuVatTu(mavattu, tenvattu, gia, donvi, hangsx, ghichu, anh);
        }
    }
}
