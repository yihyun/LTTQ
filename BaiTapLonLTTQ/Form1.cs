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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbuser1.Text = Properties.Settings.Default.user;
            tbpw1.Text = Properties.Settings.Default.pass;
            if (Properties.Settings.Default.user == "")
                cknho.Checked = false;
            else cknho.Checked = true;

        }

        private void tbuser1_TextChanged(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            DataTable h = new DataTable();
            string sql = "select *from dbo.NhanVien inner join dbo.[User] on dbo.NhanVien.MaNV=dbo.[User].MaNV where Username='" + tbuser1.Text.ToString() + "'";
            h = dtbase.SelectTable(sql);
            if (h.Rows.Count == 0) tbnv1.Text = "";
            else tbnv1.Text = h.Rows[0][1].ToString();
        }

        private void tbpw1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
            SqlConnection con = dtbase.laycon();
            con.Open();
            string sq = "select *from dbo.[User] where Username='" + tbuser1.Text.ToString() + "'";
            SqlCommand cm = new SqlCommand(sq, con);
            SqlDataReader reader = cm.ExecuteReader();
            DataTable h = new DataTable();
            h = dtbase.SelectTable(sq);
            if (h.Rows.Count == 0)
            {
                lbhien.Text = "Thông Tin Tài Khoản Mật Khẩu Không Chính Xác";
                tbuser1.Focus();
              
            }

            if (reader.HasRows)
            {
                reader.Read();
                if (tbpw1.Text == reader.GetString(2).ToString())
                {

                    this.Hide();
                    //MessageBox.Show("đăng nhập thành công");
                    FormKhachHang frmKH = new FormKhachHang();
                    frmKH.Show();
                }
                else
                {

                    lbhien.Text = "Thông Tin Tài Khoản Mật Khẩu Không Chính Xác";
                    tbpw1.Focus();
                  
                }

            }
        }

        private void ckhien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckhien.Checked)
            {
                tbpw1.UseSystemPasswordChar = true;
            }
            else tbpw1.UseSystemPasswordChar = false;
        }

        private void cknho_CheckedChanged(object sender, EventArgs e)
        {
            if(cknho.Checked)
            {
                Properties.Settings.Default.user = tbuser1.Text;
                Properties.Settings.Default.pass = tbpw1.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();
            }
           
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
   
}
