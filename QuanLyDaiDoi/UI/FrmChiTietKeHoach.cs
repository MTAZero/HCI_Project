using MetroFramework.Forms;
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
    public partial class FrmChiTietKeHoach : MetroForm
    {
        private string tenKeHoach = "";

        public FrmChiTietKeHoach(string a)
        {
            InitializeComponent();
            tenKeHoach = a;
        }

        private void FrmLapKeHoach_Load(object sender, EventArgs e)
        {
            txtTenKeHoach.Text = tenKeHoach;
            dgvDsPhanCongMain.DataSource = new List<dynamic>
            {
                new
                {
                    STT = 1,
                    Lop = "Bảo đảm an toàn thông tin",
                    HoTen = "Nguyễn Trung Kiên",
                    CapBac = "Trung sĩ",
                    ChucVu = "Học viên",
                    GioiTinh = "Nam",
                    NoiDungCongTac = "Tham gia luyện tập và biểu diễn dạ hội thanh niên"
                },
                 new
                {
                    STT = 2,
                    Lop = "Thiết bị điện tàu",
                    HoTen = "Lương Minh Hiếu",
                    CapBac = "Trung sĩ",
                    ChucVu = "Học viên",
                    GioiTinh = "Nam",
                    NoiDungCongTac = "Phụ trách đội luyện tập và biểu diễn dạ hội thanh niên"
                },
                  new
                {
                    STT = 3,
                    Lop = "Tin học",
                    HoTen = "Đỗ Tiến Đạt",
                    CapBac = "Thượng sĩ sĩ",
                    ChucVu = "Học viên",
                    GioiTinh = "Nam",
                    NoiDungCongTac = "Tham gia công tác trông đồ cho các đồng chí luyện tập dạ hội"
                },
                   new
                {
                    STT = 4,
                    Lop = "Tin học",
                    HoTen = "Nguyễn Thị Vân Anh",
                    CapBac = "Thượng sĩ",
                    ChucVu = "Học viên",
                    GioiTinh = "Nữ",
                    NoiDungCongTac = "Mua và phát sữa cho các đồng chí luyện tập dạ hội"
                },
                    new
                {
                    STT = 5,
                    Lop = "Ngư Lôi",
                    HoTen = "Trần Phú Sang",
                    CapBac = "Trung sĩ",
                    ChucVu = "Học viên",
                    GioiTinh = "Nam",
                    NoiDungCongTac = "Tham gia luyện tập và biểu diễn dạ hội thanh niên"
                },
            };

        }
    }
}
