using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL spDAL = new SanPhamDAL();
        SanPhamDTO spDTO = new SanPhamDTO();

        public bool KiemTraKetNoi()
        {
            return spDAL.KiemTraKetNoi();
        }

        public DataTable getAllSP()
        {
            return spDAL.getAllSP();
        }
        public DataTable getDSTonKho()
        {
            return spDAL.getTonKho();
        }

        public DataTable SearchTK_MaLoai(int MaLoai)
        {
            return spDAL.SearchTK_MaLoai(MaLoai);
        }
        public DataTable SearchTK_MaSP(int MaSP)
        {
            return spDAL.SearchTK_MaSP(MaSP);
        }
        public DataTable SearchTK(int MaSP, int MaLoai)
        {
            return spDAL.SearchTK(MaSP, MaLoai);
        }

        public DataTable ShowComboBox(string query)
        {
             return spDAL.ShowComboBox(query);
        }
        public bool CheckID(int MaSP)
        {
            return spDAL.CheckID(MaSP);
        }

        public int InsertSP(SanPhamDTO sanPham)
        {
            return spDAL.InsertSP(sanPham);
        }

        public int UpdateSP(SanPhamDTO sanPham)
        {
            return spDAL.UpdateSP(sanPham);
        }

        public int DeleteSP(SanPhamDTO sanPham)
        {
            return spDAL.DeleteSP(sanPham);
        }
        //tìm kiếm sản phẩm
        public DataTable SearchSP1(SanPhamDTO sp)
        {
            return spDAL.SearchSP1(sp);
        }

        public DataTable SearchSP2(SanPhamDTO sp)
        {
            return spDAL.SearchSP2(sp);
        }


        public DataTable SearchSP3(SanPhamDTO sp)
        {
            return spDAL.SearchSP3(sp);
        }

        public DataTable SearchSP4(SanPhamDTO sp)
        {
            return spDAL.SearchSP4(sp);
        }

        public DataTable SearchSP5(SanPhamDTO sp)
        {
            return spDAL.SearchSP5(sp);
        }

        public DataTable SearchSP6(SanPhamDTO sp)
        {
            return spDAL.SearchSP6(sp);
        }

    }
}
