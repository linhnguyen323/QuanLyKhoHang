namespace QuanLyKhoHangGiay.FRM
{
    partial class frmDSNhapTheoNCC
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.cbbTimKiem = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dgvDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nhàCungCấpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLoạiSảnPhẩmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngGiáTrịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTheoNCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoDataSet_DSTheoNCC = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSTheoNCC();
            this.dSTheoNCCTableAdapter = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSTheoNCCTableAdapters.DSTheoNCCTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTheoNCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSTheoNCC)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.CadetBlue;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.17666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.82334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbTimKiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 36);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Location = new System.Drawing.Point(3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 30);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.DisplayMember = "Text";
            this.cbbTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbTimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTimKiem.DropDownHeight = 200;
            this.cbbTimKiem.DropDownWidth = 500;
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.IntegralHeight = false;
            this.cbbTimKiem.ItemHeight = 14;
            this.cbbTimKiem.Location = new System.Drawing.Point(145, 3);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(466, 20);
            this.cbbTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTimKiem.TabIndex = 1;
            // 
            // dgvDS
            // 
            this.dgvDS.AutoGenerateColumns = false;
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
            this.nhàCungCấpDataGridViewTextBoxColumn,
            this.sốLoạiSảnPhẩmDataGridViewTextBoxColumn,
            this.tổngHàngDataGridViewTextBoxColumn,
            this.tổngGiáTrịDataGridViewTextBoxColumn});
            this.dgvDS.DataSource = this.dSTheoNCCBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.EnableHeadersVisualStyles = false;
            this.dgvDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDS.Location = new System.Drawing.Point(3, 45);
            this.dgvDS.Name = "dgvDS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDS.Size = new System.Drawing.Size(794, 402);
            this.dgvDS.TabIndex = 1;
            // 
            // nhàCungCấpDataGridViewTextBoxColumn
            // 
            this.nhàCungCấpDataGridViewTextBoxColumn.DataPropertyName = "Nhà cung cấp";
            this.nhàCungCấpDataGridViewTextBoxColumn.HeaderText = "Nhà cung cấp";
            this.nhàCungCấpDataGridViewTextBoxColumn.Name = "nhàCungCấpDataGridViewTextBoxColumn";
            this.nhàCungCấpDataGridViewTextBoxColumn.Width = 200;
            // 
            // sốLoạiSảnPhẩmDataGridViewTextBoxColumn
            // 
            this.sốLoạiSảnPhẩmDataGridViewTextBoxColumn.DataPropertyName = "Số loại sản phẩm";
            this.sốLoạiSảnPhẩmDataGridViewTextBoxColumn.HeaderText = "Số loại sản phẩm";
            this.sốLoạiSảnPhẩmDataGridViewTextBoxColumn.Name = "sốLoạiSảnPhẩmDataGridViewTextBoxColumn";
            this.sốLoạiSảnPhẩmDataGridViewTextBoxColumn.Width = 200;
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
            // dSTheoNCCBindingSource
            // 
            this.dSTheoNCCBindingSource.DataMember = "DSTheoNCC";
            this.dSTheoNCCBindingSource.DataSource = this.quanLyKhoDataSet_DSTheoNCC;
            // 
            // quanLyKhoDataSet_DSTheoNCC
            // 
            this.quanLyKhoDataSet_DSTheoNCC.DataSetName = "QuanLyKhoDataSet_DSTheoNCC";
            this.quanLyKhoDataSet_DSTheoNCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSTheoNCCTableAdapter
            // 
            this.dSTheoNCCTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSNhapTheoNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSNhapTheoNCC";
            this.Text = "frmDSTheoNCC";
            this.Load += new System.EventHandler(this.frmDSTheoNCC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTheoNCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSTheoNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTimKiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDS;
        private QuanLyKhoDataSet_DSTheoNCC quanLyKhoDataSet_DSTheoNCC;
        private System.Windows.Forms.BindingSource dSTheoNCCBindingSource;
        private QuanLyKhoDataSet_DSTheoNCCTableAdapters.DSTheoNCCTableAdapter dSTheoNCCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhàCungCấpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLoạiSảnPhẩmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngGiáTrịDataGridViewTextBoxColumn;
    }
}