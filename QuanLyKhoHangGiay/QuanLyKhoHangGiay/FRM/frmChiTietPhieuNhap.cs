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
    public partial class frmChiTietPhieuNhap : Form
    {

        ChiTietPhieuNhapBLL chiTietPhieuNhap = new ChiTietPhieuNhapBLL();
        ChiTietPhieuNhapDTO chiTietPN = new ChiTietPhieuNhapDTO();


        public frmChiTietPhieuNhap()
        {
            InitializeComponent();

        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_CTPN.CTPhieuNhap' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_CTPhieuNhap.CTPhieuNhap' table. You can move, or remove it, as needed.
            //this.cTPhieuNhapTableAdapter.Fill(this.quanLyKhoDataSet_CTPhieuNhap.CTPhieuNhap);

            //hiển thị danh sách chi tiết phiếu nhập
            if (chiTietPhieuNhap.KiemTraKetNoi())//kiểm tra kết nối
            {
                dgvCTPN.DataSource = chiTietPhieuNhap.getAllCTPN();


            ////Hiển thị danh sách mã phiếu nhập
            cbbMaPN.DataSource = chiTietPhieuNhap.ShowComboBox("DSPhieuNhap");
            cbbMaPN.DisplayMember = "MaPN";
            cbbMaPN.ValueMember = "MaPN";

            cbbMaPN.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaPN.AutoCompleteSource = AutoCompleteSource.ListItems;

            //hiển thị danh sách tên sản phẩm
            cbbMaSP.DataSource = chiTietPhieuNhap.ShowComboBox("proDSSP");
            cbbMaSP.DisplayMember = "TenSP";
            cbbMaSP.ValueMember = "MaSP";

            cbbMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;

            //HIỂN THỊ DANH SÁCH TÊN Nhà cung cấp
            cbbMaNCC.DataSource = chiTietPhieuNhap.ShowComboBox("proDSNCC");
            cbbMaNCC.DisplayMember = "TenNCC";
            cbbMaNCC.ValueMember = "MaNCC";

            cbbMaNCC.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaNCC.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else MessageBox.Show("Lỗi kết nối. Vui lòng thử lại !");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    
                    if (cbbMaPN.SelectedValue.ToString() != "" && cbbMaSP.SelectedValue.ToString() != "" && cbbMaNCC.SelectedValue.ToString() != "" && txtSoLuong.Text != "" && txtDonGia.Text != "")
                    {
                        chiTietPN.MaPN = Convert.ToInt32(cbbMaPN.SelectedValue.ToString());
                        chiTietPN.MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                        chiTietPN.MaNCC = Convert.ToInt32(cbbMaNCC.SelectedValue.ToString());
                        chiTietPN.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        chiTietPN.GiaNhap = Convert.ToDecimal(txtDonGia.Text);
                    if (chiTietPhieuNhap.KiemTraKetNoi())
                    {
                        if (chiTietPhieuNhap.CheckID(chiTietPN.MaPN))
                        {
                        
                            int check = chiTietPhieuNhap.InsertCTPN(chiTietPN);

                            if (check == 1)
                            {
                                dgvCTPN.DataSource = chiTietPhieuNhap.getAllCTPN();
                                MessageBox.Show("Thêm chi tiết phiếu nhập thành công !");
                                dgvCTPN.Show();
                            }
                            else MessageBox.Show("Thêm không thành công");
                        
                    }
                        else MessageBox.Show("Mã phiếu nhập " + chiTietPN.MaPN + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                
                    if (cbbMaPN.SelectedValue.ToString() != "" && cbbMaSP.SelectedValue.ToString() != "" && cbbMaNCC.SelectedValue.ToString() != "" && txtSoLuong.Text != "" && txtDonGia.Text != "")
                    {

                        chiTietPN.MaPN = Convert.ToInt32(cbbMaPN.SelectedValue.ToString());
                        chiTietPN.MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                        chiTietPN.MaNCC = Convert.ToInt32(cbbMaNCC.SelectedValue.ToString());
                        chiTietPN.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                        chiTietPN.GiaNhap = Convert.ToDecimal(txtDonGia.Text);
                    if (chiTietPhieuNhap.KiemTraKetNoi())
                    {
                        if (chiTietPhieuNhap.CheckID(chiTietPN.MaPN))
                        {
                            
                            int check = chiTietPhieuNhap.UpdateCTPN(chiTietPN);

                            if (check == 1)
                            {
                                dgvCTPN.DataSource = chiTietPhieuNhap.getAllCTPN();
                                MessageBox.Show("Đã sửa thông tin chi tiết phiếu nhập có mã " + chiTietPN.MaPN);
                                dgvCTPN.Show();
                            }
                            else MessageBox.Show("Sửa không thành công");
                        
                    }
                        else MessageBox.Show("Mã phiếu nhập " + chiTietPN.MaPN + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
               
                
                    if (cbbMaPN.Text != "")
                    {
                        chiTietPN.MaPN = Convert.ToInt32(cbbMaPN.SelectedValue.ToString());
                        chiTietPN.MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                    if (chiTietPhieuNhap.KiemTraKetNoi())
                    {
                        if (chiTietPhieuNhap.CheckID(chiTietPN.MaPN))
                        {

                            int check = chiTietPhieuNhap.DeleteCTPN(chiTietPN.MaPN, chiTietPN.MaSP);

                            if (check == 1)
                            {
                                dgvCTPN.DataSource = chiTietPhieuNhap.getAllCTPN();
                                MessageBox.Show("Đã xóa thông tin chi tiết phiếu nhập có mã " + chiTietPN.MaPN);
                                dgvCTPN.Show();
                            }
                            else MessageBox.Show("Xóa không thành công");
                        }
                        else MessageBox.Show("Mã phiếu nhập " + chiTietPN.MaPN + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    else MessageBox.Show("Vui lòng nhập mã phiếu nhập để xóa !");
               

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
                if (chiTietPhieuNhap.KiemTraKetNoi())
                {
                        if (cbbMaPN.Text != "")
                        {
                            int MaPN = Convert.ToInt32(cbbMaPN.SelectedValue.ToString());
                            dgvCTPN.DataSource = chiTietPhieuNhap.SearchCTPN_MaPN(MaPN);

                        }

                        else if (cbbMaSP.Text != "")
                        {
                            int MaSP = Convert.ToInt32(cbbMaSP.SelectedValue.ToString());
                            dgvCTPN.DataSource = chiTietPhieuNhap.SearchCTPN_MaSP(MaSP);
                        }

                        else if (cbbMaNCC.Text != "")
                        {
                            int MaNCC = Convert.ToInt32(cbbMaNCC.SelectedValue.ToString());
                            dgvCTPN.DataSource = chiTietPhieuNhap.SearchCTPN_MaNCC(MaNCC);
                        }
                }
                else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCTPN_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cbbMaPN.Text = dgvCTPN.Rows[dgvCTPN.CurrentRow.Index].Cells[0].Value.ToString();
            cbbMaSP.Text = dgvCTPN.Rows[dgvCTPN.CurrentRow.Index].Cells[1].Value.ToString();
            cbbMaNCC.Text = dgvCTPN.Rows[dgvCTPN.CurrentRow.Index].Cells[4].Value.ToString();
            txtSoLuong.Text = dgvCTPN.Rows[dgvCTPN.CurrentRow.Index].Cells[2].Value.ToString();
            txtDonGia.Text = dgvCTPN.Rows[dgvCTPN.CurrentRow.Index].Cells[3].Value.ToString();
        }

    }
}
