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
    public class ChiTietPhieuXuatBLL
    {
        ChiTietPhieuXuatDAL chiTietPhieuXuat = new ChiTietPhieuXuatDAL();

        public bool KiemTraKetNoi()
        {
            return chiTietPhieuXuat.KiemTraKetNoi();
        }


        public DataTable getAllCTPX()
        {
            return chiTietPhieuXuat.getAllCTPX();
        }

        public DataTable ShowComboBox(string Query)
        {
            return chiTietPhieuXuat.ShowComboBox(Query);
        }

        public bool CheckID(int MaPX)
        {
            return chiTietPhieuXuat.CheckID(MaPX);
        }

        public int InsertCTPX(ChiTietPhieuXuatDTO chiTiet)
        {
            return chiTietPhieuXuat.InsertCTPX(chiTiet);
        }

        public int UpdateCTPX(ChiTietPhieuXuatDTO chiTiet)
        {
            return chiTietPhieuXuat.UpdateCTPX(chiTiet);


        }

        public int DeleteCTPX(int MaPX)
        {
            return chiTietPhieuXuat.DeleteCTPN(MaPX);
        }

        //TÌM KIẾM

        public DataTable SearchCTPX_MaPX(int MaPX)
        {
            return chiTietPhieuXuat.SearchCTPX_MaPX(MaPX);
        }

        public DataTable SearchCTPX_MaSP(int MaSP)
        {
            return chiTietPhieuXuat.SearchCTPX_MaSP(MaSP);
        }

        public DataTable SearchCTPX_MaKH(int MaKH)
        {
            return chiTietPhieuXuat.SearchCTPX_MaKH(MaKH);
        }


        //CHECK Hàng trong kho
        public string CheckItem(int MaSP)
        {
            return chiTietPhieuXuat.CheckItem(MaSP);
        }
    }
}
