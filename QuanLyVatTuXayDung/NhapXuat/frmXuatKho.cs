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

namespace QuanLyVatTuXayDung.NhapXuat
{
    public partial class frmXuatKho : Form
    {
        int maXuat = -1;
        int maDon = -1;
        BUS_NhapXuat busNX = new BUS_NhapXuat();
        public frmXuatKho()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (busNX.themXuatKho(txtNhanVien.Text, dtpNgayXuat.Value.ToString(), txtGhiChu.Text, txtDaThanhToan.Text))
            {
                MessageBox.Show("Thêm xuất kho thành công.", "Thông báo");
                dgvXuatKho.DataSource = busNX.getXuatKho();
                Blank();
            }
            else
            {
                MessageBox.Show("Thêm xuất kho thất bại!", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (busNX.luuXuatKho(txtMaXuat.Text, txtNhanVien.Text, dtpNgayXuat.Value.ToString(), txtGhiChu.Text, txtDaThanhToan.Text))
            {
                MessageBox.Show("Lưu xuất kho thành công.", "Thông báo");
                dgvXuatKho.DataSource = busNX.getXuatKho();
                Blank();
                foreach (DataGridViewRow row in dgvChiTietDon.Rows)
                {
                    try
                    {
                        dgvChiTietDon.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
                btnThem.Enabled = true;
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lưu xuất kho thất bại!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busNX.xoaXuatKho(txtMaXuat.Text))
            {
                MessageBox.Show("Xóa xuất kho thành công.", "Thông báo");
                dgvXuatKho.DataSource = busNX.getXuatKho();
                Blank();
                foreach (DataGridViewRow row in dgvChiTietDon.Rows)
                {
                    try
                    {
                        dgvChiTietDon.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
                btnThem.Enabled = true;
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xóa xuất kho thất bại!", "Thông báo");
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgvXuatKho.DataSource = busNX.getXuatKho();
            Blank();
            foreach (DataGridViewRow row in dgvChiTietDon.Rows)
            {
                try
                {
                    dgvChiTietDon.Rows.Remove(row);
                }
                catch (Exception) { }
            }
            btnThem.Enabled = true;
            btnLuu.Enabled = false; btnXoa.Enabled = false;
        }

        private void Blank()
        {
            txtMaXuat.Text = "";
            txtGhiChu.Text = "";
            lblTongTien.Text = "...";
            txtDaThanhToan.Text = "";
            maXuat = -1;
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            if (maXuat != -1)
            {
                if (txtTenVatTu.Text != "" && txtSL.Text != "" && txtDonGia.Text != "")
                {
                    if (busNX.themDon(txtTenVatTu.Text, txtSL.Text, txtDonGia.Text, txtMaXuat.Text))
                    {
                        MessageBox.Show("Thêm đơn xuất kho thành công.", "Thông báo");
                        dgvChiTietDon.DataSource = busNX.getDonNhap(maXuat);
                        busNX.tongTienXuat(maXuat);
                        dgvXuatKho.DataSource = busNX.getXuatKho();
                        Blank2();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đơn xuất kho thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng xuất đầy đủ thông tin!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin nhập kho!", "Thông báo");
            }
        }

        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            if (txtTenVatTu.Text != "" && txtSL.Text != "" && txtDonGia.Text != "")
            {
                if (busNX.luuDon(maDon, txtTenVatTu.Text, txtSL.Text, txtDonGia.Text))
                {
                    MessageBox.Show("Lưu đơn xuất kho thành công.", "Thông báo");
                    dgvChiTietDon.DataSource = busNX.getDonXuat(maXuat);
                    busNX.tongTien(maXuat);
                    dgvXuatKho.DataSource = busNX.getXuatKho();
                    Blank2();

                    btnThemDon.Enabled = false;
                    btnLuuDon.Enabled = true; btnXoaDon.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lưu đơn xuất kho thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }
        }

        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            if (busNX.xoaDon(maDon))
            {
                MessageBox.Show("Xóa đơn xuất kho thành công.", "Thông báo");
                dgvChiTietDon.DataSource = busNX.getDonXuat(maXuat);
                busNX.tongTien(maXuat);
                dgvXuatKho.DataSource = busNX.getXuatKho();
                Blank2();

                btnThemDon.Enabled = false;
                btnLuuDon.Enabled = true; btnXoaDon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Xóa đơn xuất kho thất bại!", "Thông báo");
            }
        }

        private void btnMoiDon_Click(object sender, EventArgs e)
        {
            if (maXuat != -1)
            {
                dgvChiTietDon.DataSource = busNX.getDonXuat(maXuat);
                Blank2();

                btnThemDon.Enabled = true;
                btnLuuDon.Enabled = false; btnXoaDon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin nhập kho!", "Thông báo");
            }
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            if (mySave.isAdmin == true)
            {
                txtNhanVien.Text = "Thủ kho";
            }
            else
            {
                txtNhanVien.Text = "Nhân viên";
            }
            dgvXuatKho.DataSource = busNX.getXuatKho();

            if (maXuat == -1)
            {
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
            if (maDon == -1)
            {
                btnLuuDon.Enabled = false; btnXoaDon.Enabled = false;
            }
        }  

        private void Blank2()
        {
            txtTenVatTu.Text = "";
            txtSL.Text = "";
            txtDonGia.Text = "";
            lblThanhTien.Text = "...";
            maDon = -1;
        }

        private void dgvXuatKho_Click_1(object sender, EventArgs e)
        {
            int i = dgvXuatKho.CurrentRow.Index;
            maXuat = int.Parse(dgvXuatKho[0, i].Value.ToString());

            DataTable dt = busNX.getXuatKhoBangMa(maXuat);
            txtMaXuat.Text = dt.Rows[0]["maXuat"].ToString();
            txtNhanVien.Text = dt.Rows[0]["NhanVien"].ToString();
            txtGhiChu.Text = dt.Rows[0]["ghiChu"].ToString();
            lblTongTien.Text = dt.Rows[0]["tongTien"].ToString();
            txtDaThanhToan.Text = dt.Rows[0]["daThanhToan"].ToString();

            dgvChiTietDon.DataSource = busNX.getDonXuat(maXuat);

            btnThem.Enabled = false;
            btnLuu.Enabled = true; btnXoa.Enabled = true;
        }
    }
}
