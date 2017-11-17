namespace QuanLyDaiDoi.UI
{
    partial class FrmCoCauToChuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoCauToChuc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDsHocVienMain = new DevExpress.XtraGrid.GridControl();
            this.dgvDanhSachHocVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapBac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsLopMain = new DevExpress.XtraGrid.GridControl();
            this.dgvDsLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThemLop = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLop = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocVienMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLop)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 575);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDsHocVienMain);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(497, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 530);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học viên";
            // 
            // dgvDsHocVienMain
            // 
            this.dgvDsHocVienMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsHocVienMain.Location = new System.Drawing.Point(3, 20);
            this.dgvDsHocVienMain.MainView = this.dgvDanhSachHocVien;
            this.dgvDsHocVienMain.Name = "dgvDsHocVienMain";
            this.dgvDsHocVienMain.Size = new System.Drawing.Size(560, 463);
            this.dgvDsHocVienMain.TabIndex = 9;
            this.dgvDsHocVienMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDanhSachHocVien});
            // 
            // dgvDanhSachHocVien
            // 
            this.dgvDanhSachHocVien.ColumnPanelRowHeight = 30;
            this.dgvDanhSachHocVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.HoTen,
            this.ChucVu,
            this.CapBac,
            this.GioiTinh,
            this.NgaySinh});
            this.dgvDanhSachHocVien.GridControl = this.dgvDsHocVienMain;
            this.dgvDanhSachHocVien.Name = "dgvDanhSachHocVien";
            this.dgvDanhSachHocVien.OptionsBehavior.Editable = false;
            this.dgvDanhSachHocVien.OptionsBehavior.ReadOnly = true;
            this.dgvDanhSachHocVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvDanhSachHocVien.OptionsView.ShowGroupPanel = false;
            this.dgvDanhSachHocVien.PaintStyleName = "UltraFlat";
            this.dgvDanhSachHocVien.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 45;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ và tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 1;
            this.HoTen.Width = 193;
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "Chức vụ";
            this.ChucVu.FieldName = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Visible = true;
            this.ChucVu.VisibleIndex = 2;
            this.ChucVu.Width = 103;
            // 
            // CapBac
            // 
            this.CapBac.Caption = "Cấp bậc";
            this.CapBac.FieldName = "CapBac";
            this.CapBac.Name = "CapBac";
            this.CapBac.Visible = true;
            this.CapBac.VisibleIndex = 3;
            this.CapBac.Width = 122;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tinh";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            this.GioiTinh.Width = 118;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 5;
            this.NgaySinh.Width = 118;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnThemHocVien);
            this.panel4.Controls.Add(this.btnSuaHocVien);
            this.panel4.Controls.Add(this.btnXoaHocVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 44);
            this.panel4.TabIndex = 8;
            // 
            // btnThemHocVien
            // 
            this.btnThemHocVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnThemHocVien.Appearance.Options.UseFont = true;
            this.btnThemHocVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemHocVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHocVien.Image")));
            this.btnThemHocVien.Location = new System.Drawing.Point(3, 3);
            this.btnThemHocVien.Name = "btnThemHocVien";
            this.btnThemHocVien.Size = new System.Drawing.Size(120, 36);
            this.btnThemHocVien.TabIndex = 4;
            this.btnThemHocVien.Text = "Thêm";
            this.btnThemHocVien.Click += new System.EventHandler(this.btnThemHocVien_Click);
            // 
            // btnSuaHocVien
            // 
            this.btnSuaHocVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnSuaHocVien.Appearance.Options.UseFont = true;
            this.btnSuaHocVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSuaHocVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHocVien.Image")));
            this.btnSuaHocVien.Location = new System.Drawing.Point(129, 3);
            this.btnSuaHocVien.Name = "btnSuaHocVien";
            this.btnSuaHocVien.Size = new System.Drawing.Size(107, 36);
            this.btnSuaHocVien.TabIndex = 3;
            this.btnSuaHocVien.Text = "Sửa";
            this.btnSuaHocVien.Click += new System.EventHandler(this.btnSuaHocVien_Click);
            // 
            // btnXoaHocVien
            // 
            this.btnXoaHocVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnXoaHocVien.Appearance.Options.UseFont = true;
            this.btnXoaHocVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoaHocVien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHocVien.Image")));
            this.btnXoaHocVien.Location = new System.Drawing.Point(242, 3);
            this.btnXoaHocVien.Name = "btnXoaHocVien";
            this.btnXoaHocVien.Size = new System.Drawing.Size(118, 36);
            this.btnXoaHocVien.TabIndex = 0;
            this.btnXoaHocVien.Text = "Xóa";
            this.btnXoaHocVien.Click += new System.EventHandler(this.btnXoaHocVien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDsLopMain);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 530);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp";
            // 
            // dgvDsLopMain
            // 
            this.dgvDsLopMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsLopMain.Location = new System.Drawing.Point(3, 20);
            this.dgvDsLopMain.MainView = this.dgvDsLop;
            this.dgvDsLopMain.Name = "dgvDsLopMain";
            this.dgvDsLopMain.Size = new System.Drawing.Size(491, 463);
            this.dgvDsLopMain.TabIndex = 9;
            this.dgvDsLopMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDsLop});
            // 
            // dgvDsLop
            // 
            this.dgvDsLop.ColumnPanelRowHeight = 30;
            this.dgvDsLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.dgvDsLop.GridControl = this.dgvDsLopMain;
            this.dgvDsLop.Name = "dgvDsLop";
            this.dgvDsLop.OptionsBehavior.Editable = false;
            this.dgvDsLop.OptionsBehavior.ReadOnly = true;
            this.dgvDsLop.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvDsLop.OptionsView.ShowGroupPanel = false;
            this.dgvDsLop.PaintStyleName = "UltraFlat";
            this.dgvDsLop.RowHeight = 30;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "STT";
            this.gridColumn4.FieldName = "STT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 97;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên lớp";
            this.gridColumn5.FieldName = "TenLop";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 299;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Quân số";
            this.gridColumn6.FieldName = "QuanSo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 303;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnThemLop);
            this.panel5.Controls.Add(this.btnSuaLop);
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 44);
            this.panel5.TabIndex = 8;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnThemLop.Appearance.Options.UseFont = true;
            this.btnThemLop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLop.Image")));
            this.btnThemLop.Location = new System.Drawing.Point(2, 3);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(120, 36);
            this.btnThemLop.TabIndex = 7;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnSuaLop.Appearance.Options.UseFont = true;
            this.btnSuaLop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSuaLop.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLop.Image")));
            this.btnSuaLop.Location = new System.Drawing.Point(128, 3);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(107, 36);
            this.btnSuaLop.TabIndex = 6;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(241, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 43);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(95, 6);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(195, 20);
            this.searchControl1.TabIndex = 0;
            // 
            // FrmCoCauToChuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCoCauToChuc";
            this.Text = "FrmCoCauToChuc";
            this.Load += new System.EventHandler(this.FrmCoCauToChuc_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocVienMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLop)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvDsHocVienMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDanhSachHocVien;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnThemHocVien;
        private DevExpress.XtraEditors.SimpleButton btnSuaHocVien;
        private DevExpress.XtraEditors.SimpleButton btnXoaHocVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl dgvDsLopMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsLop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn CapBac;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnThemLop;
        private DevExpress.XtraEditors.SimpleButton btnSuaLop;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}