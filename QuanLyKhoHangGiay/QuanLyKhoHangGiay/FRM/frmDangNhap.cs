using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmDangNhap : Form
    {
        NhanVienDTO NhanVien = new NhanVienDTO();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private string _TenDN;

        public string TenDN
        {
            get { return _TenDN; }
            set { _TenDN = value; }
        }

        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }




        private void btnDN_Click(object sender, EventArgs e)
        {

            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.TenDangNhap = txtTenDN.Text;
            nhanVien.MatKhau = txtMatKhau.Text;

            int check = 0;
            if (nhanVienBLL.KiemTraKetNoi())
            {
                check = nhanVienBLL.Login(nhanVien);
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            try
            {

                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (check == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);

                    this.Hide();

                    frmMain Main = new frmMain();
                    frmMain.TenDN = nhanVien.TenDangNhap;


                    frmTKCN tKCN = new frmTKCN();
                    
                    frmTKCN.MaNV = nhanVienBLL.LayMaNV(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.HoTen = nhanVienBLL.LayTen(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.NamSinh = nhanVienBLL.LayNamSinh(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.QueQuan = nhanVienBLL.LayQueQuan(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.SDT = nhanVienBLL.LaySDT(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.TenDN = nhanVienBLL.LayTenDN(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.MatKhau = nhanVienBLL.LayMatKhau(nhanVien.TenDangNhap, nhanVien.MatKhau);

                    Main.NhanVienQuanLyNhanSu();
                    Main.Show();


                }
                else if (check == 2)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();

                    frmMain frmMain = new frmMain();
                    frmMain.TenDN = nhanVien.TenDangNhap;

                    frmTKCN tKCN = new frmTKCN();

                    frmTKCN.MaNV = nhanVienBLL.LayMaNV(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.HoTen = nhanVienBLL.LayTen(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.NamSinh = nhanVienBLL.LayNamSinh(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.QueQuan = nhanVienBLL.LayQueQuan(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.SDT = nhanVienBLL.LaySDT(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.TenDN = nhanVienBLL.LayTenDN(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.MatKhau = nhanVienBLL.LayMatKhau(nhanVien.TenDangNhap, nhanVien.MatKhau);

                    frmMain.NhanVienNhapHang();
                    frmMain.Show();
                }
                else if (check == 3)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();

                    frmMain frmMain = new frmMain();
                    frmMain.TenDN = nhanVien.TenDangNhap;

                    frmTKCN tKCN = new frmTKCN();

                    frmTKCN.MaNV = nhanVienBLL.LayMaNV(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.HoTen = nhanVienBLL.LayTen(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.NamSinh = nhanVienBLL.LayNamSinh(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.QueQuan = nhanVienBLL.LayQueQuan(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.SDT = nhanVienBLL.LaySDT(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.TenDN = nhanVienBLL.LayTenDN(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.MatKhau = nhanVienBLL.LayMatKhau(nhanVien.TenDangNhap, nhanVien.MatKhau);

                    frmMain.NhanVienXuatHang();
                    frmMain.Show();
                }
                else if (check == 4)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();

                    frmMain frmMain = new frmMain();
                    frmMain.TenDN = nhanVien.TenDangNhap;

                    frmTKCN tKCN = new frmTKCN();

                    frmTKCN.MaNV = nhanVienBLL.LayMaNV(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.HoTen = nhanVienBLL.LayTen(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.NamSinh = nhanVienBLL.LayNamSinh(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.QueQuan = nhanVienBLL.LayQueQuan(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.SDT = nhanVienBLL.LaySDT(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.TenDN = nhanVienBLL.LayTenDN(nhanVien.TenDangNhap, nhanVien.MatKhau);
                    frmTKCN.MatKhau = nhanVienBLL.LayMatKhau(nhanVien.TenDangNhap, nhanVien.MatKhau);

                    frmMain.QuanLy();
                    frmMain.Show();
                }
                else
                {

                    MessageBox.Show("Tài khoản không tồn tại hoặc sai mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void cbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHienThiMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }
    }
}
