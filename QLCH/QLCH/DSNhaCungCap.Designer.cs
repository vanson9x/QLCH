namespace QLCH
{
    partial class DSNhaCungCap
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaNCC = new System.Windows.Forms.TextBox();
            this.tbTenNCC = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbHotline = new System.Windows.Forms.TextBox();
            this.groupboxThongTinNCC = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtgv_NCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxThongTinNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hotline";
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.Location = new System.Drawing.Point(56, 18);
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.Size = new System.Drawing.Size(129, 20);
            this.tbMaNCC.TabIndex = 5;
            // 
            // tbTenNCC
            // 
            this.tbTenNCC.Location = new System.Drawing.Point(56, 49);
            this.tbTenNCC.Name = "tbTenNCC";
            this.tbTenNCC.Size = new System.Drawing.Size(129, 20);
            this.tbTenNCC.TabIndex = 6;
            this.tbTenNCC.TextChanged += new System.EventHandler(this.tbTenNCC_TextChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(56, 80);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(129, 20);
            this.tbDiaChi.TabIndex = 7;
            this.tbDiaChi.TextChanged += new System.EventHandler(this.tbDiaChi_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(56, 111);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(129, 20);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbHotline
            // 
            this.tbHotline.Location = new System.Drawing.Point(56, 142);
            this.tbHotline.Name = "tbHotline";
            this.tbHotline.Size = new System.Drawing.Size(129, 20);
            this.tbHotline.TabIndex = 9;
            this.tbHotline.TextChanged += new System.EventHandler(this.tbHotline_TextChanged);
            // 
            // groupboxThongTinNCC
            // 
            this.groupboxThongTinNCC.Controls.Add(this.tbHotline);
            this.groupboxThongTinNCC.Controls.Add(this.tbEmail);
            this.groupboxThongTinNCC.Controls.Add(this.tbDiaChi);
            this.groupboxThongTinNCC.Controls.Add(this.tbTenNCC);
            this.groupboxThongTinNCC.Controls.Add(this.tbMaNCC);
            this.groupboxThongTinNCC.Controls.Add(this.label5);
            this.groupboxThongTinNCC.Controls.Add(this.label4);
            this.groupboxThongTinNCC.Controls.Add(this.label3);
            this.groupboxThongTinNCC.Controls.Add(this.label2);
            this.groupboxThongTinNCC.Controls.Add(this.label1);
            this.groupboxThongTinNCC.Location = new System.Drawing.Point(7, 11);
            this.groupboxThongTinNCC.Name = "groupboxThongTinNCC";
            this.groupboxThongTinNCC.Size = new System.Drawing.Size(186, 164);
            this.groupboxThongTinNCC.TabIndex = 10;
            this.groupboxThongTinNCC.TabStop = false;
            this.groupboxThongTinNCC.Text = "Thông tin";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(63, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 28);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtgv_NCC
            // 
            this.dtgv_NCC.AllowUserToAddRows = false;
            this.dtgv_NCC.AllowUserToDeleteRows = false;
            this.dtgv_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgv_NCC.Location = new System.Drawing.Point(199, 12);
            this.dtgv_NCC.Name = "dtgv_NCC";
            this.dtgv_NCC.ReadOnly = true;
            this.dtgv_NCC.Size = new System.Drawing.Size(712, 487);
            this.dtgv_NCC.TabIndex = 12;
            this.dtgv_NCC.Click += new System.EventHandler(this.dtgv_NCC_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sMaNCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sTenNCC";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sDiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sEmail";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SHotLine";
            this.Column5.HeaderText = "Hotline";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DSNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 500);
            this.Controls.Add(this.dtgv_NCC);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupboxThongTinNCC);
            this.MaximizeBox = false;
            this.Name = "DSNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.DSNhaCungCap_Load);
            this.groupboxThongTinNCC.ResumeLayout(false);
            this.groupboxThongTinNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaNCC;
        private System.Windows.Forms.TextBox tbTenNCC;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbHotline;
        private System.Windows.Forms.GroupBox groupboxThongTinNCC;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dtgv_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}