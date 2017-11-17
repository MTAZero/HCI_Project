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
    public partial class FrmThemHocVien : MetroForm
    {
        public FrmThemHocVien()
        {
            InitializeComponent();
        }

        private void FrmThemHocVien_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            comboBoxEdit1.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm học viên thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkChonAnh_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
                Image image = Image.FromFile(path);
                pictureAnh.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
