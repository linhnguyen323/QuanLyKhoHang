namespace QuanLyKhoHangGiay.FRM
{
    partial class frmDSNhapTheoNgay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ngàyNhậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốHóaĐơnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngGiáTrịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongKeDSNhapTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoDataSet_DSNhapTheoNgay = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSNhapTheoNgay();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.thongKeDSNhapTheoNgayTableAdapter = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSNhapTheoNgayTableAdapters.ThongKeDSNhapTheoNgayTableAdapter();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.dtTimKiem = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDSNhapTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSNhapTheoNgay)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimKiem)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.73553F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDS
            // 
            this.dgvDS.AutoGenerateColumns = false;
            this.dgvDS.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngàyNhậpDataGridViewTextBoxColumn,
            this.sốHóaĐơnDataGridViewTextBoxColumn,
            this.tổngHàngDataGridViewTextBoxColumn,
            this.tổngGiáTrịDataGridViewTextBoxColumn});
            this.dgvDS.DataSource = this.thongKeDSNhapTheoNgayBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDS.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.EnableHeadersVisualStyles = false;
            this.dgvDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDS.Location = new System.Drawing.Point(3, 42);
            this.dgvDS.Name = "dgvDS";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDS.Size = new System.Drawing.Size(842, 439);
            this.dgvDS.TabIndex = 2;
            // 
            // ngàyNhậpDataGridViewTextBoxColumn
            // 
            this.ngàyNhậpDataGridViewTextBoxColumn.DataPropertyName = "Ngày nhập";
            this.ngàyNhậpDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngàyNhậpDataGridViewTextBoxColumn.Name = "ngàyNhậpDataGridViewTextBoxColumn";
            this.ngàyNhậpDataGridViewTextBoxColumn.Width = 200;
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
            // thongKeDSNhapTheoNgayBindingSource
            // 
            this.thongKeDSNhapTheoNgayBindingSource.DataMember = "ThongKeDSNhapTheoNgay";
            this.thongKeDSNhapTheoNgayBindingSource.DataSource = this.quanLyKhoDataSet_DSNhapTheoNgay;
            // 
            // quanLyKhoDataSet_DSNhapTheoNgay
            // 
            this.quanLyKhoDataSet_DSNhapTheoNgay.DataSetName = "QuanLyKhoDataSet_DSNhapTheoNgay";
            this.quanLyKhoDataSet_DSNhapTheoNgay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.17102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.82898F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtTimKiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(842, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // thongKeDSNhapTheoNgayTableAdapter
            // 
            this.thongKeDSNhapTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Location = new System.Drawing.Point(3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(146, 27);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtTimKiem
            // 
            // 
            // 
            // 
            this.dtTimKiem.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimKiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimKiem.ButtonDropDown.Visible = true;
            this.dtTimKiem.IsPopupCalendarOpen = false;
            this.dtTimKiem.Location = new System.Drawing.Point(155, 3);
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimKiem.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimKiem.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dtTimKiem.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTimKiem.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimKiem.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimKiem.MonthCalendar.TodayButtonVisible = true;
            this.dtTimKiem.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtTimKiem.Name = "dtTimKiem";
            this.dtTimKiem.Size = new System.Drawing.Size(356, 20);
            this.dtTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimKiem.TabIndex = 6;
            // 
            // frmDSNhapTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSNhapTheoNgay";
            this.Text = "frmDSNhapTheoNgay";
            this.Load += new System.EventHandler(this.frmDSNhapTheoNgay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDSNhapTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSNhapTheoNgay)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private QuanLyKhoDataSet_DSNhapTheoNgay quanLyKhoDataSet_DSNhapTheoNgay;
        private System.Windows.Forms.BindingSource thongKeDSNhapTheoNgayBindingSource;
        private QuanLyKhoDataSet_DSNhapTheoNgayTableAdapters.ThongKeDSNhapTheoNgayTableAdapter thongKeDSNhapTheoNgayTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyNhậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốHóaĐơnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngGiáTrịDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimKiem;
    }
}