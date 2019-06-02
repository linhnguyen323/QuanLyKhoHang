using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DSNhapTheoThangBLL
    {
        DSNhapTheoThangDAL DS = new DSNhapTheoThangDAL();

        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }

        public DataTable ShowCombobox(string Query)
        {
            return DS.ShowCombobox(Query);
        }
        public DataTable DSNhapTheoThang(int Nam)
        {
            return DS.DSNhapTheoThang(Nam);
        }
    }
}
