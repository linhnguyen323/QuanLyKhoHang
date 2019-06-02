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
    public class NhaCungCapDAL : DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable getAllNCC()
        {
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("proDSNCC", Conn);
            //DataTable dt = new DataTable();
            //dataAdapter.Fill(dt);
            //return dt;
            return DBcon.GetTable("proDSNCC");

        }

        //check ID
        public bool CheckID(int MaNCC)
        {
            string Query = "select * from NhaCungCap where MaNCC ='" + MaNCC + "'";
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //Thêm nhà cung cấp
        public int InsertNCC(NhaCungCapDTO nhaCungCap)
        {
            int result = 0;
            string Query = "Insert into NhaCungCap values('" + nhaCungCap.MaNCC + "', N'" + nhaCungCap.HoTen + "', N'" + nhaCungCap.DiaChi + "', '"+nhaCungCap.SDT+"')";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //sửa nhà cung câos
        public int UpdateNCC(NhaCungCapDTO ncc)
        {
            int result = 0;
            string Query = "Update NhaCungCap set TenNCC =N'" + ncc.HoTen + "', DiaChi = N'"+ncc.DiaChi+"', SDT = N'"+ncc.SDT+"'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //xóa nhà cung cấp
        public int DeleteNCC(NhaCungCapDTO ncc)
        {
            int result = 0;
            string Query = "Delete from NhaCungCap where MaNCC ="+ncc.MaNCC;
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }


        //TÌM KIẾM nhà cung cấp theo mã
        public DataTable SearchNCC1(NhaCungCapDTO ncc)
        {
            return DBcon.GetTable("Select * from NhaCungCap where MaNCC like '%" + ncc.MaNCC +"%'");

        }
        //TÌM KIẾM THEO Tên
        public DataTable SearchNCC2(NhaCungCapDTO ncc)
        {
            return DBcon.GetTable("Select * from NhaCungCap where TenNCC like N'%" + ncc.HoTen + "%'");
        }

    }
}
