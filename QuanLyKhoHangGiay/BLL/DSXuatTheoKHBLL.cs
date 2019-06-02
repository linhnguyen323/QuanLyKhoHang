using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DSXuatTheoKHBLL
    {
        DSXuatTheoKHDAL DS = new DSXuatTheoKHDAL();

        public bool KiemTraKetNoi()
        {
            return DS.KiemTraKetNoi();
        }

        public DataTable DSXuatTheoKH()
        {
            return DS.DSXuatTheoKH();
        }

        public DataTable ShowCombobox(string Query)
        {
            return DS.ShowCombobox(Query);

        }

        public DataTable Search(string khachhang)
        {
            return DS.Search(khachhang);
        }
    }
}
