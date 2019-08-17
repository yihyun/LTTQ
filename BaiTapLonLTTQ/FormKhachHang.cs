using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BaiTapLonLTTQ
{
    
    public partial class FormKhachHang : Form
    {
        int ok = 0;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void gbtk_Enter(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            cbmakh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmakh.Enabled = true;
            DataTable h = new DataTable();
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            string sqlqr = "select KhachHang.MaKH,TenKH,DiaChi,Email,SDT,LoaiKH from dbo.KhachHang inner join dbo.LoaiKH on dbo.KhachHang.MaLoaiKH=dbo.LoaiKH.MaLoaiKH";
            h = dtbase.SelectTable(sqlqr);
            dtg1.DataSource = h;
            cbmakh.DataSource = h;
            cbmakh.DisplayMember = "MaKH";
            cbmakh.ValueMember = "MaKH";
            dtg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbdiachi.Enabled = false;
            tbemail.Enabled = false;
            tbtenkh.Enabled = false;
            tbsdt.Enabled = false;
            rbmakh.Checked = false;
            rbtenkh.Checked = false;
            rbtinh.Checked = false;
            lbtim.Text = "";
            tbtimkiem.Enabled = false;
            btnthem.Enabled = false;
        }

        private void cbmakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            SqlConnection con = dtbase.laycon();
            con.Open();
            string sq = "select KhachHang.MaKH,TenKH,DiaChi,Email,SDT,dbo.LoaiKH.MaLoaiKH from dbo.KhachHang inner join dbo.LoaiKH on dbo.KhachHang.MaLoaiKH=dbo.LoaiKH.MaLoaiKH where MaKH='" + cbmakh.Text + "'";
            DataTable l = new DataTable();
            l = dtbase.SelectTable(sq);
            cbloaikh.DataSource = l;
            cbloaikh.DisplayMember = "MaLoaiKH";
            cbloaikh.ValueMember = "MaLoaiKH";
            SqlCommand cm1 = new SqlCommand(sq, con);
            SqlDataReader reader = cm1.ExecuteReader();
            if (reader.HasRows)
            {

                reader.Read();
                tbtenkh.Text = reader.GetString(1).ToString();
                tbdiachi.Text = reader.GetString(2).ToString();
                tbemail.Text = reader.GetString(3).ToString();
                tbsdt.Text = reader.GetString(4).ToString();
                cbloaikh.Text = reader.GetInt32(5).ToString();

            }
           
        }

        private void rbmakh_CheckedChanged(object sender, EventArgs e)
        {
            lbtim.Text = "Nhập Mã Khách Hàng";
            tbtimkiem.Enabled = true;
            tbtimkiem.Text = "";

        }

        private void rbtenkh_CheckedChanged(object sender, EventArgs e)
        {
            lbtim.Text = "Nhập Tên Khách Hàng";
            tbtimkiem.Enabled = true;
            tbtimkiem.Text = "";
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            if (rbmakh.Checked==true)
            {
                
                SqlConnection con = dtbase.laycon();
                con.Open();
                string sq = "select KhachHang.MaKH,TenKH,DiaChi,Email,SDT,LoaiKH from dbo.KhachHang inner join dbo.LoaiKH on dbo.KhachHang.MaLoaiKH=dbo.LoaiKH.MaLoaiKH where MaKH LIKE N'%" + tbtimkiem.Text.ToString() + "%'";
                SqlCommand cm1 = new SqlCommand(sq, con);
                SqlDataReader reader = cm1.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cbmakh.Text = reader.GetString(0).ToString();
                    DataTable h = new DataTable();
                    h = dtbase.SelectTable(sq);
                    dtg1.DataSource = h;
                }
                else
                {
                    MessageBox.Show("Mã bạn nhập không khớp. Vui lòng nhập lại!","Thông báo");
                    tbtimkiem.Focus();
                }
                
            }
            if (rbtenkh.Checked == true)
            {
                SqlConnection con = dtbase.laycon();
                con.Open();
                string sq = "select KhachHang.MaKH,TenKH,DiaChi,Email,SDT,LoaiKH from dbo.KhachHang inner join dbo.LoaiKH on dbo.KhachHang.MaLoaiKH=dbo.LoaiKH.MaLoaiKH where TenKH LIKE N'%" + tbtimkiem.Text.ToString() + "%'";
                SqlCommand cm1 = new SqlCommand(sq, con);
                SqlDataReader reader = cm1.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cbmakh.Text = reader.GetString(0).ToString();
                    DataTable h1 = new DataTable();
                    h1 = dtbase.SelectTable(sq);
                    dtg1.DataSource = h1;
                }
                else
                {
                    MessageBox.Show("Tên bạn nhập không hợp lệ. Vui lòng nhập lại!", "Thông báo");
                    tbtimkiem.Focus();
                }
            }
            if (rbtinh.Checked == true)
            {
                SqlConnection con = dtbase.laycon();
                con.Open();
                string sq = "select KhachHang.MaKH,TenKH,DiaChi,Email,SDT,LoaiKH from dbo.KhachHang inner join dbo.LoaiKH on dbo.KhachHang.MaLoaiKH=dbo.LoaiKH.MaLoaiKH where DiaChi LIKE N'%" + tbtimkiem.Text.ToString() + "%'";
                SqlCommand cm1 = new SqlCommand(sq, con);
                SqlDataReader reader = cm1.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cbmakh.Text = reader.GetString(0).ToString();
                    DataTable h1 = new DataTable();
                    h1 = dtbase.SelectTable(sq);
                    dtg1.DataSource = h1;
                }
                else
                {
                    MessageBox.Show("Tên tỉnh bạn nhập không hợp lệ. Vui lòng nhập lại!", "Thông báo");
                    tbtimkiem.Focus();
                }
            }

        }


        private void dtg1_DoubleClick(object sender, EventArgs e)
        {
            if (dtg1.Columns.Count == 6)
            {
                cbmakh.Text = this.dtg1.CurrentRow.Cells[0].Value.ToString();
                tbtenkh.Text = this.dtg1.CurrentRow.Cells[1].Value.ToString();
                tbdiachi.Text = this.dtg1.CurrentRow.Cells[2].Value.ToString();
                tbemail.Text = this.dtg1.CurrentRow.Cells[3].Value.ToString();
                tbsdt.Text = this.dtg1.CurrentRow.Cells[4].Value.ToString();
                cbloaikh.Text = this.dtg1.CurrentRow.Cells[5].Value.ToString();
            }
            else MessageBox.Show("Lỗi", "Thông Báo");

        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            ok = 1;
            cbmakh.DropDownStyle = ComboBoxStyle.DropDown;
            btnthem.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnlichsu.Enabled = false;
            tbdiachi.Enabled = true;
            tbemail.Enabled = true;
            tbtenkh.Enabled = true;
            tbsdt.Enabled = true;
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            Random rd = new Random();
 b2:        string s = "KH"+rd.Next(1,10000).ToString()+"";
            string kt = "select KhachHang.MaKH,TenKH,DiaChi,Email,SDT,LoaiKH from dbo.KhachHang inner join dbo.LoaiKH on dbo.KhachHang.MaLoaiKH=dbo.LoaiKH.MaLoaiKH where MaKH='"+s+"'";
            DataTable k1 = new DataTable();
            k1 = dtbase.SelectTable(kt);
            if (k1.Rows.Count == 0) cbmakh.Text = s;
            else goto b2;
            tbtenkh.Text = "";
            tbdiachi.Text = "";
            tbemail.Text = "";
            tbsdt.Text = "";
            cbloaikh.Text = "";
            cbmakh.Enabled = false;
            DataTable m = new DataTable();
            m = dtbase.SelectTable("select* from LoaiKH");
            cbloaikh.DataSource = m;
            cbloaikh.DisplayMember = "MaLoaiKH";
            cbloaikh.ValueMember = "MaLoaiKH";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            if (ok==1)
            {
                int k = 0;
                if (tbdiachi.Text == "" || tbemail.Text == "" || tbtenkh.Text == "" || tbsdt.Text == "")
                {
                    k = 1;
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "TB");
                    if (tbtenkh.Text == "") tbtenkh.Focus();
                    if (tbsdt.Text == "") tbsdt.Focus();
                    if (tbemail.Text == "") tbemail.Focus();
                    if (tbdiachi.Text == "") tbdiachi.Focus();
                }
                else if (k == 0)
                {
                    string ss = "INSERT dbo.KhachHang VALUES('" + cbmakh.Text + "',N'" + tbtenkh.Text + "','" + tbdiachi.Text + "','" + tbemail.Text + "','" + tbsdt.Text + "'," + cbloaikh.Text + ")";
                    dtbase.UpdateData(ss);
                    MessageBox.Show("Bạn đã thêm thành công", "Thông báo");
                    btnxoa.Enabled = true;
                    btnsua.Enabled = true;
                    btnlichsu.Enabled = true;
                    string l = "" + cbmakh.Text + "";
                    FormKhachHang_Load(sender, e);
                    cbmakh.SelectedValue = l;
                    ok = 0;
                }
            }
            else
            {
                int k = 0;
                if (tbdiachi.Text == "" || tbemail.Text == "" || tbtenkh.Text == "" || tbsdt.Text == "")
                {
                    k = 1;
                    MessageBox.Show("Thông Tin Không Được Để Trống!", "TB");
                    if (tbtenkh.Text == "") tbtenkh.Focus();
                    if (tbsdt.Text == "") tbsdt.Focus();
                    if (tbemail.Text == "") tbemail.Focus();
                    if (tbdiachi.Text == "") tbdiachi.Focus();
                }
                else if(k==0)
                {
                    string q = " update dbo.KhachHang set TenKH = N'" + tbtenkh.Text + "',DiaChi = N'" + tbdiachi.Text + "',Email = '" + tbemail.Text + "',SDT = '" + tbsdt.Text + "',MaLoaiKH = " + cbloaikh.Text + " where MaKH = '" + cbmakh.Text + "'";
                    dtbase.UpdateData(q);
                    MessageBox.Show("Bạn đã sửa thành công", "Thông báo");
                    btnxoa.Enabled = true;
                    btnsua.Enabled = true;
                    btnlichsu.Enabled = true;
                    cbmakh.DropDownStyle = ComboBoxStyle.DropDownList;
                    string l = "" + cbmakh.Text + "";
                    FormKhachHang_Load(sender, e);
                    cbmakh.SelectedValue = l;
                }
                    
                     
            }
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            DialogResult d=MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã xóa thành công!", "Thông Báo");
                string s = "DELETE FROM dbo.KhachHang WHERE MaKH= '" + cbmakh.Text.ToString() + "'";
                dtbase.UpdateData(s);
                FormKhachHang_Load(sender, e);
            }
           
                 
                
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            tbdiachi.Enabled = true;
            tbemail.Enabled = true;
            tbtenkh.Enabled = true;
            tbsdt.Enabled = true;
            btnthem.Enabled = true;
            DataTable m = new DataTable();
            m = dtbase.SelectTable("select* from LoaiKH");
            cbloaikh.DataSource = m;
            cbloaikh.DisplayMember = "MaLoaiKH";
            cbloaikh.ValueMember = "MaLoaiKH";
        }

        private void btnlichsu_Click(object sender, EventArgs e)
        {
            DataTable hk = new DataTable();
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            string sqlqr = "select dbo.HoaDonBan.MaHDB,dbo.NhanVien.TenNV,dbo.KhachHang.TenKH,dbo.SanPham.TenSP,dbo.CTHoaDonBan.GiaBan,dbo.CTHoaDonBan.SoLuong,dbo.HoaDonBan.NgayLap from(((dbo.HoaDonBan inner join dbo.CTHoaDonBan on dbo.HoaDonBan.MaHDB= dbo.CTHoaDonBan.MaHDB) inner join dbo.NhanVien on dbo.HoaDonBan.MaNV = dbo.NhanVien.MaNV) inner join dbo.SanPham on dbo.CTHoaDonBan.MaSP = dbo.SanPham.MaSP) inner join dbo.KhachHang on dbo.HoaDonBan.MaKH = dbo.KhachHang.MaKH where dbo.HoaDonBan.MaKH='" + cbmakh.Text+"'";
            hk = dtbase.SelectTable(sqlqr);
            dtg1.DataSource = hk;
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnlichsu.Enabled = true;
            FormKhachHang_Load(sender, e);
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            FormLoaiKH lh = new FormLoaiKH();
            lh.Show();
        }

        private void rbtinh_CheckedChanged(object sender, EventArgs e)
        {
            lbtim.Text = "Nhập Tên Tỉnh";
            tbtimkiem.Enabled = true;
            tbtimkiem.Text = "";
        }

        private void tbdiachi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbsdt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
