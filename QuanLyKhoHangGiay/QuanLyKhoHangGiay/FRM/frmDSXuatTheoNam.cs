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
    public partial class frmDSXuatTheoNam : Form
    {
        DSXuatTheoNamBLL DS = new DSXuatTheoNamBLL();
        public frmDSXuatTheoNam()
        {
            InitializeComponent();
        }

        private void frmDSXuatTheoNam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_DSXuatTheoNam.DSXuatTheoNam' table. You can move, or remove it, as needed.
            if (DS.KiemTraKetNoi())
            {
                this.dSXuatTheoNamTableAdapter.Fill(this.quanLyKhoDataSet_DSXuatTheoNam.DSXuatTheoNam);
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int Nam = Convert.ToInt32(txtTimKiem.Text);
                if (Nam != 0)
                {
                    if (DS.KiemTraKetNoi())
                    {
                        dgvDS.DataSource = DS.Search(Nam);
                        dgvDS.Show();
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập năm để tìm kiếm ");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error !" + ex.Message.ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
