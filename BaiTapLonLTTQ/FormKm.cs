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
    public partial class FormKm : Form
    {
        BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
        int ok = 0;
        public FormKm()
        {
            InitializeComponent();
        }

        private void FormKm_Load(object sender, EventArgs e)
        {
            if(ểvedasxag5B.quyen==2||ểvedasxag5B.quyen==3)
            {
                btluu.Visible = false;
                btthem.Visible = false;
                btxoa.Visible = false;
                btsua.Visible = false;
                btthoat.Visible = false;
            }
            //load combo km
            DataTable h = new DataTable();
            h = dtbase.SelectTable("select *from ChuongTrinhKhuyenMai");
            cbmakm.DataSource = h;
            cbmakm.DisplayMember = "MaCTKM";
            cbmakm.ValueMember = "MaCTKM";
            dtgkm.DataSource = h;
            dtgkm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbgiamgia.Enabled = false;
            tbtenkm.Enabled = false;
            dtped.Enabled = false;
            dtpst.Enabled = false;
            cktt.Checked = false;
            cbmakm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmakm.Enabled = true;
            ok = 0;

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbmakm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select *from ChuongTrinhKhuyenMai where MaCTKM='"+cbmakm.Text+"'";
            DataTable k = new DataTable();
            k = dtbase.SelectTable(s);
            cbmadtkh.DataSource = k;
            cbmadtsp.DataSource = k;
            cbmadtkh.DisplayMember = "MaDTKH";
            cbmadtkh.ValueMember = "MaDTKH";
            cbmadtsp.DisplayMember = "MaDTSP";
            cbmadtsp.ValueMember = "MaDTSP";
            SqlConnection con = dtbase.laycon();
            con.Open();
            SqlCommand cm = new SqlCommand(s, con);
            SqlDataReader r = cm.ExecuteReader();
            if(r.HasRows)
            {
                r.Read();
                tbtenkm.Text = r.GetString(1).ToString();
                dtpst.Text = r.GetDateTime(2).ToString();
                dtped.Text = r.GetDateTime(3).ToString();
                cbmadtkh.Text = r.GetInt32(4).ToString();
                cbmadtsp.Text = r.GetString(5).ToString();
                tbgiamgia.Text = r.GetDouble(6).ToString();
            }


        }

        private void cktt_CheckedChanged(object sender, EventArgs e)
        {
            if (cktt.Checked == true)
            {
                DataTable h1 = new DataTable();
                h1 = dtbase.SelectTable("select *from ChuongTrinhKhuyenMai where '"+DateTime.Now+"' between NgayBatDau and NgayKetThuc");
                dtgkm.DataSource = h1;
            }
            else FormKm_Load(sender, e);

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa chương trình khuyến mãi này không?","TB",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                dtbase.UpdateData("delete from ChuongTrinhKhuyenMai where MaCTKM='"+cbmakm.Text+"'");
                MessageBox.Show("Đã Xóa Thành Công!", "TB");
                FormKm_Load(sender, e);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            ok = 1;
            tbgiamgia.Enabled = true;
            tbtenkm.Enabled = true;
            dtped.Enabled = true;
            dtpst.Enabled = true;
            DataTable m = new DataTable();
            DataTable n = new DataTable();
            m = dtbase.SelectTable("select *from LoaiKH");
            n = dtbase.SelectTable("select *from SanPham");
            cbmadtkh.DataSource = m;
            cbmadtkh.DisplayMember = "MaLoaiKH";
            cbmadtkh.ValueMember = "MaLoaiKH";
            cbmadtsp.DataSource = n;
            cbmadtsp.DisplayMember = "MaSP";
            cbmadtsp.ValueMember = "MaSP";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tbgiamgia.Enabled = true;
            tbtenkm.Enabled = true;
            dtped.Enabled = true;
            dtpst.Enabled = true;
            tbtenkm.Text = "";
            tbgiamgia.Text = "";
            cbmakm.DropDownStyle = ComboBoxStyle.DropDown;
            DataTable m = new DataTable();
            DataTable n = new DataTable();
            m = dtbase.SelectTable("select *from LoaiKH");
            n = dtbase.SelectTable("select *from SanPham");
            cbmadtkh.DataSource = m;
            cbmadtkh.DisplayMember = "MaLoaiKH";
            cbmadtkh.ValueMember = "MaLoaiKH";
            cbmadtsp.DataSource = n;
            cbmadtsp.DisplayMember = "MaSP";
            cbmadtsp.ValueMember = "MaSP";
            dtpst.Text = DateTime.Now.ToString();
            dtped.Text = DateTime.Now.ToString();
           b2: string o = "KM"+r.Next(1,1000).ToString()+"";
            DataTable v = new DataTable();
            v = dtbase.SelectTable("select *from ChuongTrinhKhuyenMai where MaCTKM='"+o+"'");
            if (v.Rows.Count == 0) cbmakm.Text = o;
            else goto b2;
            cbmakm.Enabled = false;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if(ok==1)
            {
                if (tbtenkm.Text == "" || tbgiamgia.Text == "" || tbgiamgia.Text == "0")
                {
                    if (tbtenkm.Text == "")
                    {
                        MessageBox.Show("Bạn không được để trống tên chương trình khuyến mãi!", "TB");
                        tbtenkm.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được để trống giảm giá hoặc giảm giá không được bằng 0 !", "TB");
                        tbgiamgia.Focus();
                        tbgiamgia.Text = "";
                    }

                }
                else
                {
                    string m1 = "update ChuongTrinhKhuyenMai set TenChuongTrinh='" + tbtenkm.Text + "',NgayBatDau='" + Convert.ToDateTime(dtpst.Text.ToString()) + "',NgayKetThuc='" + Convert.ToDateTime(dtped.Text.ToString()) + "',MaDTKH='" + cbmadtkh.Text + "',MaDTSP='" + cbmadtsp.Text + "',GiamGia=" + Convert.ToDouble(tbgiamgia.Text) + " where MaCTKM='" + cbmakm.Text + "'";
                    dtbase.UpdateData(m1);
                    MessageBox.Show("Sửa Thành Công!", "TB");
                    FormKm_Load(sender, e);
                    ok = 0;
                }
                
            }
            else
            {
                if (tbtenkm.Text == ""||tbgiamgia.Text == ""||tbgiamgia.Text=="0")
                {
                    if(tbtenkm.Text=="")
                    {
                        MessageBox.Show("Bạn không được để trống tên chương trình khuyến mãi!", "TB");
                        tbtenkm.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được để trống giảm giá hoặc giảm giá không được bằng 0 !", "TB");
                        tbgiamgia.Focus();
                        tbgiamgia.Text = "";
                    }
                    
                }
                else
                {
                    string m2 = "insert into ChuongTrinhKhuyenMai values('"+cbmakm.Text+"','"+tbtenkm.Text+"','"+ Convert.ToDateTime(dtpst.Text.ToString()) + "','"+ Convert.ToDateTime(dtped.Text.ToString()) + "','"+ cbmadtkh.Text + "','" + cbmadtsp.Text + "'," + tbgiamgia.Text+")";
                    dtbase.UpdateData(m2);
                    MessageBox.Show("Thêm Chương Trình Khuyến Mãi Thành Công!", "Thông Báo");
                    FormKm_Load(sender, e);
                }
            }
        }

        private void tbgiamgia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(tbgiamgia.Text=="")
                {
                    int k;
                }
                else Convert.ToDouble(tbgiamgia.Text);
            }
            catch (FormatException) { MessageBox.Show("Vui lòng nhập số!", "TB"); tbgiamgia.Focus(); tbgiamgia.Text = ""; }
        }
    }
}
