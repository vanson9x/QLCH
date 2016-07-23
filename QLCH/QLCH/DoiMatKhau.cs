using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLCH
{
    public partial class DoiMatKhau : Form
    {
        string query = "";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);
        SqlCommand cmd;

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.CheckEmpty())
                if (this.CheckKind())
                    if (this.CheckPassword())
                    {
                        query = "SP_UpdateAccount";
                        cmd = new SqlCommand(query, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", Program.user);
                        cmd.Parameters.AddWithValue("@Pass", tbMkMoi.Text);
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            this.Close();
                        }
                        conn.Close();
                    }
        }

        private bool CheckEmpty()
        {
            if (tbMkCu.Text == "" || tbMkMoi.Text == "" || tbLaiMk.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mục nào !");
                return true;
            }
            else
                return false;
        }

        private bool CheckKind()
        {
            if(!(tbLaiMk.Text == tbMkMoi.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp.");
                return false;
            }
            return true;
        }

        private bool CheckPassword()
        {
            query = "Select sPassword From tbl_Account WHERE FK_sID = '"+Program.user+"'";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            cmd = null;

            sdr.Read();
            if (sdr.GetString(0) == tbMkCu.Text)
                return true;
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
            conn.Close();
            return false;
        }
    }
}
