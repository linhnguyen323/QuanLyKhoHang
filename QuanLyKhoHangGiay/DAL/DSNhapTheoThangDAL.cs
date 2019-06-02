using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSNhapTheoThangDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();


        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable DSNhapTheoThang(int Nam)
        {
            string Query = "select MONTH(pn.NgayNhap) as Thang, DemHD.SL as SoHD, sum(ct.SoLuong) as TongHang, sum(ct.SoLuong*ct.GiaNhap) as TongGT " +
                "from CTPhieuNhap as ct, PhieuNhap as pn, " +
                "(select NgayNhap, COUNT(PhieuNhap.MaPN) as SL from PhieuNhap group by NgayNhap) as DemHD " +
                "where ct.MaPN = pn.MaPN and YEAR(pn.NgayNhap) = " + Nam + " and pn.NgayNhap = DemHD.NgayNhap " +
                "group by MONTH(pn.NgayNhap), DemHD.SL";

            return DBcon.GetTable(Query);
        }

        public DataTable ShowCombobox(string Query)
        {
            return DBcon.GetTable(Query);
        }


    }
}
