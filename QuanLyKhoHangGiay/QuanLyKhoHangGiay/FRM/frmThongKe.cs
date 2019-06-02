using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmThongKe : Form
    {
        DSNhapTheoNgayBLL BaoCao = new DSNhapTheoNgayBLL();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnTheoNgay_Click(object sender, EventArgs e)
        {
            frmDSNhapTheoNgay DS = new frmDSNhapTheoNgay();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoThang_Click(object sender, EventArgs e)
        {
            frmDSNhapTheoThang DS = new frmDSNhapTheoThang();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoNam_Click(object sender, EventArgs e)
        {
            frmDSNhapTheoNam DS = new frmDSNhapTheoNam();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoNCC_Click(object sender, EventArgs e)
        {
            frmDSNhapTheoNCC DS = new frmDSNhapTheoNCC();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoNgay1_Click(object sender, EventArgs e)
        {
            frmDSXuatTheoNgay DS = new frmDSXuatTheoNgay();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoThang1_Click(object sender, EventArgs e)
        {
            frmDSXuatTheoThang DS = new frmDSXuatTheoThang();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoNam1_Click(object sender, EventArgs e)
        {
            frmDSXuatTheoNam DS = new frmDSXuatTheoNam();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }

        private void btnTheoKH_Click(object sender, EventArgs e)
        {
            frmDSXuatTheoKH DS = new frmDSXuatTheoKH();
            tbControl.Show();
            tbControl.Controls.Clear();
            DS.TopLevel = false;
            DS.Dock = DockStyle.Fill;
            tbControl.Controls.Add(DS);
            DS.Show();
        }
    }
}
