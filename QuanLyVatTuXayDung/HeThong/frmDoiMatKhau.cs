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
    public partial class frmDoiMatKhau : Form
    {
        BUS_HeThong busHT = new BUS_HeThong();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text != "" && txtMKMoi.Text != "" && txtXacNhan.Text != "")
            {
                if (busHT.ktMKCu(mySave.getID, txtMKCu.Text))
                {
                    if (String.Compare(txtMKMoi.Text, txtXacNhan.Text, false) ==0)
                    {
                        if(busHT.luuMKMoi(mySave.getID, txtMKMoi.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi đổi mật khẩu!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp! Vui lòng nhập lại", "Thông báo");
                        txtMKCu.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng! Vui lòng nhập lại", "Thông báo");
                    txtMKCu.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường!", "Thông báo");
                txtMKCu.Focus();
            }
        }
    }
}
