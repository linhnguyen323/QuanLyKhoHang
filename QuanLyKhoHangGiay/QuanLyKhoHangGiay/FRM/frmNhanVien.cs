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
    public partial class frmNhanVien : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        NhanVienDTO nhanVienDTO = new NhanVienDTO();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet2.DSNhanVien' table. You can move, or remove it, as needed.
            this.dSNhanVienTableAdapter3.Fill(this.quanLyKhoDataSet2.DSNhanVien);
            //// TODO: This line of code loads data into the 'quanLyKhoDataSet1.DSNhanVien' table. You can move, or remove it, as needed.
            //this.dSNhanVienTableAdapter2.Fill(this.quanLyKhoDataSet1.DSNhanVien);
            //// TODO: This line of code loads data into the 'dataSet_DSNhanVien.DSNhanVien' table. You can move, or remove it, as needed.
            //this.dSNhanVienTableAdapter1.Fill(this.dataSet_DSNhanVien.DSNhanVien);
            //// TODO: This line of code loads data into the 'quanLyKhoDataSet.DSNhanVien' table. You can move, or remove it, as needed.
            //this.dSNhanVienTableAdapter.Fill(this.quanLyKhoDataSet.DSNhanVien);
            //// TODO: This line of code loads data into the 'qLKhoDataSet_NhanVien.NhanVien' table. You can move, or remove it, as needed.
            ////this.nhanVienTableAdapter.Fill(this.qLKhoDataSet_NhanVien.NhanVien);

            if (nv.KiemTraKetNoi())
            {
                cbbLoaiNguoiDung.DataSource = nv.ShowCombobox("select * from LoaiNguoiDung");
                cbbLoaiNguoiDung.DisplayMember = "TenLoai";
                cbbLoaiNguoiDung.ValueMember = "MaLoai";
                cbbLoaiNguoiDung.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbLoaiNguoiDung.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else MessageBox.Show("Lỗi kết nối. Vui lòng thử lại !");
        }


        private void btnDSNV_Click(object sender, EventArgs e)
        {
            if (nv.KiemTraKetNoi())
            {
                dgvNV.DataSource = nv.getAllNV();
            }
            else MessageBox.Show("Lỗi kết nối. Vui lòng thử lại !");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtMaNV.Text != "" && txtHoTen.Text != "" && txtQueQuan.Text != "" && dtNamSinh.IsEmpty != true &&txtSDT.Text != "" && txtTenDN.Text != null && txtMatKhau.Text != null && cbbLoaiNguoiDung.SelectedValue.ToString() != null)
                {
                    NhanVienDTO nhanVienDTO = new NhanVienDTO();
                    nhanVienDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
                    nhanVienDTO.HoTen = txtHoTen.Text;
                    nhanVienDTO.NamSinh = dtNamSinh.Value;
                    nhanVienDTO.QueQuan = txtQueQuan.Text;
                    nhanVienDTO.SDT = txtSDT.Text;
                    nhanVienDTO.TenDangNhap = txtTenDN.Text;
                    nhanVienDTO.MatKhau = txtMatKhau.Text;
                    nhanVienDTO.MaLoaiNguoiDung = Convert.ToInt32(cbbLoaiNguoiDung.SelectedValue.ToString());

                    if (!(nv.CheckID(nhanVienDTO.MaNV)))
                    {
                        
                        if (!nv.CheckUserName(nhanVienDTO.TenDangNhap))
                        {
                            int check = nv.InsertNV(nhanVienDTO);
                            if (check == 1)
                            {
                                dgvNV.DataSource = nv.getAllNV();
                                MessageBox.Show("Thêm nhân viên thành công !");
                                dgvNV.Show();

                            }
                            else MessageBox.Show("Thêm không thành công");
                        }
                        else MessageBox.Show("Tài khoản đăng nhập đã tồn tại.");
                    }
                    else MessageBox.Show("Mã nhân viên " + nhanVienDTO.MaNV + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtMaNV.Text != "")
                {
                    NhanVienDTO nhanVienDTO = new NhanVienDTO();
                    nhanVienDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
                    nhanVienDTO.HoTen = txtHoTen.Text;
                    nhanVienDTO.NamSinh = dtNamSinh.Value;
                    nhanVienDTO.QueQuan = txtQueQuan.Text;
                    nhanVienDTO.SDT = txtSDT.Text;
                    nhanVienDTO.TenDangNhap = txtTenDN.Text;
                    nhanVienDTO.MatKhau = txtMatKhau.Text;
                    nhanVienDTO.MaLoaiNguoiDung = Convert.ToInt32(cbbLoaiNguoiDung.SelectedValue.ToString());

                    if (nv.CheckID(nhanVienDTO.MaNV))
                    {
                        int check = nv.UpdateNV(nhanVienDTO);

                        if (check == 1)
                        {
                            dgvNV.DataSource = nv.getAllNV();
                            MessageBox.Show("Đã sửa thông tin nhân viên có mã " + nhanVienDTO.MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dgvNV.Show();
                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + nhanVienDTO.MaNV + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Nhập mã nhân viên để sửa thông tin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text != "")
                {
                    nhanVienDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
                    if (nv.CheckID(nhanVienDTO.MaNV))
                    {
                        int check = nv.DeleteNV(nhanVienDTO.MaNV);

                        if (check == 1)
                        {
                            dgvNV.DataSource = nv.getAllNV();
                            MessageBox.Show("Đã xóa nhân viên có mã " + nhanVienDTO.MaNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dgvNV.Show();
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + nhanVienDTO.MaNV + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Nhập mã nhân viên để xóa");
            }
            catch (SqlException ex)
            {

            }

        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            //nhanVienDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
            if (txtMaNV.Text != "")
            {
                nhanVienDTO.MaNV = Convert.ToInt32(txtMaNV.Text);
                dgvNV.DataSource = nv.SearchNV1(nhanVienDTO);
            }

            else if(txtHoTen.Text != "")
            {
                nhanVienDTO.HoTen = txtHoTen.Text;
                dgvNV.DataSource = nv.SearchNV3(nhanVienDTO);
            }
            else if(txtQueQuan.Text != "")
            {
                nhanVienDTO.QueQuan = txtQueQuan.Text;
                dgvNV.DataSource = nv.SearchNV5(nhanVienDTO);
            }
            else if(dtNamSinh.Text != "")
            {
                nhanVienDTO.NamSinh = dtNamSinh.Value;
                dgvNV.DataSource = nv.SearchNV4(nhanVienDTO);
            }
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNV.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[1].Value.ToString();
            dtNamSinh.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[2].Value.ToString();
            txtQueQuan.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[3].Value.ToString();
            txtSDT.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[4].Value.ToString();
            txtTenDN.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[5].Value.ToString();
            txtMatKhau.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[6].Value.ToString();
            cbbLoaiNguoiDung.Text = dgvNV.Rows[dgvNV.CurrentRow.Index].Cells[7].Value.ToString();
        }

    }
}
