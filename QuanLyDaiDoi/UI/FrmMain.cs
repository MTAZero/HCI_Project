﻿using MetroFramework.Forms;
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
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FrmCoCauToChuc form = new FrmCoCauToChuc();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FrmKeHoachCongTac form = new FrmKeHoachCongTac();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FrmLyLichQuanNhan form = new FrmLyLichQuanNhan();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }
    }
}
