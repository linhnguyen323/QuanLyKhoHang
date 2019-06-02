using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatDTO
    {
        private int _MaPX;

        public int MaPX
        {
            get { return _MaPX; }
            set { _MaPX = value; }
        }

        private DateTime _NgayXuat;

        public DateTime NgayXuat
        {
            get { return _NgayXuat; }
            set { _NgayXuat = value; }
        }

        private int _HienThi;

        public int HienThi
        {
            get { return _HienThi; }
            set { _HienThi = value; }
        }


    }
}
