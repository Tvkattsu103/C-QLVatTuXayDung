using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuXayDung.HeThong
{
    public partial class frmDangXuat : Form
    {
        public frmDangXuat()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            mySave.getID = null;
            mySave.isAdmin = false;
            mySave.KT = !mySave.KT;
            MessageBox.Show("Đăng xuất thành công", "Thông báo");
            Close();
        }
    }
}
