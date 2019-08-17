using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_BacVu;
using QuanLyBanHang;
namespace BaiTapLonLTTQ
{
    public partial class ểvedasxag5B : Form
    {
        public static int quyen;
        public static string username;
        public static string password;
        public ểvedasxag5B()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(quyen==3)
            {
                barButtonItem7.Enabled = false;
                navBarGroup6.Visible = false;
                navBarGroup2.Visible = false;
                barButtonItem2.Enabled = false;
                barButtonItem8.Enabled = false;
            }
            if(quyen==2)
            {
                barButtonItem8.Enabled = false;
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSP sp = new frmSP();
            sp.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormHDBan hdb = new FormHDBan();
            hdb.Show();

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_nhaphang nhap = new frm_nhaphang();
            nhap.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCaoDoanhThu rp = new frmBaoCaoDoanhThu();
            rp.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLyTaiKhoan qltk = new frmQuanLyTaiKhoan();
            qltk.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaiKhoanCuaToi tkct = new frmTaiKhoanCuaToi();
            tkct.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_nhaphang nhap = new frm_nhaphang();
            nhap.Show();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_NhaCC ncc = new frm_NhaCC();
            ncc.Show();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormLoaiKH khl = new FormLoaiKH();
            khl.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.Show();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHDBan hdb = new FormHDBan();
            hdb.Show();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormKm km = new FormKm();
            km.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmLoaiSP sp1 = new frmLoaiSP();
            sp1.Show();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSP sp = new frmSP();
            sp.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBaoCaoDoanhThu rp = new frmBaoCaoDoanhThu();
            rp.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_NhanVien nv = new frm_NhanVien();
            nv.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_KhoHang kh = new frm_KhoHang();
            kh.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTKSP tk = new FormTKSP();
            tk.Show();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormTKSP tk1 = new FormTKSP();
            tk1.Show();
        }
    }
}
