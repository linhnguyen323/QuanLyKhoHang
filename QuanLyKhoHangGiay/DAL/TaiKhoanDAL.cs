using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL : DBconnection
    {
        DBconnection DBcon = new DBconnection();
        NhanVienDTO nhanvien = new NhanVienDTO();


        public bool CheckUserName(string TenDangNhap)
        {
            if (DBcon.GetTable("select * from DSNhanVien where  TenDangNhap = '" + TenDangNhap + "'").Rows.Count > 0)
                return true;
            return false;
        }

        public int CheckAcount(NhanVienDTO nhanVien)
        {

            if (DBcon.GetTable("select * from NhanVien where MaLoaiNguoiDung = 1 and TenDangNhap = '" + nhanVien.TenDangNhap + "' and MatKhau = '" + nhanVien.MatKhau + "'").Rows.Count > 0)
                return 1;
            else if (DBcon.GetTable("select * from NhanVien where MaLoaiNguoiDung = 2 and TenDangNhap = '" + nhanVien.TenDangNhap + "' and MatKhau = '" + nhanVien.MatKhau + "'").Rows.Count > 0)
                return 2;
            else if (DBcon.GetTable("select * from NhanVien where MaLoaiNguoiDung = 3 and TenDangNhap = '" + nhanVien.TenDangNhap + "' and MatKhau = '" + nhanVien.MatKhau + "'").Rows.Count > 0)
                return 3;
            else if (DBcon.GetTable("select * from NhanVien where MaLoaiNguoiDung = 4 and TenDangNhap = '" + nhanVien.TenDangNhap + "' and MatKhau = '" + nhanVien.MatKhau + "'").Rows.Count > 0)
                return 4;
            else return 0;

        }

        public string LayTen(string TenDangNhap, string MatKhau)
        {
            return DBcon.string_ExecuteScalarQuery("select TenNV from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }

        public int LayMaNV(string TenDangNhap, string MatKhau)
        {
            return DBcon.int_ExecuteScalarQuery("select MaNV from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }

        public string LayNamSinh(string TenDangNhap, string MatKhau)
        {
            return DBcon.string_ExecuteScalarQuery("select NamSinh from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }

        public string LayQueQuan(string TenDangNhap, string MatKhau)
        {
            return DBcon.string_ExecuteScalarQuery("select QueQuan from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }

        public string LaySDT(string TenDangNhap, string MatKhau)
        {
            return DBcon.string_ExecuteScalarQuery("select SDT from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }

        public string LayMatKhau(string TenDangNhap, string MatKhau)
        {
            return DBcon.string_ExecuteScalarQuery("select MatKhau from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }
        public string LayTenDN(string TenDangNhap, string MatKhau)
        {
            return DBcon.string_ExecuteScalarQuery("select TenDangNhap from NhanVien " +
                                            "where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'");
        }

    }
}
