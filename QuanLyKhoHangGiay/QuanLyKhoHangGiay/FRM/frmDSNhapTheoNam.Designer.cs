namespace QuanLyKhoHangGiay.FRM
{
    partial class frmDSNhapTheoNam
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nămDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốHóaĐơnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngGiáTrịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSNhapTheoNamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoDataSet_DSNhapTheoNam = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSNhapTheoNam();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dSNhapTheoNamTableAdapter = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSNhapTheoNamTableAdapters.DSNhapTheoNamTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNhapTheoNamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSNhapTheoNam)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.12397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.87603F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvDS
            // 
            this.dgvDS.AutoGenerateColumns = false;
            this.dgvDS.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nămDataGridViewTextBoxColumn,
            this.sốHóaĐơnDataGridViewTextBoxColumn,
            this.tổngHàngDataGridViewTextBoxColumn,
            this.tổngGiáTrịDataGridViewTextBoxColumn});
            this.dgvDS.DataSource = this.dSNhapTheoNamBindingSource;
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
            this.dgvDS.Location = new System.Drawing.Point(3, 48);
            this.dgvDS.Name = "dgvDS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDS.Size = new System.Drawing.Size(794, 399);
            this.dgvDS.TabIndex = 2;
            // 
            // nămDataGridViewTextBoxColumn
            // 
            this.nămDataGridViewTextBoxColumn.DataPropertyName = "Năm";
            this.nămDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.nămDataGridViewTextBoxColumn.Name = "nămDataGridViewTextBoxColumn";
            this.nămDataGridViewTextBoxColumn.Width = 200;
            // 
            // sốHóaĐơnDataGridViewTextBoxColumn
            // 
            this.sốHóaĐơnDataGridViewTextBoxColumn.DataPropertyName = "Số hóa đơn";
            this.sốHóaĐơnDataGridViewTextBoxColumn.HeaderText = "Số hóa đơn";
            this.sốHóaĐơnDataGridViewTextBoxColumn.Name = "sốHóaĐơnDataGridViewTextBoxColumn";
            this.sốHóaĐơnDataGridViewTextBoxColumn.Width = 200;
            // 
            // tổngHàngDataGridViewTextBoxColumn
            // 
            this.tổngHàngDataGridViewTextBoxColumn.DataPropertyName = "Tổng hàng";
            this.tổngHàngDataGridViewTextBoxColumn.HeaderText = "Tổng hàng";
            this.tổngHàngDataGridViewTextBoxColumn.Name = "tổngHàngDataGridViewTextBoxColumn";
            this.tổngHàngDataGridViewTextBoxColumn.Width = 200;
            // 
            // tổngGiáTrịDataGridViewTextBoxColumn
            // 
            this.tổngGiáTrịDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tổngGiáTrịDataGridViewTextBoxColumn.DataPropertyName = "Tổng giá trị";
            this.tổngGiáTrịDataGridViewTextBoxColumn.HeaderText = "Tổng giá trị";
            this.tổngGiáTrịDataGridViewTextBoxColumn.Name = "tổngGiáTrịDataGridViewTextBoxColumn";
            // 
            // dSNhapTheoNamBindingSource
            // 
            this.dSNhapTheoNamBindingSource.DataMember = "DSNhapTheoNam";
            this.dSNhapTheoNamBindingSource.DataSource = this.quanLyKhoDataSet_DSNhapTheoNam;
            // 
            // quanLyKhoDataSet_DSNhapTheoNam
            // 
            this.quanLyKhoDataSet_DSNhapTheoNam.DataSetName = "QuanLyKhoDataSet_DSNhapTheoNam";
            this.quanLyKhoDataSet_DSNhapTheoNam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.17102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.82898F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Location = new System.Drawing.Point(3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 33);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(147, 3);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(644, 33);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập năm để tìm kiếm";
            // 
            // dSNhapTheoNamTableAdapter
            // 
            this.dSNhapTheoNamTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSNhapTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSNhapTheoNam";
            this.Text = "frmDSNhapTheoNam";
            this.Load += new System.EventHandler(this.frmDSNhapTheoNam_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSNhapTheoNamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSNhapTheoNam)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private QuanLyKhoDataSet_DSNhapTheoNam quanLyKhoDataSet_DSNhapTheoNam;
        private System.Windows.Forms.BindingSource dSNhapTheoNamBindingSource;
        private QuanLyKhoDataSet_DSNhapTheoNamTableAdapters.DSNhapTheoNamTableAdapter dSNhapTheoNamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nămDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốHóaĐơnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngGiáTrịDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
    }
}