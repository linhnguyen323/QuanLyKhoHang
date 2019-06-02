using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        private int _MaPN;

        public int MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }

        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }
        private int _MaNCC;

        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }


        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private decimal _GiaNhap;

        public decimal GiaNhap
        {
            get { return _GiaNhap; }
            set { _GiaNhap = value; }
        }
    }
}
