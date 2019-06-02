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
    public partial class frmDSXuatTheoKH : Form
    {
        DSXuatTheoKHBLL DS = new DSXuatTheoKHBLL();
        public frmDSXuatTheoKH()
        {
            InitializeComponent();
        }

        private void frmDSXuatTheoKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_DSXTheoKH.DSXuatTheoKH' table. You can move, or remove it, as needed.
            if (DS.KiemTraKetNoi())
            {
                this.dSXuatTheoKHTableAdapter1.Fill(this.quanLyKhoDataSet_DSXTheoKH.DSXuatTheoKH);

            // TODO: This line of code loads data into the 'quanLyKhoDataSet_DSXuatTheoKH.DSXuatTheoKH' table. You can move, or remove it, as needed.
            //this.dSXuatTheoKHTableAdapter.Fill(this.quanLyKhoDataSet_DSXuatTheoKH.DSXuatTheoKH);


            //
                cbbTimKiem.DataSource = DS.ShowCombobox("select * from KhachHang");

                cbbTimKiem.DisplayMember = "TenKH";
                cbbTimKiem.ValueMember = "MaKH";
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string khachhang = cbbTimKiem.Text;
                if (khachhang != null)
                {
                    if (DS.KiemTraKetNoi())
                    {
                        dgvDS.DataSource = DS.Search(khachhang);
                        dgvDS.Show();
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error !" + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
