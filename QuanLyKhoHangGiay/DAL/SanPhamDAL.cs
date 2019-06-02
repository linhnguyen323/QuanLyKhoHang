using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SanPhamDAL:DBconnection
    {
        DBconnection DBcon = new DBconnection();
        SanPhamDTO SanPham = new SanPhamDTO();

        public bool KiemTraKetNoi()
        {
            if (DBcon.isConnection())
                return true;
            return false;
        }

        public DataTable getAllSP()
        {
            return DBcon.GetTable("select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC," +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia , sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo");
        }

        public DataTable getTonKho()
        {
            return DBcon.GetTable("select TenSP, Nhap, Xuat, (Nhap - Xuat) as TonKho from ThongKeTonKho ");
        }

        public DataTable ShowComboBox(string query)
        {
           return DBcon.GetTable(query);
        }

        //check ID
        public bool CheckID(int MaSP)
        {
            string Query = "select * from SanPham where MaSP ='" + MaSP + "'";
            DataTable dt = new DataTable();
            dt = DBcon.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        //Thêm SẢN PHẨM
        public int InsertSP(SanPhamDTO sanPham)
        {
            int result = 0;
            string Query = "Insert into SanPham values (" + sanPham.MaSP + ",N'" + sanPham.Ten + "'," + sanPham.MaLoai + "," + sanPham.MaNCC + "," + sanPham.MaKichCo + ",N'" + sanPham.GioiTinh + "',N'" + sanPham.GhiChu + "'," + sanPham.DonGia + ")";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //sửa  sản phẩm
        public int UpdateSP(SanPhamDTO sanPham)
        {
            int result = 0;
            string Query = "Update SanPham set TenSP = N'" + sanPham.Ten + "', MaLoai = '" + sanPham.MaLoai + "', MaNCC = '" + sanPham.MaNCC + "', GioiTinh = N'" + sanPham.GioiTinh + "', GhiChu = N'" + sanPham.GhiChu + "', MaKichCo = '" + sanPham.MaKichCo + "', DonGia = '" + sanPham.DonGia + "' where MaSP = '" + sanPham.MaSP + "'";
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //xóa sản phẩm
        public int DeleteSP(SanPhamDTO sanPham)
        {
            int result = 0;
            string Query = "Delete from SanPham where MaSP = " + sanPham.MaSP;
            try
            {
                result = DBcon.ExecuteSPNoneQuery(Query);
            }
            catch (SqlException ex)
            {

            }
            return result;
        }

        //Tìm kiếm sản phẩm
        public DataTable SearchSP1(SanPhamDTO sp)
        {
            string Query = "select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC, " +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia, sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo and sp.MaSP like '%" + sp.MaSP + "%'";
            return DBcon.GetTable(Query);
        }

        public DataTable SearchSP2(SanPhamDTO sp)
        {
            return DBcon.GetTable("select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC, " +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia, sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo and sp.TenSP like '%"+sp.Ten+"%'");
        }


        public DataTable SearchSP3(SanPhamDTO sp)
        {
            return DBcon.GetTable("select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC, " +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia, sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo and sp.MaLoai like '%"+sp.MaLoai+"%'");
        }

        public DataTable SearchSP4(SanPhamDTO sp)
        {
            return DBcon.GetTable("select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC, " +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia, sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo and sp.MaNCC like '%"+sp.MaNCC+"%'");
        }

        public DataTable SearchSP5(SanPhamDTO sp)
        {
            return DBcon.GetTable("select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC, " +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia, sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo and sp.MaKichCo like '%"+sp.MaKichCo+"%'");
        }

        public DataTable SearchSP6(SanPhamDTO sp)
        {
            return DBcon.GetTable("select sp.MaSP, sp.TenSP, lsp.TenLoai, ncc.TenNCC, " +
                                   " sp.GioiTinh, kc.KichCo, sp.DonGia, sp.GhiChu from SanPham as sp," +
                                   " LoaiSP as lsp, NhaCungCap as ncc, KichCo as kc " +
                                   "where sp.MaLoai = lsp.MaLoai and sp.MaNCC = ncc.MaNCC and sp.MaKichCo = kc.MaKichCo and sp.GioiTinh like N'%"+sp.GioiTinh+"%'");
        }



        //tìm kiếm sản phẩm tồn kho theo mã loại
        public DataTable SearchTK_MaLoai(int MaLoai)
        {
            string Query = "select TenSP, Nhap, Xuat  , (Nhap - Xuat) as TonKho from ThongKeTonKho where MaLoai like  '%"+MaLoai +"%'";
            return DBcon.GetTable(Query);
        }
        //tìm kiếm sản phẩm tồn kho theo mã sản phẩm
        public DataTable SearchTK_MaSP(int MaSP)
        {

            //string Query = "select tk.TenSP, tk.Nhap, tk.Xuat , (tk.Nhap - tk.Xuat) as Ton" +
            //                "from ThongKeTonKho as tk where tk.MaSP = " + MaSP;
            return DBcon.GetTable("select TenSP, Nhap, Xuat , (Nhap - Xuat) as TonKho from ThongKeTonKho  where MaSP like '%" + MaSP+"%'");
        }

        //tìm kiếm sản phẩm tồn kho theo mã sp, mã loại
        public DataTable SearchTK(int MaSP, int MaLoai)
        {
            string Query = "select TenSP, Nhap, Xuat , (Nhap - Xuat) as TonKho from ThongKeTonKho  where MaSP like '%" + MaSP+"%' and MaLoai like '%"+MaLoai+"%'";
            return DBcon.GetTable(Query);
        }
    }
}
