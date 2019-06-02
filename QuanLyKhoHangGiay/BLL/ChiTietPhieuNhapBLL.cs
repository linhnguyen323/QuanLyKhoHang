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
    public class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL CTPN = new DAL.ChiTietPhieuNhapDAL();

        public bool KiemTraKetNoi()
        {
            return CTPN.KiemTraKetNoi();
        }

        public DataTable getAllCTPN()
        {
            return CTPN.getAllCTPN();
        }
        
        public DataTable ShowComboBox(string query)
        {
            return CTPN.ShowComboBox(query);
        }

        public bool CheckID(int MaPN)
        {
            return CTPN.CheckID(MaPN);
        }

        public int InsertCTPN(ChiTietPhieuNhapDTO chiTietPhieuNhap)
        {
            return CTPN.InsertCTPN(chiTietPhieuNhap);
        }

        public int UpdateCTPN(ChiTietPhieuNhapDTO chiTietPhieuNhap)
        {
            return CTPN.UpdateCTPN(chiTietPhieuNhap);
        }

        public int DeleteCTPN(int MaPN, int MaSP)
        {
            return CTPN.DeleteCTPN(MaPN, MaSP);
        }

        public DataTable SearchCTPN_MaPN(int MaPN)
        {
            return CTPN.SearchCTPN_MaPN(MaPN);
        }
        public DataTable SearchCTPN_MaSP(int MaSP)
        {
            return CTPN.SearchCTPN_MaSP(MaSP);
        }
        public DataTable SearchCTPN_MaNCC(int MaNCC)
        {
            return CTPN.SearchCTPN_MaNCC(MaNCC);
        }
    }
}
