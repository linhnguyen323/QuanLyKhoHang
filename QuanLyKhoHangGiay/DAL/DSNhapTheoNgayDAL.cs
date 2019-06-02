using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DSNhapTheoNgayDAL
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable ThongKeDSNhapTheoNgay()
        {
            string Query = "SELECT * FROM ThongKeDSNhapTheoNgay";
            return DBcon.GetTable(Query);
        }

        public DataTable Search(DateTime Date)
        {
            string Query = "select * from ThongKeDSNhapTheoNgay where [Ngày nhập] like N'%" + Date + "%'";
            return DBcon.GetTable(Query);
        }

    }
}
