using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmTKCN : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        NhanVienDTO nvDTO = new NhanVienDTO();
        frmDangNhap dangNhap = new frmDangNhap();
        TaiKhoanBLL taiKhoan = new TaiKhoanBLL();

        public static int MaNV = 0;
        public static string HoTen = string.Empty;
        public static string NamSinh = string.Empty;
        public static string QueQuan = string.Empty;
        public static string SDT = string.Empty;
        public static string TenDN = string.Empty;
        public static string MatKhau = string.Empty;


        public frmTKCN()
        {
            InitializeComponent();
        }

        private void frmTKCN_Load(object sender, EventArgs e)
        {
            //frmDangNhap dangNhap = new frmDangNhap();

            if (!string.IsNullOrEmpty(TenDN))
            {
                this.txtMaNV.Text = MaNV.ToString();
                this.txtHoTen.Text = taiKhoan.LayTen(TenDN, MatKhau);
                this.dtNamSinh.Text = taiKhoan.LayNamSinh(TenDN, MatKhau);
                this.txtQueQuan.Text = taiKhoan.LayQueQuan(TenDN, MatKhau);
                this.txtSDT.Text = taiKhoan.LaySDT(TenDN, MatKhau);
                this.txtTenDN.Text = taiKhoan.LayTenDN(TenDN, MatKhau);
                this.txtMatKhau.Text = taiKhoan.LayMatKhau(TenDN, MatKhau);
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {

            if (txtMaNV.Text != null && txtHoTen.Text != null && dtNamSinh.Text != null && txtQueQuan.Text != null && txtSDT.Text != null && txtTenDN.Text != null && txtMatKhau.Text != null)
            {
                nvDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
                nvDTO.HoTen = txtHoTen.Text;
                nvDTO.NamSinh = dtNamSinh.Value;
                nvDTO.QueQuan = txtQueQuan.Text;
                nvDTO.SDT = txtSDT.Text;
                nvDTO.TenDangNhap = txtTenDN.Text;
                TenDN = txtTenDN.Text;
                nvDTO.MatKhau = txtMatKhau.Text;
                MatKhau = txtMatKhau.Text;

                if (nv.KiemTraKetNoi())
                {
                    if (nv.CheckID(nvDTO.MaNV))
                    {
                        int check = nv.UpdateNV2(nvDTO);

                        if (check == 1)
                        {

                            MessageBox.Show("Sửa thông tin thành công !");

                            frmMain main = new frmMain();
                            frmMain.TenDN = nvDTO.TenDangNhap;

                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + nvDTO.MaNV + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Vui lòng nhập thông tin để thay đổi");
        }
    }
}
