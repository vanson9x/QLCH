namespace QLCH
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MI_TaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMk = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_DanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.điệnThoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmKhuyếnMạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_NhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_BanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_TaiKhoan,
            this.MI_DanhSach,
            this.MI_NhapHang,
            this.MI_BanHang,
            this.MI_ThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MI_TaiKhoan
            // 
            this.MI_TaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.doiMk,
            this.dangxuat});
            this.MI_TaiKhoan.Name = "MI_TaiKhoan";
            this.MI_TaiKhoan.Size = new System.Drawing.Size(71, 20);
            this.MI_TaiKhoan.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // doiMk
            // 
            this.doiMk.Name = "doiMk";
            this.doiMk.Size = new System.Drawing.Size(171, 22);
            this.doiMk.Text = "Đổi mật khẩu";
            this.doiMk.Click += new System.EventHandler(this.doiMk_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(171, 22);
            this.dangxuat.Text = "Đăng xuất";
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // MI_DanhSach
            // 
            this.MI_DanhSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điệnThoạiToolStripMenuItem,
            this.sảnPhẩmKhuyếnMạiToolStripMenuItem,
            this.bảoHànhToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.MI_DanhSach.Name = "MI_DanhSach";
            this.MI_DanhSach.Size = new System.Drawing.Size(74, 20);
            this.MI_DanhSach.Text = "Danh sách";
            // 
            // điệnThoạiToolStripMenuItem
            // 
            this.điệnThoạiToolStripMenuItem.Name = "điệnThoạiToolStripMenuItem";
            this.điệnThoạiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.điệnThoạiToolStripMenuItem.Text = "Nhân viên";
            // 
            // sảnPhẩmKhuyếnMạiToolStripMenuItem
            // 
            this.sảnPhẩmKhuyếnMạiToolStripMenuItem.Name = "sảnPhẩmKhuyếnMạiToolStripMenuItem";
            this.sảnPhẩmKhuyếnMạiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sảnPhẩmKhuyếnMạiToolStripMenuItem.Text = "Sản phẩm";
            // 
            // bảoHànhToolStripMenuItem
            // 
            this.bảoHànhToolStripMenuItem.Name = "bảoHànhToolStripMenuItem";
            this.bảoHànhToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.bảoHànhToolStripMenuItem.Text = "Sản phẩm khuyến mại";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // MI_NhapHang
            // 
            this.MI_NhapHang.Name = "MI_NhapHang";
            this.MI_NhapHang.Size = new System.Drawing.Size(78, 20);
            this.MI_NhapHang.Text = "Nhập hàng";
            // 
            // MI_BanHang
            // 
            this.MI_BanHang.Name = "MI_BanHang";
            this.MI_BanHang.Size = new System.Drawing.Size(69, 20);
            this.MI_BanHang.Text = "Bán hàng";
            // 
            // MI_ThongKe
            // 
            this.MI_ThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnNhậpHàngToolStripMenuItem,
            this.hóaToolStripMenuItem});
            this.MI_ThongKe.Name = "MI_ThongKe";
            this.MI_ThongKe.Size = new System.Drawing.Size(69, 20);
            this.MI_ThongKe.Text = "Thống kê";
            // 
            // hóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.hóaĐơnNhậpHàngToolStripMenuItem.Name = "hóaĐơnNhậpHàngToolStripMenuItem";
            this.hóaĐơnNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hóaĐơnNhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            // 
            // hóaToolStripMenuItem
            // 
            this.hóaToolStripMenuItem.Name = "hóaToolStripMenuItem";
            this.hóaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hóaToolStripMenuItem.Text = "Bán hàng";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 725);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng điện thoại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MI_TaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMk;
        private System.Windows.Forms.ToolStripMenuItem dangxuat;
        private System.Windows.Forms.ToolStripMenuItem MI_DanhSach;
        private System.Windows.Forms.ToolStripMenuItem MI_NhapHang;
        private System.Windows.Forms.ToolStripMenuItem MI_BanHang;
        private System.Windows.Forms.ToolStripMenuItem MI_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điệnThoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmKhuyếnMạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
    }
}