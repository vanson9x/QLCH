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
using CrystalDecisions.CrystalReports.Engine;

namespace QLCH
{
    public partial class rptNhapHangView : Form
    {
        public string maPN;
        string connect = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
        CrystalDecisions.CrystalReports.Engine.TextObject textobject;
        rptNhapHang rptNH = new rptNhapHang();
        DSReport data = new DSReport();
        DataTable table;

        public rptNhapHangView()
        {
            InitializeComponent();
        }

        //Ten nhan vien nhap phieu
        private string getNameNV()
        {
            string name = "";
            using(SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(string.Format("Select sTenNV from tbl_NhanVien as NV join tbl_PhieuNhap as PN On NV.sMaNV = PN.FK_sMaNV Where PN.sMaPN = '{0}'",maPN), conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                try {
                    sdr.Read();
                    name = sdr.GetString(0);
                }
                catch { }
            }
            return name;
        }

        //Lay ngay lap phieu
        private string getDatePN()
        {
            string datetime = "";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(string.Format("Select dNgayLap From tbl_PhieuNhap Where sMaPN = '{0}'", maPN), conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {
                    sdr.Read();
                    datetime = sdr.GetDateTime(0).ToString().Substring(0,10);
                }
                catch { }
            }
            return datetime;
        }

        //Lay ten san pham , so luong, gia thanh 
        private void InsertDataReportDetail(string maCTPN)
        {
            using(SqlConnection conn= new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(string.Format("Select sTenSP,iSoLuong,fThanhTien From tbl_CTPhieuNhap as CTPN join tbl_SanPham as SP On CTPN.FK_sMaSP = SP.sMaSP Where CTPN.sMaCTPN = '{0}'",maCTPN),conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {
                    sdr.Read();
                    table.Rows.Add(sdr.GetString(0),sdr.GetInt32(1),sdr.GetDouble(2));
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private double getTongTien()
        {
            double sum = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                sum += Convert.ToDouble(table.Rows[i][2].ToString());
            }
            return sum;
        }

        //Event Load Form
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            table = data.Tables[0];
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(string.Format("Select FK_sMaCTPN From tbl_PhieuNhap Where sMaPN = '{0}'",maPN), conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    InsertDataReportDetail(sdr.GetString(0));
                }
            }

            //Set value ma phieu nhap
            textobject = rptNH.ReportDefinition.ReportObjects["tobMaPN"] as TextObject;
            textobject.Text = maPN;
            //set value nguoi lap phieu nhap
            textobject = rptNH.ReportDefinition.ReportObjects["tobNguoiLap"] as TextObject;
            textobject.Text = getNameNV();
            //set value  ngay lap
            textobject = rptNH.ReportDefinition.ReportObjects["tobNgayLap"] as TextObject;
            textobject.Text = getDatePN();
            //set value so luong
            textobject = rptNH.ReportDefinition.ReportObjects["tobSoLuong"] as TextObject;
            textobject.Text = table.Rows.Count.ToString();
            //set value tong tien
            textobject = rptNH.ReportDefinition.ReportObjects["tobTongTien"] as TextObject;
            textobject.Text = getTongTien().ToString();
            //set value date
            textobject = rptNH.ReportDefinition.ReportObjects["tobDate"] as TextObject;
            string date = DateTime.Now.ToString().Substring(0, 10);
            textobject.Text = string.Format("Hà nội, ngày {0}, tháng {1}, năm {2}.",date.Substring(0,2),date.Substring(3,2),date.Substring(6,4));

            //set DataSource for rptNhapHang
            rptNH.SetDataSource(table);

            //set DataSource ror rptNhapHangView
            this.crystalReportViewer1.ReportSource = rptNH;
            this.Refresh();

        }
    }
}
