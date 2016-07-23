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
    public partial class Login : Form
    {
        //Thiet lap doi tuong Sql
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);
        SqlCommand cmd;
        string query;
        //END
        
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_Account WHERE FK_sID = '"+tbUser.Text+"' AND sPassword = '"+tbPassword.Text+"'";
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Program.user = sdr.GetString(0);
                //new Form show
                MessageBox.Show("Đăng nhập thành công !");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                tbUser.Text = tbPassword.Text = "";
            }
            cmd = null; //gia phong data doi tuong
            conn.Close();
        }
    }
}
