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
    public partial class FrmSuaHocVien : MetroForm
    {
        private string Ten = "";
        public FrmSuaHocVien(string a)
        {
            InitializeComponent();
            Ten = a;
        }

        private void FrmThemHocVien_Load(object sender, EventArgs e)
        {
            txtTen.Text = Ten;
            dateEdit1.DateTime = DateTime.Now;
            comboBoxEdit1.SelectedIndex = 0;

            btnThem.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công",
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
