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
using QuanLyVatTuXayDung.BUS;
using System.Drawing.Imaging;
using System.IO;

namespace QuanLyVatTuXayDung.DanhMuc
{
    public partial class frmVatTu : Form
    {
        int maVatTu = -1;
        BUS_DanhMuc busDM = new BUS_DanhMuc();
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pbxAnh.Image = image;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenVatTu.Text != "" && txtGia.Text != "" && cboDonVi.Text != "" && txtHangSanXuat.Text != "")
            {
                if (pbxAnh.Image == null)
                {
                    MessageBox.Show("Chưa thêm ảnh.", "Thông báo");
                }
                else
                {
                    BUS_ThemVatTu busTVT = new BUS_ThemVatTu();
                    if (busTVT.themVatTu(txtTenVatTu.Text, txtGia.Text, cboDonVi.Text, txtHangSanXuat.Text, txtGhiChu.Text, pbxAnh.Image))
                    {
                        MessageBox.Show("Thêm vật tư thành công.", "Thông báo");
                        dgvVatTu.DataSource = busDM.getDanhSachVatTu();
                        Blank();
                    }
                    else
                    {
                        MessageBox.Show("Thêm vật tư thất bại!", "Thông báo");
                        txtTenVatTu.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtTenVatTu.Focus();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenVatTu.Text != "" && txtGia.Text != "" && cboDonVi.Text != "" && txtHangSanXuat.Text != "")
            {
                if (pbxAnh.Image == null)
                {
                    MessageBox.Show("Chưa thêm ảnh.", "Thông báo");
                }
                else
                {
                    BUS_ThemVatTu busTVT = new BUS_ThemVatTu();
                    if (busTVT.luuVatTu(txtMaVatTu.Text, txtTenVatTu.Text, txtGia.Text, cboDonVi.Text, txtHangSanXuat.Text, txtGhiChu.Text, pbxAnh.Image))
                    {
                        MessageBox.Show("Lưu vật tư thành công.", "Thông báo");
                        dgvVatTu.DataSource = busDM.getDanhSachVatTu();
                        Blank();
                        btnThem.Enabled = true;
                        btnLuu.Enabled = false; btnXoa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Lưu vật tư thất bại!", "Thông báo");
                        txtTenVatTu.Focus();
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                txtTenVatTu.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busDM.xoaVatTu(maVatTu))
            {
                MessageBox.Show("Xóa vật tư thành công.", "Thông báo");
                dgvVatTu.DataSource = busDM.getDanhSachVatTu();
                Blank();
                btnThem.Enabled = true;
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xóa vật tư thất bại!", "Thông báo");
                txtTenVatTu.Focus();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgvVatTu.DataSource = busDM.getDanhSachVatTu();
            Blank();
            btnThem.Enabled = true;
            btnLuu.Enabled = false; btnXoa.Enabled = false;
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            fillData();

            string[] DonVi = new string[2] { "Viên", "Cân" };
            for (int i = 0; i < DonVi.Length; i++)
            {
                cboDonVi.Items.Add(DonVi[i]);
            }

            if (maVatTu == -1)
            {
                btnLuu.Enabled = false; btnXoa.Enabled = false;
            }
        }
        private void fillData()
        {
            DataTable dt = busDM.getDanhSachVatTu();

            dgvVatTu.ColumnCount = 6;
            //dgvVatTu.Columns[0].Name = "Mã vật tư";
            //dgvVatTu.Columns[0].DataPropertyName = "maVatTu";
            //dgvVatTu.Columns[1].Name = "Tên vật tư";
            //dgvVatTu.Columns[1].DataPropertyName = "tenVatTu";
            //dgvVatTu.Columns[2].Name = "Đơn vị";
            //dgvVatTu.Columns[2].DataPropertyName = "donVi";
            //dgvVatTu.Columns[4].Name = "Giá";
            //dgvVatTu.Columns[4].DataPropertyName = "gia";

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Ảnh";
            imgCol.DataPropertyName = "anh";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvVatTu.Columns.Insert(3, imgCol);
            dgvVatTu.RowTemplate.Height = 100;
            dgvVatTu.Columns[3].Width = 100;

            dgvVatTu.DataSource = dt;
            //if (dt != null)
            //{
            //    foreach (DataRow row1 in dt.Rows)
            //    {
            //        Image img = 
            //        Object[] row = new Object[] { row1["maVatTu"].ToString(), row1["tenVatTu"].ToString(), row1["donVi"].ToString(),  };
            //        dgvVatTu.Rows.Add(row);
            //    }
            //}
        }

        private void dgvVatTu_Click(object sender, EventArgs e)
        {
            int i = dgvVatTu.CurrentRow.Index;
            maVatTu = int.Parse(dgvVatTu[0, i].Value.ToString());
            
            DataTable dt = busDM.getThongTinVTBangMa(maVatTu);
            txtMaVatTu.Text = dt.Rows[0]["maVatTu"].ToString();
            txtTenVatTu.Text = dt.Rows[0]["tenVatTu"].ToString();
            cboDonVi.Text = dt.Rows[0]["donVi"].ToString();
            txtGia.Text = dt.Rows[0]["gia"].ToString();
            txtHangSanXuat.Text = dt.Rows[0]["hangSX"].ToString();
            txtGhiChu.Text = dt.Rows[0]["ghiChu"].ToString();

            byte[] imgData = (byte[])dt.Rows[0]["anh"];
            MemoryStream ms = new MemoryStream(imgData);
            pbxAnh.Image = Image.FromStream(ms);

            txtTenVatTu.Focus();

            btnThem.Enabled = false;
            btnLuu.Enabled = true; btnXoa.Enabled = true;
        }
        private void Blank()
        {
            txtMaVatTu.Text = "";
            txtTenVatTu.Text = "";
            cboDonVi.Text = "";
            txtGia.Text = "";
            txtHangSanXuat.Text = "";
            txtGhiChu.Text = "";
            pbxAnh.Image = null;
            maVatTu = -1;
        }
    }
}
