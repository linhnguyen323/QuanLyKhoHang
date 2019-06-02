using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuXuatDTO
    {
        private int _MaPX;

        public int MaPX
        {
            get { return _MaPX; }
            set { _MaPX = value; }
        }

        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private decimal _GiamGia;

        public decimal GiamGia
        {
            get { return _GiamGia; }
            set { _GiamGia = value; }
        }


    }
}
