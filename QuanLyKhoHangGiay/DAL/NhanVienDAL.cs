using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

///HoThiGiang được phân công phần này
///Hồ thị giang
namespace DAL
{
    public class NhanVienDAL : DBconnection
    {
        NhanVienDTO nhanVien = new NhanVienDTO();
        DBconnection DBcon = new DBconnection();

        public static string MaNV = string.Empty;
        public static string HoTen = string.Empty;
        public static string NamSinh = string.Empty;
        public static string QueQuan = string.Empty;
        public static string SDT = string.Empty;
        public static string TenDN = string.Empty;
        public static string MatKhau = string.Empty;

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
            
        }


        public DataTable getAllNV()
        {
            return DBcon.GetTable("select * from DSNhanVien");
        }

        public DataTable ShowCombobox(string Query)
        {
            return DBcon.GetTable(Query);
        }

        //THÊM
        public int InsertNV(NhanVienDTO nhanVien)
        {
            int result = 0;
            string Query = "Insert into NhanVien  values(N'"+nhanVien.MaNV +"',  N'" + nhanVien.HoTen + "', '" + nhanVien.NamSinh.ToShortDateString() + "', N'" + nhanVien.QueQuan + "','" + nhanVien.TenDangNhap + "','" + nhanVien.MatKhau + "','" + nhanVien.SDT + "'," + nhanVien.MaLoaiNguoiDung + ")";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
        //SỬA
        public int UpdateNV(NhanVienDTO nhanVien)
        {
            int result = 0;
            string Query = "Update NhanVien set TenNV =N'" + nhanVien.HoTen + "', NamSinh ='" + nhanVien.NamSinh.ToShortDateString() + "', QueQuan = N'" + nhanVien.QueQuan + "', TenDangNhap =  '" + nhanVien.TenDangNhap + "', MatKhau = '" + nhanVien.MatKhau + "',SDT = '" + nhanVien.SDT + "', MaLoaiNguoiDung = " + nhanVien.MaLoaiNguoiDung + " where MaNV = '" + nhanVien.MaNV + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        public int UpdateNV2(NhanVienDTO nhanVien)
        {
            int result = 0;
            string Query = "Update NhanVien set TenNV =N'" + nhanVien.HoTen + "', NamSinh ='" + nhanVien.NamSinh.ToShortDateString() + "', QueQuan = N'" + nhanVien.QueQuan + "', MatKhau = '" + nhanVien.MatKhau + "',SDT = '" + nhanVien.SDT + "' where MaNV = '" + nhanVien.MaNV + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
        //xóa bản ghi
        public int DeleteNV(int MaNV)
        {

            int result = 0;
            string Query = "Delete from NhanVien where MaNV = '" + MaNV + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //TÌM KIẾM NHÂN VIÊN
        public DataTable SearchNV1(NhanVienDTO nv)
        {
            return DBcon.GetTable("select * from DSNhanVien where MaNV like '%" + nv.MaNV + "%'");
        }


        public DataTable SearchNV3(NhanVienDTO nv)
        {
            return DBcon.GetTable("select * from DSNhanVien where TenNV like N'%" + nv.HoTen + "%'");
        }

        public DataTable SearchNV4(NhanVienDTO nv)
        {
            return DBcon.GetTable("select * from DSNhanVien where NamSinh like '%" + nv.NamSinh + "%'");
        }

        public DataTable SearchNV5(NhanVienDTO nv)
        {
            return DBcon.GetTable("select * from DSNhanVien where QueQuan like N'%" + nv.QueQuan + "%'");
        }

        //check ID
        public bool CheckID(int MaNV)
        {
            string Query = "select * from DSNhanVien where MaNV = " + MaNV;
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }


        //check acount
        public bool CheckUserName(string TenDangNhap)
        {
            if (DBcon.GetTable("select * from DSNhanVien where  TenDangNhap = '" + TenDangNhap+"'" ).Rows.Count > 0)
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
