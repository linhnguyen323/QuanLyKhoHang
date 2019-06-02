using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmDSNhapTheoThang : Form
    {
        DSNhapTheoThangBLL DS = new DSNhapTheoThangBLL();
        DBconnection DBcon = new DBconnection();
        public frmDSNhapTheoThang()
        {
            InitializeComponent();
        }

        private void frmDSNhapTheoThang_Load(object sender, EventArgs e)
        {
            if (DS.KiemTraKetNoi())
            {
                cbbNam.DataSource = DS.ShowCombobox("select distinct YEAR(NgayNhap) as Nam from PhieuNhap");

                cbbNam.DisplayMember = "Nam";
                cbbNam.ValueMember = "Nam";
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbNam.Text != "")
                {
                    int Nam = Convert.ToInt32(cbbNam.Text);
                    if (DS.KiemTraKetNoi())
                    {
                        dgvDS.DataSource = DS.DSNhapTheoThang(Nam);
                    }
                    else MessageBox.Show("Lỗi kết nối ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập năm để tìm kiếm");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
