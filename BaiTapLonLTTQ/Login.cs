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
    public partial class Login : Form
    {
        DataProcess data = new DataProcess();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtUsername.Text.Trim();
            string mk = txtPassword.Text.Trim();
            string sql = "SELECT * FROM dbo.[User] WHERE Username = '" +
                ten + "' AND Password = '" + mk + "'";

            try
            {
                if (ten == "" || mk == "")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataTable dataTable = data.SelectTable(sql);
                    if (dataTable.Rows.Count > 0)
                    {
                        ểvedasxag5B.quyen = Convert.ToInt16(dataTable.Rows[0]["user_group"].ToString().Trim());
                        ểvedasxag5B.username = dataTable.Rows[0]["Username"].ToString().Trim();
                        ểvedasxag5B.password = dataTable.Rows[0]["Password"].ToString().Trim();


                        
                        ểvedasxag5B main = new ểvedasxag5B();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                       // txtUsername.Text = "";
                        txtUsername.Focus();
                    }
                }
            }
            catch {
                MessageBox.Show("Lỗi kết nối dữ liệu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (checkBox1.Checked)
            {
                BaiTapLonLTTQ.Properties.Settings.Default.user = txtUsername.Text;
                BaiTapLonLTTQ.Properties.Settings.Default.pass = txtPassword.Text;
                BaiTapLonLTTQ.Properties.Settings.Default.Save();
            }
            else
            {
                BaiTapLonLTTQ.Properties.Settings.Default.user = "";
                BaiTapLonLTTQ.Properties.Settings.Default.pass = "";
                BaiTapLonLTTQ.Properties.Settings.Default.Save();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = BaiTapLonLTTQ.Properties.Settings.Default.user;
            txtPassword.Text = BaiTapLonLTTQ.Properties.Settings.Default.pass;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else txtPassword.UseSystemPasswordChar = true;
        }
    }
}
