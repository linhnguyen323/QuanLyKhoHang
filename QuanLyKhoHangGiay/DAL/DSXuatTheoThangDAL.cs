using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSXuatTheoThangDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }
        public DataTable DSXuatTheoThang(int Nam)
        {
            string Query = "select Month(px.NgayXuat) as Thang, DemHD.SL as SoHD, Sum(ct.SoLuong) as TongHang, SUM(ct.SoLuong*sp.DonGia - ct.SoLuong*sp.DonGia*ct.GiamGia) as TongGT " +
                "from CTPhieuXuat as ct, PhieuXuat as px, SanPham as sp, " +
                "(select NgayXuat, COUNT(PhieuXuat.MaPX) as SL from PhieuXuat " +
                "group by NgayXuat ) as DemHD " +
                "where px.MaPX = ct.MaPX and sp.MaSP = ct.MaSP and px.NgayXuat = DemHD.NgayXuat and year(px.NgayXuat) = " + Nam +
                " group by Month(px.NgayXuat), DemHD.SL ";
            return DBcon.GetTable(Query);
        }

        public DataTable ShowCombobox(string Query)
        {
            return DBcon.GetTable(Query);
        }
    }
}
