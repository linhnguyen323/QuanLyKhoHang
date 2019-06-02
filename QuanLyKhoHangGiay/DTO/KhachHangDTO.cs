using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }


        private int _HienThi;

        public int HienThi
        {
            get { return _HienThi; }
            set { _HienThi = value; }
        }

        public KhachHangDTO()
        {

        }

        public KhachHangDTO(int MaKH, string HoTen, string DiaChi, string SDT)
        {
            this._MaKH = MaKH;
            this._HoTen = HoTen;
            this._DiaChi = DiaChi;
            this._HienThi = HienThi;
        }
    }
}
