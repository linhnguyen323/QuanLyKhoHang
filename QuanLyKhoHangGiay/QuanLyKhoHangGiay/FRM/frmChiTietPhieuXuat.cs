using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QuanLyKhoHangGiay.FRM
{
    public partial class frmChiTietPhieuXuat : Form
    {
        ChiTietPhieuXuatBLL chiTiet = new ChiTietPhieuXuatBLL();
        ChiTietPhieuXuatDTO chiTietPX = new ChiTietPhieuXuatDTO();

        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            if (chiTiet.KiemTraKetNoi())
            {
                //hiển thị danh sách chi tiết sản phẩm
                dgvCTPX.DataSource = chiTiet.getAllCTPX();

                //cbbMaPN.DataSource = chiTietPhieuNhap.ShowComboBox("DSPhieuNhap");
                //cbbMaPN.DisplayMember = "MaPN";
                //cbbMaPN.ValueMember = "MaPN";

                //hiển thị danh sách mã phiếu xuất
                cbbMaPX.DataSource = chiTiet.ShowComboBox("select * from PhieuXuat");
                cbbMaPX.DisplayMember = "MaPX";
                cbbMaPX.ValueMember = "MaPX";

                cbbMaPX.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbMaPX.AutoCompleteSource = AutoCompleteSource.ListItems;

                //Hiển thị danh sách tên sản phẩm
                cbbMaSP.DataSource = chiTiet.ShowComboBox("select * from SanPham");
                cbbMaSP.DisplayMember = "TenSP";
                cbbMaSP.ValueMember = "MaSP";

                cbbMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;
                //Hiển thị danh sách tên khách hàng
                cbbMaKH.DataSource = chiTiet.ShowComboBox("select * from KhachHang");
                cbbMaKH.DisplayMember = "TenKH";
                cbbMaKH.ValueMember = "MaKH";

                cbbMaKH.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbMaKH.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                


                    if (cbbMaPX.SelectedValue.ToString() != "" && cbbMaSP.SelectedValue.ToString() != "" && txtSoLuong.Text != "" && cbbMaKH.SelectedValue.ToString() != "" && txtGiamGia.Text != "")
                    {
                        chiTietPX.MaPX = Convert.ToInt32(cbbMaPX.SelectedValue.ToString());
                        chiTietPX.MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());

                        chiTietPX.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        chiTietPX.MaKH = Convert.ToInt32(cbbMaKH.SelectedValue.ToString());
                        chiTietPX.GiamGia = Convert.ToDecimal(txtGiamGia.Text);
                    if (chiTiet.KiemTraKetNoi())
                    {

                        if (chiTiet.CheckID(chiTietPX.MaPX))
                        {
                            int count = Convert.ToInt32(chiTiet.CheckItem(chiTietPX.MaSP));

                            if (Convert.ToInt32(txtSoLuong.Text) > count)
                            {
                                MessageBox.Show("Số lượng hàng cần xuất trong kho không đủ");
                                chiTietPX.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                            }
                            else
                            {
                                int check = chiTiet.InsertCTPX(chiTietPX);

                                if (check == 1)
                                {
                                    dgvCTPX.DataSource = chiTiet.getAllCTPX();
                                    MessageBox.Show("Thêm chi tiết phiếu xuất thành công !");
                                    dgvCTPX.Show();
                                }
                                else MessageBox.Show("Thêm không thành công");
                            }

                        }
                        else MessageBox.Show("Mã phiếu nhập " + chiTietPX.MaPX + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Các trường không được để trống !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

                try
                {
                
                    if (cbbMaPX.SelectedValue.ToString() != "" && cbbMaSP.SelectedValue.ToString() != "" && cbbMaKH.SelectedValue.ToString() != "" && txtSoLuong.Text != "" && txtGiamGia.Text != "")
                    {

                        chiTietPX.MaPX = Convert.ToInt32(cbbMaPX.SelectedValue.ToString());
                        chiTietPX.MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                        chiTietPX.MaKH = Convert.ToInt32(cbbMaKH.SelectedValue.ToString());
                        chiTietPX.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        chiTietPX.GiamGia = Convert.ToDecimal(txtGiamGia.Text);

                    if (chiTiet.KiemTraKetNoi())
                    {
                        if (chiTiet.CheckID(chiTietPX.MaPX))
                        {
                            int count = Convert.ToInt32(chiTiet.CheckItem(chiTietPX.MaSP));

                            if (Convert.ToInt32(txtSoLuong.Text) > count)
                            {
                                MessageBox.Show("Số lượng hàng cần xuất trong kho không đủ");
                                chiTietPX.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                            }
                            else
                            {
                                int check = chiTiet.UpdateCTPX(chiTietPX);

                                if (check == 1)
                                {
                                    dgvCTPX.DataSource = chiTiet.getAllCTPX();
                                    MessageBox.Show("Đã sửa thông tin chi tiết phiếu nhập có mã " + chiTietPX.MaPX);
                                    dgvCTPX.Show();
                                }
                                else MessageBox.Show("Sửa không thành công");
                            }

                        }
                        else MessageBox.Show("Mã phiếu nhập " + chiTietPX.MaPX + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                
                
                    if (cbbMaPX.Text != "")
                    {
                        chiTietPX.MaPX = Convert.ToInt32(cbbMaPX.SelectedValue.ToString());
                        chiTietPX.MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                        chiTietPX.MaKH = Convert.ToInt32(cbbMaKH.SelectedValue.ToString());
                        chiTietPX.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        chiTietPX.GiamGia = Convert.ToDecimal(txtGiamGia.Text);

                    if (chiTiet.KiemTraKetNoi())
                    {
                        if (chiTiet.CheckID(chiTietPX.MaPX))
                        {
                            int check = chiTiet.DeleteCTPX(chiTietPX.MaPX);

                            if (check == 1)
                            {
                                dgvCTPX.DataSource = chiTiet.getAllCTPX();
                                MessageBox.Show("Đã xóa thông tin chi tiết phiếu xuất có mã " + chiTietPX.MaPX);
                                dgvCTPX.Show();
                            }
                            else MessageBox.Show("Xóa không thành công");
                        }
                        else MessageBox.Show("Mã phiếu xuất " + chiTietPX.MaPX + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Vui lòng nhập mã phiếu xuất để xóa !");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (chiTiet.KiemTraKetNoi())
                {
                    if (cbbMaPX.Text != "")
                    {
                        int MaPX = Convert.ToInt32(cbbMaPX.SelectedValue.ToString());
                        dgvCTPX.DataSource = chiTiet.SearchCTPX_MaPX(MaPX);
                    }
                    else if (cbbMaSP.Text != "")
                    {
                        int MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                        dgvCTPX.DataSource = chiTiet.SearchCTPX_MaSP(MaSP);
                    }
                    else if (cbbMaKH.Text != "")
                    {
                        int MaKH = Convert.ToInt32(cbbMaKH.SelectedValue.ToString());
                        dgvCTPX.DataSource = chiTiet.SearchCTPX_MaSP(MaKH);
                    }
                }
                else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCTPX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbbMaPX.Text = dgvCTPX.Rows[dgvCTPX.CurrentRow.Index].Cells[0].Value.ToString();
            cbbMaSP.Text = dgvCTPX.Rows[dgvCTPX.CurrentRow.Index].Cells[1].Value.ToString();
            cbbMaKH.Text = dgvCTPX.Rows[dgvCTPX.CurrentRow.Index].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvCTPX.Rows[dgvCTPX.CurrentRow.Index].Cells[2].Value.ToString();
            txtGiamGia.Text = dgvCTPX.Rows[dgvCTPX.CurrentRow.Index].Cells[3].Value.ToString();
        }
    }
}
