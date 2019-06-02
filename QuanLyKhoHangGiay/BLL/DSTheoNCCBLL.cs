using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DSTheoNCCBLL
    {
        DSNhapTheoNCCDAL DS = new DSNhapTheoNCCDAL();

        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }

        public DataTable DSTheoNCC()
        {
            return DS.DSTheoNCC();
        }
        public DataTable ShowCombobox(string Query)
        {
            return DS.ShowCombobox(Query);
        }

        public DataTable Search(string NCC)
        {
            return DS.Search(NCC);
        }
    }
}
