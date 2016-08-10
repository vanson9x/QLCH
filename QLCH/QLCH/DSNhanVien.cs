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
        SqlCommand cmd;

        Boolean bHoten, bChucvu, bDiachi, bEmail, bSdt;
        DataGridViewRow RowSelected;

        public DSNhanVien()
        {
            InitializeComponent();
        }

        private void DSNhanVien_Load(object sender, EventArgs e)
        {
            query = "Select * from tbl_NhanVien";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            sda.Fill(table);
            DGView_NhanVien.DataSource = table;
            conn.Close();

            if(Program.user == "admin")
            {
                groupBox1.Enabled = true;
            }
        }

        private void checkChanged()
        {
            if (bHoten || bChucvu || bDiachi || bEmail || bSdt)
                btnSua.Enabled = btnThem.Enabled = true;
            else
                btnSua.Enabled = btnThem.Enabled = false;
        }

        private void DGView_NhanVien_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            int index = DGView_NhanVien.CurrentRow.Index;
            RowSelected = DGView_NhanVien.Rows[index];
            tbMaNV.Text = RowSelected.Cells[0].Value.ToString();
            tbHoten.Text = RowSelected.Cells[1].Value.ToString();
            tbChucvu.Text = RowSelected.Cells[2].Value.ToString();
            tbDiachi.Text = RowSelected.Cells[3].Value.ToString();
            tbEmail.Text = RowSelected.Cells[4].Value.ToString();
            tbSdt.Text = RowSelected.Cells[5].Value.ToString();
            
            tbMaNV.Enabled = false;
            checkChanged();
        }

       
        private void SetEmpty()
        {
            tbMaNV.Enabled = true;
            tbMaNV.Text = "";
            tbHoten.Text = "";
            tbChucvu.Text = "";
            tbDiachi.Text = "";
            tbEmail.Text = "";
            tbSdt.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            query = "SP_UpdateNhanVien";
            cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maNV", RowSelected.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@ten", tbHoten.Text);
            cmd.Parameters.AddWithValue("@chucvu", tbChucvu.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            cmd.Parameters.AddWithValue("@sdt", tbSdt.Text);

            conn.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Sửa thành công !");
                int index = DGView_NhanVien.CurrentRow.Index;
                DataGridViewRow row = DGView_NhanVien.Rows[index];
                row.Cells[1].Value = tbHoten.Text;
                row.Cells[2].Value = tbChucvu.Text;
                row.Cells[3].Value = tbDiachi.Text;
                row.Cells[4].Value = tbEmail.Text;
                row.Cells[5].Value = tbSdt.Text;
                DGView_NhanVien.Refresh(); 
                this.SetEmpty();
            }
                
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(tbHoten.Text=="" || tbDiachi.Text=="" || tbChucvu.Text=="" || tbEmail.Text == "" || tbSdt.Text == "")
                MessageBox.Show("Phải điền đủ thông tin");
            else
            {
                query = "SP_InsertNhanVien";
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maNV", tbMaNV.Text);
                cmd.Parameters.AddWithValue("@ten", tbHoten.Text);
                cmd.Parameters.AddWithValue("@chucvu", tbChucvu.Text);
                cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@sdt", tbSdt.Text);

                conn.Open();
                if (cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Thêm thành công");
                    DataTable table = DGView_NhanVien.DataSource as DataTable;
                    DataRow row = table.NewRow();
                    row[0] = tbMaNV.Text;
                    row[1] = tbHoten.Text;
                    row[2] = tbChucvu.Text;
                    row[3] = tbDiachi.Text;
                    row[4] = tbEmail.Text;
                    row[5] = tbSdt.Text;
                    table.Rows.InsertAt(row,0);
                    DGView_NhanVien.Refresh();
                    RowSelected = DGView_NhanVien.Rows[0];
                    SetEmpty();
                }
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            query = "SP_DeleteNhanVien";
            cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maNV", RowSelected.Cells[0].Value.ToString());
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa thành công !");
                RowSelected = null;
                DGView_NhanVien.Rows.RemoveAt(DGView_NhanVien.CurrentRow.Index);
                btnThem.Enabled = btnSua.Enabled = true;
                DGView_NhanVien.Refresh();
                SetEmpty();
            }
            conn.Close();
        }

       
        private void btnLamRong_Click(object sender, EventArgs e)
        {
            SetEmpty();
        }

        private void tbHoten_TextChanged(object sender, EventArgs e)
        {
            if (RowSelected != null)
            {
                bHoten = tbHoten.Text == RowSelected.Cells[1].Value.ToString() ? false : true;
                checkChanged();
            }
        }

        private void tbChucvu_TextChanged(object sender, EventArgs e)
        {
            if(RowSelected != null)
            {
                bChucvu = tbChucvu.Text == RowSelected.Cells[2].Value.ToString() ? false : true;
                checkChanged();
            }
            
        }

       

        private void tbDiachi_TextChanged(object sender, EventArgs e)
        {
            if(RowSelected != null)
            {
                bDiachi = tbDiachi.Text == RowSelected.Cells[3].Value.ToString() ? false : true;
                checkChanged();
            }

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if(RowSelected != null)
            {
                bEmail = tbEmail.Text == RowSelected.Cells[4].Value.ToString() ? false : true;
                checkChanged();
            }
            
        }

        private void tbSdt_TextChanged(object sender, EventArgs e)
        {
            if(RowSelected != null)
            {
                bSdt = tbSdt.Text == RowSelected.Cells[5].Value.ToString() ? false : true;
                checkChanged();
            }
            
        }

    }
}
