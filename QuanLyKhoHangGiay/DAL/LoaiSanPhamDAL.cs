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
    public class LoaiSanPhamDAL : DBconnection
    {
        LoaiSanPhamDTO lspDTO = new LoaiSanPhamDTO();
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }
        public DataTable getAllLSP()
        {
           return DBcon.GetTable("select * from LoaiSP");
        }

        //check ID
        public bool CheckID(int MaLoai)
        {
            string Query = "select * from LoaiSP where MaLoai ='" + MaLoai + "'";
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //Thêm loại sản phẩm
        public int InsertLSP(LoaiSanPhamDTO loaiSanPham)
        {
            int result = 0;
            string Query = "Insert into LoaiSP values('" + loaiSanPham.MaLoai + "', N'" + loaiSanPham.TenLoai + "')";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //Sửa loại sản phẩm
        public int UpdateLSP(LoaiSanPhamDTO loaiSanPham)
        {
            int result = 0;
            string Query = "Update LoaiSP set TenLoai = N'" + loaiSanPham.TenLoai + "' where MaLoai =" + loaiSanPham.MaLoai + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //xÓA LOẠI SẢN PHẨM
        public int DeleteLSP(int MaLoai)
        {
            int result = 0;
            string Query = "DELETE FROM LoaiSP where MaLoai =" + MaLoai + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //tìm kiếm theo mã loại sản phẩm
        public DataTable SearchLSP(LoaiSanPhamDTO lsp)
        {
            return DBcon.GetTable("Select * from LoaiSP where MaLoai like '" + lsp.MaLoai + "'");
        }

        public DataTable SearchLSP2(LoaiSanPhamDTO lsp)
        {
            return DBcon.GetTable("Select * from LoaiSP where TenLoai like '" + lsp.TenLoai + "'");
        }

    }
}
