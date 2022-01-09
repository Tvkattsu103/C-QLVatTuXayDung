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
    public partial class frmDangNhap : Form
    {
        BUS_HeThong busHT = new BUS_HeThong();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                string uid = busHT.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                if (uid!=null)
                {
                    if (busHT.isAdmin(uid))
                    {
                        mySave.isAdmin = !mySave.isAdmin;
                    }
                    mySave.getID = uid;
                    mySave.KT = !mySave.KT;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng! Vui lòng nhập lại", "Thông báo");
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo");
                txtTaiKhoan.Focus();
            }
        }
    }
}
