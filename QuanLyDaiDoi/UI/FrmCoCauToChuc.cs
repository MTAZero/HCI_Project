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
                new { STT=1, TenLop = "Bảo đảm an toàn thông tin", QuanSo = 10},
                new { STT=2, TenLop = "Tin học", QuanSo = 22}
            };
        }
    }
}
