using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private int _MaNCC;

        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
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

        public NhaCungCapDTO()
        {

        }

        public NhaCungCapDTO(int MaNCC, string HoTen, string DiaChi, string SDT, int HenThi)
        {
            this._MaNCC = MaNCC;
            this._HoTen = HoTen;
            this._DiaChi = DiaChi;
            this._SDT = SDT;
            this._HienThi = HienThi;
        }
    }
}
