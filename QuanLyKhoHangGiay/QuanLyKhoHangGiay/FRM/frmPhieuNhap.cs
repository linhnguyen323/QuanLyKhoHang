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
using DTO;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmPhieuNhap : Form
    {
        PhieuNhapBLL pnBLL = new PhieuNhapBLL();
        PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet_PhieuNhap.PhieuNhap' table. You can move, or remove it, as needed.
            //this.phieuNhapTableAdapter.Fill(this.qLKhoDataSet_PhieuNhap.PhieuNhap);

        }

        private void btnCTPN_Click(object sender, EventArgs e)
        {
            if (pnBLL.KiemTraKetNoi())
            {
                dgvPN.DataSource = pnBLL.getAllPN();
            }
            else MessageBox.Show("Lỗi kết nối.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPN.Text != "" && dtNgayNhap.IsEmpty != true)
                {
                    phieuNhapDTO.MaPN = Convert.ToInt32(txtMaPN.Text);
                    phieuNhapDTO.NgayNhap = Convert.ToDateTime(dtNgayNhap.Value);

                    if (!(pnBLL.CheckID(phieuNhapDTO.MaPN)))
                    {
                        int check = pnBLL.InsertPN(phieuNhapDTO);

                        if (check == 1)
                        {
                            dgvPN.DataSource = pnBLL.getAllPN();
                            dgvPN.Show();
                        }
                        else MessageBox.Show("Thêm không thành công");
                    }
                    else MessageBox.Show("Mã phiếu nhập " + phieuNhapDTO.MaPN + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPN.Columns["ChiTiet"].Index && e.RowIndex >= 0 )
            {
                frmChiTietPhieuNhap frmCT = new frmChiTietPhieuNhap();

                frmCT.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtMaPN.Text != "" && dtNgayNhap.IsEmpty != true)
                {
                    phieuNhapDTO.MaPN = Convert.ToInt32(txtMaPN.Text);
                    phieuNhapDTO.NgayNhap = Convert.ToDateTime(dtNgayNhap.Value);

                    if (pnBLL.CheckID(phieuNhapDTO.MaPN))
                    {
                        int check = pnBLL.UpdatePN(phieuNhapDTO);

                        if (check == 1)
                        {
                            dgvPN.DataSource = pnBLL.getAllPN();
                            MessageBox.Show("Đã sửa ngày nhập có mã " + phieuNhapDTO.MaPN);
                            dgvPN.Show();
                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã phiếu nhập " + phieuNhapDTO.MaPN + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaPN.Text != "")
                {
                    phieuNhapDTO.MaPN = Convert.ToInt32(txtMaPN.Text);

                    if (pnBLL.CheckID(phieuNhapDTO.MaPN))
                    {
                        int check = pnBLL.DeletePN(phieuNhapDTO.MaPN);

                        if (check == 1)
                        {
                            dgvPN.DataSource = pnBLL.getAllPN();
                            MessageBox.Show("Đã xóa ngày nhập có mã " + phieuNhapDTO.MaPN);
                            dgvPN.Show();
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã phiếu nhập " + phieuNhapDTO.MaPN + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập mã phiếu nhập !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPN_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaPN.Text = dgvPN.Rows[dgvPN.CurrentRow.Index].Cells[0].Value.ToString();
            dtNgayNhap.Text = dgvPN.Rows[dgvPN.CurrentRow.Index].Cells[1].Value.ToString();

        }
    }
}
