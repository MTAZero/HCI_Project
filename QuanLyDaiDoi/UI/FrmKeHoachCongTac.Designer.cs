namespace QuanLyDaiDoi.UI
{
    partial class FrmKeHoachCongTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKeHoachCongTac));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachKeHoachMain = new DevExpress.XtraGrid.GridControl();
            this.dgvDanhSachKeHoach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MucDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnChiTietKeHoach = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapKeHoach = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKeHoachMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKeHoach)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 534);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AccessibleDescription = "panelMain";
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 474);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachKeHoachMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách kế hoạch";
            // 
            // dgvDanhSachKeHoachMain
            // 
            this.dgvDanhSachKeHoachMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKeHoachMain.Location = new System.Drawing.Point(3, 20);
            this.dgvDanhSachKeHoachMain.MainView = this.dgvDanhSachKeHoach;
            this.dgvDanhSachKeHoachMain.Name = "dgvDanhSachKeHoachMain";
            this.dgvDanhSachKeHoachMain.Size = new System.Drawing.Size(1035, 451);
            this.dgvDanhSachKeHoachMain.TabIndex = 10;
            this.dgvDanhSachKeHoachMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDanhSachKeHoach});
            // 
            // dgvDanhSachKeHoach
            // 
            this.dgvDanhSachKeHoach.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvDanhSachKeHoach.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvDanhSachKeHoach.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvDanhSachKeHoach.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvDanhSachKeHoach.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dgvDanhSachKeHoach.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.dgvDanhSachKeHoach.Appearance.Row.Options.UseFont = true;
            this.dgvDanhSachKeHoach.Appearance.Row.Options.UseTextOptions = true;
            this.dgvDanhSachKeHoach.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dgvDanhSachKeHoach.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dgvDanhSachKeHoach.Appearance.ViewCaption.Options.UseFont = true;
            this.dgvDanhSachKeHoach.ColumnPanelRowHeight = 30;
            this.dgvDanhSachKeHoach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.ThoiGian,
            this.TenCongViec,
            this.MucDo,
            this.TienDo,
            this.GhiChu});
            this.dgvDanhSachKeHoach.GridControl = this.dgvDanhSachKeHoachMain;
            this.dgvDanhSachKeHoach.Name = "dgvDanhSachKeHoach";
            this.dgvDanhSachKeHoach.OptionsBehavior.Editable = false;
            this.dgvDanhSachKeHoach.OptionsBehavior.ReadOnly = true;
            this.dgvDanhSachKeHoach.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvDanhSachKeHoach.OptionsView.ShowGroupPanel = false;
            this.dgvDanhSachKeHoach.PaintStyleName = "UltraFlat";
            this.dgvDanhSachKeHoach.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 49;
            // 
            // ThoiGian
            // 
            this.ThoiGian.Caption = "Thời gian";
            this.ThoiGian.FieldName = "ThoiGian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Visible = true;
            this.ThoiGian.VisibleIndex = 1;
            this.ThoiGian.Width = 115;
            // 
            // TenCongViec
            // 
            this.TenCongViec.Caption = "Công việc";
            this.TenCongViec.FieldName = "TenCongViec";
            this.TenCongViec.Name = "TenCongViec";
            this.TenCongViec.Visible = true;
            this.TenCongViec.VisibleIndex = 2;
            this.TenCongViec.Width = 181;
            // 
            // MucDo
            // 
            this.MucDo.Caption = "Mức độ";
            this.MucDo.FieldName = "MucDo";
            this.MucDo.Name = "MucDo";
            this.MucDo.Visible = true;
            this.MucDo.VisibleIndex = 3;
            this.MucDo.Width = 111;
            // 
            // TienDo
            // 
            this.TienDo.Caption = "Tiến độ";
            this.TienDo.FieldName = "TienDo";
            this.TienDo.Name = "TienDo";
            this.TienDo.Visible = true;
            this.TienDo.VisibleIndex = 4;
            this.TienDo.Width = 112;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 5;
            this.GhiChu.Width = 131;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnChiTietKeHoach);
            this.panelControl.Controls.Add(this.btnLapKeHoach);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1041, 60);
            this.panelControl.TabIndex = 0;
            // 
            // btnChiTietKeHoach
            // 
            this.btnChiTietKeHoach.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnChiTietKeHoach.Appearance.Options.UseFont = true;
            this.btnChiTietKeHoach.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnChiTietKeHoach.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTietKeHoach.Image")));
            this.btnChiTietKeHoach.Location = new System.Drawing.Point(219, 3);
            this.btnChiTietKeHoach.Name = "btnChiTietKeHoach";
            this.btnChiTietKeHoach.Size = new System.Drawing.Size(210, 52);
            this.btnChiTietKeHoach.TabIndex = 9;
            this.btnChiTietKeHoach.Text = "Chi tiết kế hoạch";
            // 
            // btnLapKeHoach
            // 
            this.btnLapKeHoach.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btnLapKeHoach.Appearance.Options.UseFont = true;
            this.btnLapKeHoach.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLapKeHoach.Image = ((System.Drawing.Image)(resources.GetObject("btnLapKeHoach.Image")));
            this.btnLapKeHoach.Location = new System.Drawing.Point(3, 3);
            this.btnLapKeHoach.Name = "btnLapKeHoach";
            this.btnLapKeHoach.Size = new System.Drawing.Size(210, 52);
            this.btnLapKeHoach.TabIndex = 8;
            this.btnLapKeHoach.Text = "Lập kế hoạch";
            this.btnLapKeHoach.Click += new System.EventHandler(this.btnLapKeHoach_Click);
            // 
            // FrmKeHoachCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 534);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKeHoachCongTac";
            this.Text = "FrmCongTacChinhTri";
            this.Load += new System.EventHandler(this.FrmKeHoachCongTac_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKeHoachMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKeHoach)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelControl;
        private DevExpress.XtraEditors.SimpleButton btnChiTietKeHoach;
        private DevExpress.XtraEditors.SimpleButton btnLapKeHoach;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvDanhSachKeHoachMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDanhSachKeHoach;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TenCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn MucDo;
        private DevExpress.XtraGrid.Columns.GridColumn TienDo;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGian;
    }
}