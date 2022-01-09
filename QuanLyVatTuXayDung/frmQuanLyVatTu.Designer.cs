namespace QuanLyVatTuXayDung
{
    partial class frmQuanLyVatTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyVatTu));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnThuKho = new System.Windows.Forms.RibbonButton();
            this.btnDangNhap = new System.Windows.Forms.RibbonButton();
            this.btnDangXuat = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnDoiMatKhau = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnNhanVien = new System.Windows.Forms.RibbonButton();
            this.btnVatTu = new System.Windows.Forms.RibbonButton();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btnNhapKho = new System.Windows.Forms.RibbonButton();
            this.btnXuatKho = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.btnTonKho = new System.Windows.Forms.RibbonButton();
            this.btnNhapKho2 = new System.Windows.Forms.RibbonButton();
            this.btnXuatKho2 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.btnThongTin = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.tabControl1 = new MdiTabControl.TabControl();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "App";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(906, 135);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.Tabs.Add(this.ribbonTab5);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(6, 26, 20, 0);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Hệ thống";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnThuKho);
            this.ribbonPanel1.Items.Add(this.btnDangNhap);
            this.ribbonPanel1.Items.Add(this.btnDangXuat);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Thông tin";
            // 
            // btnThuKho
            // 
            this.btnThuKho.Image = ((System.Drawing.Image)(resources.GetObject("btnThuKho.Image")));
            this.btnThuKho.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThuKho.LargeImage")));
            this.btnThuKho.MinimumSize = new System.Drawing.Size(120, 0);
            this.btnThuKho.Name = "btnThuKho";
            this.btnThuKho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThuKho.SmallImage")));
            this.btnThuKho.Text = "Thông tin tài khoản";
            this.btnThuKho.Click += new System.EventHandler(this.btnThuKho_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.LargeImage")));
            this.btnDangNhap.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.SmallImage")));
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.LargeImage")));
            this.btnDangXuat.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.SmallImage")));
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnDoiMatKhau);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Tài khoản";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.LargeImage")));
            this.btnDoiMatKhau.MinimumSize = new System.Drawing.Size(90, 0);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.SmallImage")));
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Text = "Danh mục";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.btnNhanVien);
            this.ribbonPanel3.Items.Add(this.btnVatTu);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Quản lý";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeImage")));
            this.btnNhanVien.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.SmallImage")));
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Image = ((System.Drawing.Image)(resources.GetObject("btnVatTu.Image")));
            this.btnVatTu.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.LargeImage")));
            this.btnVatTu.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.SmallImage")));
            this.btnVatTu.Text = "Vật tư";
            this.btnVatTu.Click += new System.EventHandler(this.btnVatTu_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel4);
            this.ribbonTab3.Text = "Nhập - xuất";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btnNhapKho);
            this.ribbonPanel4.Items.Add(this.btnXuatKho);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Nhập - xuất";
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.Image")));
            this.btnNhapKho.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.LargeImage")));
            this.btnNhapKho.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNhapKho.SmallImage")));
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatKho.Image")));
            this.btnXuatKho.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatKho.LargeImage")));
            this.btnXuatKho.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXuatKho.SmallImage")));
            this.btnXuatKho.Text = "Xuất kho";
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Panels.Add(this.ribbonPanel5);
            this.ribbonTab4.Text = "Báo cáo - thống kê";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.btnTonKho);
            this.ribbonPanel5.Items.Add(this.btnNhapKho2);
            this.ribbonPanel5.Items.Add(this.btnXuatKho2);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Báo cáo - thống kê";
            // 
            // btnTonKho
            // 
            this.btnTonKho.Image = ((System.Drawing.Image)(resources.GetObject("btnTonKho.Image")));
            this.btnTonKho.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonKho.LargeImage")));
            this.btnTonKho.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnTonKho.SmallImage")));
            this.btnTonKho.Text = "Tồn kho";
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);
            // 
            // btnNhapKho2
            // 
            this.btnNhapKho2.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapKho2.Image")));
            this.btnNhapKho2.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapKho2.LargeImage")));
            this.btnNhapKho2.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnNhapKho2.Name = "btnNhapKho2";
            this.btnNhapKho2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNhapKho2.SmallImage")));
            this.btnNhapKho2.Text = "Nhập kho";
            this.btnNhapKho2.Click += new System.EventHandler(this.btnNhapKho2_Click);
            // 
            // btnXuatKho2
            // 
            this.btnXuatKho2.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatKho2.Image")));
            this.btnXuatKho2.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatKho2.LargeImage")));
            this.btnXuatKho2.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnXuatKho2.Name = "btnXuatKho2";
            this.btnXuatKho2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXuatKho2.SmallImage")));
            this.btnXuatKho2.Text = "Xuất kho";
            this.btnXuatKho2.Click += new System.EventHandler(this.btnXuatKho2_Click);
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Panels.Add(this.ribbonPanel7);
            this.ribbonTab5.Text = "Trợ giúp";
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.btnThongTin);
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Text = "Thông tin";
            // 
            // btnThongTin
            // 
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongTin.LargeImage")));
            this.btnThongTin.MinimumSize = new System.Drawing.Size(70, 0);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThongTin.SmallImage")));
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MinimumSize = new System.Drawing.Size(70, 0);
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Nhân viên";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MinimumSize = new System.Drawing.Size(70, 0);
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Vật tư";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.MinimumSize = new System.Drawing.Size(70, 0);
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Nhân viên";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.MinimumSize = new System.Drawing.Size(70, 0);
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "Vật tư";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 135);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(906, 375);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 1;
            // 
            // frmQuanLyVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "frmQuanLyVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyVatTu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmQuanLyVatTu_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnThuKho;
        private System.Windows.Forms.RibbonButton btnDangNhap;
        private System.Windows.Forms.RibbonButton btnDangXuat;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnDoiMatKhau;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnNhanVien;
        private System.Windows.Forms.RibbonButton btnVatTu;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnNhapKho;
        private System.Windows.Forms.RibbonButton btnXuatKho;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton btnTonKho;
        private System.Windows.Forms.RibbonButton btnNhapKho2;
        private System.Windows.Forms.RibbonButton btnXuatKho2;
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton btnThongTin;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private MdiTabControl.TabControl tabControl1;
    }
}