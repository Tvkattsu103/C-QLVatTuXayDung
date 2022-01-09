using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVatTuXayDung.DanhMuc;
using QuanLyVatTuXayDung.BaoCaoThongKe;
using QuanLyVatTuXayDung.NhapXuat;
using QuanLyVatTuXayDung.TroGiup;
using QuanLyVatTuXayDung.HeThong;

namespace QuanLyVatTuXayDung
{
    public partial class frmQuanLyVatTu : Form
    {
        public frmQuanLyVatTu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            btnDangXuat.Enabled = btnThuKho.Enabled = btnDoiMatKhau.Enabled = btnNhanVien.Enabled = btnVatTu.Enabled = 
                btnVatTu.Enabled = btnNhapKho.Enabled = btnXuatKho.Enabled = btnNhapKho2.Enabled = btnXuatKho2.Enabled = 
                btnTonKho.Enabled = !kt;
            btnDangNhap.Enabled = kt;
        }

        void Lock_User(Boolean kt)
        {
            btnNhanVien.Enabled = btnNhapKho2.Enabled = btnXuatKho2.Enabled =
                 btnTonKho.Enabled = kt;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = (frmDangNhap)Application.OpenForms["frmDangNhap"];
            if (frm == null)
            {
                frm = new frmDangNhap();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = (frmDoiMatKhau)Application.OpenForms["frmDoiMatKhau"];
            if (frm == null)
            {
                frm = new frmDoiMatKhau();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnThuKho_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = (frmThongTinCaNhan)Application.OpenForms["Thông tin cá nhân"];
            if (frm == null)
            {
                frm = new frmThongTinCaNhan();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangXuat frm = (frmDangXuat)Application.OpenForms["frmDangXuat"];
            if (frm == null)
            {
                frm = new frmDangXuat();
                tabControl1.TabPages.Clear();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = (frmNhanVien)Application.OpenForms["frmNhanVien"];
            if (frm == null)
            {
                frm = new frmNhanVien();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTin frm = (frmThongTin)Application.OpenForms["frmThongTin"];
            if (frm == null)
            {
                frm = new frmThongTin();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnVatTu_Click(object sender, EventArgs e)
        {
            frmVatTu frm = (frmVatTu)Application.OpenForms["frmVatTu"];
            if (frm == null)
            {
                frm = new frmVatTu();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapKho frm = (frmNhapKho)Application.OpenForms["frmNhapKho"];
            if (frm == null)
            {
                frm = new frmNhapKho();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            frmXuatKho frm = (frmXuatKho)Application.OpenForms["frmXuatKho"];
            if (frm == null)
            {
                frm = new frmXuatKho();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            frmTonKho frm = (frmTonKho)Application.OpenForms["frmTonKho"];
            if (frm == null)
            {
                frm = new frmTonKho();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnNhapKho2_Click(object sender, EventArgs e)
        {
            frmNhapKho2 frm = (frmNhapKho2)Application.OpenForms["frmNhapKho2"];
            if (frm == null)
            {
                frm = new frmNhapKho2();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void btnXuatKho2_Click(object sender, EventArgs e)
        {
            frmXuatKho2 frm = (frmXuatKho2)Application.OpenForms["frmXuatKho2"];
            if (frm == null)
            {
                frm = new frmXuatKho2();
                tabControl1.TabPages.Add(frm);
            }
            else
            {
                tabControl1.TabPages[frm].Select();
            }
        }

        private void frmQuanLyVatTu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
            Lock_User(mySave.isAdmin);
        }
    }
}
