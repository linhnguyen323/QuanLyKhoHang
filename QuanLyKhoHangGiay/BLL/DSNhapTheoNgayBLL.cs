using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DSNhapTheoNgayBLL
    {
        DSNhapTheoNgayDAL DS = new DSNhapTheoNgayDAL();

        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }

        public DataTable ThongKeDSNhapTheoNgay()
        {
            return DS.ThongKeDSNhapTheoNgay();
        }

        public DataTable Search(DateTime Date)
        {
            return DS.Search(Date);
        }
    }
}
