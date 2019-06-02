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
    public class PhieuNhapDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable getAllPN()
        {
            return DBcon.GetTable("proDSPN");
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

        public int InsertPN(PhieuNhapDTO phieuNhap)
        {
            int result = 0;
            string Query = "Insert into PhieuNhap(MaPN, NgayNhap) values('" + phieuNhap.MaPN + "', N'" + phieuNhap.NgayNhap.ToShortDateString() + "')";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        public int UpdatePN(PhieuNhapDTO phieuNhap)
        {
            int result = 0;
            string Query = "Update PhieuNhap set NgayNhap ='" + phieuNhap.NgayNhap.ToShortDateString() + "'where MaPN = '" + phieuNhap.MaPN+ "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        public int DeletePN(int MaPN)
        {
            int result = 0;
            string Query = "Delete from NgayNhap where MaPN = '" + MaPN + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        public DataTable SearchPN1(PhieuNhapDTO pn)
        {
            return DBcon.GetTable("Select * from PhieuNhap where MaPN like '%" + pn.MaPN + "'");
        }
        public DataTable SearchPN2(PhieuNhapDTO pn)
        {
            return DBcon.GetTable("Select * from PhieuNhap where NgayNhap like '%" + pn.NgayNhap + "%'");
        }
    }
}
