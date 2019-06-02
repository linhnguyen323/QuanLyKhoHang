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
    public partial class frmTonKho : Form
    {
 
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        
        public frmTonKho()
        {
            InitializeComponent();
        }



        private void frmTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoDataSet_TonKho.TonKho' table. You can move, or remove it, as needed.
            //this.tonKhoTableAdapter.Fill(this.quanLyKhoDataSet_TonKho.TonKho);

            if (sanPhamBLL.KiemTraKetNoi())
            {
                //hiển thị danh sách loại sản phẩm
                cbbLSP.DataSource = sanPhamBLL.ShowComboBox("proDSLSP");
                cbbLSP.DisplayMember = "TenLoai";
                cbbLSP.ValueMember = "MaLoai";

                cbbLSP.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbLSP.AutoCompleteSource = AutoCompleteSource.ListItems;

                //hiển thị danh sách sản phẩm
                cbbTenSP.DataSource = sanPhamBLL.ShowComboBox("select * from SanPham");
                cbbTenSP.DisplayMember = "TenSP";
                cbbTenSP.ValueMember = "MaSP";

                cbbTenSP.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbTenSP.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }




        private void btnDS_Click(object sender, EventArgs e)
        {
            if (sanPhamBLL.KiemTraKetNoi())
            {
                //load dữ liệu vào dgv
                dgvDSTonKho.DataSource = sanPhamBLL.getDSTonKho();
            }
            else MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbbLSP.Text != "" && cbbTenSP.Text == "")
                {
                    int MaLoai;
                    MaLoai = Convert.ToInt32(cbbLSP.SelectedValue.ToString());
                    dgvDSTonKho.DataSource = sanPhamBLL.SearchTK_MaLoai(MaLoai);

                }
                else if (cbbLSP.Text == "" && cbbTenSP.Text != "")
                {
                    int MaSP;
                    MaSP = Convert.ToInt32(cbbTenSP.SelectedValue.ToString());
                    dgvDSTonKho.DataSource = sanPhamBLL.SearchTK_MaSP(MaSP);
                }
                else if(cbbLSP.Text != "" && cbbTenSP.Text != "")
                        {
                    int MaLoai = Convert.ToInt32(cbbLSP.SelectedValue.ToString());
                    int MaSP = Convert.ToInt32(cbbTenSP.SelectedValue.ToString());
                    dgvDSTonKho.DataSource = sanPhamBLL.SearchTK(MaSP, MaLoai);
                }
                else MessageBox.Show("Vui lòng nhập thông tin để tìm kiếm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void dgvDSTonKho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbTenSP.Text = dgvDSTonKho.Rows[dgvDSTonKho.CurrentRow.Index].Cells[0].Value.ToString();
        }
    }
}
