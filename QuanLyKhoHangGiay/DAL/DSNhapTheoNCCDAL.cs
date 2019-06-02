using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSNhapTheoNCCDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable DSTheoNCC()
        {
            string Query = "select * from DSTheoNCC";
            return DBcon.GetTable(Query);
        }

        public DataTable ShowCombobox(string Query)
        {
            return DBcon.GetTable(Query);
        }

        public DataTable Search(string NCC)
        {
            string Query = "select * from DSTheoNCC where [Nhà cung cấp] like N'%"+NCC+"%'";
            return DBcon.GetTable(Query);
        }
    }
}
