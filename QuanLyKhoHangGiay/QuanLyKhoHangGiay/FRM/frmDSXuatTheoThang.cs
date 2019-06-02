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
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmDSXuatTheoThang : Form
    {
        DSXuatTheoThangBLL DS = new DSXuatTheoThangBLL();
        public frmDSXuatTheoThang()
        {
            InitializeComponent();
        }

        private void frmDSXuatTheoThang_Load(object sender, EventArgs e)
        {
            if (DS.KiemTraKetNoi())
            {
                cbbNam.DataSource = DS.ShowCombobox("select distinct YEAR(NgayXuat) as Nam from PhieuXuat");

                cbbNam.DisplayMember = "Nam";
                cbbNam.ValueMember = "Nam";
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            try
            {
                int Nam = Convert.ToInt32(cbbNam.Text);
                if (Nam != 0)
                {
                    
                    if (DS.KiemTraKetNoi())
                    {
                        dgvDS.DataSource = DS.DSXuatTheoThang(Nam);
                        dgvDS.Show();
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập năm để tìm kiếm");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error ! " + ex.Message.ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
