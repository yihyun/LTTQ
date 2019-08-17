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
    public partial class frmSP : Form
    {
        DataProcess data = new DataProcess();
        public frmSP()
        {
            InitializeComponent();
        }

        private void frmSP_Load(object sender, EventArgs e)
        {
            //dgvDSSanPham.Cursor = true;
            cboLoc.SelectedIndex = 0;
            cboTimKiem.SelectedIndex = 0;
            dgvDanhSachSanPham_Load();
            anFormThemSua();
            this.ClientSize = new System.Drawing.Size(834, 560);
            if(ểvedasxag5B.quyen != 1)
            {
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                btnHuy.Visible = false;
                btnXoa.Visible = false;
                btnLuu2.Visible = false;

            }
        }

        private void dgvDanhSachSanPham_Load()
        {
            string sql = "SELECT * FROM dbo.v_SanPham";
            dgvDSSanPham.DataSource = data.SelectTable(sql);

            foreach (DataGridViewColumn col in dgvDSSanPham.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgvDSSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = true;
            this.ClientSize = new System.Drawing.Size(834, 623);
            btnLuu.Visible = true;
            btnLuu.Location = new System.Drawing.Point(19, 356);
            btnHuy.Visible = true;
            btnHuy.Location = new System.Drawing.Point(77, 356);
            //btnSua.Visible = false;

            toolStripButton1.BackColor = Color.Gray;

            dgvDSSanPham.Enabled = false;
            hienFormThemSua();
            this.groupBox3.Visible = false;

            // load thông tin loại sản phẩm
            cboMaLoai.Focus();
            DataTable dt = data.SelectTable("SELECT MaLoaiSP, LoaiSP FROM dbo.LoaiSP");
            cboMaLoai.DataSource = dt;
            cboMaLoai.DisplayMember = "MaLoaiSP";
            cboMaLoai.ValueMember = "MaLoaiSP";
            txtLoaiSP.Text = dt.Rows[0]["LoaiSP"].ToString().Trim();

            // load thông tin kho hàng

            DataTable dtKhoHang = data.SelectTable("SELECT MaKho,TenKho FROM dbo.Kho");
            cboMaKho.DataSource = dtKhoHang;
            cboMaKho.DisplayMember = "MaKho";
            cboMaKho.ValueMember = "MaKho";
            txtTenKho.Text = dtKhoHang.Rows[0]["TenKho"].ToString().Trim();

            // sinh mã sản phẩm 
            string s = dgvDSSanPham.Rows[dgvDSSanPham.Rows.Count - 2].Cells["Mã sản phẩm"].Value.ToString().Trim();
            int k = Convert.ToInt32(s.Substring(2, 3));
            s = "SP0" + Convert.ToString(k + 1);
            txtMaSP.Text = s;
            
            


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTimKiem.Text == "Nhập giá trị cần tìm ...")
            {
                txtTimKiem.Text = "";

                txtTimKiem.Font = new Font("Consolas", 11);
            }
                
        }
        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập giá trị cần tìm ...";
            txtTimKiem.Font = new Font("Monotype Corsiva", 11);
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập giá trị cần tìm ...";
            txtTimKiem.Font = new Font("Monotype Corsiva", 11);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //btnLuu.Visible = true;
           // btnLuu.Location = new System.Drawing.Point(19, 356);
            btnHuy.Visible = true;
            btnHuy.Location = new System.Drawing.Point(77, 356);

            btnLuu.Visible = false;
            btnLuu2.Visible = true;
            btnLuu2.Location = new System.Drawing.Point(19, 356);

            btnSua.Visible = false;
            btnXoa.Visible = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            dgvKM.Enabled = true;
            
            toolStripButton1.BackColor = Color.LightSkyBlue;
            txtTenSP.Focus();

            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này ? " +
                "(Dữ liệu đã xóa sẽ không thể khôi phục.)", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                data.SelectTable("DELETE dbo.SanPham WHERE MaSP = '" + txtMaSP.Text + "'");
                dgvDanhSachSanPham_Load();
            }
            anFormThemSua();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            dgvDSSanPham.Enabled = true;
            int sl = 0;
            try { if (txtSL.Text != null) sl = Convert.ToInt16(txtSL.Text); } catch (Exception) { }
            data.UpdateData("INSERT INTO dbo.SanPham( MaSP, TenSP, XuatXu, MoTa, GhiChu, " +
                "LoaiSP, MaKho, SLton, DonGiaBan, DonGiaNhap) VALUES(N'" + 
                txtMaSP.Text + "', N'" + 
                txtTenSP.Text + "', N'" + 
                txtXuatXu.Text + "', N'" + 
                txtMoTa.Text + "', N'', '" + 
                Convert.ToInt16(cboMaLoai.Text) + "',N'" + 
                cboMaKho.Text + "', '"+sl+"', '"+Convert.ToDouble(txtDonGiaBan.Text)+ 
                "', '" + Convert.ToDouble(txtDonGiaNhap.Text) + "' )");
            dgvDanhSachSanPham_Load();

            toolStripButton1.BackColor = Color.LightSkyBlue;
            anFormThemSua();
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            data.UpdateData("UPDATE dbo.SanPham SET " +
                   "TenSP = N'" + txtTenSP.Text + "', XuatXu = N'" + 
                   txtXuatXu.Text + "',MoTa = N'" + txtMoTa.Text +
                   "',SLton = N'" + Convert.ToInt16(txtSL.Text) + 
                   "',DonGiaNhap = N'" + Convert.ToDouble(txtDonGiaNhap.Text) + 
                   "',DonGiaBan = N'" + Convert.ToDouble(txtDonGiaBan.Text) + 
                   "',LoaiSP = N'" + cboMaLoai.Text + "',MaKho = N'" + cboMaKho.Text + 
                   "'  WHERE MaSP = '" + txtMaSP.Text + "'");
            dgvDanhSachSanPham_Load();
            anFormThemSua();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvDSSanPham.Enabled = true;
            toolStripButton1.BackColor = Color.LightSkyBlue;
            anFormThemSua();
        }

        private void hienFormThemSua()
        {
            btnSua.Visible = true;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox5.Visible = true;

            this.groupBox4.Size = new System.Drawing.Size(811, 229);
            this.dgvDSSanPham.Size = new System.Drawing.Size(798, 203);
        }

        private void anFormThemSua()
        {
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnLuu2.Visible = false;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;

            this.groupBox4.Size = new System.Drawing.Size(811, 439);
            this.dgvDSSanPham.Size = new System.Drawing.Size(798, 413);
        }

        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSSanPham.Rows[e.RowIndex].ReadOnly = true;
        }

        private void dgvDSSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(834, 623);
            // điều kiện cho phép xóa
            int row = e.RowIndex;
            int kt = 1, slton;
            string masp = dgvDSSanPham.Rows[row].Cells["Mã sản phẩm"].Value.ToString();
            try
            {
                slton = Convert.ToInt16(dgvDSSanPham.Rows[row].Cells["Số lượng tồn"].Value.ToString());
            }
            catch (FormatException) { slton = 0; }
            
            if (slton > 0) kt = 0;
            else
            {
                string sql1 = "SELECT * FROM dbo.CTHoaDonNhap WHERE MaSP = '" + masp + "'";
                string sql2 = "SELECT * FROM dbo.CTHoaDonBan WHERE MaSP = '" + masp + "'";
                if (data.SelectTable(sql1).Rows.Count > 0) kt = 0;
                if (data.SelectTable(sql2).Rows.Count > 0) kt = 0;
            }

            hienFormThemSua();
            btnLuu.Visible = false;
            if (kt == 1)
                btnXoa.Visible = true;

            // cho phép chỉnh sửa;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            dgvKM.Enabled = false;

            // fill dữ liệu vào textbox
            txtMaSP.Text = masp;
            txtTenSP.Text = dgvDSSanPham.Rows[row].Cells["Tên sản phẩm"].Value.ToString();
            txtXuatXu.Text = dgvDSSanPham.Rows[row].Cells["Xuất xứ"].Value.ToString();
            txtSL.Text = Convert.ToString(slton);
            txtDonGiaNhap.Text = dgvDSSanPham.Rows[row].Cells["Đơn giá nhập"].Value.ToString();
            txtDonGiaBan.Text = dgvDSSanPham.Rows[row].Cells["Đơn giá bán"].Value.ToString();
            txtMoTa.Text = dgvDSSanPham.Rows[row].Cells["Mô tả"].Value.ToString();

            cboMaLoai.Text = dgvDSSanPham.Rows[row].Cells["Mã loại"].Value.ToString();
            txtLoaiSP.Text = dgvDSSanPham.Rows[row].Cells["Loại sản phẩm"].Value.ToString();
            cboMaKho.Text = dgvDSSanPham.Rows[row].Cells["Mã kho"].Value.ToString();
            txtTenKho.Text = dgvDSSanPham.Rows[row].Cells["Tên kho"].Value.ToString();
            try
            {
                txtGiamGia.Text = data.SelectTable("SELECT GiamGia FROM dbo.ChuongTrinhKhuyenMai " +
                "WHERE GETDATE() BETWEEN NgayBatDau AND NgayKetThuc AND MaDTSP = '" +
                txtMaSP.Text + "'").Rows[0][0].ToString();
            }
            catch (IndexOutOfRangeException) { }

            dgvKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKM.DataSource = data.SelectTable("SELECT dbo.CTKhuyenMai.MaSP, " +
            "TenSP, SoLuong FROM dbo.CTKhuyenMai JOIN dbo.ChuongTrinhKhuyenMai " +
            "ON ChuongTrinhKhuyenMai.MaCTKM = CTKhuyenMai.MaCTKM JOIN dbo.SanPham " +
            "ON SanPham.MaSP = ChuongTrinhKhuyenMai.MaDTSP WHERE GETDATE() BETWEEN " +
            "NgayBatDau AND NgayKetThuc AND MaDTSP = '"+ txtMaSP.Text +"'");


            
            

        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtLoaiSP.Text = data.SelectTable("SELECT LoaiSP FROM dbo.LoaiSP WHERE MaLoaiSP = '" +
               Convert.ToInt16(cboMaLoai.SelectedValue.ToString().Trim()) + "'").Rows[0][0].ToString();
            }
            catch (FormatException) { }
        }

        private void cboMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenKho.Text = data.SelectTable("SELECT TenKho FROM dbo.Kho WHERE MaKho = '" +
               cboMaKho.SelectedValue.ToString().Trim() + "'").Rows[0][0].ToString();
            }
            catch (IndexOutOfRangeException) { }
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaSP AS 'Mã sản phẩm', TenSP AS 'Tên sản phẩm', XuatXu AS 'Xuất xứ', " +
                "DonGiaNhap AS 'Đơn giá nhập', DonGiaBan AS 'Đơn giá bán', SLton AS 'Số lượng tồn', " +
                "MoTa AS 'Mô tả', LoaiSP.LoaiSP AS 'Loại sản phẩm', MaLoaiSP AS 'Mã loại' " +
                "FROM dbo.SanPham JOIN dbo.LoaiSP ON LoaiSP.MaLoaiSP = SanPham.LoaiSP ";
            if(txtTimKiem.Text != "Nhập giá trị cần tìm ...")
            {
                if (cboTimKiem.Text.Trim() == "Mã Sản phẩm")
                    sql += "WHERE MaSP LIKE '%" + txtTimKiem.Text + "%'";
                else if (cboTimKiem.Text.Trim() == "Tên sản phẩm")
                    sql += "WHERE TenSP LIKE N'%" + txtTimKiem.Text + "%'";
                else if (cboTimKiem.Text.Trim() == "Xuất xứ")
                    sql += "WHERE XuatXu LIKE N'%" + txtTimKiem.Text + "%'";
                else if (cboTimKiem.Text.Trim() == "Loại sản phẩm")
                    sql += "WHERE LoaiSP LIKE N'%" + txtTimKiem.Text + "%'";

                if (cboLoc.Text == "Sản phẩm đang khuyến mãi")
                sql += " AND MaSP IN (SELECT MaDTSP FROM dbo.ChuongTrinhKhuyenMai WHERE GETDATE() BETWEEN NgayBatDau AND NgayKetThuc)";
            }
            else
            {
                if (cboLoc.Text == "Sản phẩm đang khuyến mãi")
                    sql += "WHERE MaSP IN (SELECT MaDTSP FROM dbo.ChuongTrinhKhuyenMai WHERE GETDATE() BETWEEN NgayBatDau AND NgayKetThuc)";
            }
            
            dgvDSSanPham.DataSource = data.SelectTable(sql);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgvDanhSachSanPham_Load();
        }

        
    }
}
