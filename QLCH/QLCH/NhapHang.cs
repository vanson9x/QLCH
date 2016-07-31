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
    public partial class NhapHang : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);
        SqlCommand cmd;
        string maPN, maNCC, maSP, maCTPN;
        SqlTransaction sqlTran;

        //DataSource
        DataTable NCC, SP;

        public NhapHang()
        {
            InitializeComponent();
        }

        // // INSERT  INTO tbl_NhaCungCap
        private void InsertNCC()
        {
            if (!rbNcc.Checked)
            {
                string query = "SP_InsertNCC";
                cmd.CommandText = query;
                maNCC = "NCC" + NCC.Rows.Count.ToString();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ma", maNCC);
                cmd.Parameters.AddWithValue("@ten", tbTenCty.Text);
                cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@hotline", tbLienhe.Text);
                cmd.ExecuteNonQuery();
                NCC.Rows.Add(maNCC);
                cbNcc.Refresh();
            }
        }

        // INSERT  INTO tbl_SanPham
        private void InsertSanPham()
        {
            if (!rbSp.Checked)
            {
                string query = "SP_ThemSanPham";
                cmd.CommandText = query;
                maSP = tbMaSp.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sMaSP", maSP);
                cmd.Parameters.AddWithValue("@sTenSP", tbTenSp.Text);
                cmd.Parameters.AddWithValue("@sThongTinCT", rtbThongtin.Text);
                cmd.Parameters.AddWithValue("@fGia", (float)Convert.ToDouble(tbGia.Text));
                cmd.Parameters.AddWithValue("@FK_sMaNCC", rbNcc.Checked ? cbNcc.Text : maNCC);
                cmd.ExecuteNonQuery();
                SP.Rows.Add(maSP);
                cbSp.Refresh();
            } 
        }

        // INSERT  INTO tbl_CTPhieuNhap
        private void InsertCTPN()
        {
            string query = "SP_InsertCTPN";
            cmd.CommandText = query;
            maCTPN = "CTPN" + LoadData("Select * from tbl_CTPhieuNhap").Rows.Count.ToString();
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@maCTPN", maCTPN);
            cmd.Parameters.AddWithValue("@maSP", rbSp.Checked ? cbSp.Text : maSP);
            cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(tbSoluong.Text));
            cmd.ExecuteNonQuery();
            
        }

        // INSERT  INTO tbl_PhieuNhap
        private void InsertPN()
        {
            string query = "SP_InsertPN";
            cmd.CommandText = query;
            string tenPN="";
            if (rbSp.Checked)
            {
                using (SqlConnection conn2 = new SqlConnection(conn.ConnectionString))
                {
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(string.Format("Select sTenSP from tbl_SanPham WHERE sMaSP = '{0}'", cbSp.Text), conn2);
                    SqlDataReader sdr = cmd2.ExecuteReader();
                    sdr.Read();
                    tenPN = sdr.GetString(0);
                    tenPN = "Nhập kho " + tenPN + " || Số lượng: " + tbSoluong.Text;
                }
                
            }
            else
            {
                tenPN = "Nhập kho " + tbTenSp.Text + " || Số lượng: " + tbSoluong.Text  ;
            }

            cmd.Parameters.Clear(); // lam sach
            cmd.Parameters.AddWithValue("@maPN", maPN);
            cmd.Parameters.AddWithValue("@ten", tenPN);
            cmd.Parameters.AddWithValue("@maCTPN", maCTPN);
            cmd.Parameters.AddWithValue("@maNV", Program.user);
            cmd.ExecuteNonQuery();
                
        }

        //--------------- END Change Database ------------------

        private DataTable LoadData(string query)
        {
            using(SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString))
            {
                DataTable table = new DataTable();
                conn2.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn2);
                sda.Fill(table);
                conn2.Close();
                return table;
            }
            
        }

        //Event Change checked radioButton
        private void rbNcc_CheckedChanged(object sender, EventArgs e)
        {
            gbNewNcc.Enabled = !rbNcc.Checked;
            if (rbNcc.Checked)
                cbNcc.Enabled = true;
        }

        private void rbNewNcc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewNcc.Checked)
                cbNcc.Enabled = false;
        }

        private void rbSp_CheckedChanged(object sender, EventArgs e)
        {
            gbNewSp.Enabled = !rbSp.Checked;
            if (rbSp.Checked)
                cbSp.Enabled = true;
        }

        private void rbNewSp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewSp.Checked)
                cbSp.Enabled = false;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            sqlTran = conn.BeginTransaction();
            cmd.Connection = conn;
            cmd.Transaction = sqlTran;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                InsertNCC();
                InsertSanPham();
                InsertCTPN();
                InsertPN();
                sqlTran.Commit(); //chap nhan cac thay doi 
                MessageBox.Show("Thành công !");
                tbSoluong.Text = "";
                if (rbNcc.Checked)
                    tbTenCty.Text = tbDiachi.Text = tbEmail.Text = tbLienhe.Text = "";
                if (rbSp.Checked)
                    tbMaSp.Text = tbTenSp.Text = rtbThongtin.Text = tbGia.Text = "";
                
                conn.Close();
            }
            catch(Exception ex)
            {
                try { sqlTran.Rollback(); } catch{ }
                MessageBox.Show("Lỗi !\n"+ex.Message);
                conn.Close();
            }
            
        }

        //Event load form
        private void NhapHang_Load(object sender, EventArgs e)
        {
            maPN = "PN" + LoadData("Select sMaPN from tbl_PhieuNhap").Rows.Count.ToString();
            //Load Data into ComboBox Nhà cung cấp
            NCC = LoadData("Select sMaNCC From tbl_NhaCungCap");
            cbNcc.DataSource = NCC;
            cbNcc.DisplayMember = "sMaNCC";
            //Load Data into ComboBox sản phẩm
            SP = LoadData("Select sMaSP From tbl_SanPham");
            cbSp.DataSource = SP;
            cbSp.DisplayMember = "sMaSP";

        }
    }
}
