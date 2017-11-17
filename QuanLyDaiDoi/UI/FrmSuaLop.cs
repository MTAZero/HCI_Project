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
    public partial class FrmSuaLop : MetroForm
    {
        private string TenLop = "";
        public FrmSuaLop(string a)
        {
            InitializeComponent();
            TenLop = a;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tên lớp không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Sửa lớp thành công", 
                            "Thông báo", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSuaLop_Load(object sender, EventArgs e)
        {
            textBox1.Text = TenLop;
        }
    }
}
