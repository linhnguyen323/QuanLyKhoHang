using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSXuatTheoNamDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }
        public DataTable DSXuatTheoNam()
        {
            string Query = "select * from DSXuatTheoNam";
            return DBcon.GetTable(Query);
        }

        public DataTable Search(int Nam)
        {
            string Query = "select * from DSXuatTheoNam where [Năm] like '%"+Nam+"%'";
            return DBcon.GetTable(Query);
        }
    }
}
