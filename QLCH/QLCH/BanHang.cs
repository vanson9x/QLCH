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
    public partial class BanHang : Form
    {
        string connect = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlTransaction sqlTran;

        String maBH, maKH, maCTHD, maHD;

        public BanHang()
        {
            InitializeComponent();
        }

        //Them khach hang
        private void InsertKH()
        {
            maKH = "KH" + CountColumns("SELECT * FROM tbl_KhachHang").ToString();
            cmd.CommandText = "SP_InsertKhachHang";
            cmd.Parameters.Clear(); //clear
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@ten", tbTenKH.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
            cmd.Parameters.AddWithValue("@sdt", tbSdt.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            cmd.ExecuteNonQuery();
        }

        //Them bao hanh
        private void InsertBH()
        {
            maBH = "BH" + CountColumns("SELECT * FROM tbl_BaoHanh").ToString();
            cmd.CommandText = "SP_InsertBaoHanh";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@maBH", maBH);
            cmd.Parameters.AddWithValue("@thoihan", Convert.ToInt32(tbTgBH.Text));
            cmd.ExecuteNonQuery();
        }

        //Them chi tiet hoa don
        private void InsertCTHD()
        {
            maCTHD = "CTHD" + CountColumns("SELECT * FROM tbl_CTHoaDon").ToString();
            cmd.CommandText = "SP_InsertCTHD";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@maCTHD", maCTHD);
            cmd.Parameters.AddWithValue("@maSP", cbMaSP.Enabled ? cbMaSP.Text : tbMaSP.Text);
            cmd.Parameters.AddWithValue("@maBH", maBH);
            cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(tbSoluong.Text));
            cmd.ExecuteNonQuery();
        }

        //Them hoa don
        private void InsertHD()
        {
            cmd.CommandText = "SP_InsertHD";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@maHD", maHD);
            cmd.Parameters.AddWithValue("@tenHD", lbTenSP.Text);
            cmd.Parameters.AddWithValue("@maCTHD", maCTHD);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@maNV", Program.user);
            cmd.ExecuteNonQuery();
        }

        //Dem so dong du lieu trong Table
        private int CountColumns(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(table);
                conn.Close();
            }
            return table.Rows.Count;
        }

        private void tbMaSP_TextChanged(object sender, EventArgs e)
        {
            cbMaSP.Enabled = tbMaSP.Text.Trim() != "" ? false : true;
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(string.Format("Select sTenSP FROM tbl_SanPham WHERE sMaSP = '{0}'",tbMaSP.Text), conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    lbTenSP.Text = sdr.GetString(0);
                }
                catch{ lbTenSP.Text = "Không có sản phẩm nào"; }
            }
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaSP.Text = "";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(string.Format("Select sTenSP FROM tbl_SanPham WHERE sMaSP = '{0}'",cbMaSP.Text), conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    lbTenSP.Text = sdr.GetString(0);
                }
                catch { lbTenSP.Text = "Không có sản phẩm nào"; }
            }
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = "Select sMaSP From tbl_SanPham";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable table = new DataTable();
                sda.Fill(table);
                cbMaSP.DataSource = table;
                cbMaSP.DisplayMember = "sMaSP";
            }

            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = "Select * From tbl_HoaDon";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                sda.Fill(table);
                maHD = "HD" + table.Rows.Count.ToString();
            }
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connect);
            conn.Open();
            cmd = conn.CreateCommand();
            sqlTran = conn.BeginTransaction();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = sqlTran;

            try
            {
                if (gbKH.Enabled)
                    InsertKH();
                InsertBH();
                InsertCTHD();
                InsertHD();
                 
                sqlTran.Commit();
                gbKH.Enabled = false; //khoa khach hang lai
                tbMaSP.Text = lbTenSP.Text = tbSoluong.Text = tbTgBH.Text = "";
                conn.Close();
            }catch(Exception ex)
            {
                try { sqlTran.Rollback(); } catch { }
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
