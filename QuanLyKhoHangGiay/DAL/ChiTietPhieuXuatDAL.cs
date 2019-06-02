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
     public class ChiTietPhieuXuatDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }
        

        public DataTable getAllCTPX()
        {
            return DBcon.GetTable("select px.MaPX, sp.TenSP, ctpx.SoLuong, ctpx.GiamGia," +
                                    " kh.TenKH from CTPhieuXuat as ctpx, PhieuXuat as px, SanPham as sp, KhachHang as kh " +
                                    "where ctpx.MaPX = px.MaPX and ctpx.MaSP = sp.MaSP and ctpx.MaKH = kh.MaKH");
        }

        public DataTable ShowComboBox(String Query)
        {
            return DBcon.GetTable(Query);
        }

        //check ID

        public bool CheckID(int MaPX)
        {
            string Query = "select * from PhieuXuat where MaPX ='" + MaPX + "'";
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }


        public string CheckItem(int MaSP)
        {
            string Query = "Select SoLuongNhap from ThongKeNhap where MaSP = "+MaSP ;
            string count = DBcon.string_ExecuteScalarQuery(Query);
            return count;
        }




        //Thêm CHI TIẾT PHIẾU xuất
        public int InsertCTPX(ChiTietPhieuXuatDTO chiTietPhieuXuat)
        {
            int result = 0;
            string Query = "Insert into CTPhieuXuat values('" + chiTietPhieuXuat.MaPX + "', '" + chiTietPhieuXuat.MaSP + "', '" + chiTietPhieuXuat.SoLuong + "', '" + chiTietPhieuXuat.MaKH + "','" + chiTietPhieuXuat.GiamGia + "')";
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
        public int UpdateCTPX(ChiTietPhieuXuatDTO chiTietPhieuXuat)
        {
            int result = 0;
            string Query = "Update CTPhieuXuat set MaSP ='" + chiTietPhieuXuat.MaSP + "', SoLuong = '" + chiTietPhieuXuat.SoLuong + "', MaNV = '" + chiTietPhieuXuat.MaKH + "',GiaNhap = '" + chiTietPhieuXuat.GiamGia + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }                         
            return result;
        }

        //Xóa chi tiết phiếu xuất
        public int DeleteCTPN(int MaPX)
        {
            int result = 0;
            string Query = "Delete from CTPhieuXuat where MaPX ='" + MaPX + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {
                
            }
            return result;
        }

        //tìm kiếm chi tiết phiếu nhập theo mã phiếu xuất
        public DataTable SearchCTPX_MaPX(int MaPX)
        {
            return DBcon.GetTable("select px.MaPX, sp.TenSP, ctpx.SoLuong, ctpx.GiamGia,kh.TenKH " +
                                "from CTPhieuXuat as ctpx, PhieuXuat as px, SanPham as sp, KhachHang as kh " +
                                "where ctpx.MaPX = px.MaPX and ctpx.MaSP = sp.MaSP and ctpx.MaKH = kh.MaKH   and px.MaPX like '%" + MaPX + "%'");
        }
        //tìm kiếm chi tiết phiếu nhập theo mã sản phẩm
        public DataTable SearchCTPX_MaSP(int MaSP)
        {
            return DBcon.GetTable("select px.MaPX, sp.TenSP, ctpx.SoLuong, ctpx.GiamGia,kh.TenKH " +
                                 "from CTPhieuXuat as ctpx, PhieuXuat as px, SanPham as sp, KhachHang as kh " +
                                 "where ctpx.MaPX = px.MaPX and ctpx.MaSP = sp.MaSP and ctpx.MaKH = kh.MaKH   and sp.MaSP like '%"+MaSP+"%'");
        }
        //tìm kiếm chi tiết phiếu nhập theo mã khach hàng
        public DataTable SearchCTPX_MaKH(int MaKH)
        {
            return DBcon.GetTable("select px.MaPX, sp.TenSP, ctpx.SoLuong, ctpx.GiamGia,kh.TenKH " +
                                 "from CTPhieuXuat as ctpx, PhieuXuat as px, SanPham as sp, KhachHang as kh " +
                                 "where ctpx.MaPX = px.MaPX and ctpx.MaSP = sp.MaSP and ctpx.MaKH = kh.MaKH   and kh.MaKH  like '%" + MaKH +"%'");
        }
    }
}
