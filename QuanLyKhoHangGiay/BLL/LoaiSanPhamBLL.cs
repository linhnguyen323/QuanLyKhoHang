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
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL lspDAL = new LoaiSanPhamDAL();

        public bool KiemTraKetNoi()
        {
            return lspDAL.KiemTraKetNoi();
        }

        public DataTable getAllLSP()
        {
            return lspDAL.getAllLSP();
        }
        public bool CheckID(int MaLSP)
        {
            return lspDAL.CheckID(MaLSP);
        }

        public int InsertLSP(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return lspDAL.InsertLSP(loaiSanPhamDTO);
        }
        public int UpdateLSP(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return lspDAL.UpdateLSP(loaiSanPhamDTO);
        }
        public int DeleteLSP(int MaLoai)
        {
            return lspDAL.DeleteLSP(MaLoai);
        }
        public DataTable SearchLSP1(LoaiSanPhamDTO lsp)
        {
            return lspDAL.SearchLSP(lsp);
        }
        public DataTable SearchLSP2(LoaiSanPhamDTO lsp)
        {
            return lspDAL.SearchLSP2(lsp);
        }
    }
}
