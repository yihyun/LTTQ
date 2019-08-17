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
    public partial class FormQuanLytk : Form
    {
        int ok = 0;
        BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
        public FormQuanLytk()
        {
            InitializeComponent();
        }

        private void grbTimKiem_Enter(object sender, EventArgs e)
        {

        }

        private void FormQuanLytk_Load(object sender, EventArgs e)
        {
           
            /*,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV = dbo.NhanVien.MaNV*/
            DataTable h = new DataTable();
            h = dtbase.SelectTable("select dbo.NhanVien.MaNV,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV = dbo.NhanVien.MaNV");
            cbmanv1.DataSource = h;
            cbmanv1.DisplayMember = "MaNV";
            cbmanv1.ValueMember = "MaNV";
            dtglogin.DataSource = h;
            dtglogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btthem.Enabled = false;
            cbmanv1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbmanv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable h = new DataTable();
            SqlConnection con = dtbase.laycon();
            con.Open();
            string s = "select dbo.NhanVien.MaNV,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV=dbo.NhanVien.MaNV where dbo.NhanVien.MaNV='" + cbmanv1.Text + "'";
            SqlCommand cm = new SqlCommand(s, con);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tbtennv1.Text = reader.GetString(1).ToString();
                tbuser.Text = reader.GetString(2).ToString();
                tbpass.Text = reader.GetString(3).ToString();
            }
            
        }
      /*  public void kiemtra(int n)
        {
            if (n == 1)
            {

                DataTable h1 = new DataTable();
                h1 = dtbase.SelectTable("Select *from dbo.NhanVien where dbo.NhanVien.MaNV='" + cbmanv1.Text + "'");
                tbtennv1.Text = h1.Rows[0][1].ToString();
                tbuser.Text = "";
                tbpass.Text = "";
                if (MessageBox.Show("Nhân Viên Này Chưa Có Tài Khoản Bạn Có muốn lập tài khoản không?", "TB", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tbuser.Focus();
                }



            }
        }*/

        private void btxoa_Click(object sender, EventArgs e)
        {
          
            if(MessageBox.Show("Bạn Có Chắc chắn xóa không","TB",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string del = "delete dbo.[User] where dbo.[User].MaNV='" + cbmanv1.Text + "'";
                dtbase.UpdateData(del);
                MessageBox.Show("Bạn đã xóa thành công", "TB");
                FormQuanLytk_Load(sender, e);
            }
            else FormQuanLytk_Load(sender, e);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if(tbpass.Text==""||tbuser.Text=="")
            {
                MessageBox.Show("User Password không được để trống!", "TB");
                if (tbuser.Text == "") tbuser.Focus();
                else tbpass.Focus();
            }
            else
            {
                string s1 = "DELETE FROM dbo.[User] WHERE MaNV= '" + cbmanv1.Text.ToString() + "'";
                dtbase.UpdateData(s1);
                string ss = "INSERT dbo.[User] VALUES('" + cbmanv1.Text + "','" + tbuser.Text + "','" + tbpass.Text + "')";
                dtbase.UpdateData(ss);
                MessageBox.Show("Bạn đã sửa thành công", "Thông báo");
                FormQuanLytk_Load(sender, e);
            }
           
        }

        private void rbma_CheckedChanged(object sender, EventArgs e)
        {
            tbtim.Enabled = true;
            bttim.Enabled = true;
            lbtimk.Text = "Nhập Mã Nhân Viên";
        }

        private void rbten_CheckedChanged(object sender, EventArgs e)
        {
            tbtim.Enabled = true;
            bttim.Enabled = true;
            lbtimk.Text = "Nhập Tên Nhân Viên";
        }

        private void rbuser_CheckedChanged(object sender, EventArgs e)
        {
            tbtim.Enabled = true;
            bttim.Enabled = true;
            lbtimk.Text = "Nhập User Nhân Viên";
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if(rbma.Checked==true)
            {
                string s = "select dbo.NhanVien.MaNV,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV = dbo.NhanVien.MaNV where dbo.NhanVien.MaNV='"+tbtim.Text+"'";
               
                DataTable h = new DataTable();
                h = dtbase.SelectTable(s);
                if (h.Rows.Count > 0)
                {
                    cbmanv1.Text = h.Rows[0][0].ToString();
                    dtglogin.DataSource = h;
                    dtglogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Mã Bạn Nhập Không Có", "TB");
                    FormQuanLytk_Load(sender, e);
                }
            }
            if(rbten.Checked==true)
            {
                string s = "select dbo.NhanVien.MaNV,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV = dbo.NhanVien.MaNV where dbo.NhanVien.TenNV=N'" + tbtim.Text + "'";
                DataTable h = new DataTable();
                h = dtbase.SelectTable(s);
                if (h.Rows.Count > 0)
                {
                    cbmanv1.Text = h.Rows[0][0].ToString();
                    dtglogin.DataSource = h;
                    dtglogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Tên Bạn Nhập Không Có", "TB");
                    FormQuanLytk_Load(sender, e);
                }

            }
            if (rbuser.Checked == true)
            {
                string s = "select dbo.NhanVien.MaNV,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV = dbo.NhanVien.MaNV where dbo.[User].Username='" + tbtim.Text + "'";
                DataTable h = new DataTable();
                h = dtbase.SelectTable(s);
                if (h.Rows.Count > 0)
                {
                    cbmanv1.Text = h.Rows[0][0].ToString();
                    dtglogin.DataSource = h;
                    dtglogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Username Bạn Nhập Không Có", "TB");
                    FormQuanLytk_Load(sender, e);
                }


            }
        }

        private void bttao_Click(object sender, EventArgs e)
        {
            
            btthem.Enabled = true;
            cbmanv1.DropDownStyle = ComboBoxStyle.DropDown;
            tbpass.Text = "";
            tbuser.Text = "";
            cbmanv1.Text = "";
            tbtennv1.Text = "";
            lnan.Text = "Tên nhân viên sẽ tự động cập nhật khi nhập đúng mã";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            ok = 0;
            string s1 = "select *from dbo.NhanVien where dbo.NhanVien.MaNV='"+cbmanv1.Text+"'";
            DataTable h1 = new DataTable();
            h1 = dtbase.SelectTable(s1);
            string s2 = "select dbo.NhanVien.MaNV,dbo.NhanVien.TenNV,Username,Password from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV=dbo.NhanVien.MaNV where dbo.NhanVien.MaNV='" + cbmanv1.Text + "'";
            DataTable h2 = new DataTable();
            h2 = dtbase.SelectTable(s2);
            if (h1.Rows.Count == 0)
            {
                ok = 1;
                if (MessageBox.Show("Nhân Viên Này Không Tồn Tại Bạn Muốn Nhập Lại Không?", "TB", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cbmanv1.Focus();
                       
                }
               
                else
                {
                    FormQuanLytk_Load(sender, e);
                    lnan.Text = "";
                }
                
            }
            if(h2.Rows.Count>0)
            {
                ok = 1;
                if (MessageBox.Show("Nhân Viên Này Đã Có Tài Khoản Bạn Muốn Nhập Lại Không?", "TB", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cbmanv1.Focus();
                    
                }
                else
                {
                    FormQuanLytk_Load(sender, e);
                    lnan.Text = "";
                }
            }
            string s3 = "select *from dbo.[User] where dbo.[User].Username='" + tbuser.Text + "'";
            DataTable k = new DataTable();
            k = dtbase.SelectTable(s3);
            if(k.Rows.Count>0)
            {
                ok = 1;
                MessageBox.Show("User Này đã có người sử dụng vui lòng thử user khác", "TB");
                tbuser.Focus();
            }
            if(tbuser.Text==""||tbpass.Text=="")
            {
                ok = 1;
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Được để trống", "TB");
                tbuser.Focus();
            }
            if (ok==0)
            {
                string k1 = "insert into dbo.[User] values('"+cbmanv1.Text+"','"+tbuser.Text+"','"+tbpass.Text+"')";
                dtbase.UpdateData(k1);
                MessageBox.Show("Bạn đã thêm thành công","TB");
                FormQuanLytk_Load(sender, e);
                lnan.Text = "";
                cbmanv1.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        }

        private void btnot_Click(object sender, EventArgs e)
        {
            DataTable k = new DataTable();
            string s = "select MaNV,TenNV,case when GioiTinh=1 then N'Nam' else N'Nữ' end as [Giới Tính],DiaChi,Email,SDT,Luong from dbo.NhanVien where MaNV not in (select MaNV from dbo.[User])";
            k = dtbase.SelectTable(s);
            dtglogin.DataSource = k;
            dtglogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void bthome_Click(object sender, EventArgs e)
        {
            FormQuanLytk_Load(sender, e);
        }

        private void dtglogin_DoubleClick(object sender, EventArgs e)
        {
            cbmanv1.Text = dtglogin.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
