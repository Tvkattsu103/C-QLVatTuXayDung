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

namespace QuanLyVatTuXayDung.DanhMuc
{
    public partial class frmNhanVien : Form
    {
        int maNv = -1;
        BUS_DanhMuc busDM = new BUS_DanhMuc(); 
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtHoTen.Text != "" && cboQuyen.Text != "")
            {
                if (busDM.themNhanVien(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text, cboQuyen.Text))
                {
                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo");
                    dgvNhanVien.DataSource = busDM.getDanhSachNhanVien();
                    Blank();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtTaiKhoan.Focus();
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busDM.getDanhSachNhanVien();

            string[] Quyen = new string[2] { "Thủ kho", "Nhân viên" };
            for (int i = 0; i < Quyen.Length; i++)
            {
                cboQuyen.Items.Add(Quyen[i]);
            }

            if (maNv == -1)
            {
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            maNv = int.Parse(dgvNhanVien[0, i].Value.ToString());
            DataTable dt = busDM.getThongTinBangMa(maNv);
            txtTaiKhoan.Text = dt.Rows[0]["taiKhoan"].ToString();
            txtMatKhau.Text = dt.Rows[0]["matKhau"].ToString();
            txtHoTen.Text = dt.Rows[0]["hoTen"].ToString();
            if(String.Compare(dt.Rows[0]["quyen"].ToString(),"1")==0)
            {
                cboQuyen.Text = "Thủ kho";
            }
            else
            {
                cboQuyen.Text = "Nhân viên";
            }
            
            txtTaiKhoan.Focus();

            btnThem.Enabled = false;
            btnLuu.Enabled = true; btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtHoTen.Text != "" && cboQuyen.Text != "")
            {
                if (busDM.luuNhanVien(maNv, txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text, cboQuyen.SelectedItem.ToString()))
                {
                    MessageBox.Show("Lưu nhân viên thành công.", "Thông báo");
                    dgvNhanVien.DataSource = busDM.getDanhSachNhanVien();
                    Blank();
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false; btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Lưu nhân viên thất bại!", "Thông báo");
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtTaiKhoan.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busDM.xoaNhanVien(maNv))
            {
                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo");
                dgvNhanVien.DataSource = busDM.getDanhSachNhanVien();
                Blank();
                btnThem.Enabled = true;
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo");
                txtTaiKhoan.Focus();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = busDM.getDanhSachNhanVien();
            Blank();
            btnThem.Enabled = true;
            btnLuu.Enabled = false; btnXoa.Enabled = false;
        }

        private void Blank()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            maNv = -1;
        }
    }
}
