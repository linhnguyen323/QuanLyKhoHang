using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSXuatTheoNgayDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }
        public DataTable DSXuatTheoNgay()
        {
            string Query = "select * from DSXuatTheoNgay";
            return DBcon.GetTable(Query);
        }

        public DataTable Search(DateTime Date)
        {
            string Query = "select * from DSXuatTheoNgay where [Ngày xuất] like '%"+Date+"%'";
            return DBcon.GetTable(Query);
        }
    }
}
