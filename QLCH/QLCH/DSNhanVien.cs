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
    public partial class DSNhanVien : Form
    {
        string query="";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);

        public DSNhanVien()
        {
            InitializeComponent();
        }

        private void DSNhanVien_Load(object sender, EventArgs e)
        {
            query = "Select sTenNV,sChucVu,sDiaChi,sEmail,sSDT from tbl_NhanVien";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            sda.Fill(table);
            DGView_NhanVien.DataSource = table;
            conn.Close();
        }
    }
}
