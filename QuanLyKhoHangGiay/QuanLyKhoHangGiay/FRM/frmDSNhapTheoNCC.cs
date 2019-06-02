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
    public partial class frmDSNhapTheoNCC : Form
    {
        DSTheoNCCBLL DS = new DSTheoNCCBLL();
        public frmDSNhapTheoNCC()
        {
            InitializeComponent();
        }

        private void frmDSTheoNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_DSTheoNCC.DSTheoNCC' table. You can move, or remove it, as needed.
            if (DS.KiemTraKetNoi())
            {
                this.dSTheoNCCTableAdapter.Fill(this.quanLyKhoDataSet_DSTheoNCC.DSTheoNCC);


                cbbTimKiem.DataSource = DS.ShowCombobox("select * from NhaCungCap");
                cbbTimKiem.DisplayMember = "TenNCC";
                cbbTimKiem.ValueMember = "MaNCC";
            }
            else MessageBox.Show("Lỗi kết nối ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string NCC = cbbTimKiem.Text;
                if (NCC != null)
                {
                    if (DS.KiemTraKetNoi())
                    {
                        dgvDS.DataSource = DS.Search(NCC);
                        dgvDS.Show();
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error !" + ex.Message.ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
