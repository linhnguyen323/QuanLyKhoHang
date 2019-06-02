using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSNhapTheoNamDAL
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable DSNhapTheoNam()
        {
            string Query = "select * from DSNhapTheoNam";
            return DBcon.GetTable(Query);
        }

        public DataTable Search(int Nam)
        {
            string Query = "select * from DSNhapTheoNam where [Năm] like '%"+Nam+"%'";
            return DBcon.GetTable(Query);
        }
    }
}
