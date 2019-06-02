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
    public partial class frmSanPham : Form
    {
        
        SanPhamBLL spBLL = new SanPhamBLL();
        SanPhamDTO sanPhamDTO = new SanPhamDTO();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet_SanPham.SanPham' table. You can move, or remove it, as needed.
            //this.sanPhamTableAdapter.Fill(this.qLKhoDataSet_SanPham.SanPham);

            //hiển thị danh sách loại sản phẩm
            cbbMaLoai.DataSource = spBLL.ShowComboBox("proDSLSP");
            
            cbbMaLoai.DisplayMember = "TenLoai";
            cbbMaLoai.ValueMember = "MaLoai";
            cbbMaLoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaLoai.AutoCompleteSource = AutoCompleteSource.ListItems;

            //hiểm thị danh sách nhà cung cấp
            cbbMaNCC.DataSource = spBLL.ShowComboBox("proDSNCC");
            
            cbbMaNCC.DisplayMember = "TenNCC";
            cbbMaNCC.ValueMember = "MaNCC";
            cbbMaNCC.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaNCC.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Hiển thị danh sách kích cỡ
            cbbKichCo.DataSource = spBLL.ShowComboBox("proDSKC");
              
            cbbKichCo.DisplayMember = "KichCo";
            cbbKichCo.ValueMember = "MaKichCo";

            cbbKichCo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbKichCo.AutoCompleteSource = AutoCompleteSource.ListItems;
            //dgvDSSP.DataSource = spBLL.getAllSP();

        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (txtMSP.Text != "" && txtTenSP.Text != "" && cbbMaLoai.SelectedValue.ToString() != "" && cbbMaNCC.SelectedValue.ToString() != "" && cbbKichCo.SelectedValue.ToString() != "" && cbbGioiTinh.Text != "" && txtDonGia.Text != "")
                {
                    sanPhamDTO.MaSP = Convert.ToInt32(txtMSP.Text);
                    sanPhamDTO.Ten = txtTenSP.Text;
                    sanPhamDTO.MaLoai = Convert.ToInt32(cbbMaLoai.SelectedValue.ToString());
                    sanPhamDTO.MaNCC = Convert.ToInt32(cbbMaNCC.SelectedValue.ToString());
                    sanPhamDTO.MaKichCo = Convert.ToInt32(cbbKichCo.SelectedValue.ToString());
                    sanPhamDTO.GioiTinh = cbbGioiTinh.Text;
                    sanPhamDTO.GhiChu = txtGhiChu.Text;
                    sanPhamDTO.DonGia = Convert.ToDecimal(txtDonGia.Text);

                    if (!(spBLL.CheckID(sanPhamDTO.MaSP)))
                    {
                        int check = spBLL.InsertSP(sanPhamDTO);

                        if (check == 1)
                        {
                            dgvDSSP.DataSource = spBLL.getAllSP();
                            dgvDSSP.Show();
                            MessageBox.Show("Đã thêm thành công sản phẩm có mã " + sanPhamDTO.MaSP);
                        }
                        else MessageBox.Show("Thêm không thành công");
                    }
                    else MessageBox.Show("Mã sản phẩm " + sanPhamDTO.MaSP + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (txtMSP.Text != "")
                {
                    sanPhamDTO.MaSP = Convert.ToInt32(txtMSP.Text);
                    sanPhamDTO.Ten = txtTenSP.Text;
                    sanPhamDTO.MaLoai = Convert.ToInt32(cbbMaLoai.SelectedValue.ToString());
                    sanPhamDTO.MaNCC = Convert.ToInt32(cbbMaNCC.SelectedValue.ToString());
                    sanPhamDTO.MaKichCo = Convert.ToInt32(cbbKichCo.SelectedValue.ToString());
                    sanPhamDTO.GioiTinh = cbbGioiTinh.Text;
                    sanPhamDTO.GhiChu = txtGhiChu.Text;
                    sanPhamDTO.DonGia = Convert.ToDecimal(txtDonGia.Text);

                    if (spBLL.CheckID(sanPhamDTO.MaSP))
                    {
                        int check = spBLL.UpdateSP(sanPhamDTO);

                        if (check == 1)
                        {
                            dgvDSSP.DataSource = spBLL.getAllSP();
                            MessageBox.Show("Đã sửa thông tin sản phẩm có mã " + sanPhamDTO.MaSP);
                            dgvDSSP.Show();
                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã sản phẩm " + sanPhamDTO.MaSP + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập mã sản phẩm !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDSSP_Click_1(object sender, EventArgs e)
        {
            if (spBLL.KiemTraKetNoi())
            {
                dgvDSSP.DataSource = spBLL.getAllSP();
            }
            else MessageBox.Show("Lỗi kết nối.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSP.Text != "")
                {
                    sanPhamDTO.MaSP = Convert.ToInt32(txtMSP.Text);
                    dgvDSSP.DataSource = spBLL.SearchSP1(sanPhamDTO);
                }
                else if (txtTenSP.Text != "")
                {
                    sanPhamDTO.Ten = txtTenSP.Text;
                    dgvDSSP.DataSource = spBLL.SearchSP2(sanPhamDTO);
                }
                else if (cbbMaLoai.SelectedValue.ToString() != "")
                {
                    sanPhamDTO.MaLoai = Convert.ToInt32(cbbMaLoai.SelectedValue.ToString());
                    dgvDSSP.DataSource = spBLL.SearchSP3(sanPhamDTO);
                }
                else if (cbbMaNCC.SelectedValue.ToString() != "")
                {
                    sanPhamDTO.MaNCC = Convert.ToInt32(cbbMaNCC.SelectedValue.ToString());
                    dgvDSSP.DataSource = spBLL.SearchSP4(sanPhamDTO);
                }
                else if (cbbKichCo.Text != "")
                {
                    sanPhamDTO.MaKichCo = Convert.ToInt32(cbbMaNCC.Text);
                    dgvDSSP.DataSource = spBLL.SearchSP5(sanPhamDTO);
                }
                else if (cbbGioiTinh.Text != "")
                {
                    sanPhamDTO.MaKichCo = Convert.ToInt32(cbbGioiTinh.Text);
                    dgvDSSP.DataSource = spBLL.SearchSP6(sanPhamDTO);
                }
                else MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }





        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtMSP.Text != "")
                {
                    sanPhamDTO.MaSP = Convert.ToInt32(txtMSP.Text);

                    if (spBLL.CheckID(sanPhamDTO.MaSP))
                    {
                        int check = spBLL.DeleteSP(sanPhamDTO);

                        if (check == 1)
                        {
                            dgvDSSP.DataSource = spBLL.getAllSP();
                            MessageBox.Show("Đã xóa thông tin sản phẩm có mã " + sanPhamDTO.MaSP);
                            dgvDSSP.Show();
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã sản phẩm " + sanPhamDTO.MaSP + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Vui lòng nhập mã sản phẩm !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSSP_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMSP.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[0].Value.ToString();
            txtTenSP.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[1].Value.ToString();
            cbbMaLoai.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[2].Value.ToString();
            cbbMaNCC.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[3].Value.ToString();
            cbbKichCo.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[5].Value.ToString();
            cbbGioiTinh.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[4].Value.ToString();
            txtGhiChu.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[7].Value.ToString();
            txtDonGia.Text = dgvDSSP.Rows[dgvDSSP.CurrentRow.Index].Cells[6].Value.ToString();
        }
    }
}
