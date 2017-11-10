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
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public object FrmMain { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain form = new FrmMain();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
