using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DSXuatTheoThangBLL
    {
        DSXuatTheoThangDAL DS = new DSXuatTheoThangDAL();
        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }
        public DataTable DSXuatTheoThang(int Nam)
        {
            return DS.DSXuatTheoThang(Nam);
        }
        public DataTable ShowCombobox(string Query)
        {
            return DS.ShowCombobox(Query);
        }
    }
}
