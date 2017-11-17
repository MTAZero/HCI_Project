using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace QuanLyDaiDoi.UI
{
    public partial class FrmKeHoachCongTac : Form
    {
        public FrmKeHoachCongTac()
        {
            InitializeComponent();
        }

        private void FrmKeHoachCongTac_Load(object sender, EventArgs e)
        {
            dgvDanhSachKeHoachMain.DataSource = new List<dynamic>
            {
                new {STT = "1", ThoiGian = "08/11/2017 - 17/11/2017" ,TenCongViec = "Dạ hội thanh niên quân đội" , MucDo = "Đặc biệt quan trọng", TienDo = "Đang thực hiện", GhiChu = ""},
                new {STT = "2", ThoiGian = "09/11/2017 - 09/11/2017" ,TenCongViec = "Chào cờ tiểu đoàn" , MucDo = "Quan trọng", TienDo = "Chưa thực hiện", GhiChu = ""},
                new {STT = "3", ThoiGian = "09/11/2017 - 12/11/2017" ,TenCongViec = "Dọn vệ sinh hội trường" , MucDo = "Quan trọng", TienDo = "Chưa thực hiện", GhiChu = ""},
                new {STT = "4", ThoiGian = "20/11/2017 - 20/11/2017" ,TenCongViec = "Kỉ niệm ngày nhà giáo Việt Nam" , MucDo = "Đặc biệt quan trọng", TienDo = "Chưa thực hiện", GhiChu = ""},
                new {STT = "5", ThoiGian = "22/11/2017 - 22/12/2017" ,TenCongViec = "Kỉ niệm ngày thành lập QĐND" , MucDo = "Đặc biệt quan trọng", TienDo = "Chưa thực hiện", GhiChu = ""}
            };
        }
    }
}
