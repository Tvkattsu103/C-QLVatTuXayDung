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
    public partial class frmNhapKho : Form
    {
        int maNhap = -1;
        int maDon = -1;
        BUS_NhapXuat busNX = new BUS_NhapXuat();
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            if(mySave.isAdmin == true)
            {
                txtNhanVien.Text = "Thủ kho";
            }
            else
            {
                txtNhanVien.Text = "Nhân viên";
            }
            dgvNhapKho.DataSource = busNX.getNhapKho();

            if (maNhap == -1)
            {
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
            if (maDon == -1)
            {
                btnLuuDon.Enabled = false; btnXoaDon.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNhaCC.Text != "")
            {
                if (busNX.themNhapKho(txtNhanVien.Text, dtpNgayNhap.Value.ToString(), txtNhaCC.Text, txtGhiChu.Text))
                {
                    MessageBox.Show("Thêm nhập kho thành công.", "Thông báo");
                    dgvNhapKho.DataSource = busNX.getNhapKho();
                    Blank();
                }
                else
                {
                    MessageBox.Show("Thêm nhập kho thất bại!", "Thông báo");
                    txtNhaCC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtNhaCC.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtNhaCC.Text != "")
            {
                if (busNX.luuNhapKho(txtMaNhap.Text, txtNhanVien.Text, dtpNgayNhap.Value.ToString(), txtNhaCC.Text, txtGhiChu.Text))
                {
                    MessageBox.Show("Lưu nhập kho thành công.", "Thông báo");
                    dgvNhapKho.DataSource = busNX.getNhapKho();
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
                    MessageBox.Show("Lưu nhập kho thất bại!", "Thông báo");
                    txtNhaCC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtNhaCC.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busNX.xoaNhapKho(txtMaNhap.Text))
            {
                MessageBox.Show("Xóa nhập kho thành công.", "Thông báo");
                dgvNhapKho.DataSource = busNX.getNhapKho();
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
                MessageBox.Show("Xóa nhập kho thất bại!", "Thông báo");
                txtNhaCC.Focus();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgvNhapKho.DataSource =  busNX.getNhapKho();
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

        private void dgvNhapKho_Click(object sender, EventArgs e)
        {
            int i = dgvNhapKho.CurrentRow.Index;
            maNhap = int.Parse(dgvNhapKho[0, i].Value.ToString());

            DataTable dt = busNX.getNhapKhoBangMa(maNhap);
            txtMaNhap.Text = dt.Rows[0]["maNhap"].ToString();
            txtNhanVien.Text = dt.Rows[0]["NhanVien"].ToString();
            txtNhaCC.Text = dt.Rows[0]["nhaCC"].ToString();
            txtGhiChu.Text = dt.Rows[0]["ghiChu"].ToString();
            lblTongTien.Text = dt.Rows[0]["tongTien"].ToString();

            txtNhaCC.Focus();

            dgvChiTietDon.DataSource = busNX.getDonNhap(maNhap);

            btnThem.Enabled = false;
            btnLuu.Enabled = true; btnXoa.Enabled = true;
        }
        private void Blank()
        {
            txtMaNhap.Text = "";
            txtNhaCC.Text = "";
            txtGhiChu.Text = "";
            lblTongTien.Text = "...";
            maNhap = -1;
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            if (maNhap != -1)
            {
                if (txtTenVatTu.Text != "" && txtSL.Text != "" && txtDonGia.Text != "")
                {
                    if (busNX.themDon(txtTenVatTu.Text, txtSL.Text, txtDonGia.Text, txtMaNhap.Text))
                    {
                        MessageBox.Show("Thêm đơn nhập kho thành công.", "Thông báo");
                        dgvChiTietDon.DataSource = busNX.getDonNhap(maNhap);
                        busNX.tongTien(maNhap);
                        dgvNhapKho.DataSource = busNX.getNhapKho();
                        Blank2();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đơn nhập kho thất bại!", "Thông báo");
                        txtNhaCC.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    txtNhaCC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin nhập kho!", "Thông báo");
            }
        }

        private void dgvChiTietDon_Click(object sender, EventArgs e)
        {
            int i = dgvChiTietDon.CurrentRow.Index;
            maDon = int.Parse(dgvChiTietDon[0, i].Value.ToString());

            DataTable dt = busNX.getDonNhapBangMa(maDon);
            txtTenVatTu.Text = dt.Rows[0]["vatTu"].ToString();
            txtSL.Text = dt.Rows[0]["soLuong"].ToString();
            txtDonGia.Text = dt.Rows[0]["donGia"].ToString();
            lblThanhTien.Text = dt.Rows[0]["thanhTien"].ToString();

            txtMaNhap.Focus();

            btnThemDon.Enabled = false;
            btnLuuDon.Enabled = true; btnXoaDon.Enabled = true;
        }

        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            if (txtTenVatTu.Text != "" && txtSL.Text != "" && txtDonGia.Text != "")
            {
                if (busNX.luuDon(maDon, txtTenVatTu.Text, txtSL.Text, txtDonGia.Text))
                {
                    MessageBox.Show("Lưu đơn nhập kho thành công.", "Thông báo");
                    dgvChiTietDon.DataSource = busNX.getDonNhap(maNhap);
                    busNX.tongTien(maNhap);
                    dgvNhapKho.DataSource = busNX.getNhapKho();
                    Blank2();

                    btnThemDon.Enabled = false;
                    btnLuuDon.Enabled = true; btnXoaDon.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lưu đơn nhập kho thất bại!", "Thông báo");
                    txtNhaCC.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtNhaCC.Focus();
            }
        }

        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            if (busNX.xoaDon(maDon))
            {
                MessageBox.Show("Xóa đơn nhập kho thành công.", "Thông báo");
                dgvChiTietDon.DataSource = busNX.getDonNhap(maNhap);
                busNX.tongTien(maNhap);
                dgvNhapKho.DataSource = busNX.getNhapKho();
                Blank2();

                btnThemDon.Enabled = false;
                btnLuuDon.Enabled = true; btnXoaDon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Xóa đơn nhập kho thất bại!", "Thông báo");
                txtNhaCC.Focus();
            }
        }

        private void btnMoiDon_Click(object sender, EventArgs e)
        {
            if (maNhap != -1)
            {
                dgvChiTietDon.DataSource = busNX.getDonNhap(maNhap);
                Blank2();

                btnThemDon.Enabled = true;
                btnLuuDon.Enabled = false; btnXoaDon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin nhập kho!", "Thông báo");
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
    }
}
