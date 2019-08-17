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
using ThucHanh1;
using BaiTapLonLTTQ;

namespace BTL_BacVu
{
    public partial class frm_KhoHang : Form
    {
        Dataprocess process = new Dataprocess();
        int RowSelectedNow;
        int them = 0, sua = 0;
        public frm_KhoHang()
        {
            InitializeComponent();
            phanquyen();
            loadMaKho();
            loadGridView();
            loadData(cbb_makho.SelectedValue.ToString());
            bat(false);
        }
        private void phanquyen()
        {
            if(ểvedasxag5B.quyen!=1)
            {
                btn_luu.Visible = false;
                btn_sua.Visible = false;
                btn_them.Visible = false;
                btn_xoa.Visible = false;
                btn_huy.Visible = false;
            }
        }
        private void loadMaKho()
        {
            string sql = "SELECT * FROM dbo.Kho";
            DataTable dtt = new DataTable();
            dtt = process.SelectTable(sql);
            cbb_makho.DataSource = dtt;
            cbb_makho.ValueMember = "MaKho";
            cbb_makho.DisplayMember = "MaKho";
        }
        private void loadGridView()
        {
            string sql = "SELECT *FROM dbo.Kho";
            DataTable dtt = new DataTable();
            dtt = process.SelectTable(sql);
            DTgrid_Kho.DataSource = dtt;
            //DTgrid_Kho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTgrid_Kho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadData(string dk)
        {
            string sql = "SELECT *FROM dbo.Kho where MaKho = '"+dk+"'";
            process.OpenConnect();
            SqlCommand cm = new SqlCommand(sql,process.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Read();
                txt_tenkho.Text = rd.GetString(1);
                txt_diachi.Text = rd.GetString(2);
                richtxt_ghichu.Text = rd.GetString(3);
            }
            process.CloseConnect();
        }

        private void cbb_makho_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(cbb_makho.SelectedValue.ToString());
        }

        private void DTgrid_Kho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            RowSelectedNow = n;
            string makho = DTgrid_Kho.Rows[n].Cells[0].Value.ToString();
            //MessageBox.Show(makho);
            cbb_makho.Text = makho;
            txt_tenkho.Text = DTgrid_Kho.Rows[n].Cells[1].Value.ToString();
            txt_diachi.Text = DTgrid_Kho.Rows[n].Cells[2].Value.ToString();
            richtxt_ghichu.Text = DTgrid_Kho.Rows[n].Cells[3].Value.ToString();
        }
        private void InsertKho()
        {
            string makho, tenkho, diachi, ghichu;
            makho = cbb_makho.Text;
            tenkho = txt_tenkho.Text;
            diachi = txt_diachi.Text;
            ghichu = richtxt_ghichu.Text;
            string sql = "INSERT dbo.Kho VALUES('" + makho + "',N'" + tenkho + "',N'" + diachi + "',N'" + ghichu + "')";
            try
            {
                if(tenkho !="" && diachi !="")
                {
                    //MessageBox.Show(sql);
                    process.UpdateData(sql);
                    MessageBox.Show("Thêm kho thành công", "Thông báo", MessageBoxButtons.OK);
                    loadMaKho();
                    cbb_makho.Text = makho;
                    loadGridView();
                    btn_them.Enabled = true;
                    cbb_makho.Enabled = true;
                    them = 0;
                }
                else
                {
                    MessageBox.Show("Nhập đầy đủ thông tin tên kho, địa chỉ","Thông báo",MessageBoxButtons.OK);
                    cbb_makho.Enabled = false;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Thêm kho lỗi", "lỗi", MessageBoxButtons.OK);
            }
        }
        private void DeleteKho(string makho, string tenkho)
        {
            string sql = "DELETE dbo.Kho WHERE MaKho = '" + makho + "'";
            try
            {
                process.UpdateData(sql);
                MessageBox.Show("Đã xóa thành công kho "+tenkho);
                loadMaKho();
                loadGridView();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa");
            }
        }
        private void UpdateKHo(String makho)
        {
            string  tenkho, diachi, ghichu;
            tenkho = txt_tenkho.Text;
            diachi = txt_diachi.Text;
            ghichu = richtxt_ghichu.Text;
            string sql = "UPDATE dbo.Kho SET TenKho = N'" + tenkho + "',DiaChi = N'" + diachi + "',GhiChu = N'" + ghichu + "' WHERE MaKho = '"+makho+"'";
            try
            {
                process.UpdateData(sql);
                //MessageBox.Show(sql);
                MessageBox.Show("Sửa thành công");
                loadGridView();
                sua = 0;
            }
            catch
            {
                MessageBox.Show("Sửa bị lỗi");
            }
        }
        private void bat(Boolean ok)
        {
            btn_luu.Enabled = ok;
            btn_huy.Enabled = ok;
        }
        private void sinhmakho()
        {
            string sql = "SELECT MaKho FROM dbo.Kho ORDER BY MaKho DESC";
            /*process.OpenConnect();
            SqlCommand cm = new SqlCommand(sql, process.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            rd.Read();
            MessageBox.Show(rd.GetString(0));
            process.CloseConnect();*/
            SqlDataReader rd = process.GetData(sql);
            string macu = rd.GetString(0);
            string[] ma = macu.Split('K');
            int duoima = Convert.ToInt32(ma[1]);
            if(duoima<9)
            {
                cbb_makho.Text = "K0" + (duoima + 1);
            }
            else cbb_makho.Text = "K" + (duoima + 1);
            process.CloseConnect(); 
        }
        private void clean()
        {
            txt_tenkho.Text = "";
            txt_diachi.Text = "";
            richtxt_ghichu.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            them = 1;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            cbb_makho.Enabled = false;
            sinhmakho();
            bat(true);
            clean();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            cbb_makho.Enabled = true;
            if (them ==1)
            {
                string makho = cbb_makho.Text;
                InsertKho();
                return;
            }
            if(sua ==1)
            {
                string makho = cbb_makho.Text;
                UpdateKHo(makho);
            }
            bat(false);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+DTgrid_Kho.RowCount);
            if (RowSelectedNow < 0 || RowSelectedNow > (DTgrid_Kho.RowCount - 2))
            {
                MessageBox.Show("Bản ghi được chọn không phù hợp","Thông báo",MessageBoxButtons.OK);
                return;
            }
            else
            {
                string tenkho = DTgrid_Kho.Rows[RowSelectedNow].Cells[1].Value.ToString();
                if ((MessageBox.Show("Bạn có chắc muốn xóa kho "+tenkho,"Thông báo xóa",MessageBoxButtons.YesNo)==DialogResult.Yes))
                {
                    string makho = DTgrid_Kho.Rows[RowSelectedNow].Cells[0].Value.ToString();
                    DeleteKho(makho,tenkho);
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            cbb_makho.Enabled = true;
            bat(false);
            if(them ==1)
            {
                loadMaKho();
                loadGridView();
                them = 0;
            }
            else if(sua ==1)
            {
                loadData(cbb_makho.Text);
                sua = 0;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            sua = 1;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            cbb_makho.Enabled = false;
            bat(true);
        }
    }
}
