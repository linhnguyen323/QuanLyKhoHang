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
    public class KhachHangDAL : DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        //hiển thị danh sách khách hàng
        public DataTable getAllKH()
        {
            return DBcon.GetTable("proDSKH");
        }
        //check ID
        public bool CheckID(int MaKH)
        {
            string Query = "select * from KhachHang where MaKH ='" + MaKH + "'";
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //Thêm khách hàng
        public int InsertKH(KhachHangDTO khachHang)
        {
            int result = 0;
            string Query = "Insert into KhachHang values('" + khachHang.MaKH + "', N'" +khachHang.HoTen + "', N'" + khachHang.DiaChi + "', N'" + khachHang.SDT + "')";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //sửa khách hàng
        public int UpdateKH(KhachHangDTO khachHang)
        {
            int result = 0;
            string Query = "Update KhachHang set TenKH = N'" + khachHang.HoTen + "', DiaChi = N'" + khachHang.DiaChi + "', SDT = '" + khachHang.SDT + "' where MaKH = '"+khachHang.MaKH +"' ";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //xóa khách hàng
        public int DeleteKH(int MaKH)
        {
            int result = 0;
            string Query = "Delete from KhachHang  where MaKH = '" + MaKH + "' ";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }


        //tìm kiếm khách hàng
        public DataTable SearchKH(KhachHangDTO khachHang)
        {
            return DBcon.GetTable("Select * from KhachHang where MaKH like '%" + khachHang.MaKH + "'");
        }

        public DataTable SearchKH2(KhachHangDTO khachHang)
        {
            return DBcon.GetTable("Select * from KhachHang where TenKH like N'" + khachHang.HoTen+"'");
        }
    }
}
