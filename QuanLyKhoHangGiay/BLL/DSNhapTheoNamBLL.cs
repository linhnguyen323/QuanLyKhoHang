using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    
    public class DSNhapTheoNamBLL
    {
        DSNhapTheoNamDAL DS = new DSNhapTheoNamDAL();

        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }

        public DataTable DSNhapTheoNam()
        {
            return DS.DSNhapTheoNam();
        }

        public DataTable Search(int Nam)
        {
            return DS.Search(Nam);
        }
    }
}
