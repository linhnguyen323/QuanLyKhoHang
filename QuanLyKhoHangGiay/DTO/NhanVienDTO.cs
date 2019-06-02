using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private String _HoTen;

        public String HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        private DateTime _NamSinh;

        public DateTime NamSinh
        {
            get { return _NamSinh; }
            set { _NamSinh = value; }
        }
        

        private string _QueQuan;

        public string QueQuan
        {
            get { return _QueQuan; }
            set { _QueQuan = value; }
        }
        private string _TenDangNhap;

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }

        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }


        private int _MaLoaiNguoiDung;

        public int MaLoaiNguoiDung
        {
            get { return _MaLoaiNguoiDung; }
            set { _MaLoaiNguoiDung = value; }
        }




        public NhanVienDTO()
        {

        }

        public NhanVienDTO(int MaNV, string HoTen, DateTime NamSinh, String QueQuan, string SDT, string TenDangNhap, string MatKhau, int MaLoaiNguoiDung)
        {
            this._MaNV = MaNV;
            this._HoTen = HoTen;
            this._NamSinh = NamSinh;
            this._QueQuan = QueQuan;
            this._SDT = SDT;
            this._TenDangNhap = TenDangNhap;
            this._MatKhau = MatKhau;
            this._MaLoaiNguoiDung = MaLoaiNguoiDung;
        }
    }
}
