namespace QuanLyKhoHangGiay.FRM
{
    partial class frmDSXuatTheoThang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbbNam = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.dgvDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDS, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.07407F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel2.Controls.Add(this.labelX1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbNam, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimkiem, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.DodgerBlue;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 31);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Năm";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cbbNam
            // 
            this.cbbNam.DisplayMember = "Text";
            this.cbbNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.ItemHeight = 14;
            this.cbbNam.Location = new System.Drawing.Point(116, 3);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(317, 20);
            this.cbbNam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbNam.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimkiem.Location = new System.Drawing.Point(439, 3);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(129, 31);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dgvDS
            // 
            this.dgvDS.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.SoHD,
            this.TongHang,
            this.TongGT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.EnableHeadersVisualStyles = false;
            this.dgvDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDS.Location = new System.Drawing.Point(3, 46);
            this.dgvDS.Name = "dgvDS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDS.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDS.Size = new System.Drawing.Size(794, 401);
            this.dgvDS.TabIndex = 1;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.Width = 200;
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số hóa đơn";
            this.SoHD.Name = "SoHD";
            this.SoHD.Width = 200;
            // 
            // TongHang
            // 
            this.TongHang.DataPropertyName = "TongHang";
            this.TongHang.HeaderText = "Tổng hàng";
            this.TongHang.Name = "TongHang";
            this.TongHang.Width = 200;
            // 
            // TongGT
            // 
            this.TongGT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongGT.DataPropertyName = "TongGT";
            this.TongGT.HeaderText = "Tổng giá trị";
            this.TongGT.Name = "TongGT";
            // 
            // frmDSXuatTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSXuatTheoThang";
            this.Text = "frmDSXuatTheoThang";
            this.Load += new System.EventHandler(this.frmDSXuatTheoThang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbNam;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGT;
    }
}