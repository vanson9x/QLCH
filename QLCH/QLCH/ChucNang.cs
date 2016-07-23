using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCH
{
    public partial class ChucNang : Form
    {
        public ChucNang()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTCaNhan profile = new TTCaNhan();
            profile.MdiParent = this;
            profile.Show();
        }

        private void doiMk_Click(object sender, EventArgs e)
        {
            DoiMatKhau change = new DoiMatKhau();
            change.MdiParent = this;
            change.Show();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            this.MI_TaiKhoan.Enabled = false;
            this.MI_BanHang.Enabled = false;
            this.MI_DanhSach.Enabled = false;
            this.MI_NhapHang.Enabled = false;
            this.MI_ThongKe.Enabled = false;
            Program.user = "";
            DangNhap login = new DangNhap();
            login.MdiParent = this;
            login.Show();
        }

        public void EnableMenuItem()
        {
            this.MI_TaiKhoan.Enabled = true;
            this.MI_BanHang.Enabled = true;
            this.MI_DanhSach.Enabled = true;
            this.MI_NhapHang.Enabled = true;
            this.MI_ThongKe.Enabled = true;
        }
    }
}
