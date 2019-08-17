using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanHang;
namespace BaiTapLonLTTQ
{
    public partial class frmQuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        DataProcess data = new DataProcess();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadForm();
            
        }
        private void LoadForm()
        {

            DataTable dt = null;
            dt = data.SelectTable("SELECT * FROM ThongTinTaiKhoan");

            if (dt.Rows.Count > 0)
            {
                gridControl1.DataSource = dt;
                loadThongTin(dt);
                anThongTin();
            }
        }

        private void loadThongTin(DataTable dt)
        {
            txtTenTK.Text = dt.Rows[0]["Username"].ToString();
            txtMK.Text = dt.Rows[0]["Password"].ToString();
            cboMaNV.Text = dt.Rows[0]["MaNV"].ToString();
            cboQuyen.Text = dt.Rows[0]["PhanQuyen"].ToString();

            loadThongTinNhanVien(cboMaNV.Text);
        }

        private void loadThongTinNhanVien(string manv)
        {
            if(cboMaNV.Text != "" || cboMaNV.Text != null){
                DataTable dt = data.SelectTable("SELECT [TenNV],CASE WHEN GioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS 'GioiTinh',[DiaChi],[Email],[SDT],[Luong] FROM [QuanLyBanHang].[dbo].[NhanVien] WHERE [MaNV] = '" + manv + "'");
                txtTenNV.Text = dt.Rows[0]["TenNV"].ToString();
                cboGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            }
            else
            {
                txtTenNV.Text = null;
                cboGioiTinh.Text = null;
                txtDiaChi.Text = null;
                txtEmail.Text = null;
                txtSDT.Text = null;
            }
        }
        private void anThongTin()
        {
            lcgThongTin.Enabled = false;
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            txtTenTK.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Username").ToString();
            txtMK.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Password").ToString();
            cboMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
            cboQuyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PhanQuyen").ToString();

            loadThongTinNhanVien(cboMaNV.Text);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTao.Enabled = false;
            btnLuu.Enabled = false;

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            btnTao.Enabled = false;
            btnRefesh.Enabled = false;
            cboMaNV.Enabled = true;
            DataTable dt = data.SelectTable("SELECT MaNV FROM dbo.NhanVien WHERE MaNV NOT IN (SELECT MaNV FROM dbo.[User])");
            cboMaNV.Properties.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboMaNV.Properties.Items.Add(row["MaNV"]);
            }
            cboMaNV.SelectedIndex = 0;
            setNullFormThongTin();
            
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void setNullFormThongTin()
        {
            lcgThongTin.Enabled = true;
            item1.Enabled = true;
            txtTenTK.Text = null;
            txtMK.Text = null;
            cboQuyen.SelectedIndex = 2; 
            loadThongTinNhanVien(cboMaNV.Text);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int gr = 3;
            DataTable dt = null;
            if (cboQuyen.Text == "Admin") gr = 1;
            else if (cboQuyen.Text == "Kế Toán") gr = 2;
            dt = data.SelectTable("SELECT MaNV FROM dbo.NhanVien WHERE MaNV NOT IN " +
                "(SELECT MaNV FROM dbo.[User])");
            foreach (DataRow row in dt.Rows)
            {
               
                if (row != null && cboMaNV.Text == row["MaNV"].ToString())
                {
                    ok = true;
                }
                
            }
            string sql = "SELECT * FROM dbo.[User] WHERE Username = '"+txtTenTK.Text+"'";
            if (kiemtra(txtTenTK.Text, txtMK.Text))
            {
                if (ok)
                {
                    if(data.SelectTable(sql).Rows.Count <= 0)
                    {
                        data.UpdateData("INSERT dbo.[User] VALUES  ( N'" + cboMaNV.Text + "', N'" +
                        txtTenTK.Text + "' , N'" + txtMK.Text + "' , '" + gr + "')");
                        MessageBox.Show("Tạo tài khoản thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadForm();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnTao.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!", "Cảnh báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (data.SelectTable(sql).Rows.Count <= 1)
                    {
                        data.UpdateData("UPDATE dbo.[User] SET Username = N'" +
                        txtTenTK.Text + "' , Password = N'" + txtMK.Text + "' , user_group = '" + gr +
                        "' WHERE MaNV = '" + cboMaNV.Text + "'");
                        LoadForm();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnTao.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!", "Cảnh báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }
        private bool kiemtra(string user, string pass)
        {
            if(user.Trim() == null || user.Trim() == "")
            {
                MessageBox.Show("Hãy nhập Tên tài khoản!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(pass.Trim() == null || pass.Trim() == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //cboMaNV.Enabled = false;
            lcgThongTin.Enabled = true;
            cboMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            cboGioiTinh.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTao.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                string s = "DELETE FROM [User] WHERE MaNV= '" + cboMaNV.Text + "'";
                data.UpdateData(s);
                MessageBox.Show("Bạn đã xóa thành công!", "Thông Báo");
                
            }
            LoadForm();
            btnRefesh.Enabled = true;
            btnTao.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadForm();
            btnRefesh.Enabled = true;
            btnTao.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThongTinNhanVien(cboMaNV.Text);
            btnLuu.Enabled = true;
        }

        private void txtTenTK_EditValueChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void txtMK_EditValueChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void cboQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
    }
}