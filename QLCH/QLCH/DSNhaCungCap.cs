using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLCH
{
    public partial class DSNhaCungCap : Form
    {
        bool bTenNCC, bDiaChi, bEmail, bHotline;
        string query = "";
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);

        public DSNhaCungCap()
        {
            InitializeComponent();
        }

        private void DSNhaCungCap_Load(object sender, EventArgs e)
        {
            groupboxThongTinNCC.Enabled = false;
            btnEmpty.Enabled = false;
            btnSua.Enabled = false;

            LoadDataGriptView();
            if (Program.user == "admin")
            {
                groupboxThongTinNCC.Enabled = true;
            }
        }

        private void LoadDataGriptView()
        {
            query = "select  * from tbl_NhaCungCap";
            cmd = new SqlCommand(query, conn);
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                using (DataTable table = new DataTable())
                {
                    adapter.Fill(table);
                    dtgv_NCC.DataSource = table;
                }
            }
        }

        private void LoadTextFromDTGVToTextBox()
        {
            try
            {
                tbMaNCC.Text = dtgv_NCC.CurrentRow.Cells[0].Value.ToString();
                tbTenNCC.Text = dtgv_NCC.CurrentRow.Cells[1].Value.ToString();
                tbDiaChi.Text = dtgv_NCC.CurrentRow.Cells[2].Value.ToString();
                tbEmail.Text = dtgv_NCC.CurrentRow.Cells[3].Value.ToString();
                tbHotline.Text = dtgv_NCC.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không có trường nào được chọn");
            }
        }

        private void dtgv_NCC_Click(object sender, EventArgs e)
        {
            LoadTextFromDTGVToTextBox();
            tbMaNCC.Enabled = false;
            tbTenNCC.Enabled = true;
            tbDiaChi.Enabled = true;
            tbEmail.Enabled = true;
            tbHotline.Enabled = true;
            btnSua.Enabled = false;
            if (Program.user == "admin")
            {
                btnEmpty.Enabled = true;
            }
        }

        private void CheckTextChange()
        {
            if (bTenNCC || bDiaChi || bEmail || bHotline)
            {
                btnSua.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
            }
        }

        private Boolean check_Empty()
        {
            bool check = true;
            if (tbTenNCC.Text.Length == 0 || tbDiaChi.Text.Length == 0 || tbEmail.Text.Length == 0 || tbHotline.Text.Length == 0)
            {
                check = false;
            }
            return check;
        }

        private void AnHienBtnSua()
        {
            string tenhientai = dtgv_NCC.CurrentRow.Cells[1].Value.ToString();
            bTenNCC = tbTenNCC.Text == tenhientai ? false : true;
            string diachihientai = dtgv_NCC.CurrentRow.Cells[2].Value.ToString();
            bDiaChi = tbDiaChi.Text == diachihientai ? false : true;
            string emailhientai = dtgv_NCC.CurrentRow.Cells[3].Value.ToString();
            bEmail = tbEmail.Text == emailhientai ? false : true;
            string hotlinehientai = dtgv_NCC.CurrentRow.Cells[4].Value.ToString();
            bHotline = tbHotline.Text == hotlinehientai ? false : true;
            CheckTextChange();
        }

        private void tbTenNCC_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void tbHotline_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check_Empty())
            {
                query = "SP_SuaNCC";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sMaNCC", dtgv_NCC.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@sTenNCC", tbTenNCC.Text);
                cmd.Parameters.AddWithValue("@sDiaChi", tbDiaChi.Text);
                cmd.Parameters.AddWithValue("@sEmail", tbEmail.Text);
                cmd.Parameters.AddWithValue("@SHotLine", tbHotline.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                conn.Close();
                LoadDataGriptView();
            }
            else
            {
                MessageBox.Show("Các trường ko được bỏ trống", "Thông báo");
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            tbTenNCC.Text = "";
            tbDiaChi.Text = "";
            tbEmail.Text = "";
            tbHotline.Text = "";
        }


    }
}
