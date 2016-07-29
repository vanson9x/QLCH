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
    public partial class DSSanPham : Form
    {
        bool bTenSP, bMoTa, bGia, bMaNCC;
        string query = "";
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);

        public DSSanPham()
        {
            InitializeComponent();
        }

        private void CheckTextChange()
        {
            if (bTenSP || bMoTa || bGia || bMaNCC)
            {
                btnSua.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
            }
        }

        private void DSSanPham_Load(object sender, EventArgs e)
        {
            groupBoxMoTa.Enabled = false;
            groupBoxChucNang.Enabled = false;
            groupBoxThongTinSP.Enabled = false;
            LoadDataGripView();
            if (Program.user == "admin")
            {
                groupBoxChucNang.Enabled = true;
                groupBoxThongTinSP.Enabled = true;
                groupBoxMoTa.Enabled = true;
            }
        }

        private void LoadDataGripView()
        {
            query = "select  * from tbl_SanPham";
            cmd = new SqlCommand(query, conn);
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                using (DataTable table = new DataTable())
                {
                    adapter.Fill(table);
                    dtgv_SanPham.DataSource = table;
                }
            }
        }

        private Boolean check_Empty()
        {
            bool check = true;
            if (tbMaSP.Text.Length == 0 || tbTenSP.Text.Length == 0 || tbGiaSP.Text.Length == 0 || tbMoTa.Text.Length == 0 || tbMaNCC.Text.Length == 0)
            {
                check = false;
            }
            return check;
        }

        private Boolean checkMaNCC()
        {
            bool check = false;
            string maNCC = tbMaNCC.Text;
            query = "select * from tbl_NhaCungCap where sMaNCC = '" + maNCC + "'";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.GetString(0).Equals(maNCC))
                    {
                        check = true;
                    }
                }
            }
            conn.Close();
            return check;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkMaNCC())
            {
                if (check_Empty())
                {
                    string maSP = tbMaSP.Text;
                    string tenSP = tbTenSP.Text;
                    string motaSP = tbMoTa.Text;
                    float giaSP = float.Parse(tbGiaSP.Text);
                    string maNCC = tbMaNCC.Text;
                    query = "SP_UpdateSanPham";
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSP", dtgv_SanPham.CurrentRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sTenSP", tenSP);
                    cmd.Parameters.AddWithValue("@sThongTinCT", motaSP);
                    cmd.Parameters.AddWithValue("@fGia", giaSP);
                    cmd.Parameters.AddWithValue("@FK_sMaNCC", maNCC);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    conn.Close();
                    LoadDataGripView();
                }
                else
                {
                    MessageBox.Show("Các trường ko được bỏ trống", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã nhà cung cấp", "Lỗi mã nhà cung cấp");
            }
        }

        private void LoadTextFromDTGVToTextBox()
        {
            try
            {
                tbMaSP.Text = dtgv_SanPham.CurrentRow.Cells[0].Value.ToString();
                tbTenSP.Text = dtgv_SanPham.CurrentRow.Cells[1].Value.ToString();
                tbMoTa.Text = dtgv_SanPham.CurrentRow.Cells[2].Value.ToString();
                tbGiaSP.Text = dtgv_SanPham.CurrentRow.Cells[3].Value.ToString();
                tbMaNCC.Text = dtgv_SanPham.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không có trường nào được chọn");
            }
        }

        private void dtgv_SanPham_Click(object sender, EventArgs e)
        {
            LoadTextFromDTGVToTextBox();
            tbMaNCC.Enabled = true;
            tbMaSP.Enabled = false;
            tbTenSP.Enabled = true;
            tbGiaSP.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                query = "SP_XoaSanPham";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sMaSP", dtgv_SanPham.CurrentRow.Cells[0].Value.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                LoadDataGripView();
                conn.Close();
            }
        }

        private void AnHienBtnSua()
        { 
            string mahientai = dtgv_SanPham.CurrentRow.Cells[4].Value.ToString();
            bMaNCC = tbMaNCC.Text == mahientai ? false : true;
            string tenhientai = dtgv_SanPham.CurrentRow.Cells[1].Value.ToString();
            bTenSP = tbTenSP.Text == tenhientai ? false : true;
            string giahientai = dtgv_SanPham.CurrentRow.Cells[3].Value.ToString();
            bGia = tbGiaSP.Text == giahientai ? false : true;
            string motahientai = dtgv_SanPham.CurrentRow.Cells[2].Value.ToString();
            bMoTa = tbMoTa.Text == motahientai ? false : true;
            CheckTextChange();
        }

        private void tbMaNCC_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void tbTenSP_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void tbGiaSP_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void tbMoTa_TextChanged(object sender, EventArgs e)
        {
            AnHienBtnSua();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            tbMaSP.Text = "";
            tbTenSP.Text = "";
            tbGiaSP.Text = "";
            tbMaNCC.Text = "";
            tbMoTa.Text = "";
        }


    }
}

