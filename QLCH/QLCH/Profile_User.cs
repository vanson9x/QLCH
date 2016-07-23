﻿using System;
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
    public partial class Profile_User : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectString"].ConnectionString);
        SqlCommand cmd;
        string query;

        public Profile_User()
        {
            InitializeComponent();
            btnSua.FlatStyle = FlatStyle.Flat;
        }

        private void Profile_User_Load(object sender, EventArgs e)
        {
            query = "Select sTenNV,sChucVu,sDiaChi,sEmail,sSDT FROM tbl_NhanVien WHERE sMaNV = '"+Program.user+"'";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            lbTen.Text = sdr.GetString(0);
            lbChucVu.Text = sdr.GetString(1);
            lbDiaChi.Text = sdr.GetString(2);
            lbEmail.Text = sdr.GetString(3);
            lbSdt.Text = sdr.GetString(4);
            conn.Close();
        }
    }
}
