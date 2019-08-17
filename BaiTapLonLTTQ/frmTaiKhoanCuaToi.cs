using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTapLonLTTQ;
namespace QuanLyBanHang
{
    public partial class frmTaiKhoanCuaToi : Form
    {
        DataProcess data = new DataProcess();
        DataTable dataTable = null;
        public frmTaiKhoanCuaToi()
        {
            InitializeComponent();

        }

        private void frmTaiKhoanCuaToi_Load(object sender, EventArgs e)
        {
            this.panel1.Location = new System.Drawing.Point(0, 27);
            panel1.Visible = true;
            panel2.Visible = false;
           
            loadForm();
        }
        
        private void loadForm()
        {
            string sql = "SELECT * FROM dbo.NhanVien WHERE MaNV = " +
                "(SELECT MaNV FROM dbo.[User] WHERE Username = '" +
                ểvedasxag5B.username + "')";
            dataTable = data.SelectTable(sql);
            txtTenTaiKhoan.Text = ểvedasxag5B.username;
            try
            {
                txtMaNV.Text = dataTable.Rows[0]["MaNV"].ToString();
                txtTenNV.Text = dataTable.Rows[0]["TenNV"].ToString();
                cboGioiTinh.Text = (dataTable.Rows[0]["GioiTinh"].ToString().ToLower() == "true") ? "Nam" : "Nữ";
                txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                txtDiaChi.Text = dataTable.Rows[0]["DiaChi"].ToString();
                txtSDT.Text = dataTable.Rows[0]["SDT"].ToString();
            }
            catch (IndexOutOfRangeException) { }

            button2.Visible = false;
            button3.Visible = false;
            setEnable(false);
        }


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Location = new System.Drawing.Point(0, 27);
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Location = new System.Drawing.Point(0, 27);
            panel1.Visible = true;
            panel2.Visible = false;
        }

        public void setEnable(bool b)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = b;
            txtDiaChi.Enabled = b;
            txtEmail.Enabled = b;
            cboGioiTinh.Enabled = b;
            txtSDT.Enabled = b;
            txtTenTaiKhoan.Enabled = b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setEnable(true);
            button1.Visible = false;
            button4.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button2.Location = new System.Drawing.Point(0, 3);
            button3.Location = new System.Drawing.Point(60, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setEnable(false);
            if (txtTenTaiKhoan.Text != ểvedasxag5B.username)
            {
                string sql1 = "UPDATE dbo.[User] SET Username = '" +
                    txtTenTaiKhoan.Text + "' WHERE MaNV = '" + txtMaNV.Text + "'";
                ểvedasxag5B.username = txtTenTaiKhoan.Text;
                data.UpdateData(sql1);
            }
            bool gt = false;
            if (cboGioiTinh.Text.ToString().ToLower() == "Nam") gt = true;
            data.UpdateData("UPDATE dbo.NhanVien SET TenNV = '"+txtTenNV.Text+"', GioiTinh = '"+
                gt+ "', DiaChi = '"+
                txtDiaChi.Text+"', Email = '"+txtEmail.Text+"', SDT = '"+txtSDT.Text+"' WHERE MaNV = '"+
                txtMaNV.Text+"'");

            button1.Visible = true;
            button4.Visible = true;
            loadForm();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            setEnable(false);
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            button4.Visible = true;
            loadForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(txtMKHT.Text == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (ểvedasxag5B.password != txtMKHT.Text.Trim())
            {
                MessageBox.Show("Mật khẩu sai!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtMKM.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txtMKM.Text.Trim() != txtXNMKM.Text.Trim())
            {
                MessageBox.Show("Xác nhận không đúng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXNMKM.Text = "";
                txtMKM.Text = "";
            }
            else
            {
                if (ểvedasxag5B.password == txtMKHT.Text.Trim() && txtMKM.Text.Trim() == txtXNMKM.Text.Trim())
                {
                    data.UpdateData("UPDATE dbo.[User] SET Password = '" +
                        txtMKM.Text.Trim() + "' WHERE Username = '" + ểvedasxag5B.username + "'");
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //panel2.Visible = false;
                    ểvedasxag5B.password = txtMKM.Text.Trim();
                }
                else
                {

                }

            }
        }
    }
}
