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
    public partial class DSKhachHang : Form
    {
        string connect = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
        DataTable table = new DataTable();
        DataRow rowSelected;

        public DSKhachHang()
        {
            InitializeComponent();
        }

        private void DSKhachHang_Load(object sender, EventArgs e)
        {
            //load datagriidview
            using (SqlConnection conn = new SqlConnection(connect))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_KhachHang", conn);
                sda.Fill(table);
                dgvKhachHang.DataSource = table;
                dgvKhachHang.Refresh();
            }

            //Disable groupbox
            groupBox1.Enabled = false;
        }

        //Function check active button Sua
        private void checkBtnSua()
        {
            try
            {
                if (tbTen.Text != rowSelected[1].ToString() || tbDiachi.Text != rowSelected[2].ToString() || tbSdt.Text != rowSelected[3].ToString() || tbEmail.Text != rowSelected[4].ToString())
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = false;
                }
                else { btnXoa.Enabled = true; }
            } catch {}
            
        }

        //Event when click into button Sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("SP_UpdateKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", tbMaKH.Text);
            cmd.Parameters.AddWithValue("@ten", tbTen.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
            cmd.Parameters.AddWithValue("@sdt", tbSdt.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công !");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Event when click into button Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("SP_DEL_KhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", tbMaKH.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !");
                tbMaKH.Text = tbTen.Text = tbDiachi.Text = tbSdt.Text = tbEmail.Text = "";
                groupBox1.Enabled = false;
                table.Rows.RemoveAt(dgvKhachHang.CurrentRow.Index);
                dgvKhachHang.Refresh();
                conn.Close();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        //Event when click cell on datagridview
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowSelected = table.Rows[e.RowIndex];
                tbMaKH.Text = rowSelected[0].ToString();
                tbTen.Text = rowSelected[1].ToString();
                tbDiachi.Text = rowSelected[2].ToString();
                tbSdt.Text = rowSelected[3].ToString();
                tbEmail.Text = rowSelected[4].ToString();

                //Enable gruopBox
                groupBox1.Enabled = true;
                //Disable Edit 
                btnSua.Enabled = false;
            }
            catch { }
            
        }

        //Event TextChange
        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {
            checkBtnSua();
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {
            checkBtnSua();
        }

        private void tbDiachi_TextChanged(object sender, EventArgs e)
        {
            checkBtnSua();
        }

        private void tbSdt_TextChanged(object sender, EventArgs e)
        {
            checkBtnSua();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            checkBtnSua();
        }
    }
}
