using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiDoi.UI
{
    public partial class FrmCoCauToChuc : Form
    {
        public FrmCoCauToChuc()
        {
            InitializeComponent();
        }

        private void FrmCoCauToChuc_Load(object sender, EventArgs e)
        {
            dgvDsLopMain.DataSource = new List<dynamic>
            {
                new { STT="1", TenLop = "Bảo đảm an toàn thông tin", QuanSo = 10},
                new { STT="2", TenLop = "Tin học", QuanSo = 22},
                new { STT="3", TenLop = "Tên Lửa Hải Quân", QuanSo = 10},
                new { STT="4", TenLop = "Tên Lửa Phòng Không", QuanSo = 19},
                new { STT="5", TenLop = "Ngư Lôi", QuanSo = 8},
                new { STT="6", TenLop = "Tác Chiến Điện Tử", QuanSo = 12},
                new { STT="7", TenLop = "Thiết Bị Điện Tàu", QuanSo = 10},
                new { STT="8", TenLop = "Thông Tin", QuanSo = 24},
                new { STT="9", TenLop = "Thông Tin Hải Quân", QuanSo = 8},
                new { STT="10", TenLop = "Rađa Sôna", QuanSo = 10},
                new { STT="", TenLop = "Toàn Đại đội", QuanSo = 133}
            };

            dgvDsHocVienMain.DataSource = new List<dynamic>
            {
                new { STT=1, HoTen = "Nguyễn Trọng Huyền Anh", ChucVu = "Học viên", CapBac = "Thượng sĩ", GioiTinh = "Nữ", NgaySinh = "03/06/1996"},
                new { STT=2, HoTen = "Nguyễn Nam Anh", ChucVu = "Lớp phó", CapBac = "Thượng sĩ", GioiTinh = "Nam", NgaySinh = "11/12/1996"},
                new { STT=3, HoTen = "Vũ Đình Đạt", ChucVu = "Học viên", CapBac = "Trung sĩ", GioiTinh = "Nam", NgaySinh = "27/05/1996"},
                new { STT=4, HoTen = "Phan Trung Đức", ChucVu = "Học viên", CapBac = "Trung sĩ", GioiTinh = "Nam", NgaySinh = "01/12/1996"},
                new { STT=5, HoTen = "Ngô Thị Hòa", ChucVu = "Học viên", CapBac = "Thượng sĩ", GioiTinh = "Nữ", NgaySinh = "11/10/1996"},
                new { STT=6, HoTen = "Nguyễn Văn Hòa", ChucVu = "Học viên", CapBac = "Thượng sĩ", GioiTinh = "Nam", NgaySinh = "07/06/1995"},
                new { STT=7, HoTen = "Nguyễn Trung Kiên", ChucVu = "Học viên", CapBac = "Trung sĩ", GioiTinh = "Nam", NgaySinh = "09/09/1996"},
                new { STT=8, HoTen = "Trần Tuấn Phong", ChucVu = "Học viên", CapBac = "Thượng sĩ", GioiTinh = "Nam", NgaySinh = "01/05/1996"},
                new { STT=9, HoTen = "Bùi Xuân Thủy", ChucVu = "Lớp trưởng", CapBac = "Thượng sĩ", GioiTinh = "Nam", NgaySinh = "03/09/1996"},
                new { STT=10, HoTen = "Nguyễn Thị Trinh", ChucVu = "Học viên", CapBac = "Thượng sĩ", GioiTinh = "Nữ", NgaySinh = "01/10/1996"}
            };
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            FrmThemLop form = new FrmThemLop();
            form.ShowDialog();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            try
            {
                string tenLop = (string) dgvDsLop.GetFocusedRowCellValue("TenLop");

                if (tenLop == "Toàn Đại đội") return;

                FrmSuaLop form = new FrmSuaLop(tenLop);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa có lớp nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnThemHocVien_Click(object sender, EventArgs e)
        {
            FrmThemHocVien form = new FrmThemHocVien();
            form.ShowDialog();
        }

        private void btnSuaHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                string Ten = (string) dgvDanhSachHocVien.GetFocusedRowCellValue("HoTen");
                FrmSuaHocVien form = new FrmSuaHocVien(Ten);
                form.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Chưa có học viên nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnXoaHocVien_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin học viên này không?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            MessageBox.Show("Xóa thông tin học viên thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin lớp này không?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            MessageBox.Show("Xóa thông tin lớp thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
