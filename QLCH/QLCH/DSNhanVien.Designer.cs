namespace QLCH
{
    partial class DSNhanVien
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
            this.DGView_NhanVien = new System.Windows.Forms.DataGridView();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // DGView_NhanVien
            // 
            this.DGView_NhanVien.AllowUserToAddRows = false;
            this.DGView_NhanVien.AllowUserToDeleteRows = false;
            this.DGView_NhanVien.AllowUserToResizeColumns = false;
            this.DGView_NhanVien.AllowUserToResizeRows = false;
            this.DGView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.chucvu,
            this.diachi,
            this.email,
            this.sdt});
            this.DGView_NhanVien.Location = new System.Drawing.Point(3, 2);
            this.DGView_NhanVien.Name = "DGView_NhanVien";
            this.DGView_NhanVien.ReadOnly = true;
            this.DGView_NhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGView_NhanVien.RowHeadersVisible = false;
            this.DGView_NhanVien.Size = new System.Drawing.Size(825, 360);
            this.DGView_NhanVien.TabIndex = 0;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "sTenNV";
            this.hoten.HeaderText = "Họ và Tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 200;
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "sChucVu";
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            this.chucvu.ReadOnly = true;
            this.chucvu.Width = 120;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "sDiaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "sEmail";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sSDT";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 365);
            this.Controls.Add(this.DGView_NhanVien);
            this.MaximizeBox = false;
            this.Name = "DSNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.DSNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGView_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}