using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
     public class DSXuatTheoNamBLL
    {
        DSXuatTheoNamDAL DS = new DSXuatTheoNamDAL();

        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }

        public DataTable DSXuatTheoNam()
        {
            return DS.DSXuatTheoNam();
        }

        public DataTable Search(int Nam)
        {
            return DS.Search(Nam);
        }
    }
}
