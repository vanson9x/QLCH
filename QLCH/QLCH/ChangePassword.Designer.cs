namespace QLCH
{
    partial class ChangePassword
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMkCu = new System.Windows.Forms.TextBox();
            this.tbMkMoi = new System.Windows.Forms.TextBox();
            this.tbLaiMk = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(28, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(70, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Mật khẩu cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // tbMkCu
            // 
            this.tbMkCu.Location = new System.Drawing.Point(128, 23);
            this.tbMkCu.Name = "tbMkCu";
            this.tbMkCu.PasswordChar = '*';
            this.tbMkCu.Size = new System.Drawing.Size(160, 20);
            this.tbMkCu.TabIndex = 3;
            // 
            // tbMkMoi
            // 
            this.tbMkMoi.Location = new System.Drawing.Point(128, 50);
            this.tbMkMoi.Name = "tbMkMoi";
            this.tbMkMoi.PasswordChar = '*';
            this.tbMkMoi.Size = new System.Drawing.Size(160, 20);
            this.tbMkMoi.TabIndex = 4;
            // 
            // tbLaiMk
            // 
            this.tbLaiMk.Location = new System.Drawing.Point(128, 77);
            this.tbLaiMk.Name = "tbLaiMk";
            this.tbLaiMk.PasswordChar = '*';
            this.tbLaiMk.Size = new System.Drawing.Size(160, 20);
            this.tbLaiMk.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(128, 121);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Thay đổi";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 156);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbLaiMk);
            this.Controls.Add(this.tbMkMoi);
            this.Controls.Add(this.tbMkCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Name = "ChangePassword";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMkCu;
        private System.Windows.Forms.TextBox tbMkMoi;
        private System.Windows.Forms.TextBox tbLaiMk;
        private System.Windows.Forms.Button btnOk;
    }
}