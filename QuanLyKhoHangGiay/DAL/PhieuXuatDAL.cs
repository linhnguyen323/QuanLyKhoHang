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
    public class PhieuXuatDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable getAllPX()
        {
            return DBcon.GetTable("procDSPX");
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
        //THÊM PHIẾU XUẤT
        public int InsertPX(PhieuXuatDTO phieuXuatDTO)
        {
            int result = 0;
            string Query = "Insert into PhieuXuat(MaPX, NgayXuat) values('" + phieuXuatDTO.MaPX + "', N'" + phieuXuatDTO.NgayXuat.ToShortDateString() + "')";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //Sửa phiếu xuất
        public int UpdatePX(PhieuXuatDTO phieuXuatDTO)
        {
            int result = 0;
            string Query = "Update PhieuXuat set NgayXuat ='"+ phieuXuatDTO.NgayXuat.ToShortDateString() + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //XÓA PHIẾU XUẤT
        public int DeletePX(int MaPX)
        {
            int result = 0;
            string Query = "Delete from PhieuXuat where MaPX ='" +MaPX + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }
    }
}
