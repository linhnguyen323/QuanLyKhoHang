using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL nccDAL = new NhaCungCapDAL();
        NhaCungCapDTO ncc = new NhaCungCapDTO();

        public bool KiemTraKetNoi()
        {
            return nccDAL.KiemTraKetNoi();
        }
        public DataTable getAllNCC()
        {
            return nccDAL.getAllNCC();
        }

        public bool CheckID(int MaNCC)
        {
            return nccDAL.CheckID(MaNCC);
        }

        public int InsertNCC(NhaCungCapDTO nhaCungCap)
        {
            return nccDAL.InsertNCC(nhaCungCap);
        }

        public int DeleteNCC(NhaCungCapDTO nhaCungCap)
        {
            return nccDAL.DeleteNCC(nhaCungCap);
        }

        public DataTable SearchNCC1(NhaCungCapDTO ncc)
        {
            return nccDAL.SearchNCC1(ncc);
        }

        public DataTable SearchNCC2(NhaCungCapDTO ncc)
        {
            return nccDAL.SearchNCC2(ncc);
        }
    }
}
