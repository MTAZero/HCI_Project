namespace QuanLyDaiDoi.UI
{
    partial class FrmLyLichQuanNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLyLichQuanNhan));
            this.panelBG = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsLopMain = new DevExpress.XtraGrid.GridControl();
            this.dgvDsLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvDsHocVienMain = new DevExpress.XtraGrid.GridControl();
            this.dgvDanhSachHocVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapBac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemHocVien = new DevExpress.XtraEditors.SimpleButton();
            this.panelBG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocVienMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBG
            // 
            this.panelBG.Controls.Add(this.panel2);
            this.panelBG.Controls.Add(this.panel1);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBG.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBG.Location = new System.Drawing.Point(0, 0);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(1041, 534);
            this.panelBG.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 534);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(486, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 534);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDsLopMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnThemHocVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 46);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDsHocVienMain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 486);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học viên";
            // 
            // dgvDsLopMain
            // 
            this.dgvDsLopMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsLopMain.Location = new System.Drawing.Point(3, 20);
            this.dgvDsLopMain.MainView = this.dgvDsLop;
            this.dgvDsLopMain.Name = "dgvDsLopMain";
            this.dgvDsLopMain.Size = new System.Drawing.Size(478, 509);
            this.dgvDsLopMain.TabIndex = 10;
            this.dgvDsLopMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDsLop});
            // 
            // dgvDsLop
            // 
            this.dgvDsLop.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvDsLop.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvDsLop.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvDsLop.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvDsLop.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dgvDsLop.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvDsLop.Appearance.Row.Options.UseFont = true;
            this.dgvDsLop.Appearance.Row.Options.UseTextOptions = true;
            this.dgvDsLop.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dgvDsLop.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dgvDsLop.Appearance.ViewCaption.Options.UseFont = true;
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
            // dgvDsHocVienMain
            // 
            this.dgvDsHocVienMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsHocVienMain.Location = new System.Drawing.Point(3, 20);
            this.dgvDsHocVienMain.MainView = this.dgvDanhSachHocVien;
            this.dgvDsHocVienMain.Name = "dgvDsHocVienMain";
            this.dgvDsHocVienMain.Size = new System.Drawing.Size(547, 463);
            this.dgvDsHocVienMain.TabIndex = 10;
            this.dgvDsHocVienMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDanhSachHocVien});
            // 
            // dgvDanhSachHocVien
            // 
            this.dgvDanhSachHocVien.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvDanhSachHocVien.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvDanhSachHocVien.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvDanhSachHocVien.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvDanhSachHocVien.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvDanhSachHocVien.Appearance.Row.Options.UseFont = true;
            this.dgvDanhSachHocVien.Appearance.Row.Options.UseTextOptions = true;
            this.dgvDanhSachHocVien.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
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
            this.CapBac.VisibleIndex = 4;
            this.CapBac.Width = 122;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tinh";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 5;
            this.GioiTinh.Width = 118;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            this.NgaySinh.Width = 118;
            // 
            // btnThemHocVien
            // 
            this.btnThemHocVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnThemHocVien.Appearance.Options.UseFont = true;
            this.btnThemHocVien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemHocVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHocVien.Image")));
            this.btnThemHocVien.Location = new System.Drawing.Point(4, 3);
            this.btnThemHocVien.Name = "btnThemHocVien";
            this.btnThemHocVien.Size = new System.Drawing.Size(190, 37);
            this.btnThemHocVien.TabIndex = 5;
            this.btnThemHocVien.Text = "Lý lịch chi tiết";
            // 
            // FrmLyLichQuanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 534);
            this.Controls.Add(this.panelBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLyLichQuanNhan";
            this.Text = "FrmCongTacDang";
            this.panelBG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLopMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocVienMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl dgvDsLopMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsLop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl dgvDsHocVienMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDanhSachHocVien;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn CapBac;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraEditors.SimpleButton btnThemHocVien;
    }
}