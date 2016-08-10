namespace QLCH
{
    partial class FrmTKBanHang
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
            this.crystalReportViewerTKBanHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonKoLoc = new System.Windows.Forms.RadioButton();
            this.lbNhapthoigian = new System.Windows.Forms.Label();
            this.tbThoiGian = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lbThongBaoThoiGian = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewerTKBanHang
            // 
            this.crystalReportViewerTKBanHang.ActiveViewIndex = -1;
            this.crystalReportViewerTKBanHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTKBanHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTKBanHang.Location = new System.Drawing.Point(-1, 43);
            this.crystalReportViewerTKBanHang.Name = "crystalReportViewerTKBanHang";
            this.crystalReportViewerTKBanHang.Size = new System.Drawing.Size(977, 633);
            this.crystalReportViewerTKBanHang.TabIndex = 0;
            this.crystalReportViewerTKBanHang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lọc theo";
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.Location = new System.Drawing.Point(62, 16);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(56, 17);
            this.radioButtonThang.TabIndex = 2;
            this.radioButtonThang.Text = "Tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            this.radioButtonThang.CheckedChanged += new System.EventHandler(this.radioButtonThang_CheckedChanged);
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Location = new System.Drawing.Point(6, 16);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(50, 17);
            this.radioButtonNgay.TabIndex = 3;
            this.radioButtonNgay.Text = "Ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            this.radioButtonNgay.CheckedChanged += new System.EventHandler(this.radioButtonNgay_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonKoLoc);
            this.groupBox1.Controls.Add(this.radioButtonThang);
            this.groupBox1.Controls.Add(this.radioButtonNgay);
            this.groupBox1.Location = new System.Drawing.Point(89, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 39);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonKoLoc
            // 
            this.radioButtonKoLoc.AutoSize = true;
            this.radioButtonKoLoc.Checked = true;
            this.radioButtonKoLoc.Location = new System.Drawing.Point(119, 16);
            this.radioButtonKoLoc.Name = "radioButtonKoLoc";
            this.radioButtonKoLoc.Size = new System.Drawing.Size(55, 17);
            this.radioButtonKoLoc.TabIndex = 4;
            this.radioButtonKoLoc.TabStop = true;
            this.radioButtonKoLoc.Text = "Ko lọc";
            this.radioButtonKoLoc.UseVisualStyleBackColor = true;
            this.radioButtonKoLoc.CheckedChanged += new System.EventHandler(this.radioButtonKoLoc_CheckedChanged);
            // 
            // lbNhapthoigian
            // 
            this.lbNhapthoigian.AutoSize = true;
            this.lbNhapthoigian.Location = new System.Drawing.Point(273, 9);
            this.lbNhapthoigian.Name = "lbNhapthoigian";
            this.lbNhapthoigian.Size = new System.Drawing.Size(63, 13);
            this.lbNhapthoigian.TabIndex = 5;
            this.lbNhapthoigian.Text = "Nhập tháng";
            // 
            // tbThoiGian
            // 
            this.tbThoiGian.Location = new System.Drawing.Point(342, 6);
            this.tbThoiGian.Name = "tbThoiGian";
            this.tbThoiGian.Size = new System.Drawing.Size(100, 20);
            this.tbThoiGian.TabIndex = 6;
            this.tbThoiGian.TextChanged += new System.EventHandler(this.tbThoiGian_TextChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(448, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(62, 23);
            this.btnLoc.TabIndex = 7;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lbThongBaoThoiGian
            // 
            this.lbThongBaoThoiGian.AutoSize = true;
            this.lbThongBaoThoiGian.BackColor = System.Drawing.SystemColors.Control;
            this.lbThongBaoThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lbThongBaoThoiGian.Location = new System.Drawing.Point(341, 27);
            this.lbThongBaoThoiGian.Name = "lbThongBaoThoiGian";
            this.lbThongBaoThoiGian.Size = new System.Drawing.Size(108, 13);
            this.lbThongBaoThoiGian.TabIndex = 8;
            this.lbThongBaoThoiGian.Text = "lbThongBaoThoiGian";
            // 
            // FrmTKBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 675);
            this.Controls.Add(this.lbThongBaoThoiGian);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.tbThoiGian);
            this.Controls.Add(this.lbNhapthoigian);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewerTKBanHang);
            this.Name = "FrmTKBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kế bán hàng";
            this.Load += new System.EventHandler(this.FrmTKBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTKBanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.RadioButton radioButtonNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNhapthoigian;
        private System.Windows.Forms.TextBox tbThoiGian;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lbThongBaoThoiGian;
        private System.Windows.Forms.RadioButton radioButtonKoLoc;
    }
}