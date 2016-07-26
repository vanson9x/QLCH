namespace QLCH
{
    partial class DSSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaNCC = new System.Windows.Forms.TextBox();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.tbGiaSP = new System.Windows.Forms.TextBox();
            this.dtgv_SanPham = new System.Windows.Forms.DataGridView();
            this.sMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sThongTinCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_sMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThongTinSP = new System.Windows.Forms.GroupBox();
            this.groupBoxMoTa = new System.Windows.Forms.GroupBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SanPham)).BeginInit();
            this.groupBoxThongTinSP.SuspendLayout();
            this.groupBoxMoTa.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Nhà CC";
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.Location = new System.Drawing.Point(92, 21);
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.Size = new System.Drawing.Size(179, 20);
            this.tbMaNCC.TabIndex = 5;
            this.tbMaNCC.TextChanged += new System.EventHandler(this.tbMaNCC_TextChanged);
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(92, 52);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(179, 20);
            this.tbMaSP.TabIndex = 6;
            this.tbMaSP.TextChanged += new System.EventHandler(this.tbMaSP_TextChanged);
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(92, 83);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(179, 20);
            this.tbTenSP.TabIndex = 7;
            // 
            // tbMoTa
            // 
            this.tbMoTa.Location = new System.Drawing.Point(1, 13);
            this.tbMoTa.Multiline = true;
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMoTa.Size = new System.Drawing.Size(440, 93);
            this.tbMoTa.TabIndex = 8;
            // 
            // tbGiaSP
            // 
            this.tbGiaSP.Location = new System.Drawing.Point(92, 118);
            this.tbGiaSP.Name = "tbGiaSP";
            this.tbGiaSP.Size = new System.Drawing.Size(179, 20);
            this.tbGiaSP.TabIndex = 9;
            // 
            // dtgv_SanPham
            // 
            this.dtgv_SanPham.AllowUserToAddRows = false;
            this.dtgv_SanPham.AllowUserToDeleteRows = false;
            this.dtgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSP,
            this.sTenSP,
            this.sThongTinCT,
            this.fGia,
            this.FK_sMaNCC});
            this.dtgv_SanPham.Location = new System.Drawing.Point(12, 167);
            this.dtgv_SanPham.Name = "dtgv_SanPham";
            this.dtgv_SanPham.ReadOnly = true;
            this.dtgv_SanPham.Size = new System.Drawing.Size(778, 327);
            this.dtgv_SanPham.TabIndex = 10;
            this.dtgv_SanPham.Click += new System.EventHandler(this.dtgv_SanPham_Click);
            // 
            // sMaSP
            // 
            this.sMaSP.DataPropertyName = "sMaSP";
            this.sMaSP.HeaderText = "Mã Sản Phẩm";
            this.sMaSP.Name = "sMaSP";
            this.sMaSP.ReadOnly = true;
            // 
            // sTenSP
            // 
            this.sTenSP.DataPropertyName = "sTenSP";
            this.sTenSP.HeaderText = "Tên Sản Phẩm";
            this.sTenSP.Name = "sTenSP";
            this.sTenSP.ReadOnly = true;
            // 
            // sThongTinCT
            // 
            this.sThongTinCT.DataPropertyName = "sThongTinCT";
            this.sThongTinCT.HeaderText = "Mô tả";
            this.sThongTinCT.Name = "sThongTinCT";
            this.sThongTinCT.ReadOnly = true;
            // 
            // fGia
            // 
            this.fGia.DataPropertyName = "fGia";
            this.fGia.HeaderText = "Giá";
            this.fGia.Name = "fGia";
            this.fGia.ReadOnly = true;
            // 
            // FK_sMaNCC
            // 
            this.FK_sMaNCC.DataPropertyName = "FK_sMaNCC";
            this.FK_sMaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.FK_sMaNCC.Name = "FK_sMaNCC";
            this.FK_sMaNCC.ReadOnly = true;
            // 
            // groupBoxThongTinSP
            // 
            this.groupBoxThongTinSP.Controls.Add(this.tbGiaSP);
            this.groupBoxThongTinSP.Controls.Add(this.tbTenSP);
            this.groupBoxThongTinSP.Controls.Add(this.tbMaSP);
            this.groupBoxThongTinSP.Controls.Add(this.tbMaNCC);
            this.groupBoxThongTinSP.Controls.Add(this.label5);
            this.groupBoxThongTinSP.Controls.Add(this.label4);
            this.groupBoxThongTinSP.Controls.Add(this.label2);
            this.groupBoxThongTinSP.Controls.Add(this.label1);
            this.groupBoxThongTinSP.Location = new System.Drawing.Point(13, 7);
            this.groupBoxThongTinSP.Name = "groupBoxThongTinSP";
            this.groupBoxThongTinSP.Size = new System.Drawing.Size(302, 155);
            this.groupBoxThongTinSP.TabIndex = 11;
            this.groupBoxThongTinSP.TabStop = false;
            this.groupBoxThongTinSP.Text = "Thông tin SP";
            // 
            // groupBoxMoTa
            // 
            this.groupBoxMoTa.Controls.Add(this.tbMoTa);
            this.groupBoxMoTa.Location = new System.Drawing.Point(349, 55);
            this.groupBoxMoTa.Name = "groupBoxMoTa";
            this.groupBoxMoTa.Size = new System.Drawing.Size(441, 107);
            this.groupBoxMoTa.TabIndex = 12;
            this.groupBoxMoTa.TabStop = false;
            this.groupBoxMoTa.Text = "Mô tả";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnXoa);
            this.groupBoxChucNang.Controls.Add(this.btnSua);
            this.groupBoxChucNang.Location = new System.Drawing.Point(349, 7);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(441, 47);
            this.groupBoxChucNang.TabIndex = 13;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(226, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(91, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DSSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 508);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxMoTa);
            this.Controls.Add(this.groupBoxThongTinSP);
            this.Controls.Add(this.dtgv_SanPham);
            this.MaximizeBox = false;
            this.Name = "DSSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSSanPham";
            this.Load += new System.EventHandler(this.DSSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SanPham)).EndInit();
            this.groupBoxThongTinSP.ResumeLayout(false);
            this.groupBoxThongTinSP.PerformLayout();
            this.groupBoxMoTa.ResumeLayout(false);
            this.groupBoxMoTa.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaNCC;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.TextBox tbGiaSP;
        private System.Windows.Forms.DataGridView dtgv_SanPham;
        private System.Windows.Forms.GroupBox groupBoxThongTinSP;
        private System.Windows.Forms.GroupBox groupBoxMoTa;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn sThongTinCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_sMaNCC;
    }
}