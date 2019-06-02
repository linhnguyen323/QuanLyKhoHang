using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietPhieuNhapDAL : DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }


        public DataTable getAllCTPN()
        {
            return DBcon.GetTable("select pn.MaPN, sp.TenSP, ctpn.SoLuong, ctpn.GiaNhap," +
                                    "ncc.TenNCC from CTPhieuNhap as ctpn, PhieuNhap as pn, SanPham as sp, NhaCungCap as ncc " +
                                    "where ctpn.MaPN = pn.MaPN and ctpn.MaSP = sp.MaSP and ctpn.MaNCC = ncc.MaNCC");
        }

        
        public DataTable ShowComboBox(string query)
        {
            return DBcon.GetTable(query);
        }

        //check ID
        public bool CheckID(int MaPN)
        {
            string Query = "select * from PhieuNhap where MaPN ='" + MaPN + "'";
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }


        //Thêm CHI TIẾT PHIẾU NHẬP
        public int InsertCTPN(ChiTietPhieuNhapDTO chiTietPhieuNhap)
        {
            int result = 0;
            string Query = "Insert into CTPhieuNhap values('" + chiTietPhieuNhap.MaPN + "', '" + chiTietPhieuNhap.MaSP + "', '" + chiTietPhieuNhap.MaNCC + "', '" + chiTietPhieuNhap.SoLuong + "', '" + chiTietPhieuNhap.GiaNhap + "')";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //sửa chi tiết phiếu xuất
        public int UpdateCTPN(ChiTietPhieuNhapDTO chiTietPhieuNhap)
        {
            int result = 0;
            string Query = "Update CTPhieuNhap set MaNCC = '" + chiTietPhieuNhap.MaNCC + "', SoLuong = '" + chiTietPhieuNhap.SoLuong + "',GiaNhap = '" + chiTietPhieuNhap.GiaNhap + "' Where MaPN = '"+chiTietPhieuNhap.MaPN+"'and MaSP = '"+chiTietPhieuNhap.MaSP+"'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //Xóa chi tiết phiếu nhập
        public int DeleteCTPN(int MaPN, int MaSP)
        {
            int result = 0;
            string Query = "Delete from CTPhieuNhap where MaPN ='" + MaPN + "' and MaSP = '"+MaSP+"'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //tìm kiếm chi tiết phiếu nhập theo mã phiếu nhập
        public DataTable SearchCTPN_MaPN(int MaPN)
        {
            return DBcon.GetTable("select pn.MaPN, sp.TenSP, ctpn.SoLuong, ctpn.GiaNhap,ncc.TenNCC" +
                                 " from CTPhieuNhap as ctpn, PhieuNhap as pn, SanPham as sp, NhaCungCap as ncc " +
                                 "where ctpn.MaPN = pn.MaPN and ctpn.MaSP = sp.MaSP and ctpn.MaNCC = ncc.MaNCC   and pn.MaPN like '%"+MaPN+"%'");
        }
        //tìm kiếm chi tiết phiếu nhập theo mã sản phẩm
        public DataTable SearchCTPN_MaSP(int MaSP)
        {
            return DBcon.GetTable("select pn.MaPN, sp.TenSP, ctpn.SoLuong, ctpn.GiaNhap, ncc.TenNCC " +
                                "from CTPhieuNhap as ctpn, PhieuNhap as pn, SanPham as sp, NhaCungCap as ncc  " +
                                "where ctpn.MaPN = pn.MaPN and ctpn.MaSP = sp.MaSP and sp.MaSP like '%"+MaSP+ "%' and ctpn.MaNCC = ncc.MaNCC");
        }
        //tìm kiếm chi tiết phiếu nhập theo mã nhà cung cấp
        public DataTable SearchCTPN_MaNCC(int MaNCC)
        {
            return DBcon.GetTable("select pn.MaPN, sp.TenSP, ctpn.SoLuong, ctpn.GiaNhap,ncc.TenNCC " +
                                "from CTPhieuNhap as ctpn, PhieuNhap as pn, SanPham as sp, NhaCungCap as ncc " +
                                 "where ctpn.MaPN = pn.MaPN and sp.MaSP = ctpn.MaSP and ctpn.MaNCC = ncc.MaNCC and ncc.MaNCC like '%" + MaNCC+"%'");
        }

    }
}
