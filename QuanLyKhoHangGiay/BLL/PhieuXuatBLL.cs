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
    public class PhieuXuatBLL
    {
        PhieuXuatDAL pxDAL = new PhieuXuatDAL();

        public bool KiemTraKetNoi()
        {
            return pxDAL.KiemTraKetNoi();
        }

        public DataTable getAllPX()
        {
            return pxDAL.getAllPX();
        }
        public bool CheckID(int MaPX)
        {
            return pxDAL.CheckID(MaPX);
        }
        public int InsertPX(PhieuXuatDTO phieuXuatDTO)
        {
            return pxDAL.InsertPX(phieuXuatDTO);
        }
        public int UpdatePX(PhieuXuatDTO phieuXuatDTO)
        {
            return pxDAL.UpdatePX(phieuXuatDTO);
        }
        public int DeletePX(int MaPX)
        {
            return pxDAL.DeletePX(MaPX);
        }
    }
}
