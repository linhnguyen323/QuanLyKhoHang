using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

///HoThiGiang được phân công phần này
/// Nhan viên bll hồ thị giang
namespace BLL
{
    public class NhanVienBLL
    {
        
        NhanVienDAL nvDAL = new NhanVienDAL();
        NhanVienDTO nvDTO = new NhanVienDTO();


        public bool KiemTraKetNoi()
        {
            return nvDAL.isConnection();
        }

        public DataTable getAllNV()
        {
            return nvDAL.getAllNV();
        }

        public DataTable ShowCombobox(string Query)
        {
            return nvDAL.ShowCombobox(Query);
        }

        public int InsertNV(NhanVienDTO nhanVien)
        {
             return nvDAL.InsertNV(nhanVien);
        }
        public bool CheckID(int MaNV)
        {
            return nvDAL.CheckID(MaNV);
        }
        public int UpdateNV(NhanVienDTO nhanVien)
        {
            return nvDAL.UpdateNV(nhanVien);
        }
        public int UpdateNV2(NhanVienDTO nhanVien)
        {
            return nvDAL.UpdateNV2(nhanVien);
        }
        public int DeleteNV(int MaNV)
        {
            return nvDAL.DeleteNV(MaNV);
        }

        public DataTable SearchNV1(NhanVienDTO nv)
        {
            return nvDAL.SearchNV1(nv);
        }

        public DataTable SearchNV3(NhanVienDTO nv)
        {
            return nvDAL.SearchNV3(nv);
        }

        public DataTable SearchNV4(NhanVienDTO nv)
        {
            return nvDAL.SearchNV4(nv);
        }

        public DataTable SearchNV5(NhanVienDTO nv)
        {
            return nvDAL.SearchNV5(nv);
        }


        //check acount
        //public int Login(NhanVienDTO nhanVien)
        //{
        //    if (string.IsNullOrEmpty(nhanVien.TenDangNhap) || string.IsNullOrEmpty(nhanVien.MatKhau))
        //        return 0;
        //    if (nvDAL.CheckAcount(nhanVien) == false)
        //        return -1;
        //    return 1;
        //}

        public bool CheckUserName (string TenDangNhap)
        {
            if (nvDAL.CheckUserName(TenDangNhap))
            {
                return true;
            
            }
            return false;
        }


        public int Login(NhanVienDTO nhanVien)
        {
            if (string.IsNullOrEmpty(nhanVien.TenDangNhap) || string.IsNullOrEmpty(nhanVien.MatKhau))
                return 0;
            if (nvDAL.CheckAcount(nhanVien) == 1)
                return 1;
            else if (nvDAL.CheckAcount(nhanVien) == 2)
                    return 2;
            else if (nvDAL.CheckAcount(nhanVien) == 3)
                    return 3;
            else if (nvDAL.CheckAcount(nhanVien) == 4)
                return 4;
            else 
                return 6;

        }




        public string LayTen(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LayTen(TenDangNhap, MatKhau);
        }

        public int LayMaNV(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LayMaNV(TenDangNhap, MatKhau);
        }
        public string LayNamSinh(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LayNamSinh(TenDangNhap, MatKhau);
        }
        public string LayQueQuan(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LayQueQuan(TenDangNhap, MatKhau);
        }
        public string LaySDT(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LaySDT(TenDangNhap, MatKhau);
        }

        public string LayTenDN(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LayTenDN(TenDangNhap, MatKhau);
        }
        public string LayMatKhau(string TenDangNhap, string MatKhau)
        {
            return nvDAL.LayMatKhau(TenDangNhap, MatKhau);
        }
    }
}
