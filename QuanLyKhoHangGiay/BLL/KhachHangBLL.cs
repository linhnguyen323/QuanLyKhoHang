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
    public class KhachHangBLL
    {
        KhachHangDAL khDAL = new KhachHangDAL();
        public bool KiemTraKetNoi()
        {
            return khDAL.KiemTraKetNoi();
        }
        public DataTable getAllKH()
        {
            return khDAL.getAllKH();
        }

        public bool CheckID(int MaKH)
        {
            return khDAL.CheckID(MaKH);
        }

        public int InsertKH(KhachHangDTO khachHang)
        {
            return khDAL.InsertKH(khachHang);
        }

        public int UpdateKH(KhachHangDTO khachHang)
        {
            return khDAL.UpdateKH(khachHang);
        }

        public int DeleteKH(int MaKH)
        {
            return khDAL.DeleteKH(MaKH);
        }

        public DataTable SearchKH1(KhachHangDTO khachHang)
        {
            return khDAL.SearchKH(khachHang);
        }

        public DataTable SearchKH2(KhachHangDTO khachHang)
        {
            return khDAL.SearchKH2(khachHang);
        }
    }
}
