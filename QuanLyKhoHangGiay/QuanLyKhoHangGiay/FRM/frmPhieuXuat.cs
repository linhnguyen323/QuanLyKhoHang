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

using DTO;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmPhieuXuat : Form
    {
        PhieuXuatBLL pxBLL = new PhieuXuatBLL();
        PhieuXuatDTO phieuXuatDTO = new PhieuXuatDTO();
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet_PhieuXuat.PhieuXuat' table. You can move, or remove it, as needed.
            //this.phieuXuatTableAdapter.Fill(this.qLKhoDataSet_PhieuXuat.PhieuXuat);

        }

        private void btnDSPX_Click(object sender, EventArgs e)
        {
            if (pxBLL.KiemTraKetNoi())
            {
                dgvPX.DataSource = pxBLL.getAllPX();
            }
            else MessageBox.Show("Lỗi kết nối.","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtMaPX.Text != "" && dtNgayXuat.IsEmpty != true)
                {
                    phieuXuatDTO.MaPX = Convert.ToInt32(txtMaPX.Text);
                    phieuXuatDTO.NgayXuat = Convert.ToDateTime(dtNgayXuat.Value);

                    if (!(pxBLL.CheckID(phieuXuatDTO.MaPX)))
                    {
                        int check = pxBLL.InsertPX(phieuXuatDTO);

                        if (check == 1)
                        {
                            dgvPX.DataSource = pxBLL.getAllPX();
                            dgvPX.Show();
                        }
                        else MessageBox.Show("Thêm không thành công");
                    }
                    else MessageBox.Show("Mã phiếu xuất " + phieuXuatDTO.MaPX + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPX.Text != "")
                {
                    phieuXuatDTO.MaPX = Convert.ToInt32(txtMaPX.Text);

                    if (pxBLL.CheckID(phieuXuatDTO.MaPX))
                    {
                        int check = pxBLL.DeletePX(phieuXuatDTO.MaPX);

                        if (check == 1)
                        {
                            dgvPX.DataSource = pxBLL.getAllPX();
                            dgvPX.Show();
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã phiếu xuất " + phieuXuatDTO.MaPX + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập mã phiếu xuất !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPX.Columns["ChiTiet"].Index && e.RowIndex >= 0)
            {
                frmChiTietPhieuXuat frmChiTiet = new frmChiTietPhieuXuat();
                frmChiTiet.ShowDialog();

            }
        }



        private void dgvPX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaPX.Text = dgvPX.Rows[dgvPX.CurrentRow.Index].Cells[0].Value.ToString();
            dtNgayXuat.Text = dgvPX.Rows[dgvPX.CurrentRow.Index].Cells[1].Value.ToString();

        }
    }
}
