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
            Form form = checkExistForm("Thông tin người dùng");
            if (!(form is TTCaNhan))
            {
                TTCaNhan profile = new TTCaNhan();
                profile.MdiParent = this;
                profile.Show();
            }
            else
                form.Focus();  
        }

        private void doiMk_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Đổi mật khẩu");
            if (!(form is DoiMatKhau))
            {
                DoiMatKhau change = new DoiMatKhau();
                change.MdiParent = this;
                change.Show();
            }
            else
                form.Focus();
               
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

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Danh sách nhân viên");
            if (!(form is DSNhanVien))
            {
                DSNhanVien dsNhanvien = new DSNhanVien();
                dsNhanvien.MdiParent = this;
                dsNhanvien.Show();
            }
            else
                form.Focus();

            
        }

        private void MI_NhapHang_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Nhập hàng");
            if (!(form is NhapHang))
            {
                NhapHang nh = new NhapHang();
                nh.MdiParent = this;
                nh.Show();
            }
            else
                form.Focus();
            
        }

        private void MI_BanHang_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Bán hàng");
            if (!(form is BanHang))
            {
                BanHang bhang = new BanHang();
                bhang.MdiParent = this;
                bhang.Show();
            }
            else
                form.Focus();
            
        }

        private void sảnPhẩmKhuyếnMạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Quản lý sản phẩm");
            if (!(form is DSSanPham))
            {
                DSSanPham dsSP = new DSSanPham();
                dsSP.MdiParent = this;
                dsSP.Show();
            }
            else
                form.Focus();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Quản lý Nhà Cung Cấp");
            if (!(form is DSNhaCungCap))
            {
                DSNhaCungCap dsNCC = new DSNhaCungCap();
                dsNCC.MdiParent = this;
                dsNCC.Show();
            }
            else
                form.Focus();
        }
        //Kiểm tra form đã được mở chưa
        private Form checkExistForm(string nameForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == nameForm)
                    return form;
            }
            return new Form();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = checkExistForm("Thống kê nhập hàng");
            if (!(form is TKNhapHang))
            {
                TKNhapHang tkNH = new TKNhapHang();
                tkNH.MdiParent = this;
                tkNH.Show();
            }
            else
                form.Focus();
        }
    }
}
