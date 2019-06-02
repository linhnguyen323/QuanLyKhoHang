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
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pnDAL = new PhieuNhapDAL();
        public bool KiemTraKetNoi()
        {
            return pnDAL.KiemTraKetNoi();
        }

        public DataTable getAllPN()
        {
            return pnDAL.getAllPN();
        }
        public bool CheckID(int MaPN)
        {
            return pnDAL.CheckID(MaPN);
        }
        public int InsertPN(PhieuNhapDTO phieuNhapDTO)
        {
            return pnDAL.InsertPN(phieuNhapDTO);
        }
        public int UpdatePN(PhieuNhapDTO phieuNhapDTO)
        {
            return pnDAL.UpdatePN(phieuNhapDTO);
        }
        public int DeletePN(int MaPN)
        {
            return pnDAL.DeletePN(MaPN);
        }
    }
}
