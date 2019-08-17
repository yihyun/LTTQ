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
    
    public partial class FormLoaiKH : Form
    {
        BanHang2017.Classes.DataProcess dtbase;
        public FormLoaiKH()
        {
            
            InitializeComponent();
        }

        private void FormLoaiKH_Load(object sender, EventArgs e)
        {
            if(ểvedasxag5B.quyen==2||ểvedasxag5B.quyen==3)
            {
                btnexit.Visible = false;
                btnchitiet.Visible = false;
                btnre.Visible = false;
                btntaomoi.Visible = false;
                btnxoa.Visible = false;
                btnsua.Visible = false;
                btnthem.Visible = false;
            }
            cbMaLoaiKH.Enabled = true;
            cbMaLoaiKH.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable h = new DataTable();
            DataTable h1 = new DataTable();
            string sq = "select *from dbo.LoaiKH";
            dtbase = new BanHang2017.Classes.DataProcess();
            h=dtbase.SelectTable(sq);
            dtg2.DataSource = h;
            cbMaLoaiKH.DataSource = h;
            cbMaLoaiKH.DisplayMember = "MaLoaiKH";
            cbMaLoaiKH.ValueMember = "MaLoaiKH";
            dtg2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbMaLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtbase = new BanHang2017.Classes.DataProcess();
            SqlConnection con = dtbase.laycon();
            con.Open();
            string s1 = "select *from dbo.LoaiKH where MaLoaiKH='"+ cbMaLoaiKH.Text.ToString()+"'";
            SqlCommand cm = new SqlCommand(s1, con);
            SqlDataReader r1 = cm.ExecuteReader();
            if(r1.HasRows)
            {
                r1.Read();
                tbTenLoaiKH.Text = r1.GetString(1).ToString();
                tbghichu.Text = r1.GetString(2).ToString();
            }
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            dtbase = new BanHang2017.Classes.DataProcess();
            string sq = "select MaKH,TenKH,DiaChi,Email,SDT from dbo.KhachHang where dbo.KhachHang.MaLoaiKH='"+Convert.ToInt32(cbMaLoaiKH.Text)+"'";
            DataTable h = new DataTable();
            h = dtbase.SelectTable(sq);
            dtg2.DataSource = h;
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            FormLoaiKH_Load(sender, e);
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            cbMaLoaiKH.DropDownStyle = ComboBoxStyle.DropDown;
            dtbase = new BanHang2017.Classes.DataProcess();
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = true;
            string s1 = "select *from dbo.LoaiKH";
            DataTable h = new DataTable();
            h = dtbase.SelectTable(s1);
            int k = h.Rows.Count;
            int max = Convert.ToInt32(h.Rows[0][0]);
            for (int i = Convert.ToInt32(h.Rows[0][0]); i <= Convert.ToInt32(h.Rows[k-1][0]); i++)
            if(max<i)
            {
                    max = i;
            }
            cbMaLoaiKH.Text = ""+(max+1)+"";
            tbTenLoaiKH.Text = "";
            tbghichu.Text = "";
            cbMaLoaiKH.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(tbTenLoaiKH.Text=="")
            {
                MessageBox.Show("Bạn không được bỏ trống tên loại khách hàng!", "TB");
                tbTenLoaiKH.Focus();
            }
            else
            {
                string ss = "INSERT dbo.LoaiKH VALUES('" + cbMaLoaiKH.Text + "',N'" + tbTenLoaiKH.Text + "',N'" + tbghichu.Text + "')";
                dtbase.UpdateData(ss);
                MessageBox.Show("Bạn đã thêm thành công", "Thông báo");
                FormLoaiKH_Load(sender, e);
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                DataTable h = new DataTable();
                string s1 = "select *from dbo.KhachHang where MaLoaiKH='"+cbMaLoaiKH.Text+"'";
                h = dtbase.SelectTable(s1);
                if (h.Rows.Count > 0)
                {
                    MessageBox.Show("Có khách hàng đang tồn tại loại này bạn hãy xóa hết khách hàng thuộc loại này!", "TB");
                }
                else
                {
                    MessageBox.Show("Bạn đã xóa thành công!", "Thông Báo");
                    string s = "DELETE FROM dbo.LoaiKH WHERE dbo.LoaiKH.MaLoaiKH= '" + cbMaLoaiKH.Text.ToString() + "'";
                    dtbase.UpdateData(s);
                    FormLoaiKH_Load(sender, e);
                }
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string s1 = "DELETE FROM dbo.LoaiKH WHERE dbo.LoaiKH.MaLoaiKH= '" + cbMaLoaiKH.Text.ToString() + "'";
            dtbase.UpdateData(s1);
            string ss = "INSERT dbo.LoaiKH VALUES('" + cbMaLoaiKH.Text + "',N'" + tbTenLoaiKH.Text + "',N'" + tbghichu.Text + "')";
            dtbase.UpdateData(ss);
            MessageBox.Show("Bạn đã sửa thành công", "Thông báo");
            FormLoaiKH_Load(sender, e);

        }
    }
}
