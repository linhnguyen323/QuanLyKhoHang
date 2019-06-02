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
    public partial class frmNCC : Form
    {

        NhaCungCapBLL nccBLL = new NhaCungCapBLL();
        NhaCungCapDTO nhaCungCapDTO = new NhaCungCapDTO();
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhoDataSet_NCC.NhaCungCap' table. You can move, or remove it, as needed.
           // this.nhaCungCapTableAdapter.Fill(this.qLKhoDataSet_NCC.NhaCungCap);

        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            if (nccBLL.KiemTraKetNoi())
            {
                dgvNCC.DataSource = nccBLL.getAllNCC();
            }
            else MessageBox.Show("Lỗi kết nối.","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
                {
                    nhaCungCapDTO.MaNCC = Convert.ToInt32(txtMaNCC.Text);
                    nhaCungCapDTO.HoTen = txtTenNCC.Text;
                    nhaCungCapDTO.DiaChi = txtDiaChi.Text;
                    nhaCungCapDTO.SDT = txtSDT.Text;

                    if (!(nccBLL.CheckID(nhaCungCapDTO.MaNCC)))
                    {
                        int check = nccBLL.InsertNCC(nhaCungCapDTO);

                        if (check == 1)
                        {
                            dgvNCC.DataSource = nccBLL.getAllNCC();
                            dgvNCC.Show();
                        }
                        else MessageBox.Show("Thêm không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + nhaCungCapDTO.MaNCC + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtMaNCC.Text != "")
                {
                    nhaCungCapDTO.MaNCC = Convert.ToInt32(txtMaNCC.Text);
                    nhaCungCapDTO.HoTen = txtTenNCC.Text;
                    nhaCungCapDTO.DiaChi = txtDiaChi.Text;
                    nhaCungCapDTO.SDT = txtSDT.Text;
                    if (nccBLL.CheckID(nhaCungCapDTO.MaNCC))
                    {
                        int check = nccBLL.InsertNCC(nhaCungCapDTO);

                        if (check == 1)
                        {
                            dgvNCC.DataSource = nccBLL.getAllNCC();
                            dgvNCC.Show();
                        }
                        else MessageBox.Show("Sửa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + nhaCungCapDTO.MaNCC + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Vui lòng nhập mã nhà cung cấp để sửa thông tin");
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
                if (txtMaNCC.Text != "")
                {
                    nhaCungCapDTO.MaNCC = Convert.ToInt32(txtMaNCC.Text);
                    if (nccBLL.CheckID(nhaCungCapDTO.MaNCC))
                    {

                        int check = nccBLL.DeleteNCC(nhaCungCapDTO);

                        if (check == 1)
                        {
                            dgvNCC.DataSource = nccBLL.getAllNCC();
                            dgvNCC.Show();
                            MessageBox.Show("Đã xóa nhân viên có mã " + nhaCungCapDTO.MaNCC);
                        }
                        else MessageBox.Show("Xóa không thành công");
                    }
                    else MessageBox.Show("Mã nhân viên " + nhaCungCapDTO.MaNCC + " không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Vui lòng nhập mã nhà cung cấp để xóa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaNCC.Text != ""){
                    nhaCungCapDTO.MaNCC = Convert.ToInt32(txtMaNCC.Text);
                    dgvNCC.DataSource = nccBLL.SearchNCC1(nhaCungCapDTO);
                }
                else if(txtTenNCC.Text != "")
                {
                    nhaCungCapDTO.HoTen = txtTenNCC.Text;
                    dgvNCC.DataSource = nccBLL.SearchNCC2(nhaCungCapDTO);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNCC.Text = dgvNCC.Rows[dgvNCC.CurrentRow.Index].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[dgvNCC.CurrentRow.Index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[dgvNCC.CurrentRow.Index].Cells[2].Value.ToString(); 
            txtSDT.Text = dgvNCC.Rows[dgvNCC.CurrentRow.Index].Cells[3].Value.ToString();
        }
    }
}
