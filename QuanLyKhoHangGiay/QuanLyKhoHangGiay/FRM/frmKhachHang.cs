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
    public partial class frmKhachHang : Form
    {

        KhachHangBLL khBLL = new KhachHangBLL();
        //KhachHangDAL KhachHang = new KhachHangDAL();
        KhachHangDTO khachHangDTO = new KhachHangDTO();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet_KhachHang.KhachHang' table. You can move, or remove it, as needed.
           // this.khachHangTableAdapter.Fill(this.qLKhoDataSet_KhachHang.KhachHang);

        }

        private void btnDSKH_Click(object sender, EventArgs e)
        {
            if (khBLL.KiemTraKetNoi())
            {
                dgvKH.DataSource = khBLL.getAllKH();
            }
            else MessageBox.Show("Lỗi kết nối !","Thong báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != "" && txtSDT.Text !="")
                {
                    khachHangDTO.MaKH = Convert.ToInt32(txtMaKH.Text);
                    khachHangDTO.HoTen = txtHoTen.Text;
                    khachHangDTO.DiaChi = txtDiaChi.Text;
                    khachHangDTO.SDT = txtSDT.Text;

                    if (!(khBLL.CheckID(khachHangDTO.MaKH)))
                    {
                        int check = khBLL.InsertKH(khachHangDTO);

                        if (check == 1)
                        {
                            dgvKH.DataSource = khBLL.getAllKH();
                            dgvKH.Show();
                        }
                        else MessageBox.Show("Thêm không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + khachHangDTO.MaKH + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
                {
                    khachHangDTO.MaKH = Convert.ToInt32(txtMaKH.Text);
                    khachHangDTO.HoTen = txtHoTen.Text;
                    khachHangDTO.DiaChi = txtDiaChi.Text;
                    khachHangDTO.SDT = txtSDT.Text;
                    if (khBLL.CheckID(khachHangDTO.MaKH))
                    {
                        int check = khBLL.UpdateKH(khachHangDTO);

                        if (check == 1)
                        {
                            dgvKH.DataSource = khBLL.getAllKH();
                            MessageBox.Show("Đã sửa thông tin khách hàng có mã " + khachHangDTO.MaKH);
                            dgvKH.Show();
                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + khachHangDTO.MaKH + " không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtMaKH.Text != "")
                {
                    khachHangDTO.MaKH = Convert.ToInt32(txtMaKH.Text);

                    if (khBLL.CheckID(khachHangDTO.MaKH))
                    {
                        int check = khBLL.DeleteKH(khachHangDTO.MaKH);

                        if (check == 1)
                        {
                            dgvKH.DataSource = khBLL.getAllKH();
                            MessageBox.Show("Đã xóa thông tin khách hàng có mã " + khachHangDTO.MaKH);
                            dgvKH.Show();
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + khachHangDTO.MaKH + " không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập mã khách hàng !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text != "")
                {
                    dgvKH.DataSource = khBLL.SearchKH1(khachHangDTO);
                }
                else if (txtHoTen.Text != "")
                {
                    dgvKH.DataSource = khBLL.SearchKH2(khachHangDTO);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message.ToString(), "THông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaKH.Text = dgvKH.Rows[dgvKH.CurrentRow.Index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKH.Rows[dgvKH.CurrentRow.Index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[dgvKH.CurrentRow.Index].Cells[2].Value.ToString();
            txtSDT.Text = dgvKH.Rows[dgvKH.CurrentRow.Index].Cells[3].Value.ToString();
        }
    }
}
