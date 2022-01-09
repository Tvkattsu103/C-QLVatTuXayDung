using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyVatTuXayDung;

namespace QuanLyVatTuXayDung.HeThong
{
    public partial class frmThongTinCaNhan : Form
    {
        BUS_HeThong busHT = new BUS_HeThong();
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DataTable dt = busHT.getThongTin(mySave.getID);
            if (dt != null)
            {
                txtHoTen.Text = dt.Rows[0]["hoTen"].ToString();
                txtTenTaiKhoan.Text = dt.Rows[0]["taiKhoan"].ToString();
                if(mySave.isAdmin==true)
                {
                    txtQuyen.Text = "Thủ kho";
                }
                else
                {
                    txtQuyen.Text = "Nhân viên";
                }
            }
        }
    }
}
