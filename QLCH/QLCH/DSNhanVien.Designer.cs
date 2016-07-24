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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamRong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbChucvu = new System.Windows.Forms.TextBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.DGView_NhanVien.Location = new System.Drawing.Point(266, 8);
            this.DGView_NhanVien.Name = "DGView_NhanVien";
            this.DGView_NhanVien.ReadOnly = true;
            this.DGView_NhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGView_NhanVien.RowHeadersVisible = false;
            this.DGView_NhanVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGView_NhanVien.Size = new System.Drawing.Size(825, 593);
            this.DGView_NhanVien.TabIndex = 0;
            this.DGView_NhanVien.Click += new System.EventHandler(this.DGView_NhanVien_Click);
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
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(88, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(167, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamRong);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.tbDiachi);
            this.groupBox1.Controls.Add(this.tbChucvu);
            this.groupBox1.Controls.Add(this.tbHoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnLamRong
            // 
            this.btnLamRong.Location = new System.Drawing.Point(164, 162);
            this.btnLamRong.Name = "btnLamRong";
            this.btnLamRong.Size = new System.Drawing.Size(75, 23);
            this.btnLamRong.TabIndex = 11;
            this.btnLamRong.Text = "Làm rỗng";
            this.btnLamRong.UseVisualStyleBackColor = true;
            this.btnLamRong.Click += new System.EventHandler(this.btnLamRong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(87, 136);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(152, 20);
            this.tbSdt.TabIndex = 9;
            this.tbSdt.TextChanged += new System.EventHandler(this.tbSdt_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(87, 107);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 20);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(87, 78);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(152, 20);
            this.tbDiachi.TabIndex = 7;
            this.tbDiachi.TextChanged += new System.EventHandler(this.tbDiachi_TextChanged);
            // 
            // tbChucvu
            // 
            this.tbChucvu.Location = new System.Drawing.Point(87, 49);
            this.tbChucvu.Name = "tbChucvu";
            this.tbChucvu.Size = new System.Drawing.Size(152, 20);
            this.tbChucvu.TabIndex = 6;
            this.tbChucvu.TextChanged += new System.EventHandler(this.tbChucvu_TextChanged);
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(87, 17);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(152, 20);
            this.tbHoten.TabIndex = 5;
            this.tbHoten.TextChanged += new System.EventHandler(this.tbHoten_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGView_NhanVien);
            this.MaximizeBox = false;
            this.Name = "DSNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.DSNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGView_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbChucvu;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamRong;
    }
}