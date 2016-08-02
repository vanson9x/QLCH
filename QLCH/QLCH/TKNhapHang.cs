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
    public partial class TKNhapHang : Form
    {
        string connect = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
        DataTable table = new DataTable();

        public TKNhapHang()
        {
            InitializeComponent();
        }

        // Load DataGridView
        private void LoadDataGridView()
        {
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string timeBegin, timeEnd;
                timeBegin = dtpBegin.Value.ToString().Substring(0, 10);
                timeEnd = dtpEnd.Value.ToString().Substring(0, 10);
                //Format yyyy/mm/dd
                timeBegin = string.Format("{0}/{1}/{2}",timeBegin.Substring(6,4),timeBegin.Substring(3,2),timeBegin.Substring(0,2));
                timeEnd = string.Format("{0}/{1}/{2}", timeEnd.Substring(6, 4), timeEnd.Substring(3, 2), timeEnd.Substring(0, 2));

                SqlDataAdapter sda = new SqlDataAdapter(string.Format("SELECT sMaPN,sTenPN,fTongTien,dNgayLap FROM tbl_PhieuNhap WHERE (dNgayLap >= '{0}' AND dNgayLap <= '{1}')",timeBegin,timeEnd), conn);
                sda.Fill(table);

                string saveMaPN="";
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    var maPN = table.Rows[i][0] as string;
                    if (saveMaPN != maPN)
                    {
                        cbMaPN.Items.Add(maPN);
                        saveMaPN = maPN;
                    }
                        
                }

                dgvPhieuNhap.DataSource = table;
                dgvPhieuNhap.Refresh();
            }
        }

        private void TKNhapHang_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MIN(dNgayLap) FROM tbl_PhieuNhap", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {
                    sdr.Read();
                    dtpBegin.Value = sdr.GetDateTime(0);
                    LoadDataGridView();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            cbMaPN.Items.Clear();
            LoadDataGridView();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
