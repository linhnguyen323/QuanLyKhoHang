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
    public partial class frmDSNhapTheoNgay : Form
    {
        DSNhapTheoNgayBLL DS = new DSNhapTheoNgayBLL();
        public frmDSNhapTheoNgay()
        {
            InitializeComponent();
        }

        private void frmDSNhapTheoNgay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_DSNhapTheoNgay.ThongKeDSNhapTheoNgay' table. You can move, or remove it, as needed.
            if (DS.KiemTraKetNoi())
            {
                this.thongKeDSNhapTheoNgayTableAdapter.Fill(this.quanLyKhoDataSet_DSNhapTheoNgay.ThongKeDSNhapTheoNgay);
            }
            else MessageBox.Show("Lỗi kết nối ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Date = dtTimKiem.Value;
                Date.ToShortDateString();
                if (Date != null)
                {
                    if (DS.KiemTraKetNoi())
                    {
                        dgvDS.DataSource = DS.Search(Date);
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập ngày để tìm kiếm");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error !" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
