namespace QuanLyKhoHangGiay.FRM
{
    partial class frmDSXuatTheoNgay
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
            this.dtTimkiem = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgvDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ngàyXuấtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốHóaĐơnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tổngGiáTrịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSXuatTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoDataSet_DSXuatTheoNgay = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSXuatTheoNgay();
            this.dSXuatTheoNgayTableAdapter = new QuanLyKhoHangGiay.QuanLyKhoDataSet_DSXuatTheoNgayTableAdapters.DSXuatTheoNgayTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTimkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSXuatTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSXuatTheoNgay)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.42857F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtTimkiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Location = new System.Drawing.Point(3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(152, 24);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtTimkiem
            // 
            // 
            // 
            // 
            this.dtTimkiem.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTimkiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimkiem.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTimkiem.ButtonDropDown.Visible = true;
            this.dtTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtTimkiem.IsPopupCalendarOpen = false;
            this.dtTimkiem.Location = new System.Drawing.Point(161, 3);
            // 
            // 
            // 
            this.dtTimkiem.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTimkiem.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimkiem.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtTimkiem.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTimkiem.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimkiem.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dtTimkiem.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTimkiem.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTimkiem.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTimkiem.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTimkiem.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTimkiem.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTimkiem.MonthCalendar.TodayButtonVisible = true;
            this.dtTimkiem.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtTimkiem.Name = "dtTimkiem";
            this.dtTimkiem.Size = new System.Drawing.Size(536, 20);
            this.dtTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTimkiem.TabIndex = 1;
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngàyXuấtDataGridViewTextBoxColumn,
            this.sốHóaĐơnDataGridViewTextBoxColumn,
            this.tổngHàngDataGridViewTextBoxColumn,
            this.tổngGiáTrịDataGridViewTextBoxColumn});
            this.dgvDS.DataSource = this.dSXuatTheoNgayBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDS.Location = new System.Drawing.Point(3, 39);
            this.dgvDS.Name = "dgvDS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDS.Size = new System.Drawing.Size(794, 408);
            this.dgvDS.TabIndex = 1;
            // 
            // ngàyXuấtDataGridViewTextBoxColumn
            // 
            this.ngàyXuấtDataGridViewTextBoxColumn.DataPropertyName = "Ngày xuất";
            this.ngàyXuấtDataGridViewTextBoxColumn.HeaderText = "Ngày xuất";
            this.ngàyXuấtDataGridViewTextBoxColumn.Name = "ngàyXuấtDataGridViewTextBoxColumn";
            this.ngàyXuấtDataGridViewTextBoxColumn.Width = 200;
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
            // dSXuatTheoNgayBindingSource
            // 
            this.dSXuatTheoNgayBindingSource.DataMember = "DSXuatTheoNgay";
            this.dSXuatTheoNgayBindingSource.DataSource = this.quanLyKhoDataSet_DSXuatTheoNgay;
            // 
            // quanLyKhoDataSet_DSXuatTheoNgay
            // 
            this.quanLyKhoDataSet_DSXuatTheoNgay.DataSetName = "QuanLyKhoDataSet_DSXuatTheoNgay";
            this.quanLyKhoDataSet_DSXuatTheoNgay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSXuatTheoNgayTableAdapter
            // 
            this.dSXuatTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSXuatTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSXuatTheoNgay";
            this.Text = "frmDSXuatTheoNgay";
            this.Load += new System.EventHandler(this.frmDSXuatTheoNgay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTimkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSXuatTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDataSet_DSXuatTheoNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTimkiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDS;
        private QuanLyKhoDataSet_DSXuatTheoNgay quanLyKhoDataSet_DSXuatTheoNgay;
        private System.Windows.Forms.BindingSource dSXuatTheoNgayBindingSource;
        private QuanLyKhoDataSet_DSXuatTheoNgayTableAdapters.DSXuatTheoNgayTableAdapter dSXuatTheoNgayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyXuấtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốHóaĐơnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngGiáTrịDataGridViewTextBoxColumn;
    }
}