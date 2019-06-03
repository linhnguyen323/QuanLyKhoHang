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
        
    }
}
