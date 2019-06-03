using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class TaiKhoanBLL
    {

        TaiKhoanDAL taiKhoan = new TaiKhoanDAL();

        public bool CheckUserName(string TenDangNhap)
        {
            if (taiKhoan.CheckUserName(TenDangNhap))
            {
                return true;

            }
            return false;
        }


        public int Login(NhanVienDTO nhanVien)
        {
            if (string.IsNullOrEmpty(nhanVien.TenDangNhap) || string.IsNullOrEmpty(nhanVien.MatKhau))
                return 0;
            if (taiKhoan.CheckAcount(nhanVien) == 1)
                return 1;
            else if (taiKhoan.CheckAcount(nhanVien) == 2)
                return 2;
            else if (taiKhoan.CheckAcount(nhanVien) == 3)
                return 3;
            else if (taiKhoan.CheckAcount(nhanVien) == 4)
                return 4;
            else
                return 6;

        }

        public string LayTen(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LayTen(TenDangNhap, MatKhau);
        }

        public int LayMaNV(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LayMaNV(TenDangNhap, MatKhau);
        }
        public string LayNamSinh(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LayNamSinh(TenDangNhap, MatKhau);
        }
        public string LayQueQuan(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LayQueQuan(TenDangNhap, MatKhau);
        }
        public string LaySDT(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LaySDT(TenDangNhap, MatKhau);
        }

        public string LayTenDN(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LayTenDN(TenDangNhap, MatKhau);
        }
        public string LayMatKhau(string TenDangNhap, string MatKhau)
        {
            return taiKhoan.LayMatKhau(TenDangNhap, MatKhau);
        }
    }
}
