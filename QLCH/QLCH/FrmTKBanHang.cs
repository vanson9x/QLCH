using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;

namespace QLCH
{
    public partial class FrmTKBanHang : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
        CrystalReportTKBanHang cry = new CrystalReportTKBanHang();

        public FrmTKBanHang()
        {
            InitializeComponent();
        }

        private void FrmTKBanHang_Load(object sender, EventArgs e)
        {
            lbThongBaoThoiGian.Text = "";
            //cry.Load(@"C:\Users\anhsachxx\Documents\QLCH\QLCH\QLCH\CrystalReportTKBanHang.rpt");
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("dbo.TKBanHang", conn))
                {
                    //sda.SelectCommand.CommandType = CommandType.Text;
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet st = new DataSet();
                    sda.Fill(st, "DataTable1");
                    cry.SetDataSource(st);
                    crystalReportViewerTKBanHang.ReportSource = cry;
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbThoiGian.Text.Equals(""))
                {
                    lbThongBaoThoiGian.Text = "Nhập dữ liệu thời gian trước";
                }
                //cry.Load(@"C:\Users\anhsachxx\Documents\QLCH\QLCH\QLCH\CrystalReportTKBanHang.rpt");
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SP_TKBANHANGTHEOTHOIGIAN", conn))
                    {
                        //sda.SelectCommand.CommandType = CommandType.Text;
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue("@ngay", int.Parse(tbThoiGian.Text));
                        sda.SelectCommand.Parameters.AddWithValue("@thang", int.Parse(tbThoiGian.Text));
                        DataSet st = new DataSet();
                        sda.Fill(st, "DataTable1");
                        cry.SetDataSource(st);
                        crystalReportViewerTKBanHang.ReportSource = cry;
                    }
                }
            }
            catch (Exception) { }
        }

        private void radioButtonNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNgay.Checked == true)
            {
                lbNhapthoigian.Text = "Nhập ngày";
            }
        }

        private void radioButtonThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThang.Checked == true)
            {
                lbNhapthoigian.Text = "Nhập tháng";
            }
        }

        private void tbThoiGian_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonNgay.Checked == true)
            {
                try
                {
                    int thoigian = int.Parse(tbThoiGian.Text);
                    if (thoigian > 31 || thoigian <= 0)
                    {
                        lbThongBaoThoiGian.Text = "Thời gian không đúng";
                    }
                    else if (int.Parse(tbThoiGian.Text) <= 31 || int.Parse(tbThoiGian.Text) > 0)
                    {
                        lbThongBaoThoiGian.Text = "";
                    }
                }
                catch (Exception) { }
            }
            else 
            {
                try
                {
                    int thoigian = int.Parse(tbThoiGian.Text);
                    if (thoigian > 12 || thoigian <= 0)
                    {
                        lbThongBaoThoiGian.Text = "Thời gian không đúng";
                    }
                    else if (int.Parse(tbThoiGian.Text) <= 12 || int.Parse(tbThoiGian.Text) > 0)
                    {
                        lbThongBaoThoiGian.Text = "";
                    }
                }
                catch (Exception) { }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbThoiGian.Text = "";
            //cry.Load(@"C:\Users\anhsachxx\Documents\QLCH\QLCH\QLCH\CrystalReportTKBanHang.rpt");
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("dbo.TKBanHang", conn))
                {
                    //sda.SelectCommand.CommandType = CommandType.Text;
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet st = new DataSet();
                    sda.Fill(st, "DataTable1");
                    cry.SetDataSource(st);
                    crystalReportViewerTKBanHang.ReportSource = cry;
                }
            }
        }
    }
}
