using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public  class DSXuatTheoNgayBLL
    {
        DSXuatTheoNgayDAL DS = new DSXuatTheoNgayDAL();
        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }
        public DataTable DSXuatTheoNgay()
        {
            return DS.DSXuatTheoNgay();
        }

        public DataTable Search(DateTime Date)
        {
            return DS.Search(Date);
        }
    }
}
