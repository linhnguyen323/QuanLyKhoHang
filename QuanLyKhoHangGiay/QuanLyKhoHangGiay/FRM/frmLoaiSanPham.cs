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
    public partial class frmLoaiSanPham : Form
    {
        LoaiSanPhamBLL lspBLL = new LoaiSanPhamBLL();
        LoaiSanPhamDTO lspDTO = new LoaiSanPhamDTO();


        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet_LoaiSP.LoaiSP' table. You can move, or remove it, as needed.
            //this.loaiSPTableAdapter.Fill(this.qLKhoDataSet_LoaiSP.LoaiSP);

        }

        private void btnDSLSP_Click(object sender, EventArgs e)
        {
            if (lspBLL.KiemTraKetNoi())
            {
                dgvDSLSP.DataSource = lspBLL.getAllLSP();
            }
            else MessageBox.Show("Lỗi kết nối","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoaiSanPham.Text != "" && txtTenLoai.Text != "")
                {
                    lspDTO.MaLoai = Convert.ToInt32(txtLoaiSanPham.Text);
                    lspDTO.TenLoai = txtTenLoai.Text;

                    if (!(lspBLL.CheckID(lspDTO.MaLoai)))
                    {
                        int check = lspBLL.InsertLSP(lspDTO);

                        if (check == 1)
                        {
                            dgvDSLSP.DataSource = lspBLL.getAllLSP();
                            dgvDSLSP.Show();
                        }
                        else MessageBox.Show("Thêm không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + lspDTO.MaLoai + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (txtLoaiSanPham.Text != "" && txtTenLoai.Text != "")
                {
                    lspDTO.MaLoai = Convert.ToInt32(txtLoaiSanPham.Text);
                    lspDTO.TenLoai = txtTenLoai.Text;

                    if (lspBLL.CheckID(lspDTO.MaLoai))
                    {
                        int check = lspBLL.UpdateLSP(lspDTO);

                        if (check == 1)
                        {
                            dgvDSLSP.DataSource = lspBLL.getAllLSP();
                            MessageBox.Show("Đã sửa thông tin loại sản phẩm có mã " + lspDTO.MaLoai);
                            dgvDSLSP.Show();
                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã loại sản phẩm " + lspDTO.MaLoai + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtLoaiSanPham.Text != "" )
                {
                    lspDTO.MaLoai = Convert.ToInt32(txtLoaiSanPham.Text);

                    if (lspBLL.CheckID(lspDTO.MaLoai))
                    {
                        int check = lspBLL.DeleteLSP(lspDTO.MaLoai);

                        if (check == 1)
                        {
                            dgvDSLSP.DataSource = lspBLL.getAllLSP();
                            MessageBox.Show("Đã xóa thông tin loại sản phẩm có mã " + lspDTO.MaLoai);
                            dgvDSLSP.Show();
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã loại sản phẩm " + lspDTO.MaLoai + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập mã loại sản phẩm !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.FormBorderStyle = FormBorderStyle.Sizable;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtLoaiSanPham.Text != "")
                {
                    dgvDSLSP.DataSource = lspBLL.SearchLSP1(lspDTO);
                }
                else if(txtTenLoai.Text != "")
                {
                    dgvDSLSP.DataSource = lspBLL.SearchLSP2(lspDTO);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message.ToString(), "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSLSP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLoaiSanPham.Text = dgvDSLSP.Rows[dgvDSLSP.CurrentRow.Index].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvDSLSP.Rows[dgvDSLSP.CurrentRow.Index].Cells[1].Value.ToString();

        }
    }
}
