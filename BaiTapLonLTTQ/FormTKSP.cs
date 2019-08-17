using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapLonLTTQ
{
    public partial class FormTKSP : Form
    {
        BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
        public FormTKSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] lb = { lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10 };
            labelct.Text = "Chú Thích";
            reset(lb);
            chart1.Series["Sản Phẩm"].Points.Clear();
            if(radioButton1.Checked==true)
            {
                string m = "select top " + cbtop.Text + " dbo.SanPham.MaSP,TenSP,sum(dbo.CTHoaDonBan.SoLuong) as soluong from (dbo.CTHoaDonBan inner join dbo.HoaDonBan on dbo.CTHoaDonBan.MaHDB=dbo.HoaDonBan.MaHDB) inner join dbo.SanPham on SanPham.MaSP=dbo.CTHoaDonBan.MaSP " +
                "where MONTH(dbo.HoaDonBan.NgayLap)= " + cbthang.Text + " and YEAR(dbo.HoaDonBan.NgayLap)= " + cbnam.Text + " " +
                "group by dbo.SanPham.MaSP,TenSP order by soluong desc ";
                DataTable chart = new DataTable();
                chart = dtbase.SelectTable(m);
                int p = chart.Rows.Count;
                for (int i = 0; i < p; i++)
                {
                    this.chart1.Series["Sản Phẩm"].Points.AddXY("" + chart.Rows[i][0].ToString() + "(" + chart.Rows[i][2] + ")", chart.Rows[i][2]);
                    lb[i].Text = ("" + chart.Rows[i][0] + ":" + chart.Rows[i][1] + "");
                }
                label6.Text = "Biểu Đồ Thống Kê Top " + p + " Sản Phẩm Bán Chạy Nhất (Giảm Dần) Trong Tháng " + cbthang.Text + " Năm " + cbnam.Text + "";
            }
            else if(radioButton2.Checked==true)
            {
                string m = "select top " + cbtop.Text + " dbo.SanPham.MaSP,TenSP,sum(dbo.CTHoaDonBan.SoLuong) as soluong from (dbo.CTHoaDonBan inner join dbo.HoaDonBan on dbo.CTHoaDonBan.MaHDB=dbo.HoaDonBan.MaHDB) inner join dbo.SanPham on SanPham.MaSP=dbo.CTHoaDonBan.MaSP " +
                "where dbo.HoaDonBan.NgayLap between '"+Convert.ToDateTime(dateTimePicker1.Text.ToString())+"' and '"+Convert.ToDateTime(dateTimePicker2.Text.ToString())+"' " +
                "group by dbo.SanPham.MaSP,TenSP order by soluong desc ";
                DataTable chart = new DataTable();
                chart = dtbase.SelectTable(m);
                int p = chart.Rows.Count;
                for (int i = 0; i < p; i++)
                {
                    this.chart1.Series["Sản Phẩm"].Points.AddXY("" + chart.Rows[i][0].ToString() + "(" + chart.Rows[i][2] + ")", chart.Rows[i][2]);
                    lb[i].Text = ("" + chart.Rows[i][0] + ":" + chart.Rows[i][1] + "");
                }
               label6.Text = "Biểu Đồ Thống Kê Top " + p + " Sản Phẩm Bán Chạy Nhất (Giảm Dần) Từ Ngày "+dateTimePicker1.Text+"" +
                    " Đến Ngày "+dateTimePicker2.Text+"";
            }
        }
        private void reset(Label[] b)
        {
            for(int i=0;i<b.Length;i++)
            {
                b[i].Text = "";
            }
        }
        private void FormTKSP_Load(object sender, EventArgs e)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] b = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024 };
            int[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbthang.DataSource = a;
            cbnam.DataSource = b;
            cbtop.DataSource = t;
            cbnam.SelectedIndex = 17;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            button1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            button1.Enabled = true;
        }
    }
}
