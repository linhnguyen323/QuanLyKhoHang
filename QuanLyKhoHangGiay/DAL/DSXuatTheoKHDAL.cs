using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSXuatTheoKHDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }


        public DataTable DSXuatTheoKH()
        {
            string Query = "select * from DSXuatTheoKH";
            return DBcon.GetTable(Query);
        }

        public DataTable ShowCombobox(string Query)
        {
            return DBcon.GetTable(Query);
        }

        public DataTable Search(string khachhang)
        {
            string Query = "select * from DSXuatTheoKH where [Khách hàng] like N'%" +khachhang + "%'";
            return DBcon.GetTable(Query);
        }
    }
}
