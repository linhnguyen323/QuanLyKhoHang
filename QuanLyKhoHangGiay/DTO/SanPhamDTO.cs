using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TenSP;

        public string Ten
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        private int _MaLoai;

        public int MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        private int _MaNCC;

        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        private int _MaKichCo;

        public int MaKichCo
        {
            get { return _MaKichCo; }
            set { _MaKichCo = value; }
        }

        private string _GioiTinh;

        public string GioiTinh
        { 
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        private decimal _DonGia;

        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

    }
}
