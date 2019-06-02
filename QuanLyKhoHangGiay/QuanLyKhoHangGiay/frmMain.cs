using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoHangGiay.FRM;
using BLL;
using DTO;
namespace QuanLyKhoHangGiay
{
    public partial class frmMain : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        public static string TenDN = string.Empty;
        public static string MatKhau = string.Empty;

        public frmMain()
        {
            InitializeComponent();

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            frmDangNhap dangNhap = new frmDangNhap();
            if (!string.IsNullOrEmpty(TenDN))
            {
               // this.btnDN.Visible = true;
                this.btnTenDN.Text = "Xin chào : " + TenDN;

            }
            //dangNhap.ShowDialog();
            btnTenDN.Refresh();

        }



        private void btnDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            tbChiTiet.Controls.Clear();//xóa hết các controls đang có trong tbChiTiet
            frmNV.TopLevel = false;
            frmNV.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmNV);
            frmNV.Show();

            tabControlPanel1.Hide();
        }


        int n = 4, m = 4, a = 1;

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNCC frmncc = new frmNCC();
            tbChiTiet.Controls.Clear();
            frmncc.TopLevel = false;
            frmncc.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmncc);
            frmncc.Show();
            tabControlPanel1.Hide();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            tbChiTiet.Controls.Clear();
            frmKH.TopLevel = false;
            frmKH.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmKH);
            frmKH.Show();
            tabControlPanel1.Hide();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPN = new frmPhieuNhap();
            tbChiTiet.Show();
            tbChiTiet.Controls.Clear();
            frmPN.TopLevel = false;
            frmPN.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmPN);
            frmPN.Show();
            tabControlPanel1.Hide();
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frmPX = new frmPhieuXuat();
            tbChiTiet.Show();
            tbChiTiet.Controls.Clear();
            frmPX.TopLevel = false;
            frmPX.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmPX);
            frmPX.Show();
            tabControlPanel1.Hide();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {

            frmSanPham frmSP = new frmSanPham();
            tbChiTiet.Show();
            tbChiTiet.Controls.Clear();
            frmSP.TopLevel = false;
            frmSP.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmSP);
            frmSP.Show();
            tabControlPanel1.Hide();
        }

        private void btnLSP_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLSP = new frmLoaiSanPham();
            tbChiTiet.Show();
            tbChiTiet.Controls.Clear();
            frmLSP.TopLevel = false;
            frmLSP.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frmLSP);
            frmLSP.Show();
            tabControlPanel1.Hide();
        }



        private void btnTonKho_Click(object sender, EventArgs e)
        {
            frmTonKho frm = new frmTonKho();
            tbChiTiet.Show();
            tbChiTiet.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frm);
            frm.Show();
            tabControlPanel1.Hide();
        }


        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                n += a;
                lbHTLK.Location = new Point(n, m);
                if (n >= 880)
                {
                    a = -1;
                    lbHTLK.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (n <= 4)
                {
                    a = 1;
                    lbHTLK.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();

            //frm.ShowDialog();
            //frmTonKho frm = new frmTonKho();
            //tbChiTiet.Show();
            //tbChiTiet.Controls.Clear();
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //tbChiTiet.Controls.Add(frm);
            //frm.Show();
            //tabControlPanel1.Hide();

            tbChiTiet.Show();
            tbChiTiet.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            tbChiTiet.Controls.Add(frm);
            frm.Show();
            tabControlPanel1.Hide();
        }

        private void btnTKCN_Click(object sender, EventArgs e)
        {
            frmTKCN frm = new frmTKCN();
            frm.ShowDialog();
            //tbChiTiet.Show();
            //tbChiTiet.Controls.Clear();
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //tbChiTiet.Controls.Add(frm);
            //frm.Show();
            //tabControlPanel1.Hide();

        }

        private void btnTenDN_Click(object sender, EventArgs e)
        {
            frmTKCN tKCN = new frmTKCN();
            tKCN.ShowDialog();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Quản lý kho giày", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    this.Hide();
                    frmDangNhap dangNhap = new frmDangNhap();
                    dangNhap.Show();
                }
        }

        public void NhanVienXuatHang()
        {
            this.btnNV.Enabled = false;
            this.btnSP.Enabled = false;
            this.btnPhieuNhap.Enabled = false;
            this.btnPhieuXuat.Enabled = true;
            this.btnNCC.Enabled = false;
            this.btnTonKho.Enabled = true;
            this.btnDoanhThu.Enabled = false;
            this.btnLSP.Enabled = false;
            this.btnKH.Enabled = true;
            this.btnTKCN.Enabled = true;
            this.btnDN.Enabled = false;
            this.btnDX.Enabled = true;
            this.btnTenDN.Enabled = true;
            //this.btnDN.Visible = true;
        }

        public void NhanVienQuanLyNhanSu()
        {
            this.btnNV.Enabled = true;
            this.btnSP.Enabled = false;
            this.btnPhieuNhap.Enabled = false;
            this.btnPhieuXuat.Enabled = false;
            this.btnNCC.Enabled = false;
            this.btnTonKho.Enabled = false;
            this.btnDoanhThu.Enabled = false;
            this.btnLSP.Enabled = false;
            this.btnKH.Enabled = false;
            this.btnTKCN.Enabled = true;
            this.btnDN.Enabled = false;
            this.btnDX.Enabled = true;
            this.btnTenDN.Enabled = true;
        }
        public void Default()
        {
            this.btnNV.Enabled = false;
            this.btnSP.Enabled = false;
            this.btnPhieuNhap.Enabled = false;
            this.btnPhieuXuat.Enabled = false;
            this.btnNCC.Enabled = false;
            this.btnTonKho.Enabled = false;
            this.btnDoanhThu.Enabled = false;
            this.btnLSP.Enabled = false;
            this.btnLSP.Enabled = false;
            this.btnKH.Enabled = false;
            this.btnTKCN.Enabled = false;
            this.btnTenDN.Enabled = true;
            //this.btnDN.Enabled
        }



        public void QuanLy()
        {
            this.btnNV.Enabled = true;
            this.btnSP.Enabled = true;
            this.btnPhieuNhap.Enabled = true;
            this.btnPhieuXuat.Enabled = true;
            this.btnNCC.Enabled = true;
            this.btnTonKho.Enabled = true;
            this.btnDoanhThu.Enabled = true;
            this.btnLSP.Enabled = true;
            this.btnLSP.Enabled = true;
            this.btnKH.Enabled = true;
            this.btnTKCN.Enabled = true;
            this.btnDN.Enabled = false;
            this.btnDX.Enabled = true;
            this.btnTenDN.Enabled = true;
            //this.btnDN.Visible = true;
        }

        public void NhanVienNhapHang()
        {
            this.btnNV.Enabled = false;
            this.btnSP.Enabled = true;
            this.btnPhieuNhap.Enabled = true;
            this.btnPhieuXuat.Enabled = false;
            this.btnNCC.Enabled = false;
            this.btnTonKho.Enabled = true;
            this.btnDoanhThu.Enabled = false;
            this.btnLSP.Enabled = true;
            this.btnKH.Enabled = false;
            this.btnTKCN.Enabled = true;
            this.btnDN.Enabled = false;
            this.btnDX.Enabled = true;
            this.btnTenDN.Enabled = true;
        }
    }
}
