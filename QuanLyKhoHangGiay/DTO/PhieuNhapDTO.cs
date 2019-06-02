using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private int _MaPN;

        public int MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }

        private DateTime _NgayNhap;

        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }

        private int _HienThi;

        public int HienThi
        {
            get { return _HienThi; }
            set { _HienThi = value; }
        }

    }
}
